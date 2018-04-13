namespace Djlastnight.Win32.Win32RawInput
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct RAWINPUT
    {
        [FieldOffset(0)]
        public RAWINPUTHEADER header;

        [FieldOffset(16)]
        public RAWMOUSE mouse;

        [FieldOffset(16)]
        public RAWKEYBOARD keyboard;

        [FieldOffset(16)]
        public RAWHID hid;

        public override string ToString()
        {
            return string.Format("{1}{0}{0}{2}{0}{0}{3}{0}{0}{4}", Environment.NewLine, this.header, this.mouse, this.keyboard, this.hid);
        }
    }
}