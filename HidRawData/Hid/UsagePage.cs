namespace Djlastnight.Hid
{
    /// <summary>
    /// From USB HID usage tables.
    /// http://www.usb.org/developers/hidpage#HID_Usage
    /// http://www.usb.org/developers/hidpage/Hut1_12v2.pdf
    /// </summary>
    public enum UsagePage : ushort
    {
        Undefined = 0,
        GenericDesktopControls,
        SimulationControls,
        VirtualRealityControls,
        SportControls,
        GameControls,
        GenericDeviceControls,
        Keyboard,
        LightEmittingDiode,
        Button,
        Ordinal,
        Telephony,
        Consumer,
        Digitiser,
        PhysicalInterfaceDevice = 0x0f,
        Unicode = 0x10,
        AlphaNumericDisplay = 0x14,
        MedicalInstruments = 0x40,
        MonitorPage0 = 0x80,
        MonitorPage1,
        MonitorPage2,
        MonitorPage3,
        PowerPage0,
        PowerPage1,
        PowerPage2,
        PowerPage3,
        BarCodeScanner = 0x8c,
        Scale,
        MagneticStripeReader,
        ReservedPointOfSale,
        CameraControl,
        Arcade,

        // http://msdn.microsoft.com/en-us/library/windows/desktop/bb417079.aspx
        WindowsMediaCenterRemoteControl = 0xffbc,
        TerraTecRemote = 0xffcc
    }
}