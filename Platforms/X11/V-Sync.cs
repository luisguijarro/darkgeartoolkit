using System;

namespace dgtk.Platforms.X11
{
    internal static unsafe class VSync
    {
        public static LinuxSwapControlExt SupportedVSync(IntPtr display, int idScreen)
        {
            string s_ext = new string ((sbyte*)glx.glXQueryExtensionsString(display, idScreen));
            if (s_ext.Contains("GLX_EXT_swap_control"))
            {
                return LinuxSwapControlExt.GLX_EXT_swap_control;
            }
            if (s_ext.Contains("GLX_MESA_swap_control"))
            {
                return LinuxSwapControlExt.GLX_MESA_swap_control;
            }
            if (s_ext.Contains("GLX_SGI_swap_control"))
            {
                return LinuxSwapControlExt.GLX_SGI_swap_control;
            }
            return LinuxSwapControlExt.V_SyncNoSupported;
        }
    }
}