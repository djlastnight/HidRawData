namespace Djlastnight.Win32.Win32RawInput
{
    using System;
    using System.Runtime.InteropServices;

    internal static partial class NativeMethods
    {
        [DllImport("User32.dll", SetLastError = true)]
        public static extern bool RegisterRawInputDevices(RAWINPUTDEVICE[] pRawInputDevice, uint uiNumDevices, uint cbSize);

        [DllImport("User32.dll", SetLastError = true)]
        public static extern uint GetRawInputData(IntPtr hRawInput, uint uiCommand, IntPtr pData, ref uint pcbSize, uint cbSizeHeader);

        [DllImport("User32.dll", SetLastError = true)]
        public static extern int GetRawInputDeviceInfo(IntPtr hDevice, RawInputDeviceInfoType uiCommand, IntPtr pData, ref uint pcbSize);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern int GetRawInputDeviceList(
            [In, Out] RAWINPUTDEVICELIST[] InputdeviceList,
            [In, Out] ref uint puiNumDevices,
            [In] uint cbSize);
    }
}