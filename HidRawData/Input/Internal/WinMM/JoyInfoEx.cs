namespace Djlastnight.Input.WinMM
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    internal struct JoyInfoEx
    {
        /// <summary>
        /// Size, in bytes, of this structure.
        /// </summary>
        public int dwSize;

        /// <summary>
        /// Flags indicating the valid information returned in this structure.
        /// </summary>
        public int dwFlags;

        /// <summary>
        /// Current X-coordinate.
        /// </summary>
        public int dwXpos;

        /// <summary>
        /// Current Y-coordinate.
        /// </summary>
        public int dwYpos;

        /// <summary>
        /// Current Z-coordinate.
        /// </summary>
        public int dwZpos;

        /// <summary>
        /// Current position of the rudder or fourth joystick axis.
        /// </summary>
        public int dwRpos;

        /// <summary>
        /// Current fifth axis position.
        /// </summary>
        public int dwUpos;

        /// <summary>
        /// Current sixth axis position.
        /// </summary>
        public int dwVpos;

        /// <summary>
        /// Current state of the 32 joystick buttons (bits)
        /// </summary>
        public int dwButtons;

        /// <summary>
        /// Total pressed buttons count
        /// </summary>
        public int dwButtonNumber;

        /// <summary>
        /// Current position of the point-of-view control (0..35,900, deg*100)
        /// </summary>
        public int dwPOV;

        /// <summary>
        /// Reserved; do not use.
        /// </summary>
        public int dwReserved1;

        /// <summary>
        /// Reserved; do not use.
        /// </summary>
        public int dwReserved2;
    }
}