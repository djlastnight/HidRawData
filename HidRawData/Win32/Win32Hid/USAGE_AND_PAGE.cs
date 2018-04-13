namespace Djlastnight.Win32.Win32Hid
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    internal struct USAGE_AND_PAGE
    {
        public ushort Usage;
        public ushort UsagePage;
    }
}