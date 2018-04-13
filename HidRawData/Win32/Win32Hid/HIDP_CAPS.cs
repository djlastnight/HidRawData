namespace Djlastnight.Win32.Win32Hid
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct HIDP_CAPS
    {
        /// USAGE->USHORT->unsigned short
        public ushort Usage;

        /// USAGE->USHORT->unsigned short
        public ushort UsagePage;

        /// USHORT->unsigned short
        public ushort InputReportByteLength;

        /// USHORT->unsigned short
        public ushort OutputReportByteLength;

        /// USHORT->unsigned short
        public ushort FeatureReportByteLength;

        /// USHORT[17]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 17, ArraySubType = UnmanagedType.U2)]
        public ushort[] Reserved;

        /// USHORT->unsigned short
        public ushort NumberLinkCollectionNodes;

        /// USHORT->unsigned short
        public ushort NumberInputButtonCaps;

        /// USHORT->unsigned short
        public ushort NumberInputValueCaps;

        /// USHORT->unsigned short
        public ushort NumberInputDataIndices;

        /// USHORT->unsigned short
        public ushort NumberOutputButtonCaps;

        /// USHORT->unsigned short
        public ushort NumberOutputValueCaps;

        /// USHORT->unsigned short
        public ushort NumberOutputDataIndices;

        /// USHORT->unsigned short
        public ushort NumberFeatureButtonCaps;

        /// USHORT->unsigned short
        public ushort NumberFeatureValueCaps;

        /// USHORT->unsigned short
        public ushort NumberFeatureDataIndices;
    }
}