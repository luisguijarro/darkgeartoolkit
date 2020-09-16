using System;
using System.Runtime.InteropServices;

namespace dgtk.GameControlSystem.Linux
{
    internal class Imports
    {

        [DllImport("libc", EntryPoint = "open")]
        internal static extern int open (string filename, int flags);  //flag 4

        [DllImport("libc", EntryPoint = "close")]
        internal static extern int close (int filedes);  //flag 4

        [DllImport("libevdev", EntryPoint = "libevdev_new_from_fd")]
        internal static unsafe extern int libevdev_new_from_fd (int fd, IntPtr* dev);  //Obtener Device desde id de Fichero

        [DllImport("libevdev", EntryPoint = "libevdev_get_uniq")]
        internal static extern string libevdev_get_uniq (IntPtr dev); //Obtener identificador único de dispositivo.

        [DllImport("libevdev", EntryPoint = "libevdev_get_name")]
        internal static extern string libevdev_get_name (IntPtr dev);

        [DllImport("libevdev", EntryPoint = "libevdev_has_event_type")]
        internal static extern int libevdev_has_event_type (IntPtr dev, GameControlEventType type); // ¿Tiene el dispositivo este tipo de vento? 	

        [DllImport("libevdev", EntryPoint = "libevdev_has_event_code")]
        internal static extern int libevdev_has_event_code (IntPtr dev, GameControlEventType type, uint code); //¿Tiene le código de evento? 	

        [DllImport("libevdev", EntryPoint = "libevdev_next_event")]
        internal static extern int libevdev_next_event (IntPtr dev, libevdev_read_flag banderas, ref input_event ev);

        [DllImport("libevdev", EntryPoint = "libevdev_has_event_pending")]
        internal static extern int libevdev_has_event_pending (IntPtr dev); // 0 o 1

        [DllImport("libevdev", EntryPoint = "libevdev_get_abs_minimum")]
        internal static extern int libevdev_get_abs_minimum (IntPtr dev, uint code); 	

        [DllImport("libevdev", EntryPoint = "libevdev_get_abs_maximum")]
        internal static extern int libevdev_get_abs_maximum (IntPtr dev, uint code); 	

        [DllImport("libevdev", EntryPoint = "libevdev_free")]
        internal static unsafe extern void libevdev_free (IntPtr dev); // Liberar Device.
    }
}