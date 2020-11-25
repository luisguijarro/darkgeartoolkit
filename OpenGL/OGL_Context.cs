using System;

using dgtk.Platforms;
using dgtk.Platforms.Win32;
using dgtk.Platforms.X11;

namespace dgtk.OpenGL
{
    internal class OGL_Context : IDisposable
    {
        internal IntPtr ptr_GLContext;
        internal IntPtr ptr_xglwin;
        private IntPtr ptr_Display_Device; //Linux X11 Display or Win32 Device
        private dgtk.Platforms.Platform os;

        //Win32 OpenGLContext
        public OGL_Context(IntPtr CDevice, IntPtr GLContextPointer)
        {
            os = dgtk.Platforms.Platform.Windows;

			if (dgtk.OpenGL.OGL_SharedContext.p_SharedContext == IntPtr.Zero)
			{
				dgtk.OpenGL.OGL_SharedContext.InitSharedContext();
			}

            this.ptr_Display_Device = CDevice;
            this.ptr_GLContext = GLContextPointer;

            dgtk.OpenGL.OGL_SharedContext.LinkContext(this.ptr_GLContext);
        }

        //X11 OpenGLContext
        public OGL_Context(IntPtr Display, IntPtr xglwin, IntPtr GLContextPointer)
        {
            os = dgtk.Platforms.Platform.Linux_X11;

			if (dgtk.OpenGL.OGL_SharedContext.p_SharedContext == IntPtr.Zero)
			{
				dgtk.OpenGL.OGL_SharedContext.InitSharedContext();
			}

            this.ptr_Display_Device = Display;
            this.ptr_xglwin = xglwin;
            this.ptr_GLContext = GLContextPointer;

            dgtk.OpenGL.OGL_SharedContext.LinkContext(this.ptr_GLContext); // Solo se usa para el conteo.
        }

        public void Dispose()
		{
            dgtk.OpenGL.OGL_SharedContext.DeslinkCntx();
            switch(this.os)
            {
                case dgtk.Platforms.Platform.Linux_X11:
                    glx.glXDestroyContext(this.ptr_Display_Device, this.ptr_GLContext);
                    break;
                case dgtk.Platforms.Platform.Windows:
                    wgl.wglDeleteContext(this.ptr_GLContext);
                    break;
            }
        }

        //Internal Methods:
        internal bool X11MakeCurrent()
        {
            return glx.glXMakeContextCurrent(this.ptr_Display_Device, this.ptr_xglwin, this.ptr_xglwin, this.ptr_GLContext);
        }

        internal bool Win32MakeCurrent()
        {
            return wgl.wglMakeCurrent(this.ptr_Display_Device, this.ptr_GLContext);
        }

        internal bool X11UnMakeCurrent()
        {
            return glx.glXMakeContextCurrent(this.ptr_Display_Device, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero);
        }

        internal bool Win32UnMakeCurrent()
        {
            //return wgl.wglMakeCurrent(this.ptr_Display_Device, IntPtr.Zero);
            return wgl.wglMakeCurrent(IntPtr.Zero, IntPtr.Zero);
        }

        internal void X11SwapBuffers()
		{
            glx.glXSwapBuffers(this.ptr_Display_Device, this.ptr_xglwin);
        }

        internal bool Win32SwapBuffers()
		{
            return dgtk.Platforms.Win32.Imports.SwapBuffers(this.ptr_Display_Device);
        }
    }
}
