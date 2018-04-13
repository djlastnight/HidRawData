namespace Djlastnight.Win32.Win32RawInput
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct RAWMOUSE
    {
        [MarshalAs(UnmanagedType.U2)]
        [FieldOffset(0)]
        public RawInputMouseFlags usFlags;

        [MarshalAs(UnmanagedType.U4)]
        [FieldOffset(4)]
        public uint ulButtons;

        [FieldOffset(4)]
        public RAWMOUSEBUTTONS buttonsStr;

        [MarshalAs(UnmanagedType.U4)]
        [FieldOffset(8)]
        public uint ulRawButtons;

        [MarshalAs(UnmanagedType.U4)]
        [FieldOffset(12)]
        public int lLastX;

        [MarshalAs(UnmanagedType.U4)]
        [FieldOffset(16)]
        public int lLastY;

        [MarshalAs(UnmanagedType.U4)]
        [FieldOffset(20)]
        public uint ulExtraInformation;

        public override string ToString()
        {
            return string.Format(
                "RawMouse:{0} - usFlags = {1}{0} - ulButtons = {2}{0} - {3}{0} - ulRawButtons = {4}{0} - LastX = {5}{0} - LastY = {6}{0} - ulExtraInformation = {7}",
                Environment.NewLine,
                this.usFlags,
                this.ulButtons,
                this.buttonsStr,
                this.ulRawButtons,
                this.lLastX,
                this.lLastY,
                this.ulExtraInformation);
        }
    }
}