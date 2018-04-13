namespace Djlastnight.Win32.Win32RawInput
{
    using System;

    /// <summary>
    /// Value taken by RAWMOUSEBUTTONS.usButtonFlags.
    /// </summary>
    [Flags]
    public enum RawInputMouseButtonFlags : ushort
    {
        /// <summary>
        /// Left button changed to down.
        /// </summary>
        RI_MOUSE_LEFT_BUTTON_DOWN = 0x0001,

        /// <summary>
        /// Left button changed to up.
        /// </summary>
        RI_MOUSE_LEFT_BUTTON_UP = 0x0002,

        /// <summary>
        /// Middle button changed to down.
        /// </summary>
        RI_MOUSE_MIDDLE_BUTTON_DOWN = 0x0010,

        /// <summary>
        /// Middle button changed to up.
        /// </summary>
        RI_MOUSE_MIDDLE_BUTTON_UP = 0x0020,

        /// <summary>
        /// Right button changed to down.
        /// </summary>
        RI_MOUSE_RIGHT_BUTTON_DOWN = 0x0004,

        /// <summary>
        /// Right button changed to up.
        /// </summary>
        RI_MOUSE_RIGHT_BUTTON_UP = 0x0008,

        /// <summary>
        /// See RI_MOUSE_LEFT_BUTTON_DOWN
        /// </summary>
        RI_MOUSE_BUTTON_1_DOWN = 0x0001,

        /// <summary>
        /// See RI_MOUSE_LEFT_BUTTON_UP
        /// </summary>
        RI_MOUSE_BUTTON_1_UP = 0x0002,

        /// <summary>
        /// See RI_MOUSE_RIGHT_BUTTON_DOWN
        /// </summary>
        RI_MOUSE_BUTTON_2_DOWN = 0x0004,

        /// <summary>
        /// See RI_MOUSE_RIGHT_BUTTON_UP
        /// </summary>
        RI_MOUSE_BUTTON_2_UP = 0x0008,

        /// <summary>
        /// See RI_MOUSE_MIDDLE_BUTTON_DOWN
        /// </summary>
        RI_MOUSE_BUTTON_3_DOWN = 0x0010,

        /// <summary>
        /// See RI_MOUSE_MIDDLE_BUTTON_UP
        /// </summary>
        RI_MOUSE_BUTTON_3_UP = 0x0020,

        /// <summary>
        /// XBUTTON1 changed to down.
        /// </summary>        
        RI_MOUSE_BUTTON_4_DOWN = 0x0040,

        /// <summary>
        /// XBUTTON1 changed to up.
        /// </summary>
        RI_MOUSE_BUTTON_4_UP = 0x0080,

        /// <summary>
        /// XBUTTON2 changed to down.
        /// </summary>
        RI_MOUSE_BUTTON_5_DOWN = 0x100,

        /// <summary>
        /// XBUTTON2 changed to up.
        /// </summary>
        RI_MOUSE_BUTTON_5_UP = 0x0200,

        /// <summary>
        /// Raw input comes from a mouse wheel.The wheel delta is stored in usButtonData.
        /// </summary>
        RI_MOUSE_WHEEL = 0x0400
    }
}
