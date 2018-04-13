namespace Djlastnight.Input.WinMM
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    internal struct JoyInfo
    {
        public int wXpos; // Current X-coordinate.
        public int wYpos; // Current Y-coordinate.
        public int wZpos; // Current Z-coordinate.
        public int wButtons; // Current state of joystick buttons.
    }
}