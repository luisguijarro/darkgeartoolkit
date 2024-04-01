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
                dgtk.Platforms.X11.glx.glXSwapIntervalEXT = (dgtk.Platforms.X11.glx.d_glXSwapIntervalEXT)dgtk.OpenGL.InternalTool.GetGLMethodAdress("glXSwapIntervalEXT", typeof(dgtk.Platforms.X11.glx.d_glXSwapIntervalEXT));
                return LinuxSwapControlExt.GLX_EXT_swap_control;
            }
            if (s_ext.Contains("GLX_MESA_swap_control"))
            {
                dgtk.Platforms.X11.glx.glXSwapIntervalMESA = (dgtk.Platforms.X11.glx.d_glXSwapIntervalMESA)dgtk.OpenGL.InternalTool.GetGLMethodAdress("glXSwapIntervalMESA", typeof(dgtk.Platforms.X11.glx.d_glXSwapIntervalMESA));
                return LinuxSwapControlExt.GLX_MESA_swap_control;
            }
            if (s_ext.Contains("GLX_SGI_swap_control"))
            {
                dgtk.Platforms.X11.glx.glXSwapIntervalSGI = (dgtk.Platforms.X11.glx.d_glXSwapIntervalSGI)dgtk.OpenGL.InternalTool.GetGLMethodAdress("glXSwapIntervalSGI", typeof(dgtk.Platforms.X11.glx.d_glXSwapIntervalSGI));
                return LinuxSwapControlExt.GLX_SGI_swap_control;
            }
            return LinuxSwapControlExt.V_SyncNoSupported;
        }
    }
}