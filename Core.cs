using System;
using System.IO;
using System.Collections.Generic;

namespace dgtk
{
    internal static class Core
    {
        internal static List<dgtk_Window> windows;
        internal static void AddWin(dgtk_Window window)
        {
            if (windows == null)
            {
                windows = new List<dgtk_Window>();
                // Iniciar systema de joysticks y gamepads.
                //GameControlsManager.DetectNewDevices();
            }
            windows.Add(window);
        }
        internal static void RemoveWin(dgtk_Window window)
        {
            windows.Remove(window);
            if (windows.Count <= 0) // ¿Por que menor o igual? Paranoia.
            {
                // Eliminar sistema de joysticks y gamepads:
                foreach (dgtk_GameControler gcd in GameControlsManager.devices.Values)
                {
                    gcd.Dispose();
                }
                GameControlsManager.devices.Clear();
            }
        }
    }
}