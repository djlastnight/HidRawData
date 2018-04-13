namespace Djlastnight.Input.WinMM
{
    using System.Runtime.InteropServices;

    internal struct JoyCaps
    {
        /// <summary>
        ///     Manufacturer identifier. Manufacturer identifiers are defined in Manufacturer and Product Identifiers.
        /// </summary>
        public ushort wMid;

        /// <summary>
        ///     Product identifier. Product identifiers are defined in Manufacturer and Product Identifiers.
        /// </summary>
        public ushort wPid;

        /// <summary>
        ///     Null-terminated string containing the joystick product name.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string szPname;

        /// <summary>
        ///     Minimum X-coordinate.
        /// </summary>
        /// 
        public int wXmin;

        /// <summary>
        ///     Maximum X-coordinate.
        /// </summary>
        public int wXmax;

        /// <summary>
        /// Minimum Y-coordinate.
        /// </summary>
        public int wYmin;

        /// <summary>
        ///     Maximum Y-coordinate.
        /// </summary>
        public int wYmax;

        /// <summary>
        ///     Minimum Z-coordinate.
        /// </summary>
        public int wZmin;

        /// <summary>
        ///     Maximum Z-coordinate.
        /// </summary>
        public int wZmax;

        /// <summary>
        ///     Number of joystick buttons.
        /// </summary>
        public int wNumButtons;

        /// <summary>
        ///     Smallest polling frequency supported when captured by the <see cref="joySetCapture"/> function.
        /// </summary>
        public int wPeriodMin;

        /// <summary>
        ///     Largest polling frequency supported when captured by <see cref="joySetCapture"/>.
        /// </summary>
        public int wPeriodMax;

        /// <summary>
        ///     Minimum rudder value. The rudder is a fourth axis of movement.
        /// </summary>
        public int wRmin;

        /// <summary>
        ///     Maximum rudder value. The rudder is a fourth axis of movement.
        /// </summary>
        public int wRmax;

        /// <summary>
        ///     Minimum u-coordinate (fifth axis) values.
        /// </summary>
        public int wUmin;

        /// <summary>
        ///     Maximum u-coordinate (fifth axis) values.
        /// </summary>
        public int wUmax;

        /// <summary>
        ///     Minimum v-coordinate (sixth axis) values.
        /// </summary>
        public int wVmin;

        /// <summary>
        ///     Maximum v-coordinate (sixth axis) values.
        /// </summary>
        public int wVmax;

        /// <summary>
        ///     Joystick capabilities The following flags define individual capabilities that a joystick might have:
        /// </summary>
        public int wCaps;

        /// <summary>
        ///     Maximum number of axes supported by the joystick.
        /// </summary>
        public int wMaxAxes;

        /// <summary>
        ///     Number of axes currently in use by the joystick.
        /// </summary>
        public int wNumAxes;

        /// <summary>
        ///     Maximum number of buttons supported by the joystick.
        /// </summary>
        public int wMaxButtons;

        /// <summary>
        ///     Null-terminated string containing the registry key for the joystick.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string szRegKey;

        /// <summary>
        ///     Null-terminated string identifying the joystick driver OEM.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
        public string szOEMVxD;
    }
}
