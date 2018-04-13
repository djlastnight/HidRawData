namespace Djlastnight.Win32.Win32RawInput
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct RAWMOUSEBUTTONS
    {
        [MarshalAs(UnmanagedType.U2)]
        public RawInputMouseButtonFlags usButtonFlags;

        [MarshalAs(UnmanagedType.U2)]
        public ushort usButtonData;

        public override string ToString()
        {
            return string.Format(
                "RawMouseButtons:{0}  -- MouseButtonFlags = {1}{0}  -- ButtonData = {2}",
                Environment.NewLine,
                this.usButtonFlags,
                this.usButtonData);
        }
    }
}