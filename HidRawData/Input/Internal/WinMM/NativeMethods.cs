namespace Djlastnight.Input.WinMM
{
    using System.Runtime.InteropServices;
    using System.Security;

    internal static class NativeMethods
    {
        /// <summary>
        /// Retruns the number of joysticks supported. Usually 16
        /// </summary>
        /// <returns></returns>
        public static int JoyGetNumDevs()
        {
            return joyGetNumDevs();
        }

        /// <summary>
        /// Used to retrieve data from joystick. If JoyInfoEx structure is not properly initialized,
        /// this method will do it for you.
        /// </summary>
        /// <param name="joyId"></param>
        /// <param name="infox"></param>
        /// <returns></returns>
        public static MMResult JoyGetPosX(int joyId, ref JoyInfoEx infox)
        {
            if (infox.dwSize == 0)
            {
                infox.dwSize = Marshal.SizeOf(infox);
            }

            if (infox.dwFlags == 0)
            {
                infox.dwSize = (int)JoyFlags.ReturnAll;
            }

            return (MMResult)joyGetPosEx(joyId, ref infox);
        }

        public static MMResult JoyGetDevCaps(int joyId, ref JoyCaps caps)
        {
            var result = joyGetDevCaps(joyId, ref caps, Marshal.SizeOf(caps));
            return (MMResult)result;
        }

        [DllImport("winmm.dll", CallingConvention = CallingConvention.StdCall), SuppressUnmanagedCodeSecurity]
        private static extern int joyGetNumDevs();

        [DllImport("winmm.dll", CallingConvention = CallingConvention.StdCall), SuppressUnmanagedCodeSecurity]
        private static extern int joyGetPosEx(int uJoyID, ref JoyInfoEx pji);

        [DllImport("winmm.dll", CallingConvention = CallingConvention.StdCall), SuppressUnmanagedCodeSecurity]
        private static extern int joyGetDevCaps(int uJoyID, ref JoyCaps caps, int cbjc);
    }
}