namespace Djlastnight.Input.WinMM
{
    internal enum JoyFlags : int
    {
        ReturnX = 0x1,
        ReturnY = 0x2,
        ReturnZ = 0x4,
        ReturnR = 0x08,
        ReturnU = 0x10,
        ReturnV = 0x20,
        ReturnPOV = 0x40,
        ReturnButtons = 0x80,
        ReturnRawData = 0x100,
        ReturnPovCTS = 0x200,
        RetrunrCentered = 0x400,
        UseDeadZone = 0x800,
        ReturnAll = ReturnX | ReturnY | ReturnZ | ReturnR | ReturnU | ReturnV | ReturnPOV | ReturnButtons,
    }
}