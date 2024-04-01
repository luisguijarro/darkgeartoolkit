using System;

using dgtk.Platforms;
using dgtk.Platforms.Win32;
using dgtk.Platforms.X11;

namespace dgtk.OpenGL
{
    public class OGL_Context : IDisposable
    {
        internal IntPtr ptr_GLContext;
        internal IntPtr ptr_xglwin;
        private IntPtr ptr_Display_Device; //Linux X11 Display or Win32 Device
        private dgtk.Platforms.Platform os;
        internal bool IsEGLContext;
        private bool isGLES;

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
            this.IsEGLContext = false;
        }

        //X11 OpenGLContext
        public OGL_Context(IntPtr Display, IntPtr xglwin_eglSurface, IntPtr GLContextPointer, bool IsEGL, bool isOGLES)
        {
            os = dgtk.Platforms.Platform.Linux_X11;

            this.ptr_Display_Device = Display;
            this.ptr_xglwin = xglwin_eglSurface;
            this.ptr_GLContext = GLContextPointer;

            dgtk.OpenGL.OGL_SharedContext.LinkContext(this.ptr_GLContext); // Solo se usa para el conteo.
            this.IsEGLContext = IsEGL;
            this.isGLES = isOGLES;
        }

        public void Dispose()
		{
            dgtk.OpenGL.OGL_SharedContext.DeslinkCntx();
            switch(this.os)
            {
                case dgtk.Platforms.Platform.Linux_X11:
                    if (this.IsEGLContext)
                    {
                        Platforms.EGL.Imports.eglDestroyContext(this.ptr_Display_Device, this.ptr_GLContext);
                    }
                    else
                    {
                        glx.glXDestroyContext(this.ptr_Display_Device, this.ptr_GLContext);
                    }
                    break;
                case dgtk.Platforms.Platform.Windows:
                    wgl.wglDeleteContext(this.ptr_GLContext);
                    break;
            }
        }

        //Internal Methods:
        internal bool X11MakeCurrent()
        {
            if (this.IsEGLContext)
            {
                if (dgtk.Platforms.EGL.Imports.eglMakeCurrent(this.ptr_Display_Device, this.ptr_xglwin, this.ptr_xglwin, this.ptr_GLContext))
                {
                    dgtk.Core.int_ActualOpenGLContext = this;
                    return true;
                }
            }
            else
            {
                if (glx.glXMakeContextCurrent(this.ptr_Display_Device, this.ptr_xglwin, this.ptr_xglwin, this.ptr_GLContext))
                {
                    dgtk.Core.int_ActualOpenGLContext = this;
                    return true;
                }
            }
            return false;
            //return glx.glXMakeContextCurrent(this.ptr_Display_Device, this.ptr_xglwin, this.ptr_xglwin, this.ptr_GLContext);
        }

        internal bool Win32MakeCurrent()
        {
            if (wgl.wglMakeCurrent(this.ptr_Display_Device, this.ptr_GLContext))
            {
                dgtk.Core.int_ActualOpenGLContext = this;
                return true;
            }
            return false;
            //return wgl.wglMakeCurrent(this.ptr_Display_Device, this.ptr_GLContext);
        }

        internal bool X11UnMakeCurrent()
        {
            if (this.IsEGLContext)
            {
                return dgtk.Platforms.EGL.Imports.eglMakeCurrent(this.ptr_Display_Device, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero);
            }
            else
            {
                return glx.glXMakeContextCurrent(this.ptr_Display_Device, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero);
            }
        }

        internal bool Win32UnMakeCurrent()
        {
            //return wgl.wglMakeCurrent(this.ptr_Display_Device, IntPtr.Zero);
            return wgl.wglMakeCurrent(IntPtr.Zero, IntPtr.Zero);
        }

        internal void X11SwapBuffers()
		{
            if (this.IsEGLContext)
            {
                if (!dgtk.Platforms.EGL.Imports.eglSwapBuffers(this.ptr_Display_Device, this.ptr_xglwin))
                {
                    #if DEBUG
                        Console.WriteLine("eglSwapBuffers FAILS!");
                    #endif
                }
            }
            else
            {
                glx.glXSwapBuffers(this.ptr_Display_Device, this.ptr_xglwin);
            }
        }

        internal bool Win32SwapBuffers()
		{
            return dgtk.Platforms.Win32.Imports.SwapBuffers(this.ptr_Display_Device);
        }

        public bool MakeCurrent()
        {
            switch(this.os)
            {
                case dgtk.Platforms.Platform.Linux_X11:
                    return this.X11MakeCurrent();
                
                case dgtk.Platforms.Platform.Windows:
                    return this.Win32MakeCurrent();
            }
            return false;
        }

        public bool UnMakeCurrent()
        {
            switch(this.os)
            {
                case dgtk.Platforms.Platform.Linux_X11:
                    return this.X11UnMakeCurrent();
                
                case dgtk.Platforms.Platform.Windows:
                    return this.Win32UnMakeCurrent();
            }
            return false;
        }
    
        public bool IsGLES
        {
            get { return this.isGLES; }
        }
    }
}
