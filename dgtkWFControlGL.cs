/*
using System;

namespace dgtk
{
    public partial class dgtk_WFControl
    {
        private IntPtr ptr_Display_Device; //Linux X11 Display or Win32 DeviceC
        private void PrepareWin32glContext()
        {
            // SurfaceHandle = this.Handle
            dgtk.Platforms.Win32.OGLPreparation.PreparationOGLContext(this.Handle, 32, 24, out ptr_Display_Device);
            this.context = dgtk.Platforms.Win32.OGLPreparation.GenerateOGLContext(ptr_Display_Device);
        }  
        private void PrepareX11glContext()
        {
            this.ptr_Display_Device = dgtk.Platforms.X11.Imports.XOpenDisplay(null);
            int ScreenId = dgtk.Platforms.X11.Imports.XDefaultScreen(this.ptr_Display_Device);

            dgtk.Platforms.X11.XVisualInfo Visual;
            IntPtr ptr_Visual;

            IntPtr FBConfig = IntPtr.Zero;
			dgtk.Platforms.X11.OGLPreparation.PreparationOGLContext(this.ptr_Display_Device, ScreenId, ref FBConfig, out Visual, out ptr_Visual);

            IntPtr xglwin = dgtk.Platforms.X11.OGLPreparation.Getglxwin(this.ptr_Display_Device, FBConfig, this.Handle);

            this.context = dgtk.Platforms.X11.OGLPreparation.GenerateOGL_Context(this.ptr_Display_Device, xglwin, ref Visual, dgtk.OpenGL.OGL_SharedContext.p_SharedContext, true);

        }
        
        public bool MakeCurrent()
        {
            switch(this.platform)
            {
                case dgtk.Platforms.Platform.Linux_X11:
                    return this.context.X11MakeCurrent();
                case dgtk.Platforms.Platform.Windows:
                    return this.context.Win32MakeCurrent();
            }
            return false;
        }
        public bool UnMakeCurrent()
        {
            switch(this.platform)
            {
                case dgtk.Platforms.Platform.Linux_X11:
                    return this.context.X11UnMakeCurrent();
                case dgtk.Platforms.Platform.Windows:
                    return this.context.Win32UnMakeCurrent();
            }
            return false;
        }

        public void SwapBuffers()
        {
            switch(this.platform)
            {
                case dgtk.Platforms.Platform.Linux_X11:
                    this.context.X11SwapBuffers();
                    break;
                case dgtk.Platforms.Platform.Windows:
                    this.context.Win32SwapBuffers();
                    break;
            }
        }
    }
}
*/