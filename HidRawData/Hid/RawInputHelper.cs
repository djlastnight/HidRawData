namespace Djlastnight.Hid
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;
    using Djlastnight.Win32;
    using Djlastnight.Win32.Win32Hid;
    using Djlastnight.Win32.Win32RawInput;

    /// <summary>
    /// Provide some utility functions for raw input handling.
    /// </summary>
    internal static class RawInputHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="rawInputHandle"></param>
        /// <param name="rawInput"></param>
        /// <param name="rawInputBuffer">Caller must free up memory on the pointer using Marshal.FreeHGlobal</param>
        /// <returns></returns>
        public static bool GetRawInputData(IntPtr rawInputHandle, ref RAWINPUT rawInput, ref IntPtr rawInputBuffer)
        {
            bool success = true;
            rawInputBuffer = IntPtr.Zero;

            try
            {
                uint size = 0;
                uint sizeOfHeader = (uint)Marshal.SizeOf(typeof(RAWINPUTHEADER));

                // Get the size of our raw input data.
                Win32.Win32RawInput.NativeMethods.GetRawInputData(rawInputHandle, Contants.RID_INPUT, IntPtr.Zero, ref size, sizeOfHeader);

                // Allocate a large enough buffer
                rawInputBuffer = Marshal.AllocHGlobal((int)size);

                // Now read our RAWINPUT data
                if (Win32.Win32RawInput.NativeMethods.GetRawInputData(rawInputHandle, Contants.RID_INPUT, rawInputBuffer, ref size, (uint)Marshal.SizeOf(typeof(RAWINPUTHEADER))) != size)
                {
                    return false;
                }

                // Cast our buffer
                rawInput = (RAWINPUT)Marshal.PtrToStructure(rawInputBuffer, typeof(RAWINPUT));
            }
            catch
            {
                Debug.WriteLine("GetRawInputData failed!");
                success = false;
            }

            return success;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="deviceHandle"></param>
        /// <param name="deviceInfo"></param>
        /// <returns></returns>
        public static bool GetDeviceInfo(IntPtr deviceHandle, ref RID_DEVICE_INFO deviceInfo)
        {
            bool success = true;
            IntPtr deviceInfoBuffer = IntPtr.Zero;
            try
            {
                // Get Device Info
                uint deviceInfoSize = (uint)Marshal.SizeOf(typeof(RID_DEVICE_INFO));
                deviceInfoBuffer = Marshal.AllocHGlobal((int)deviceInfoSize);

                int res = Win32.Win32RawInput.NativeMethods.GetRawInputDeviceInfo(deviceHandle, RawInputDeviceInfoType.RIDI_DEVICEINFO, deviceInfoBuffer, ref deviceInfoSize);
                if (res <= 0)
                {
                    Debug.WriteLine("WM_INPUT could not read device info: " + Marshal.GetLastWin32Error().ToString());
                    return false;
                }

                // Cast our buffer
                deviceInfo = (RID_DEVICE_INFO)Marshal.PtrToStructure(deviceInfoBuffer, typeof(RID_DEVICE_INFO));
            }
            catch
            {
                Debug.WriteLine("GetRawInputData failed!");
                success = false;
            }
            finally
            {
                // Always executes, prevents memory leak
                Marshal.FreeHGlobal(deviceInfoBuffer);
            }

            return success;
        }

        /// <summary>
        /// Fetch pre-parsed data corresponding to HID descriptor for the given HID device.
        /// </summary>
        /// <param name="deviceHandle"></param>
        /// <returns></returns>
        public static IntPtr GetPreParsedData(IntPtr deviceHandle)
        {
            uint dataSize = 0;
            int result = Win32.Win32RawInput.NativeMethods.GetRawInputDeviceInfo(deviceHandle, RawInputDeviceInfoType.RIDI_PREPARSEDDATA, IntPtr.Zero, ref dataSize);
            if (result != 0)
            {
                Debug.WriteLine("Failed to get raw input pre-parsed data size: " + result + " : " + Marshal.GetLastWin32Error());
                return IntPtr.Zero;
            }

            IntPtr data = Marshal.AllocHGlobal((int)dataSize);
            result = Win32.Win32RawInput.NativeMethods.GetRawInputDeviceInfo(deviceHandle, RawInputDeviceInfoType.RIDI_PREPARSEDDATA, data, ref dataSize);
            if (result <= 0)
            {
                Debug.WriteLine("Failed to get raw input pre-parsed data: " + result + " : " + Marshal.GetLastWin32Error());
                return IntPtr.Zero;
            }

            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="device"></param>
        /// <returns></returns>
        public static string GetDeviceName(IntPtr device)
        {
            uint deviceNameSize = 256;
            int result = Win32.Win32RawInput.NativeMethods.GetRawInputDeviceInfo(device, RawInputDeviceInfoType.RIDI_DEVICENAME, IntPtr.Zero, ref deviceNameSize);
            if (result != 0)
            {
                return string.Empty;
            }

            // Size is the character count not byte count
            IntPtr deviceName = Marshal.AllocHGlobal((int)deviceNameSize * 2);
            try
            {
                result = Win32.Win32RawInput.NativeMethods.GetRawInputDeviceInfo(device, RawInputDeviceInfoType.RIDI_DEVICENAME, deviceName, ref deviceNameSize);
                if (result > 0)
                {
                    // -1 for NULL termination
                    return Marshal.PtrToStringAnsi(deviceName, result - 1);
                }

                return string.Empty;
            }
            finally
            {
                Marshal.FreeHGlobal(deviceName);
            }
        }

        /// <summary>
        /// Populate the given tree-view control with our Raw Input Devices.
        /// </summary>
        /// <param name="treeView"></param>
        public static void PopulateDeviceList(TreeView treeView)
        {
            // Get our list of devices
            RAWINPUTDEVICELIST[] ridList = null;
            uint deviceCount = 0;
            int res = Win32.Win32RawInput.NativeMethods.GetRawInputDeviceList(ridList, ref deviceCount, (uint)Marshal.SizeOf(typeof(RAWINPUTDEVICELIST)));
            if (res == -1)
            {
                // Just give up then
                return;
            }

            ridList = new RAWINPUTDEVICELIST[deviceCount];
            res = Win32.Win32RawInput.NativeMethods.GetRawInputDeviceList(ridList, ref deviceCount, (uint)Marshal.SizeOf(typeof(RAWINPUTDEVICELIST)));
            if (res != deviceCount)
            {
                // Just give up then
                return;
            }

            // For each our device add a node to our treeview
            foreach (RAWINPUTDEVICELIST device in ridList)
            {
                Device hidDevice;

                // Try create our HID device.
                try
                {
                    hidDevice = new Device(device.hDevice);
                }
                catch
                {
                    continue;
                }

                TreeNode node = null;
                if (hidDevice.Product != null && hidDevice.Product.Length > 1)
                {
                    // Add the devices with a proper name at the top
                    node = treeView.Nodes.Insert(0, hidDevice.Name, hidDevice.FriendlyName);
                }
                else
                {
                    // Add other once at the bottom
                    node = treeView.Nodes.Add(hidDevice.Name, hidDevice.FriendlyName);
                }

                // Each device root node keeps a reference to our HID device
                node.Tag = hidDevice;

                // Populate device properties
                node.Nodes.Add("Manufacturer: " + hidDevice.Manufacturer);
                node.Nodes.Add("Product ID: 0x" + hidDevice.ProductId.ToString("X4"));
                node.Nodes.Add("Vendor ID: 0x" + hidDevice.VendorId.ToString("X4"));
                node.Nodes.Add("Version: " + hidDevice.Version);
                node.Nodes.Add(hidDevice.Info.dwType.ToString());
                if (hidDevice.Info.dwType == RawInputDeviceType.RIM_TYPEHID)
                {
                    node.Nodes.Add("UsagePage / UsageCollection: 0x" + hidDevice.Info.hid.usUsagePage.ToString("X4") + " / 0x" + hidDevice.Info.hid.usUsage.ToString("X4"));
                }

                if (hidDevice.InputCapabilitiesDescription != null)
                {
                    node.Nodes.Add(hidDevice.InputCapabilitiesDescription);
                }

                // Add button count
                node.Nodes.Add("Button Count: " + hidDevice.ButtonCount);

                // Those can be joystick/gamepad axis
                if (hidDevice.InputValueCapabilities != null)
                {
                    foreach (HIDP_VALUE_CAPS caps in hidDevice.InputValueCapabilities)
                    {
                        string des = Djlastnight.Hid.Device.InputValueCapabilityDescription(caps);
                        if (des != null)
                        {
                            node.Nodes.Add(des);
                        }
                    }
                }

                node.Nodes.Add(hidDevice.Name);
            }
        }

        public static List<Device> GetDevices()
        {
            var treeview = new System.Windows.Forms.TreeView();
            RawInputHelper.PopulateDeviceList(treeview);
            var devices = new Dictionary<uint, Device>();
            foreach (System.Windows.Forms.TreeNode node in treeview.Nodes)
            {
                var dev = (Device)node.Tag;
                if (!devices.ContainsKey(dev.UsageId))
                {
                    devices.Add(dev.UsageId, dev);
                }
            }

            return devices.Values.ToList();
        }
    }
}