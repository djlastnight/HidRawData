namespace Djlastnight.Win32.Win32RawInput
{
    using System;

    /// <summary>
    /// See RAWKEYBOARD.Flags
    /// </summary>
    [Flags]
    public enum RawInputKeyFlags : ushort
    {
        /// <summary>
        /// The key is down.
        /// </summary>
        RI_KEY_MAKE = 0x0000,

        /// <summary>
        /// The key is up.
        /// </summary>
        RI_KEY_BREAK = 0x0001,

        /// <summary>
        /// The scan code has the E0 prefix.
        /// </summary>
        RI_KEY_E0 = 0x0002,

        /// <summary>
        /// The scan code has the E1 prefix.
        /// </summary>
        RI_KEY_E1 = 0x0004
    }
}
