namespace Djlastnight.Input
{
    using System;

    public class HidKeyboard : IIinputDevice
    {
        internal HidKeyboard(string deviceId, string description)
        {
            if (deviceId == null)
            {
                throw new ArgumentNullException("deviceId");
            }

            if (description == null)
            {
                throw new ArgumentNullException("description");
            }

            this.DeviceID = deviceId;
            this.Description = description;

            int vidIndex = this.DeviceID.IndexOf("VID_");
            if (vidIndex == -1)
            {
                this.Vendor = null;
            }
            else
            {
                string startingAtVid = this.DeviceID.Substring(vidIndex + 4);
                this.Vendor = startingAtVid.Substring(0, 4);
            }

            int pidIndex = this.DeviceID.IndexOf("PID_");
            if (pidIndex == -1)
            {
                this.Product = null;
            }
            else
            {
                string startingAtPid = this.DeviceID.Substring(pidIndex + 4);
                this.Product = startingAtPid.Substring(0, 4);
            }

            this.FriendlyName = description;
        }

        public string DeviceID
        {
            get;
            private set;
        }

        public string Description
        {
            get;
            private set;
        }

        public string Vendor
        {
            get;
            private set;
        }

        public string Product
        {
            get;
            private set;
        }

        public string FriendlyName
        {
            get;
            private set;
        }

        public DeviceType DeviceType
        {
            get { return DeviceType.Keyboard; }
        }

        public override string ToString()
        {
            return string.Format(
                "HID Keyboard:{0}Friendly name: {1}{0}DeviceID: {2}{0}VID: {3}{0}PID: {4}{0}Description: {5}",
                Environment.NewLine,
                this.FriendlyName,
                this.DeviceID,
                this.Vendor,
                this.Product,
                this.Description);
        }
    }
}
