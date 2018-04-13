namespace Djlastnight.Win32.Win32RawInput
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct RID_DEVICE_INFO
    {
        [FieldOffset(0)]
        public uint cbSize;

        [FieldOffset(4)]
        [MarshalAs(UnmanagedType.U4)]
        public RawInputDeviceType dwType;

        [FieldOffset(8)]
        public RID_DEVICE_INFO_MOUSE mouse;

        [FieldOffset(8)]
        public RID_DEVICE_INFO_KEYBOARD keyboard;

        [FieldOffset(8)]
        public RID_DEVICE_INFO_HID hid;
    }
}