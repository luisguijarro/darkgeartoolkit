using System;
using System.Runtime.InteropServices;

namespace dgtk.Platforms.Win32
{
    internal static unsafe class VSync
    {
        internal static bool SupportedVSync()
        {
            bool ret = false;
            string s_ext = new string((sbyte*)dgtk.OpenGL.GL.glGetString(dgtk.OpenGL.StringName.GL_EXTENSIONS));
            ret = s_ext.Contains("WGL_EXT_swap_control");
            if (ret)
            {
                wgl.wglSwapIntervalEXT = (wgl.d_wglSwapIntervalEXT) dgtk.OpenGL.InternalTool.GetGLMethodAdress("wglSwapIntervalEXT",typeof(wgl.d_wglSwapIntervalEXT));                
            }
            return ret;
        }
    }
}