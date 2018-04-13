namespace Djlastnight.Hid
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows;
    using System.Windows.Interop;
    using Djlastnight.Win32.Win32RawInput;

    /// <summary>
    /// The HidRawData.dll main class. It is intended to read the raw data from all the connected HID devices.
    /// </summary>
    public class HidDataReader : IDisposable
    {
        private readonly Window window;
        private HidHandler handler;

        /// <summary>
        /// Creates new HID data reader.
        /// </summary>
        /// <param name="window">Window instance, which will reveice the WM_INPUT messages</param>
        public HidDataReader(Window window)
        {
            if (window == null)
            {
                throw new ArgumentNullException("window");
            }

            this.window = window;
            this.window.Closed += this.OnWindowClosed;
            var handle = new WindowInteropHelper(this.window).Handle;
            var source = HwndSource.FromHwnd(handle);
            source.AddHook(this.WndProc);

            var devices = RawInputHelper.GetDevices();

            int i = 0;
            RAWINPUTDEVICE[] rids = new RAWINPUTDEVICE[devices.Count];

            // Setting handle to each rid device to receive the WM_INPUT message
            foreach (var device in devices)
            {
                rids[i].usUsagePage = device.UsagePage;
                rids[i].usUsage = device.UsageCollection;
                rids[i].dwFlags = RawInputDeviceFlags.RIDEV_INPUTSINK;
                rids[i].hwndTarget = handle;
                i++;
            }

            this.handler = new HidHandler(rids);
            this.handler.OnHidEvent += this.OnHidEvent;
        }

        /// <summary>
        /// Raised, when data from HID device is received
        /// </summary>
        public event HidEventHandler HidDataReceived;

        public static List<Device> GetDevices()
        {
            var devices = RawInputHelper.GetDevices();
            return devices;
        }

        public void Dispose()
        {
            if (this.handler != null)
            {
                this.handler.OnHidEvent -= this.OnHidEvent;
                this.handler.Dispose();
                this.handler = null;

                if (this.window != null)
                {
                    var windowHandle = new WindowInteropHelper(this.window).Handle;
                    var source = HwndSource.FromHwnd(windowHandle);
                    source.RemoveHook(this.WndProc);
                }
            }
        }

        private IntPtr WndProc(IntPtr hwnd, int msg, IntPtr wordParam, IntPtr longParam, ref bool handled)
        {
            if (this.window == null || msg != Djlastnight.Win32.Contants.WM_INPUT)
            {
                return IntPtr.Zero;
            }

            var message = new System.Windows.Forms.Message();
            message.HWnd = hwnd;
            message.Msg = msg;
            message.WParam = wordParam;
            message.LParam = longParam;
            this.handler.ProcessInput(ref message);

            return IntPtr.Zero;
        }

        private void OnHidEvent(object sender, HidEvent e)
        {
            if (this.HidDataReceived == null ||
                this.window == null ||
                this.window.Dispatcher == null)
            {
                return;
            }

            this.window.Dispatcher.BeginInvoke((Action)delegate
            {
                this.HidDataReceived(sender, e);
            });
        }

        private void OnWindowClosed(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}