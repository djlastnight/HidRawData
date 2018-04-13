namespace Djlastnight.Hid
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal static class Utils
    {
        /// <summary>
        /// Provide the type for the usage collection corresponding to the given usage page.
        /// </summary>
        /// <param name="usagePage"></param>
        /// <returns></returns>
        public static Type UsageCollectionType(UsagePage usagePage)
        {
            switch (usagePage)
            {
                case UsagePage.GenericDesktopControls:
                    return typeof(UsageCollection.GenericDesktop);

                case UsagePage.Consumer:
                    return typeof(UsageCollection.Consumer);

                case UsagePage.WindowsMediaCenterRemoteControl:
                    return typeof(UsageCollection.WindowsMediaCenter);

                default:
                    return null;
            }
        }

        /// <summary>
        /// Provide the type for the usage corresponding to the given usage page.
        /// </summary>
        /// <param name="usagePage"></param>
        /// <returns></returns>
        public static Type UsageType(UsagePage usagePage)
        {
            switch (usagePage)
            {
                case UsagePage.GenericDesktopControls:
                    return typeof(Usage.GenericDesktop);

                case UsagePage.Consumer:
                    return typeof(Usage.ConsumerControl);

                case UsagePage.WindowsMediaCenterRemoteControl:
                    return typeof(Usage.WindowsMediaCenterRemoteControl);

                case UsagePage.Telephony:
                    return typeof(Usage.TelephonyDevice);

                case UsagePage.SimulationControls:
                    return typeof(Usage.SimulationControl);

                case UsagePage.GameControls:
                    return typeof(Usage.GameControl);

                case UsagePage.GenericDeviceControls:
                    return typeof(Usage.GenericDevice);

                default:
                    return null;
            }
        }
    }
}
