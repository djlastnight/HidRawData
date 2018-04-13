namespace Djlastnight.Hid
{
    using System;
    using System.Runtime.InteropServices;
    using System.Text;
    using Djlastnight.Hid.UsageCollection;
    using Djlastnight.Win32.Win32CreateFile;
    using Djlastnight.Win32.Win32Hid;
    using Djlastnight.Win32.Win32RawInput;

    public class Device : IDisposable
    {
        private RID_DEVICE_INFO info;
        private HIDP_CAPS capabilities;
        private HIDP_BUTTON_CAPS[] inputButtonCapabilities;
        private HIDP_VALUE_CAPS[] inputValueCapabilities;

        /// <summary>
        /// Class constructor will fetch this object properties from HID sub system.
        /// </summary>
        /// <param name="handleToRawInputDevice">Device Handle as provided by RAWINPUTHEADER.hDevice, typically accessed as rawinput.header.hDevice</param>
        internal Device(IntPtr handleToRawInputDevice)
        {
            // Try construct and rollback if needed
            try
            {
                this.Construct(handleToRawInputDevice);
            }
            catch (Exception ex)
            {
                // Just rollback and propagate
                this.Dispose();
                throw ex;
            }
        }

        /// <summary>
        /// Make sure dispose is called even if the user forgot about it.
        /// </summary>
        ~Device()
        {
            this.Dispose();
        }

        /// <summary>
        /// Unique name of that HID device.
        /// Notably used as input to CreateFile.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Friendly name that people should be able to read.
        /// </summary>
        public string FriendlyName { get; private set; }

        public string Manufacturer { get; private set; }

        public string Product { get; private set; }

        public ushort VendorId { get; private set; }

        public ushort ProductId { get; private set; }

        public ushort Version { get; private set; }

        public IntPtr PreParsedData { get; private set; }

        public RID_DEVICE_INFO Info
        {
            get
            {
                return this.info;
            }
        }

        public HIDP_CAPS Capabilities
        {
            get
            {
                return this.capabilities;
            }
        }

        public string InputCapabilitiesDescription { get; private set; }

        public HIDP_BUTTON_CAPS[] InputButtonCapabilities
        {
            get
            {
                return this.inputButtonCapabilities;
            }
        }

        public HIDP_VALUE_CAPS[] InputValueCapabilities
        {
            get
            {
                return this.inputValueCapabilities;
            }
        }

        public int ButtonCount { get; private set; }

        public bool IsGamePad
        {
            get
            {
                return (UsagePage)this.capabilities.UsagePage == Hid.UsagePage.GenericDesktopControls && (UsageCollection.GenericDesktop)this.capabilities.Usage == GenericDesktop.GamePad;
            }
        }

        public bool IsMouse
        {
            get
            {
                return this.Info.dwType == RawInputDeviceType.RIM_TYPEMOUSE;
            }
        }

        public bool IsKeyboard
        {
            get
            {
                return this.Info.dwType == RawInputDeviceType.RIM_TYPEKEYBOARD;
            }
        }

        public bool IsHid
        {
            get
            {
                return this.Info.dwType == RawInputDeviceType.RIM_TYPEHID;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public ushort UsagePage
        {
            get
            {
                if (this.Info.dwType == RawInputDeviceType.RIM_TYPEHID)
                {
                    // Generic HID
                    return this.Info.hid.usUsagePage;
                }
                else if (this.Info.dwType == RawInputDeviceType.RIM_TYPEKEYBOARD)
                {
                    // Keyboard
                    return (ushort)Hid.UsagePage.GenericDesktopControls;
                }
                else if (this.Info.dwType == RawInputDeviceType.RIM_TYPEMOUSE)
                {
                    // Mouse
                    return (ushort)Hid.UsagePage.GenericDesktopControls;
                }

                return 0;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public ushort UsageCollection
        {
            get
            {
                if (this.Info.dwType == RawInputDeviceType.RIM_TYPEHID)
                {
                    // Generic HID
                    return this.Info.hid.usUsage;
                }
                else if (this.Info.dwType == RawInputDeviceType.RIM_TYPEKEYBOARD)
                {
                    // Keyboard
                    return (ushort)Hid.UsageCollection.GenericDesktop.Keyboard;
                }
                else if (this.Info.dwType == RawInputDeviceType.RIM_TYPEMOUSE)
                {
                    // Mouse
                    return (ushort)Hid.UsageCollection.GenericDesktop.Mouse;
                }

                return 0;
            }
        }

        public uint UsageId
        {
            get
            {
                return (uint)(this.UsagePage << 16) | this.UsageCollection;
            }
        }

        /// <summary>
        /// Provide a description for the given capabilities.
        /// Notably describes axis on a gamepad/joystick.
        /// </summary>
        /// <param name="caps"></param>
        /// <returns></returns>
        public static string InputValueCapabilityDescription(HIDP_VALUE_CAPS caps)
        {
            if (!caps.IsRange && Enum.IsDefined(typeof(UsagePage), caps.UsagePage))
            {
                Type usageType = Utils.UsageType((UsagePage)caps.UsagePage);
                if (usageType == null)
                {
                    return "Input Value: " + Enum.GetName(typeof(UsagePage), caps.UsagePage) + " Usage 0x" + caps.NotRange.Usage.ToString("X2");
                }

                string name = Enum.GetName(usageType, caps.NotRange.Usage);
                if (name == null)
                {
                    // Could not find that usage in our enum.
                    // Provide a relevant warning instead.
                    name = "Usage 0x" + caps.NotRange.Usage.ToString("X2") + " not defined in " + usageType.Name;
                }
                else
                {
                    // Prepend our usage type name
                    name = usageType.Name + "." + name;
                }

                return "Input Value: " + name;
            }

            return null;
        }

        /// <summary>
        /// Dispose is just for unmanaged clean-up.
        /// Make sure calling disposed multiple times does not crash.
        /// See: http://stackoverflow.com/questions/538060/proper-use-of-the-idisposable-interface/538238#538238
        /// </summary>
        public void Dispose()
        {
            Marshal.FreeHGlobal(this.PreParsedData);
            this.PreParsedData = IntPtr.Zero;
        }

        public override string ToString()
        {
            return "HID Device: " + this.FriendlyName;
        }

        /// <summary>
        /// Private constructor.
        /// </summary>
        /// <param name="handleToRawInputDevice"></param>
        private void Construct(IntPtr handleToRawInputDevice)
        {
            this.PreParsedData = IntPtr.Zero;
            this.inputButtonCapabilities = null;
            this.inputValueCapabilities = null;

            // Fetch various information defining the given HID device
            this.Name = RawInputHelper.GetDeviceName(handleToRawInputDevice);

            // Fetch device info
            this.info = new RID_DEVICE_INFO();
            if (!RawInputHelper.GetDeviceInfo(handleToRawInputDevice, ref this.info))
            {
                throw new Exception("HidDevice: GetDeviceInfo failed: " + Marshal.GetLastWin32Error().ToString());
            }

            // Open our device from the device name/path
            var handle = Win32.Win32CreateFile.NativeMethods.CreateFile(
                this.Name,
                FileAccess.NONE,
                FileShare.FILE_SHARE_READ | FileShare.FILE_SHARE_WRITE,
                IntPtr.Zero,
                CreationDisposition.OPEN_EXISTING,
                FileFlagsAttributes.FILE_FLAG_OVERLAPPED,
                IntPtr.Zero);

            // Check if CreateFile worked
            if (handle.IsInvalid)
            {
                throw new Exception("HidDevice: CreateFile failed: " + Marshal.GetLastWin32Error().ToString());
            }

            // Get manufacturer string
            var manufacturerString = new StringBuilder(256);
            if (Win32.Win32Hid.NativeMethods.HidD_GetManufacturerString(handle, manufacturerString, manufacturerString.Capacity))
            {
                this.Manufacturer = manufacturerString.ToString();
            }

            // Get product string
            StringBuilder productString = new StringBuilder(256);
            if (Win32.Win32Hid.NativeMethods.HidD_GetProductString(handle, productString, productString.Capacity))
            {
                this.Product = productString.ToString();
            }

            // Get attributes
            HIDD_ATTRIBUTES attributes = new HIDD_ATTRIBUTES();
            if (Win32.Win32Hid.NativeMethods.HidD_GetAttributes(handle, ref attributes))
            {
                this.VendorId = attributes.VendorID;
                this.ProductId = attributes.ProductID;
                this.Version = attributes.VersionNumber;
            }

            handle.Close();

            this.SetFriendlyName();

            // Get our HID descriptor pre-parsed data
            this.PreParsedData = RawInputHelper.GetPreParsedData(handleToRawInputDevice);

            if (this.PreParsedData == IntPtr.Zero)
            {
                // We are done then. Some devices don't have pre-parsed data.
                return;
            }

            // Get capabilities
            var status = Win32.Win32Hid.NativeMethods.HidP_GetCaps(this.PreParsedData, ref this.capabilities);
            if (status != HidStatus.HIDP_STATUS_SUCCESS)
            {
                throw new Exception("HidDevice: HidP_GetCaps failed: " + status.ToString());
            }

            this.SetInputCapabilitiesDescription();

            // Get input button caps if needed
            if (this.Capabilities.NumberInputButtonCaps > 0)
            {
                this.inputButtonCapabilities = new HIDP_BUTTON_CAPS[this.Capabilities.NumberInputButtonCaps];
                ushort buttonCapabilitiesLength = this.Capabilities.NumberInputButtonCaps;
                status = Win32.Win32Hid.NativeMethods.HidP_GetButtonCaps(HIDP_REPORT_TYPE.HidP_Input, this.inputButtonCapabilities, ref buttonCapabilitiesLength, this.PreParsedData);
                if (status != HidStatus.HIDP_STATUS_SUCCESS || buttonCapabilitiesLength != this.Capabilities.NumberInputButtonCaps)
                {
                    throw new Exception("HidDevice: HidP_GetButtonCaps failed: " + status.ToString());
                }

                this.ComputeButtonCount();
            }

            // Get input value caps if needed
            if (this.Capabilities.NumberInputValueCaps > 0)
            {
                this.inputValueCapabilities = new HIDP_VALUE_CAPS[this.Capabilities.NumberInputValueCaps];
                ushort valueCapabilitiesLength = this.Capabilities.NumberInputValueCaps;
                status = Win32.Win32Hid.NativeMethods.HidP_GetValueCaps(HIDP_REPORT_TYPE.HidP_Input, this.inputValueCapabilities, ref valueCapabilitiesLength, this.PreParsedData);
                if (status != HidStatus.HIDP_STATUS_SUCCESS || valueCapabilitiesLength != this.Capabilities.NumberInputValueCaps)
                {
                    throw new Exception("HidDevice: HidP_GetValueCaps failed: " + status.ToString());
                }
            }
        }

        /// <summary>
        /// Useful for gamepads.
        /// </summary>
        private void ComputeButtonCount()
        {
            this.ButtonCount = 0;
            foreach (HIDP_BUTTON_CAPS bc in this.inputButtonCapabilities)
            {
                if (bc.IsRange)
                {
                    this.ButtonCount += bc.Range.UsageMax - bc.Range.UsageMin + 1;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void SetInputCapabilitiesDescription()
        {
            this.InputCapabilitiesDescription = string.Format(
                "[ Input Capabilities ] Button: {0} - Value: {1} - Data indices: {2}",
                this.Capabilities.NumberInputButtonCaps,
                this.Capabilities.NumberInputValueCaps,
                this.Capabilities.NumberInputDataIndices);
        }

        /// <summary>
        /// 
        /// </summary>
        private void SetFriendlyName()
        {
            /* Work out proper suffix for our device root node.
             * That allows users to see in a glance what kind of device this is.
            */
            string suffix = string.Empty;
            Type usageCollectionType = null;
            if (this.Info.dwType == RawInputDeviceType.RIM_TYPEHID)
            {
                // Process usage page
                if (Enum.IsDefined(typeof(UsagePage), this.Info.hid.usUsagePage))
                {
                    // We know this usage page, add its name
                    var usagePage = (UsagePage)this.Info.hid.usUsagePage;
                    suffix += " ( " + usagePage.ToString() + ", ";
                    usageCollectionType = Utils.UsageCollectionType(usagePage);
                }
                else
                {
                    // We don't know this usage page, add its value
                    suffix += " ( 0x" + this.Info.hid.usUsagePage.ToString("X4") + ", ";
                }

                /*Process usage collection
                We don't know this usage page, add its value */
                if (usageCollectionType == null || !Enum.IsDefined(usageCollectionType, this.Info.hid.usUsage))
                {
                    // Show Hexa
                    suffix += "0x" + this.Info.hid.usUsage.ToString("X4") + " )";
                }
                else
                {
                    // We know this usage page, add its name
                    suffix += Enum.GetName(usageCollectionType, this.Info.hid.usUsage) + " )";
                }
            }
            else if (this.Info.dwType == RawInputDeviceType.RIM_TYPEKEYBOARD)
            {
                suffix = " - Keyboard";
            }
            else if (this.Info.dwType == RawInputDeviceType.RIM_TYPEMOUSE)
            {
                suffix = " - Mouse";
            }

            if (this.Product != null && this.Product.Length > 1)
            {
                // This device as a proper name, use it
                this.FriendlyName = this.Product + suffix;
            }
            else
            {
                // Extract friendly name from name
                char[] delimiterChars = { '#', '&' };
                string[] words = this.Name.Split(delimiterChars);
                if (words.Length >= 2)
                {
                    // Use our name sub-string to describe this device
                    this.FriendlyName = words[1] + " - 0x" + this.ProductId.ToString("X4") + suffix;
                }
                else
                {
                    // No proper name just use the device ID instead
                    this.FriendlyName = "0x" + this.ProductId.ToString("X4") + suffix;
                }
            }
        }
    }
}