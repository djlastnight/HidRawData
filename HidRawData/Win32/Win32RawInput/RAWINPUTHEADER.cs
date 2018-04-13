namespace Djlastnight.Win32.Win32RawInput
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct RAWINPUTHEADER
    {
        [MarshalAs(UnmanagedType.U4)]
        public RawInputDeviceType dwType;

        [MarshalAs(UnmanagedType.U4)]
        public int dwSize;

        public IntPtr hDevice;

        [MarshalAs(UnmanagedType.U4)]
        public int wParam;

        public override string ToString()
        {
            return string.Format(
                "RawInputHeader:{0} - DeviceType = {1}{0} - Size = {2}{0} - DeviceHandle = {3}{0} - WordParam = {4}",
                Environment.NewLine,
                this.dwType,
                this.dwSize,
                this.hDevice,
                this.wParam);
        }
    }
}