namespace Djlastnight.Hid
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;
    using Djlastnight.Win32;
    using Djlastnight.Win32.Win32RawInput;

    /// <summary>
    /// The HID handler manages raw input registrations, processes WM_INPUT messages and broadcasts HID events in return.
    /// </summary>
    internal class HidHandler : IDisposable
    {
        private List<HidEvent> hidEvents;
        private Dictionary<ulong, HidEvent> keyDownEvents;
        private RAWINPUTDEVICE[] rawInputDevices;

        /// <summary>
        /// Create an HID handler.
        /// Registers the provided input devices.
        /// </summary>
        /// <param name="rawInputDevices">List of HID devices to receive input from.</param>
        /// <param name="manageRepeats">Specify if we want to our handler to manage event repeats for our application.</param>
        /// <param name="repeatDelayInMs">The initial delay in milliseconds before an event starts repeating.</param>
        /// <param name="repeatSpeedInMs">The delay in milliseconds between an event repeat notification past the first one.</param>
        public HidHandler(RAWINPUTDEVICE[] rawInputDevices, bool manageRepeats = false, int repeatDelayInMs = -1, int repeatSpeedInMs = -1)
        {
            this.Init(manageRepeats, repeatDelayInMs, repeatSpeedInMs);
            this.rawInputDevices = rawInputDevices;
            this.IsRegistered = Win32.Win32RawInput.NativeMethods.RegisterRawInputDevices(this.rawInputDevices, (uint)this.rawInputDevices.Length, (uint)Marshal.SizeOf(this.rawInputDevices[0]));
        }

        /// <summary>
        /// Create an HID handler without registering for WM_INPUT messages.
        /// This is useful in a context where we already registered for WM_INPUT messages through another SharpLib.Hid.Handler instance or otherwise. 
        /// One can then still use this Handler to parse incoming WM_INPUT messages.
        /// </summary>
        /// <param name="manageRepeats">Specify if we want to our handler to manage event repeats for our application.</param>
        /// <param name="repeatDelayInMs">The initial delay in milliseconds before an event starts repeating.</param>
        /// <param name="repeatSpeedInMs">The delay in milliseconds between an event repeat notification past the first one.</param>
        public HidHandler(bool manageRepeats = false, int repeatDelayInMs = -1, int repeatSpeedInMs = -1)
        {
            this.Init(manageRepeats, repeatDelayInMs, repeatSpeedInMs);
        }

        public event HidEventHandler OnHidEvent;

        public bool IsRegistered { get; private set; }

        public bool ManageRepeats { get; private set; }

        public int RepeatDelayInMs { get; private set; }

        public int RepeatSpeedInMs { get; private set; }

        /// <summary>
        /// Provide a collection of keyboard keys currently pushed down.
        /// </summary>
        public Dictionary<ulong, HidEvent> KeyDownEvents
        {
            get { return this.keyDownEvents; }
        }

        /// <summary>
        /// Checks if SHIFT modifier is enabled.
        /// </summary>
        public bool HasModifierShift
        {
            get
            {
                return this.keyDownEvents.Values.Any(hidEvent => hidEvent.IsModifierShift);
            }
        }

        /// <summary>
        /// Checks if CTRL modifier is enabled.
        /// </summary>
        public bool HasModifierControl
        {
            get
            {
                return this.keyDownEvents.Values.Any(hidEvent => hidEvent.IsModifierControl);
            }
        }

        /// <summary>
        /// Checks if ALT modifier is enabled.
        /// </summary>
        public bool HasModifierAlt
        {
            get
            {
                return this.keyDownEvents.Values.Any(hidEvent => hidEvent.IsModifierAlt);
            }
        }

        /// <summary>
        /// Checks if WINDOWS modifier is enabled.
        /// </summary>
        public bool HasModifierWindows
        {
            get
            {
                return this.keyDownEvents.Values.Any(hidEvent => hidEvent.IsModifierWindows);
            }
        }

        /// <summary>
        /// Will de-register devices.
        /// </summary>
        public void Dispose()
        {
            if (!this.IsRegistered)
            {
                return;
            }

            // Setup device removal
            for (int i = 0; i < this.rawInputDevices.Length; i++)
            {
                this.rawInputDevices[i].dwFlags = RawInputDeviceFlags.RIDEV_REMOVE;
                this.rawInputDevices[i].hwndTarget = IntPtr.Zero;
            }

            // De-register
            Win32.Win32RawInput.NativeMethods.RegisterRawInputDevices(this.rawInputDevices, (uint)this.rawInputDevices.Length, (uint)Marshal.SizeOf(this.rawInputDevices[0]));
            this.IsRegistered = false;
        }

        /// <summary>
        /// Process a WM_INPUT message.
        /// </summary>
        /// <param name="message"></param>
        public void ProcessInput(ref Message message)
        {
            if (message.Msg != Contants.WM_INPUT)
            {
                // We only process WM_INPUT messages
                return;
            }

            var hidEvent = new HidEvent(message);
            hidEvent.DebugWrite();

            if (!hidEvent.IsValid)
            {
                Debug.WriteLine("Skipping HID message.");
                return;
            }

            /// We want to repeat only a single event at a time.
            /// Any other event will interrupt the current repeat.
            if (this.ManageRepeats && hidEvent.IsGeneric)
            {
                // Discard all outstanding repeats, though we should only ever have only one
                for (int i = this.hidEvents.Count - 1; i >= 0; i--)
                {
                    this.hidEvents[i].Dispose();
                    this.hidEvents.RemoveAt(i);
                }

                /// Add our newly created event to our repeat list
                /// TODO: instead of a list we could now have a single event since we only support one repeat at a time
                this.hidEvents.Add(hidEvent);
            }
            else if (hidEvent.IsKeyboard)
            {
                hidEvent.HasModifierShift = !hidEvent.IsModifier && this.HasModifierShift;
                hidEvent.HasModifierControl = !hidEvent.IsModifier && this.HasModifierControl;
                hidEvent.HasModifierAlt = !hidEvent.IsModifier && this.HasModifierAlt;
                hidEvent.HasModifierWindows = !hidEvent.IsModifier && this.HasModifierWindows;

                // We are dealing with a keyboard event 
                if (hidEvent.IsButtonDown)
                {
                    HidEvent previous;
                    if (this.keyDownEvents.TryGetValue(hidEvent.KeyId, out previous))
                    {
                        /// This key is already pushed down
                        /// Increment our repeat count
                        hidEvent.RepeatCount = previous.RepeatCount + 1;

                        /// Discard our previous instance
                        previous.Dispose();
                    }

                    // Add or update our key in our dictionary
                    this.keyDownEvents[hidEvent.KeyId] = hidEvent;
                }
                else if (hidEvent.IsButtonUp)
                {
                    HidEvent previous;
                    if (this.keyDownEvents.TryGetValue(hidEvent.KeyId, out previous))
                    {
                        // Key was released just make sure we track that by removing it
                        previous.Dispose();
                        this.keyDownEvents.Remove(hidEvent.KeyId);
                    }
                }
            }

            // Broadcast our events
            // Filter out keyboard repeats unless otherwise specified.
            // Only keyboard repeats coming from drivers come through here.
            if (this.ManageRepeats || !hidEvent.IsRepeat)
            {
                this.OnHidEvent(this, hidEvent);
            }
        }

        public void OnHidEventRepeat(HidEvent hidEvent)
        {
            /// Generic HID repeats generated using timer go through here.  
            /// Broadcast our events
            this.OnHidEvent(this, hidEvent);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="manageRepeats"></param>
        /// <param name="repeatDelayInMs"></param>
        /// <param name="repeatSpeedInMs"></param>
        private void Init(bool manageRepeats, int repeatDelayInMs, int repeatSpeedInMs)
        {
            this.rawInputDevices = new RAWINPUTDEVICE[0];
            this.hidEvents = new List<HidEvent>();
            this.keyDownEvents = new Dictionary<ulong, HidEvent>();
            this.IsRegistered = false;
            this.ManageRepeats = manageRepeats;
            this.RepeatDelayInMs = repeatDelayInMs;
            this.RepeatSpeedInMs = repeatSpeedInMs;
        }
    }
}