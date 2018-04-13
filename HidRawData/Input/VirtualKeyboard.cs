namespace Djlastnight.Input
{
    public class VirtualKeyboard : IIinputDevice
    {
        static VirtualKeyboard()
        {
            object locker = new object();
            lock (locker)
            {
                Instance = new VirtualKeyboard();
            }
        }

        private VirtualKeyboard()
        {
            this.DeviceID = null;
            this.Description = "On-Screen Keyboard";
            this.Vendor = "0000";
            this.Product = "0000";
            this.FriendlyName = this.Description;
        }

        public static VirtualKeyboard Instance { get; private set; }

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
            get { return DeviceType.VirtualKeyboard; }
        }

        public override string ToString()
        {
            return this.FriendlyName;
        }
    }
}