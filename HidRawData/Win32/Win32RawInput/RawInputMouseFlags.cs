namespace Djlastnight.Win32.Win32RawInput
{
    using System;

    /// <summary>
    /// See RAWMOUSE.usFlags.
    /// </summary>
    [Flags]
    public enum RawInputMouseFlags : ushort
    {
        /// <summary>
        /// Mouse movement data is relative to the last mouse position.
        /// </summary>
        MOUSE_MOVE_RELATIVE = 0,

        /// <summary>
        /// Mouse movement data is based on absolute position.
        /// </summary>
        MOUSE_MOVE_ABSOLUTE = 1,

        /// <summary>
        /// Mouse coordinates are mapped to the virtual desktop (for a multiple monitor system).
        /// </summary>
        MOUSE_VIRTUAL_DESKTOP = 0x02,

        /// <summary>
        /// Mouse attributes changed; application needs to query the mouse attributes.
        /// </summary>
        MOUSE_ATTRIBUTES_CHANGED = 0x04
    }
}