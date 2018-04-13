namespace Djlastnight.Win32.Win32CreateFile
{
    using System;
    using System.Runtime.InteropServices;
    using Microsoft.Win32.SafeHandles;

    internal static class NativeMethods
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern SafeFileHandle CreateFile(
             [MarshalAs(UnmanagedType.LPTStr)] string lpFileName,
             [MarshalAs(UnmanagedType.U4)] FileAccess dwDesiredAccess,
             [MarshalAs(UnmanagedType.U4)] FileShare dwShareMode,
             IntPtr lpSecurityAttributes, // optional SECURITY_ATTRIBUTES struct or IntPtr.Zero
             [MarshalAs(UnmanagedType.U4)] CreationDisposition dwCreationDisposition,
             [MarshalAs(UnmanagedType.U4)] FileFlagsAttributes dwFlagsAndAttributes,
             IntPtr hTemplateFile);

        [DllImport("kernel32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern SafeFileHandle CreateFileA(
             [MarshalAs(UnmanagedType.LPStr)] string lpFileName,
             [MarshalAs(UnmanagedType.U4)] FileAccess dwDesiredAccess,
             [MarshalAs(UnmanagedType.U4)] FileShare dwShareMode,
             IntPtr lpSecurityAttributes,
             [MarshalAs(UnmanagedType.U4)] CreationDisposition dwCreationDisposition,
             [MarshalAs(UnmanagedType.U4)] FileFlagsAttributes dwFlagsAndAttributes,
             IntPtr hTemplateFile);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern SafeFileHandle CreateFileW(
             [MarshalAs(UnmanagedType.LPWStr)] string lpFileName,
             [MarshalAs(UnmanagedType.U4)] FileAccess dwDesiredAccess,
             [MarshalAs(UnmanagedType.U4)] FileShare dwShareMode,
             IntPtr lpSecurityAttributes,
             [MarshalAs(UnmanagedType.U4)] CreationDisposition dwCreationDisposition,
             [MarshalAs(UnmanagedType.U4)] FileFlagsAttributes dwFlagsAndAttributes,
             IntPtr hTemplateFile);
    }
}