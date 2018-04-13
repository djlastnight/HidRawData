namespace Djlastnight.Hid
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Reflection;
    using System.Runtime.InteropServices;
    using System.Timers;
    using System.Windows.Forms;
    using Djlastnight.Hid.Usage;
    using Djlastnight.Win32;
    using Djlastnight.Win32.Win32Hid;
    using Djlastnight.Win32.Win32RawInput;

    public class HidEvent : IDisposable
    {
        private RAWINPUT rawInput;

        /// <summary>
        /// Initialize an HidEvent from a WM_INPUT message
        /// </summary>
        /// <param name="message"></param>
        /// <param name="repeatDelegate"></param>
        /// <param name="repeat"></param>
        /// <param name="repeatDelayInMs"></param>
        /// <param name="repeatSpeedInMs"></param>
        internal HidEvent(Message message)
        {
            this.RepeatCount = 0;
            this.IsValid = false;
            this.IsKeyboard = false;
            this.IsGeneric = false;

            this.Time = DateTime.Now;
            this.OriginalTime = DateTime.Now;
            this.Usages = new List<ushort>();
            this.UsageValues = new Dictionary<HIDP_VALUE_CAPS, uint>();

            if (message.Msg != Contants.WM_INPUT)
            {
                // Has to be a WM_INPUT message
                return;
            }

            if (Helper.GET_RAWINPUT_CODE_WPARAM(message.WParam) == Contants.RIM_INPUT)
            {
                this.IsForeground = true;
            }
            else if (Helper.GET_RAWINPUT_CODE_WPARAM(message.WParam) == Contants.RIM_INPUTSINK)
            {
                this.IsForeground = false;
            }

            // Declare some pointers
            IntPtr rawInputBuffer = IntPtr.Zero;

            try
            {
                // Fetch raw input
                this.rawInput = new RAWINPUT();
                if (!RawInputHelper.GetRawInputData(message.LParam, ref this.rawInput, ref rawInputBuffer))
                {
                    Debug.WriteLine("GetRawInputData failed!");
                    return;
                }

                // Our device can actually be null. This is notably happening for some keyboard events
                if (this.RawInput.header.hDevice != IntPtr.Zero)
                {
                    this.Device = new Device(this.RawInput.header.hDevice);
                }

                if (this.RawInput.header.dwType == RawInputDeviceType.RIM_TYPEHID)
                {
                    this.IsGeneric = true;

                    Debug.WriteLine("WM_INPUT source device is HID.");

                    // Get Usage Page and Usage
                    this.UsagePage = this.Device.Info.hid.usUsagePage;
                    this.UsageCollection = this.Device.Info.hid.usUsage;

                    /* Make sure our HID msg size more than 1.
                     * In fact the first ushort is irrelevant to us for now
                     * Check that we have at least one HID msg
                    */
                    if (!(this.RawInput.hid.dwSizeHid > 1
                        && this.RawInput.hid.dwCount > 0))
                    {
                        return;
                    }

                    // Allocate a buffer for one HID input
                    this.InputReport = new byte[this.RawInput.hid.dwSizeHid];

                    Debug.WriteLine("Raw input contains " + this.RawInput.hid.dwCount + " HID input report(s)");

                    // For each HID input report in our raw input
                    for (int i = 0; i < this.RawInput.hid.dwCount; i++)
                    {
                        // Compute the address from which to copy our HID input
                        int hidInputOffset = 0;
                        unsafe
                        {
                            byte* source = (byte*)rawInputBuffer;
                            source += sizeof(RAWINPUTHEADER) + sizeof(RAWHID) + (this.RawInput.hid.dwSizeHid * i);
                            hidInputOffset = (int)source;
                        }

                        // Copy HID input into our buffer
                        Marshal.Copy(new IntPtr(hidInputOffset), this.InputReport, 0, (int)this.RawInput.hid.dwSizeHid);
                        this.ProcessInputReport(this.InputReport);
                    }
                }
                else if (this.RawInput.header.dwType == RawInputDeviceType.RIM_TYPEMOUSE)
                {
                    this.IsMouse = true;
                    this.UsagePage = (ushort)Hid.UsagePage.GenericDesktopControls;
                    this.UsageCollection = (ushort)Hid.UsageCollection.GenericDesktop.Mouse;

                    Debug.WriteLine("WM_INPUT source device is Mouse.");
                }
                else if (this.RawInput.header.dwType == RawInputDeviceType.RIM_TYPEKEYBOARD)
                {
                    this.IsKeyboard = true;
                    this.UsagePage = (ushort)Hid.UsagePage.GenericDesktopControls;
                    this.UsageCollection = (ushort)Hid.UsageCollection.GenericDesktop.Keyboard;

                    // Precise ALT key - work out if we are left or right ALT
                    if (this.rawInput.keyboard.VKey == (ushort)Keys.Menu)
                    {
                        if (this.RawInput.keyboard.Flags.HasFlag(RawInputKeyFlags.RI_KEY_E0))
                        {
                            this.rawInput.keyboard.VKey = (ushort)Keys.RMenu;
                        }
                        else
                        {
                            this.rawInput.keyboard.VKey = (ushort)Keys.LMenu;
                        }
                    }

                    // Precise CTRL key - work out if we are left or right CTRL
                    if (this.rawInput.keyboard.VKey == (ushort)Keys.ControlKey)
                    {
                        if (this.RawInput.keyboard.Flags.HasFlag(RawInputKeyFlags.RI_KEY_E0))
                        {
                            this.rawInput.keyboard.VKey = (ushort)Keys.RControlKey;
                        }
                        else
                        {
                            this.rawInput.keyboard.VKey = (ushort)Keys.LControlKey;
                        }
                    }

                    // Precise SHIFT key - work out if we are left or right SHIFT
                    if (this.rawInput.keyboard.VKey == (ushort)Keys.ShiftKey)
                    {
                        if (this.RawInput.keyboard.MakeCode == 0x0036)
                        {
                            this.rawInput.keyboard.VKey = (ushort)Keys.RShiftKey;
                        }
                        else
                        {
                            Debug.Assert(this.RawInput.keyboard.MakeCode == 0x002A, "Keyboard make code is different from 0x002A");
                            this.rawInput.keyboard.VKey = (ushort)Keys.LShiftKey;
                        }
                    }

                    Debug.WriteLine("WM_INPUT source device is Keyboard.");

                    // Do keyboard handling...
                    if (this.Device != null)
                    {
                        Debug.WriteLine("Type: " + this.Device.Info.keyboard.dwType.ToString());
                        Debug.WriteLine("SubType: " + this.Device.Info.keyboard.dwSubType.ToString());
                        Debug.WriteLine("Mode: " + this.Device.Info.keyboard.dwKeyboardMode.ToString());
                        Debug.WriteLine("Number of function keys: " + this.Device.Info.keyboard.dwNumberOfFunctionKeys.ToString());
                        Debug.WriteLine("Number of indicators: " + this.Device.Info.keyboard.dwNumberOfIndicators.ToString());
                        Debug.WriteLine("Number of keys total: " + this.Device.Info.keyboard.dwNumberOfKeysTotal.ToString());
                    }
                }
            }
            finally
            {
                // Always executed when leaving our try block
                Marshal.FreeHGlobal(rawInputBuffer);
            }

            this.IsValid = true;
        }

        public bool IsValid { get; private set; }

        public bool IsForeground { get; private set; }

        public bool IsBackground
        {
            get
            {
                return !this.IsForeground;
            }
        }

        public bool IsMouse { get; private set; }

        public bool IsKeyboard { get; private set; }

        /// <summary>
        /// If this not a mouse or keyboard event then it's a generic HID event.
        /// </summary>
        public bool IsGeneric { get; private set; }

        public Keys VirtualKey
        {
            get { return (Keys)this.RawInput.keyboard.VKey; }
        }

        public bool HasModifierShift { get; set; }

        public bool HasModifierControl { get; set; }

        public bool HasModifierAlt { get; set; }

        public bool HasModifierWindows { get; set; }

        /// <summary>
        /// Tells whether this event is a SHIFT modifier.
        /// </summary>
        public bool IsModifierShift
        {
            get
            {
                return this.IsKeyboard &&
                       (this.VirtualKey == Keys.ShiftKey || this.VirtualKey == Keys.LShiftKey || this.VirtualKey == Keys.RShiftKey);
            }
        }

        /// <summary>
        /// Tells whether this event is a CONTROL modifier.
        /// </summary>
        public bool IsModifierControl
        {
            get
            {
                return this.IsKeyboard &&
                       (this.VirtualKey == Keys.ControlKey ||
                       this.VirtualKey == Keys.LControlKey ||
                        this.VirtualKey == Keys.RControlKey);
            }
        }

        /// <summary>
        /// Tells whether this event is a ALT modifier.
        /// </summary>
        public bool IsModifierAlt
        {
            get
            {
                return this.IsKeyboard && (this.VirtualKey == Keys.Menu || this.VirtualKey == Keys.LMenu || this.VirtualKey == Keys.RMenu);
            }
        }

        /// <summary>
        /// Tells whether this event is a WINDOWS modifier.
        /// </summary>
        public bool IsModifierWindows
        {
            get { return this.IsKeyboard && (this.VirtualKey == Keys.LWin || this.VirtualKey == Keys.RWin); }
        }

        /// <summary>
        /// Tells whether this is a modifier key.
        /// </summary>
        public bool IsModifier
        {
            get { return this.IsModifierShift || this.IsModifierControl || this.IsModifierAlt || this.IsModifierWindows; }
        }

        /// <summary>
        /// Check if this event correspond to a button or a key being pushed down.
        /// </summary>
        public bool IsButtonDown
        {
            get
            {
                if (this.IsGeneric)
                {
                    // For generic HID device check that our first usage is not zero
                    return this.Usages.Count == 1 && this.Usages[0] != 0;
                }
                else if (this.IsKeyboard)
                {
                    return !this.IsButtonUp;
                }

                Debug.Assert(false, "TODO: mouse handling");
                return false;
            }
        }

        /// <summary>
        /// Check if this event correspond to a button or a key being released.
        /// </summary>
        public bool IsButtonUp
        {
            get
            {
                if (this.IsGeneric)
                {
                    // Button up event if we do not have any usages
                    return this.Usages.Count == 0;
                }
                else if (this.IsKeyboard)
                {
                    // This is a key up event if our break flag is set
                    return this.RawInput.keyboard.Flags.HasFlag(RawInputKeyFlags.RI_KEY_BREAK);
                }

                Debug.Assert(false, "TODO: mouse handling");
                return false;
            }
        }

        public bool IsRepeat
        {
            get
            {
                return this.RepeatCount != 0;
            }
        }

        public uint RepeatCount { get; set; }

        /// <summary>
        /// Uniquely identify keyboard events.
        /// Key down and up event will return the same ID.
        /// </summary>
        public ulong KeyId
        {
            get
            {
                return (ulong)this.RawInput.keyboard.VKey << 32 | (ulong)this.RawInput.keyboard.MakeCode << 16 | (ulong)(this.RawInput.keyboard.Flags & ~RawInputKeyFlags.RI_KEY_BREAK);
            }
        }

        public Device Device { get; private set; }

        public RAWINPUT RawInput
        {
            get
            {
                return this.rawInput;
            }
        }

        /// <summary>
        /// Usage Page
        /// </summary>
        public ushort UsagePage { get; private set; }

        /// <summary>
        /// Usage Page as enumeration.
        /// </summary>
        public UsagePage UsagePageEnum
        {
            get
            {
                return (UsagePage)this.UsagePage;
            }
        }

        /// <summary>
        /// Usage Collection
        /// </summary>
        public ushort UsageCollection { get; private set; }

        public List<ushort> Usages { get; private set; }

        public uint UsageId
        {
            get
            {
                return (uint)this.UsagePage << 16 | (uint)this.UsageCollection;
            }
        }

        /// <summary>
        /// Sorted in the same order as Device.InputValueCapabilities.
        /// </summary>
        public Dictionary<HIDP_VALUE_CAPS, uint> UsageValues { get; private set; }

        public byte[] InputReport { get; private set; }

        public DateTime Time { get; private set; }

        public DateTime OriginalTime { get; private set; }

        /// <summary>
        /// We typically dispose of events as soon as we get the corresponding key up signal.
        /// </summary>
        public void Dispose()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            var result = string.Empty;
            if (!this.IsValid)
            {
                result += "HID Event Invalid";
                return result;
            }

            result += "HID Event";
            if (this.IsButtonDown)
            {
                result += ", DOWN";
            }

            if (this.IsButtonUp)
            {
                result += ", UP";
            }

            if (this.IsGeneric)
            {
                result += ", Generic";
                for (int i = 0; i < this.Usages.Count; i++)
                {
                    result += ", Usage: " + this.UsageNameAndValue(i);
                }

                result += ", UsagePage: " + this.UsagePageNameAndValue();
                result += ", UsageCollection: " + this.UsageCollectionNameAndValue();
                result += ", Input Report: 0x" + this.InputReportString();
            }
            else if (this.IsKeyboard)
            {
                result += ", Keyboard";
                result += ", Virtual Key: " + this.VirtualKey;
            }
            else if (this.IsMouse)
            {
                result += ", Mouse";
            }

            if (this.IsBackground)
            {
                result += ", Background";
            }

            if (this.IsRepeat)
            {
                result += ", Repeat: " + this.RepeatCount;
            }

            return result;
        }

        /// <summary>
        /// Provides the name of our usage page.
        /// </summary>
        internal string UsagePageName()
        {
            return this.UsagePageEnum.ToString();
        }

        /// <summary>
        /// Provides name and value of our usage page as a string.
        /// </summary>
        internal string UsagePageNameAndValue()
        {
            return string.Format("{0} (0x{1})", this.UsagePageName(), this.UsagePage.ToString("X4"));
        }

        /// <summary>
        /// Provides the name of our usage collection.
        /// </summary>
        internal string UsageCollectionName()
        {
            Type collectionType = Utils.UsageCollectionType(this.UsagePageEnum);
            return Enum.GetName(collectionType, this.UsageCollection);
        }

        /// <summary>
        /// Provides name and value of our usage collection as a string.
        /// </summary>
        internal string UsageCollectionNameAndValue()
        {
            return string.Format("{0} (0x{1})", this.UsageCollectionName(), this.UsageCollection.ToString("X4"));
        }

        /// <summary>
        /// Provides name of the usage at the given index.
        /// </summary>
        /// <param name="index">Index of the usage concerned.</param>
        /// <returns></returns>
        internal string UsageName(int index)
        {
            Type usageType = Utils.UsageType(this.UsagePageEnum);
            return Enum.GetName(usageType, this.Usages[index]);
        }

        /// <summary>
        /// Provides name and value of the usage at the given index.
        /// </summary>
        /// <param name="index">Index of the usage concerned.</param>
        /// <returns></returns>
        internal string UsageNameAndValue(int index)
        {
            return string.Format("{0} (0x{1})", this.UsageName(index), this.Usages[index].ToString("X4"));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="usagePage"></param>
        /// <param name="Usage"></param>
        /// <returns></returns>
        internal uint GetUsageValue(ushort usagePage, ushort usage)
        {
            foreach (HIDP_VALUE_CAPS caps in this.Device.InputValueCapabilities)
            {
                if (caps.IsRange)
                {
                    // What should we do with those guys?
                    continue;
                }

                // Check if we have a match
                if (caps.UsagePage == usagePage && caps.NotRange.Usage == usage)
                {
                    return this.UsageValues[caps];
                }
            }

            return 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="usagePage"></param>
        /// <param name="usage"></param>
        /// <returns></returns>
        internal int GetValueCapabilitiesIndex(ushort usagePage, ushort usage)
        {
            int i = -1;

            // Make sure we have a device with input value capabilities
            if (this.Device == null || this.Device.InputValueCapabilities == null)
            {
                return i;
            }

            // Search our value capabilities for the first one matching usage and usage page
            foreach (HIDP_VALUE_CAPS caps in this.Device.InputValueCapabilities)
            {
                i++;
                if (caps.IsRange)
                {
                    // What should we do with those guys?
                    continue;
                }

                // Check if we have a match
                if (caps.UsagePage == usagePage && caps.NotRange.Usage == usage)
                {
                    return i;
                }
            }

            return i;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        internal string InputReportString()
        {
            if (this.InputReport == null)
            {
                return "null";
            }

            var hidDump = string.Empty;
            foreach (byte b in this.InputReport)
            {
                hidDump += b.ToString("X2");
            }

            return hidDump;
        }

        /// <summary>
        /// Print information about this device to our debug output.
        /// </summary>
        [Conditional("DEBUG")]
        internal void DebugWrite()
        {
            Debug.Write(this.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        private void ProcessInputReport(byte[] inputReport)
        {
            /// Get all our usages, those are typically the buttons currently pushed on a gamepad.
            /// For a remote control it's usually just the one button that was pushed.
            this.GetUsages(inputReport);

            // Now process direction pad (d-pad, dpad) and axes
            this.GetUsageValues(inputReport);
        }

        /// <summary>
        /// Typically fetches values of a joystick/gamepad axis and dpad directions.
        /// </summary>
        /// <param name="inputReport"></param>
        private void GetUsageValues(byte[] inputReport)
        {
            if (this.Device.InputValueCapabilities == null)
            {
                return;
            }

            foreach (HIDP_VALUE_CAPS caps in this.Device.InputValueCapabilities)
            {
                if (caps.IsRange)
                {
                    // What should we do with those guys?
                    continue;
                }

                // Now fetch and add our usage value
                uint usageValue = 0;
                HidStatus status = Win32.Win32Hid.NativeMethods.HidP_GetUsageValue(HIDP_REPORT_TYPE.HidP_Input, caps.UsagePage, caps.LinkCollection, caps.NotRange.Usage, ref usageValue, this.Device.PreParsedData, inputReport, (uint)inputReport.Length);
                if (status == HidStatus.HIDP_STATUS_SUCCESS)
                {
                    this.UsageValues[caps] = usageValue;
                }
            }
        }

        /// <summary>
        /// Get all our usages, those are typically the buttons currently pushed on a gamepad.
        /// For a remote control it's usually just the one button that was pushed.
        /// </summary>
        private void GetUsages(byte[] inputReport)
        {
            /// Do proper parsing of our HID report
            /// First query our usage count
            uint usageCount = 0;
            USAGE_AND_PAGE[] usages = null;
            HidStatus status = Win32.Win32Hid.NativeMethods.HidP_GetUsagesEx(HIDP_REPORT_TYPE.HidP_Input, 0, usages, ref usageCount, this.Device.PreParsedData, inputReport, (uint)inputReport.Length);
            if (status == HidStatus.HIDP_STATUS_BUFFER_TOO_SMALL)
            {
                // Allocate a large enough buffer 
                usages = new USAGE_AND_PAGE[usageCount];

                // ...and fetch our usages
                status = Win32.Win32Hid.NativeMethods.HidP_GetUsagesEx(HIDP_REPORT_TYPE.HidP_Input, 0, usages, ref usageCount, this.Device.PreParsedData, inputReport, (uint)inputReport.Length);
                if (status != HidStatus.HIDP_STATUS_SUCCESS)
                {
                    Debug.WriteLine("Second pass could not parse HID data: " + status.ToString());
                }
            }
            else if (status != HidStatus.HIDP_STATUS_SUCCESS)
            {
                Debug.WriteLine("First pass could not parse HID data: " + status.ToString());
            }

            Debug.WriteLine("Usage count: " + usageCount.ToString());

            // Copy usages into this event
            if (usages != null)
            {
                foreach (USAGE_AND_PAGE up in usages)
                {
                    this.Usages.Add(up.Usage);
                }
            }
        }
    }
}