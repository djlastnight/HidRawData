namespace Djlastnight.Win32.Win32RawInput
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct RAWKEYBOARD
    {
        [MarshalAs(UnmanagedType.U2)]
        public ushort MakeCode;

        [MarshalAs(UnmanagedType.U2)]
        public RawInputKeyFlags Flags;

        [MarshalAs(UnmanagedType.U2)]
        public ushort Reserved;

        [MarshalAs(UnmanagedType.U2)]
        public ushort VKey;

        [MarshalAs(UnmanagedType.U4)]
        public uint Message;

        [MarshalAs(UnmanagedType.U4)]
        public uint ExtraInformation;

        public override string ToString()
        {
            return string.Format(
                "RawKeyboard:{0} - MakeCode = {1}{0} - KeyFlags = {2}{0} - Reserved = {3}{0} - VKey = {4}{0} - Message = {5}{0} - ExtraInfo = {6}",
                Environment.NewLine,
                this.MakeCode,
                this.Flags,
                this.Reserved,
                this.VKey,
                this.Message,
                this.ExtraInformation);
        }
    }
}