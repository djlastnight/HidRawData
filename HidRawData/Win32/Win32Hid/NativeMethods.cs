namespace Djlastnight.Win32.Win32Hid
{
    using System;
    using System.Runtime.InteropServices;
    using System.Text;
    using Microsoft.Win32.SafeHandles;

    internal static class NativeMethods
    {
        [DllImport("hid.dll", CharSet = CharSet.Unicode)]
        public static extern HidStatus HidP_GetUsagesEx(HIDP_REPORT_TYPE reportType, ushort linkCollection, [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] USAGE_AND_PAGE[] buttonList, ref uint usageLength, IntPtr preparsedData, [MarshalAs(UnmanagedType.LPArray)] byte[] report, uint reportLength);

        [DllImport("hid.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool HidD_GetManufacturerString(SafeFileHandle hidDeviceObject, StringBuilder buffer, int bufferLength);

        [DllImport("hid.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool HidD_GetProductString(SafeFileHandle hidDeviceObject, StringBuilder buffer, int bufferLength);

        [DllImport("hid.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool HidD_GetAttributes(SafeFileHandle hidDeviceObject, ref HIDD_ATTRIBUTES attributes);

        /// Return Type: NTSTATUS->LONG->int
        /// PreparsedData: PHIDP_PREPARSED_DATA->_HIDP_PREPARSED_DATA*
        /// Capabilities: PHIDP_CAPS->_HIDP_CAPS*
        [DllImport("hid.dll", EntryPoint = "HidP_GetCaps", CallingConvention = CallingConvention.StdCall)]
        public static extern HidStatus HidP_GetCaps(IntPtr preparsedData, ref HIDP_CAPS capabilities);

        /// Return Type: NTSTATUS->LONG->int
        /// ReportType: HIDP_REPORT_TYPE->_HIDP_REPORT_TYPE
        /// ButtonCaps: PHIDP_BUTTON_CAPS->_HIDP_BUTTON_CAPS*
        /// ButtonCapsLength: PUSHORT->USHORT*
        /// PreparsedData: PHIDP_PREPARSED_DATA->_HIDP_PREPARSED_DATA*
        [DllImport("hid.dll", EntryPoint = "HidP_GetButtonCaps", CallingConvention = CallingConvention.StdCall)]
        public static extern HidStatus HidP_GetButtonCaps(HIDP_REPORT_TYPE reportType, [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] HIDP_BUTTON_CAPS[] buttonCaps, ref ushort buttonCapsLength, IntPtr preparsedData);

        /// Return Type: NTSTATUS->LONG->int
        /// ReportType: HIDP_REPORT_TYPE->_HIDP_REPORT_TYPE
        /// ValueCaps: PHIDP_VALUE_CAPS->_HIDP_VALUE_CAPS*
        /// ValueCapsLength: PUSHORT->USHORT*
        /// PreparsedData: PHIDP_PREPARSED_DATA->_HIDP_PREPARSED_DATA*
        [DllImport("hid.dll", EntryPoint = "HidP_GetValueCaps", CallingConvention = CallingConvention.StdCall)]
        public static extern HidStatus HidP_GetValueCaps(HIDP_REPORT_TYPE reportType, [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] HIDP_VALUE_CAPS[] valueCaps, ref ushort valueCapsLength, IntPtr preparsedData);

        /// Return Type: NTSTATUS->LONG->int
        /// ReportType: HIDP_REPORT_TYPE->_HIDP_REPORT_TYPE
        /// UsagePage: USAGE->USHORT->unsigned short
        /// LinkCollection: USHORT->unsigned short
        /// Usage: USAGE->USHORT->unsigned short
        /// UsageValue: PULONG->ULONG*
        /// PreparsedData: PHIDP_PREPARSED_DATA->_HIDP_PREPARSED_DATA*
        /// Report: PCHAR->CHAR*
        /// ReportLength: ULONG->unsigned int
        [DllImport("hid.dll", EntryPoint = "HidP_GetUsageValue", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern HidStatus HidP_GetUsageValue(HIDP_REPORT_TYPE reportType, ushort usagePage, ushort linkCollection, ushort usage, ref uint usageValue, IntPtr preparsedData, [MarshalAs(UnmanagedType.LPArray)] byte[] report, uint reportLength);
    }
}