namespace Djlastnight.Input
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Management;
    using Djlastnight.Input.Internal;

    public static class DeviceScanner
    {
        public static List<UsbGamepad> GetUsbGamepads()
        {
            var output = new List<UsbGamepad>();
            using (var searcher = new ManagementObjectSearcher("select * from Win32_PnPEntity where DeviceID like 'USB%'"))
            {
                using (var collection = searcher.Get())
                {
                    foreach (var item in collection)
                    {
                        var entity = item.ToPnpEntity();

                        if (entity.Service == null ||
                            entity.Service != "HidUsb" ||
                            entity.Status != "OK")
                        {
                            continue;
                        }

                        var gamepad = new UsbGamepad(entity.DeviceID, entity.Description);

                        if (gamepad.Product == null ||
                            gamepad.Vendor == null ||
                            string.IsNullOrEmpty(gamepad.FriendlyName))
                        {
                            continue;
                        }

                        if (output.FirstOrDefault(pad => pad.DeviceID == gamepad.DeviceID) != null)
                        {
                            // Gamepad with this DeviceID is already added
                            continue;
                        }

                        item.Dispose();
                        output.Add(gamepad);
                    }
                }
            }

            return output;
        }

        public static List<HidKeyboard> GetHidKeyboards()
        {
            var output = new List<HidKeyboard>();
            using (var searcher = new ManagementObjectSearcher("select * from Win32_PnPEntity where DeviceID like 'HID%'"))
            {
                using (var collection = searcher.Get())
                {
                    foreach (var item in collection)
                    {
                        var entity = item.ToPnpEntity();

                        if (entity.Service == null ||
                            entity.Service != "kbdhid" ||
                            entity.Status != "OK")
                        {
                            continue;
                        }

                        var keyboard = new HidKeyboard(entity.DeviceID, entity.Description);

                        if (keyboard.Product == null ||
                            keyboard.Vendor == null ||
                            string.IsNullOrEmpty(keyboard.FriendlyName))
                        {
                            continue;
                        }

                        if (output.FirstOrDefault(pad => pad.DeviceID == keyboard.DeviceID) != null)
                        {
                            // Keyboard with this DeviceID is already added
                            continue;
                        }

                        item.Dispose();
                        output.Add(keyboard);
                    }
                }
            }

            return output;
        }

        public static List<HidMouse> GetHidMice()
        {
            var output = new List<HidMouse>();
            using (var searcher = new ManagementObjectSearcher("select * from Win32_PnPEntity where DeviceID like 'HID%'"))
            {
                using (var collection = searcher.Get())
                {
                    foreach (var item in collection)
                    {
                        var entity = item.ToPnpEntity();

                        if (entity.Service == null ||
                            entity.Service != "mouhid" ||
                            entity.Status != "OK")
                        {
                            continue;
                        }

                        var mouse = new HidMouse(entity.DeviceID, entity.Description);

                        if (mouse.Product == null ||
                            mouse.Vendor == null ||
                            string.IsNullOrEmpty(mouse.FriendlyName))
                        {
                            continue;
                        }

                        if (output.FirstOrDefault(dev => dev.DeviceID == mouse.DeviceID) != null)
                        {
                            // Mouse with this DeviceID is already added
                            continue;
                        }

                        item.Dispose();
                        output.Add(mouse);
                    }
                }
            }

            return output;
        }

        public static List<HidOtherDevice> GetOtherHidDevices()
        {
            var output = new List<HidOtherDevice>();
            using (var searcher = new ManagementObjectSearcher("select * from Win32_PnPEntity where DeviceID like 'HID%'"))
            {
                using (var collection = searcher.Get())
                {
                    foreach (var item in collection)
                    {
                        var entity = item.ToPnpEntity();

                        if (entity.Status != "OK")
                        {
                            continue;
                        }

                        if (entity.Service == "mouhid")
                        {
                            continue;
                        }

                        if (entity.Service == "kbdhid")
                        {
                            continue;
                        }

                        var otherDevice = new HidOtherDevice(entity.DeviceID, entity.Description, entity.Name);

                        if (output.FirstOrDefault(dev => dev.DeviceID == otherDevice.DeviceID) != null)
                        {
                            // Device with this DeviceID is already added
                            continue;
                        }

                        item.Dispose();
                        output.Add(otherDevice);
                    }
                }
            }

            return output;
        }
    }
}