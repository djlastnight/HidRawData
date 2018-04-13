namespace Djlastnight.Win32
{
    using System;

    internal static class Helper
    {
        public static int GET_APPCOMMAND_LPARAM(IntPtr longParam)
        {
            return (short)HIWORD(longParam.ToInt32()) & ~Contants.FAPPCOMMAND_MASK;
        }

        /// <summary>
        /// Retrieves the input code from wParam in WM_INPUT.
        /// See RIM_INPUT and RIM_INPUTSINK.
        /// </summary>
        /// <param name="wordParam"></param>
        /// <returns></returns>
        public static int GET_RAWINPUT_CODE_WPARAM(IntPtr wordParam)
        {
            return wordParam.ToInt32() & 0xff;
        }

        public static int GET_DEVICE_LPARAM(IntPtr longParam)
        {
            return (ushort)(HIWORD(longParam.ToInt32()) & Contants.FAPPCOMMAND_MASK);
        }

        public static int HIWORD(int val)
        {
            return (val >> 16) & 0xffff;
        }
    }
}