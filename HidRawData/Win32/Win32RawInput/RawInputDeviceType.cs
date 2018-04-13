namespace Djlastnight.Win32.Win32RawInput
{
    /// <summary>
    /// Introduced this enum for consistency and easy of use.
    /// Naming of the Win32 constants were preserved.
    /// </summary>
    public enum RawInputDeviceType : uint
    {
        /// <summary>
        /// Data comes from a mouse.
        /// </summary>
        RIM_TYPEMOUSE = 0,

        /// <summary>
        /// Data comes from a keyboard.
        /// </summary>
        RIM_TYPEKEYBOARD = 1,

        /// <summary>
        /// Data comes from an HID that is not a keyboard or a mouse.
        /// </summary>
        RIM_TYPEHID = 2
    }
}