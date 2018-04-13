namespace Djlastnight.Input.Internal
{
    using System;
    using System.Management;

    internal class Win32_PnPEntity
    {
        public ushort Availability { get; private set; }

        public string Caption { get; private set; }

        public string ClassGuid { get; private set; }

        public string[] CompatibleID { get; private set; }

        public uint ConfigManagerErrorCode { get; private set; }

        public bool ConfigManagerUserConfig { get; private set; }

        public string CreationClassName { get; private set; }

        public string Description { get; private set; }

        public string DeviceID { get; private set; }

        public bool ErrorCleared { get; private set; }

        public string ErrorDescription { get; private set; }

        public string[] HardwareID { get; private set; }

        public DateTime InstallDate { get; private set; }

        public uint LastErrorCode { get; private set; }

        public string Manufacturer { get; private set; }

        public string Name { get; private set; }

        public string PNPClass { get; private set; }

        public string PNPDeviceID { get; private set; }

        public ushort[] PowerManagementCapabilities { get; private set; }

        public bool PowerManagementSupported { get; private set; }

        public bool Present { get; private set; }

        public string Service { get; private set; }

        public string Status { get; private set; }

        public ushort StatusInfo { get; private set; }

        public string SystemCreationClassName { get; private set; }

        public string SystemName { get; private set; }

        public void SetValue(string propertyName, object value)
        {
            switch (propertyName)
            {
                case "Availability":
                    this.Availability = (ushort)value;
                    break;
                case "Caption":
                    this.Caption = (string)value;
                    break;
                case "ClassGuid":
                    this.ClassGuid = (string)value;
                    break;
                case "CompatibleID":
                    this.CompatibleID = (string[])value;
                    break;
                case "ConfigManagerErrorCode":
                    this.ConfigManagerErrorCode = (uint)value;
                    break;
                case "ConfigManagerUserConfig":
                    this.ConfigManagerUserConfig = (bool)value;
                    break;
                case "CreationClassName":
                    this.CreationClassName = (string)value;
                    break;
                case "Description":
                    this.Description = (string)value;
                    break;
                case "DeviceID":
                    this.DeviceID = (string)value;
                    break;
                case "ErrorCleared":
                    this.ErrorCleared = (bool)value;
                    break;
                case "ErrorDescription":
                    this.ErrorDescription = (string)value;
                    break;
                case "HardwareID":
                    this.HardwareID = (string[])value;
                    break;
                case "InstallDate":
                    this.InstallDate = (DateTime)value;
                    break;
                case "LastErrorCode":
                    this.LastErrorCode = (uint)value;
                    break;
                case "Manufacturer":
                    this.Manufacturer = (string)value;
                    break;
                case "Name":
                    this.Name = (string)value;
                    break;
                case "PNPClass":
                    this.PNPClass = (string)value;
                    break;
                case "PNPDeviceID":
                    this.PNPDeviceID = (string)value;
                    break;
                case "PowerManagementCapabilities":
                    this.PowerManagementCapabilities = (ushort[])value;
                    break;
                case "PowerManagementSupported":
                    this.PowerManagementSupported = (bool)value;
                    break;
                case "Present":
                    this.Present = (bool)value;
                    break;
                case "Service":
                    this.Service = (string)value;
                    break;
                case "Status":
                    this.Status = (string)value;
                    break;
                case "StatusInfo":
                    this.StatusInfo = (ushort)value;
                    break;
                case "SystemCreationClassName":
                    this.SystemCreationClassName = (string)value;
                    break;
                case "SystemName":
                    this.SystemName = (string)value;
                    break;
                default:
                    throw new NotImplementedException(string.Format("Non existring property: '{0}'", propertyName));
            }
        }
    }
}