namespace Djlastnight.Win32.Win32Hid
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct HIDP_BUTTON_CAPS
    {
        /// USAGE->USHORT->unsigned short
        [FieldOffset(0)]
        public ushort UsagePage;

        /// UCHAR->unsigned char
        [FieldOffset(2)]
        public byte ReportID;

        /// BOOLEAN->BYTE->unsigned char
        [FieldOffset(3)]
        [MarshalAs(UnmanagedType.U1)]
        public bool IsAlias;

        /// USHORT->unsigned short
        [FieldOffset(4)]
        public ushort BitField;

        /// USHORT->unsigned short
        [FieldOffset(6)]
        public ushort LinkCollection;

        /// USAGE->USHORT->unsigned short
        [FieldOffset(8)]
        public ushort LinkUsage;

        /// USAGE->USHORT->unsigned short
        [FieldOffset(10)]
        public ushort LinkUsagePage;

        /// BOOLEAN->BYTE->unsigned char
        [FieldOffset(12)]
        [MarshalAs(UnmanagedType.U1)]
        public bool IsRange;

        /// BOOLEAN->BYTE->unsigned char
        [FieldOffset(13)]
        [MarshalAs(UnmanagedType.U1)]
        public bool IsStringRange;

        /// BOOLEAN->BYTE->unsigned char
        [FieldOffset(14)]
        [MarshalAs(UnmanagedType.U1)]
        public bool IsDesignatorRange;

        /// BOOLEAN->BYTE->unsigned char
        [FieldOffset(15)]
        [MarshalAs(UnmanagedType.U1)]
        public bool IsAbsolute;

        /// ULONG[10]
        [FieldOffset(16)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.U4)]
        public uint[] Reserved;

        /// Union Range/NotRange
        [FieldOffset(56)]
        public HIDP_BUTTON_CAPS_RANGE Range;

        [FieldOffset(56)]
        public HIDP_BUTTON_CAPS_NOT_RANGE NotRange;
    }
}