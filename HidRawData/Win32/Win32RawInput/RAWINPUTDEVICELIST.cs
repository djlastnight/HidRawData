namespace Djlastnight.Win32.Win32RawInput
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct RAWINPUTDEVICELIST
    {
        public IntPtr hDevice;
        public RawInputDeviceType dwType;
    }
}