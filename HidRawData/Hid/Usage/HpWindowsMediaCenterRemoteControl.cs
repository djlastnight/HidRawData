namespace Djlastnight.Hid.Usage
{
    /// <summary>
    /// Those codes come from experimenting with HP remotes.
    /// </summary>
    public enum HpWindowsMediaCenterRemoteControl : ushort
    {
        /// <summary>
        /// Displays visual imagery that is synchronized to the sound of your music tracks.
        /// <para />
        /// Second press action: Repeats message.
        /// <para />
        /// Auto-repeat: No
        /// <para />
        /// Notably sent by the 'Visualization' button of HP Windows Media Center Remote (TSGH-IR08).
        /// <para />
        /// According to HP specs it displays visual imagery that is synchronized to the sound of your music tracks.
        /// </summary>
        Visualization = WindowsMediaCenterRemoteControl.Ext0,

        /// <summary>
        /// Plays a slide show of all the pictures on your hard disk drive.
        /// <para />
        /// Second press action: Repeats message.
        /// <para />
        /// Auto-repeat: No
        /// <para />
        /// Notably sent by the 'Slide Show' button of HP Windows Media Center Remote (TSGH-IR08).
        /// <para />
        /// According to HP specs it plays a slide show of all the pictures on your hard disk drive.
        /// </summary>
        SlideShow = WindowsMediaCenterRemoteControl.Ext1,

        /// <summary>
        /// Eject optical drive.
        /// <para />
        /// Second press action: Repeats message.
        /// <para />
        /// Auto-repeat: No
        /// <para />
        /// Notably sent by the 'Eject' button of HP Windows Media Center Remote (TSGH-IR08).
        /// Also interpreted as 'Eject' action by SoundGraph iMON Manager in MCE mode (OrigenAE VF310).
        /// </summary>
        HpEject = WindowsMediaCenterRemoteControl.Ext2,

        /// <summary>
        /// Not sure what this should do.
        /// <para />
        /// Second press action: Repeats message.
        /// <para />
        /// Auto-repeat: No
        /// <para />
        /// Notably sent by the 'Input selection' button of HP Windows Media Center Remote (TSGH-IR08).
        /// </summary>
        InputSelection = WindowsMediaCenterRemoteControl.Ext3,
    } 
}