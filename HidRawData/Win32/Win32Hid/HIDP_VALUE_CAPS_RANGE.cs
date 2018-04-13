namespace Djlastnight.Win32.Win32Hid
{
    using System.Runtime.InteropServices;

    /// <summary>
    /// Type created in place of an anonymous struct
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct HIDP_VALUE_CAPS_RANGE
    {
        /// USAGE->USHORT->unsigned short
        public ushort UsageMin;

        /// USAGE->USHORT->unsigned short
        public ushort UsageMax;

        /// USHORT->unsigned short
        public ushort StringMin;

        /// USHORT->unsigned short
        public ushort StringMax;

        /// USHORT->unsigned short
        public ushort DesignatorMin;

        /// USHORT->unsigned short
        public ushort DesignatorMax;

        /// USHORT->unsigned short
        public ushort DataIndexMin;

        /// USHORT->unsigned short
        public ushort DataIndexMax;
    }
}