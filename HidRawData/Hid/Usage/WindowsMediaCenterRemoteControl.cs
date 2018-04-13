namespace Djlastnight.Hid.Usage
{
    public enum WindowsMediaCenterRemoteControl : ushort
    {
        /// <summary>
        /// Not defined by the Microsoft specs.
        /// </summary>
        Null = 0x00,
        GreenStart = 0x0D,
        ClosedCaptioning = 0x2B,
        PrestigoA = 0x52, // Philips Prestigo A
        PrestigoB = 0x53, // Philips Prestigo B
        PrestigoC = 0x54, // Philips Prestigo C
        PrestigoD = 0x55, // Philips Prestigo D
        Teletext = 0x5A,
        TeletextRed = 0x5B,
        TeletextGreen = 0x5C,
        TeletextYellow = 0x5D,
        TeletextBlue = 0x5E,
        LiveTv = 0x25,
        Tv = 0x46,
        Music = 0x47,
        RecordedTv = 0x48,
        Pictures = 0x49,
        Videos = 0x4A,
        FmRadio = 0x50,
        Extras = 0x3C,
        ExtrasApp = 0x3D,
        DvdMenu = 0x24,
        DvdAngle = 0x4B,
        DvdAudio = 0x4C,
        DvdSubtitle = 0x4D,

        /// <summary>
        /// First press action: Ejects a DVD drive.
        /// <para />
        /// Second press action: Repeats first press action.
        /// <para />
        /// Notably issued by XBOX360 remote as defined in irplus - Remote Control - Android application.
        /// </summary>
        Eject = 0x28,
        DvdTopMenu = 0x43,

        /// <summary>
        /// First press action: Generates EXTn HID message in the Media Center Vendor Specific
        /// Collection (page 0xFFBC, usage 0x88).
        /// <para />
        /// Second press action: Repeats message.
        /// <para />
        /// Auto-repeat: No
        /// <para />
        /// Notably sent by the 'Visualization' button of HP Windows Media Center Remote (TSGH-IR08).
        /// <para />
        /// According to HP specs it displays visual imagery that is synchronized to the sound of your music tracks.
        /// </summary>
        Ext0 = 0x32,

        /// <summary>
        /// First press action: Generates EXTn HID message in the Media Center Vendor Specific
        /// Collection (page 0xFFBC, usage 0x88).
        /// <para />
        /// Second press action: Repeats message.
        /// <para />
        /// Auto-repeat: No
        /// <para />
        /// Notably sent by the 'Slide Show' button of HP Windows Media Center Remote (TSGH-IR08).
        /// <para />
        /// According to HP specs it plays a slide show of all the pictures on your hard disk drive.
        /// </summary>
        Ext1 = 0x33,

        /// <summary>
        /// First press action: Generates EXTn HID message in the Media Center Vendor Specific
        /// Collection (page 0xFFBC, usage 0x88).
        /// <para />
        /// Second press action: Repeats message.
        /// <para />
        /// Auto-repeat: No
        /// <para />
        /// Notably sent by the 'Eject' button of HP Windows Media Center Remote (TSGH-IR08).
        /// Also interpreted as 'Eject' action by SoundGraph iMON Manager in MCE mode (OrigenAE VF310).
        /// </summary>
        Ext2 = 0x34,

        /// <summary>
        /// First press action: Generates EXTn HID message in the Media Center Vendor Specific
        /// Collection (page 0xFFBC, usage 0x88).
        /// <para />
        /// Second press action: Repeats message.
        /// <para />
        /// Auto-repeat: No
        /// <para />
        /// Notably sent by the 'Input selection' button of HP Windows Media Center Remote (TSGH-IR08).
        /// </summary>
        Ext3 = 0x35,
        Ext4 = 0x36,
        Ext5 = 0x37,
        Ext6 = 0x38,
        Ext7 = 0x39,
        Ext8 = 0x3A,
        Ext9 = 0x80,
        Ext10 = 0x81,
        Ext11 = 0x6F,
        Zoom = 0x27,
        ChannelInput = 0x42,
        SubAudio = 0x2D,
        Channel10 = 0x3E,
        Channel11 = 0x3F,
        Channel12 = 0x40,

        /// <summary>
        /// First press action: Generates OEM2 HID message in the Media Center Vendor Specific
        /// Collection. This button is intended to control the front panel display of home entertainment
        /// computers. When this button is pressed, the display could be turned on or off, or the display
        /// mode could change.
        /// <para />
        /// Second press action: Repeats message.
        /// <para />
        /// Auto-repeat: No
        /// <para />
        /// Notably issued by XBOX360 remote as defined in irplus - Remote Control - Android application.
        /// </summary>
        Display = 0x4F,

        /// <summary>
        /// First press action: To be determined.
        /// <para />
        /// Second press action: Repeats message.
        /// <para />
        /// Auto-repeat: No
        /// </summary>
        Kiosk = 0x6A,
        NetworkSelection = 0x2C,
        BlueRayTool = 0x78,
        ChannelInfo = 0x41,
        VideoSelection = 0x61,

        /// <summary>
        /// Notably featured on the OrigenAE RC147 and other MCE remote with basic IR learning capabilities.
        /// </summary>
        TvPower = 0x65,

        /// <summary>
        /// Notably featured on Microsoft Remote Keyboard for Windows XP Media Center Edition v1.0
        /// </summary>
        Messenger = 0x69
    } 
}