namespace Djlastnight.Win32.Win32RawInput
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct RAWHID
    {
        [MarshalAs(UnmanagedType.U4)]
        public uint dwSizeHid;

        [MarshalAs(UnmanagedType.U4)]
        public uint dwCount;

        public override string ToString()
        {
            return string.Format(
                "RawHid:{0} - Size = {1}{0} - Count = {2}",
                Environment.NewLine,
                this.dwSizeHid,
                this.dwCount);
        }
    }
}