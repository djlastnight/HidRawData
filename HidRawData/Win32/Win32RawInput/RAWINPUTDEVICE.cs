namespace Djlastnight.Win32.Win32RawInput
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct RAWINPUTDEVICE
    {
        [MarshalAs(UnmanagedType.U2)]
        public ushort usUsagePage;

        [MarshalAs(UnmanagedType.U2)]
        public ushort usUsage;

        [MarshalAs(UnmanagedType.U4)]
        public RawInputDeviceFlags dwFlags;

        public IntPtr hwndTarget;
    }
}
