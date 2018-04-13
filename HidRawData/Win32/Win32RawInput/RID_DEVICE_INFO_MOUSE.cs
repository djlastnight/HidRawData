namespace Djlastnight.Win32.Win32RawInput
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct RID_DEVICE_INFO_MOUSE
    {
        public uint dwId;
        public uint dwNumberOfButtons;
        public uint dwSampleRate;
        public bool fHasHorizontalWheel;
    }
}