using System;
using System.IO;
using System.Collections.Generic;

namespace dgtk
{
    public static class GameControlsManager
    {
        internal static Dictionary<uint, dgtk_GameControler> devices;

        internal static void DetectNewDevices()
        {
            if (devices == null)
            {
                devices = new Dictionary<uint, dgtk_GameControler>();
            }
            switch(dgtk.Platforms.Tools.GetPlatform())
            {
                case dgtk.Platforms.Platform.Linux_X11:
                    dgtk.GameControlSystem.Linux.GMSystem.RefreshDeviceList();
                    return;
                case dgtk.Platforms.Platform.Windows:
                    dgtk.GameControlSystem.Windows.GMSystem.RefreshDeviceList();
                    return;
                default:
                    // No Supported;
                    break;
            }
        }
        public static dgtk_GameControler GetInputDevice(uint key)
        {
            return devices[key];
        }
        public static uint[] DevicesIds
        {
            get
            {
                uint[] ret = new uint[devices.Count];
                devices.Keys.CopyTo(ret, 0);
                return ret;
            }            
        }
        public static int Count
        {
            get { return devices.Count; }
        }
    }
}