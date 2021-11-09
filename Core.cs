using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;

namespace dgtk
{
    public static class Core
    {
        internal static object lockObject;
        internal static List<dgtk_Window> windows;
        internal static void AddWin(dgtk_Window window)
        {
            if (windows == null)
            {
                windows = new List<dgtk_Window>();
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

        public static System.IO.Stream LoadEmbeddedResource(string resource)
        {
            return Assembly.GetExecutingAssembly().GetManifestResourceStream(resource);
        }

        public static System.IO.Stream LoadEmbeddedResource(string resource, Assembly assembly)
        {
            return assembly.GetManifestResourceStream(resource);
        }

    }
}