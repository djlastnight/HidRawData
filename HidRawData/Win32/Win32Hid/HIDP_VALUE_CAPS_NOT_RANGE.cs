namespace Djlastnight.Win32.Win32Hid
{
    using System.Runtime.InteropServices;

    /// <summary>
    /// Type created in place of an anonymous struct
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct HIDP_VALUE_CAPS_NOT_RANGE
    {
        /// USAGE->USHORT->unsigned short
        public ushort Usage;

        /// USAGE->USHORT->unsigned short
        public ushort Reserved1;

        /// USHORT->unsigned short
        public ushort StringIndex;

        /// USHORT->unsigned short
        public ushort Reserved2;

        /// USHORT->unsigned short
        public ushort DesignatorIndex;

        /// USHORT->unsigned short
        public ushort Reserved3;

        /// USHORT->unsigned short
        public ushort DataIndex;

        /// USHORT->unsigned short
        public ushort Reserved4;
    }
}