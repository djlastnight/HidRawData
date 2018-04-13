namespace Djlastnight.Win32.Win32RawInput
{
    /// <summary>
    /// Introduced this enum for consistency and easy of use.
    /// Naming of the Win32 constants were preserved.
    /// </summary>
    internal enum RawInputDeviceInfoType : uint
    {
        /// <summary>
        /// GetRawInputDeviceInfo pData points to a string that contains the device name.
        /// </summary>
        RIDI_DEVICENAME = 0x20000007,

        /// <summary>
        /// GetRawInputDeviceInfo For this uiCommand only, the value in pcbSize is the character count (not the byte count).
        /// </summary>
        RIDI_DEVICEINFO = 0x2000000b,

        /// <summary>
        /// GetRawInputDeviceInfo pData points to an RID_DEVICE_INFO structure.
        /// </summary>
        RIDI_PREPARSEDDATA = 0x20000005
    }
}
