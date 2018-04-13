namespace Djlastnight.Win32.Win32Hid
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct HIDP_VALUE_CAPS
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

        /// BOOLEAN->BYTE->unsigned char
        [FieldOffset(16)]
        [MarshalAs(UnmanagedType.U1)]
        public bool HasNull;

        /// UCHAR->unsigned char
        [FieldOffset(17)]
        public byte Reserved;

        /// USHORT->unsigned short
        [FieldOffset(18)]
        public ushort BitSize;

        /// USHORT->unsigned short
        [FieldOffset(20)]
        public ushort ReportCount;

        /// USHORT[5]
        /// We had to use 5 ushorts instead of an array to avoid alignment exception issues.
        [FieldOffset(22)]
        public ushort Reserved21;
        [FieldOffset(24)]
        public ushort Reserved22;
        [FieldOffset(26)]
        public ushort Reserved23;
        [FieldOffset(28)]
        public ushort Reserved24;
        [FieldOffset(30)]
        public ushort Reserved25;

        /// ULONG->unsigned int
        [FieldOffset(32)]
        public uint UnitsExp;

        /// ULONG->unsigned int
        [FieldOffset(36)]
        public uint Units;

        /// LONG->int
        [FieldOffset(40)]
        public int LogicalMin;

        /// LONG->int
        [FieldOffset(44)]
        public int LogicalMax;

        /// LONG->int
        [FieldOffset(48)]
        public int PhysicalMin;

        /// LONG->int
        [FieldOffset(52)]
        public int PhysicalMax;

        /// Union Range/NotRange
        [FieldOffset(56)]
        public HIDP_VALUE_CAPS_RANGE Range;

        [FieldOffset(56)]
        public HIDP_VALUE_CAPS_NOT_RANGE NotRange;
    }   
}