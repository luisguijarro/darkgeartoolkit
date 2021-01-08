using System;
using System.Runtime.InteropServices;
using System.ComponentModel;

namespace dgtk.OpenGL
{
    public static class OGL_SharedContext
    {
        internal static IntPtr p_SharedContext;
        private static IntPtr DeviceC_SurfaceHandle;
        private static IntPtr Display;
        private static dgtk.Platforms.Platform os;

        internal static int contx; // Contador de contextos ¿Es necesario?

        internal static dgtk.Platforms.Win32.W32Dummy WinDummy;

        internal static void InitSharedContext()
        {
            os = dgtk.Platforms.Tools.GetPlatform();
            switch (os)
            {
                case dgtk.Platforms.Platform.Windows:
                    CreateWin32Context();
                    break;
                case dgtk.Platforms.Platform.Linux_X11:
                    CreateLinuxContext();
                    break;
                case dgtk.Platforms.Platform.Linux_Wayland:
                    break;
            }
        }

        private static void CreateLinuxContext()
        {
            /*IntPtr display*/Display = dgtk.Platforms.X11.Imports.XOpenDisplay(IntPtr.Zero);
            int screen = dgtk.Platforms.X11.Imports.XDefaultScreen(Display);
            
            DeviceC_SurfaceHandle = dgtk.Platforms.X11.Imports.XRootWindow(Display, screen);
            
            int[] att = new int[]{ (int)dgtk.Platforms.X11.glxVisualAttributes.GLX_RGBA, (int)dgtk.Platforms.X11.glxVisualAttributes.GLX_DEPTH_SIZE, 1, (int)dgtk.Platforms.X11.glxVisualAttributes.GLX_DOUBLEBUFFER, 0 };
            
            dgtk.Platforms.X11.XVisualInfo visual = dgtk.Platforms.X11.glx.glXChooseVisual(Display, screen, att);

            IntPtr shareListConext = new IntPtr(0);
            p_SharedContext = dgtk.Platforms.X11.glx.glXCreateContext(Display, ref visual, shareListConext, true);
            if (p_SharedContext == IntPtr.Zero)
            {
                p_SharedContext = dgtk.Platforms.X11.glx.glXCreateContext(Display, ref visual, shareListConext, false);
                if (p_SharedContext == IntPtr.Zero)
                {
                    throw new Exception("ERROR: Shared Context Creation FAIL!!!");
                }
            }
            if (MakeCurrent())
            {
                // Deshabilitar todo por defecto.
                foreach (dgtk.OpenGL.EnableCap cap in Enum.GetValues(typeof(dgtk.OpenGL.EnableCap)))
                {
                    //dgtk.OpenGL.GL.glDisable(cap);
                }
                foreach (dgtk.OpenGL.EnableCap cap in Enum.GetValues(typeof(dgtk.OpenGL.EnableCap)))
                {
                    //dgtk.OpenGL.GL.glDisableClientState (cap);
                }
            }
            UnMakeCurrent();
        }

        private static void CreateWin32Context()
        {
            WinDummy = new dgtk.Platforms.Win32.W32Dummy();
					
				//	return CreateWin32Context(WinDummy.Handle, 32, 24);//
            dgtk.Platforms.Win32.PIXELFORMATDESCRIPTOR pfd = new dgtk.Platforms.Win32.PIXELFORMATDESCRIPTOR();
			pfd.nSize = dgtk.Platforms.Win32.PIXELFORMATDESCRIPTOR.SizeInBytes;
			pfd.nVersion = 1;

            pfd.dwFlags = (dgtk.Platforms.Win32.dwFlags.DRAW_TO_BITMAP | dgtk.Platforms.Win32.dwFlags.SUPPORT_OPENGL | dgtk.Platforms.Win32.dwFlags.GENERIC_ACCELERATED);

            pfd.iPixelType = dgtk.Platforms.Win32.PixelType.PFD_TYPE_RGBA;
			pfd.cColorBits = (byte)32;
			pfd.cDepthBits = 24;
				
			DeviceC_SurfaceHandle = dgtk.Platforms.Win32.Imports./*GetWindowDC*/GetDC(WinDummy.Handle); //Usado luego para crear OpenGL Context.

            int error;
            if (DeviceC_SurfaceHandle == IntPtr.Zero)
			{
				error = Marshal.GetLastWin32Error();
				throw new Exception("Error Device_Context "+error.ToString()+": " + new Win32Exception(error).Message);
			}
			int pxlfrmt = dgtk.Platforms.Win32.Imports.ChoosePixelFormat(DeviceC_SurfaceHandle, ref pfd);
			if (pxlfrmt < 1)
			{
				error = Marshal.GetLastWin32Error();
				throw new Exception("Error ChoosePixelFormat "+error.ToString()+": " + new Win32Exception(error).Message);
			}					

			if (!dgtk.Platforms.Win32.Imports.SetPixelFormat(DeviceC_SurfaceHandle, pxlfrmt, ref pfd))
			{
				error = Marshal.GetLastWin32Error();
				throw new Exception("Error SetPixelFormat "+error.ToString()+": " + new Win32Exception(error).Message);
			}
			
			/*IntPtr GLDummyContext*/p_SharedContext = dgtk.Platforms.Win32.wgl.wglCreateContext(DeviceC_SurfaceHandle); //¿ESTÁ CASCANDO O NO? En el Statico creo que sí.

			if (/*GLDummyContext*/p_SharedContext == IntPtr.Zero) //NO ES NULL
			{
				error = Marshal.GetLastWin32Error();
				throw new Exception("Error wglCreateContext "+error.ToString()+": " + new Win32Exception(error).Message);
			}

			if(!dgtk.Platforms.Win32.wgl.wglMakeCurrent(DeviceC_SurfaceHandle, /*GLDummyContext*/p_SharedContext))
			{
				error = Marshal.GetLastWin32Error();
				throw new Exception("MakeCurrentFail"+error.ToString()+": " + new Win32Exception(error).Message);				
				//Console.WriteLine("MakeCurrentFail"+this.error.ToString()+": " + new Win32Exception(this.error).Message);
			}

            // FALTA CREAR CONTEXTO DEFINITIVO PARA p_SharedContext


        }

        #region LinkSection
        internal static void LinkContext(IntPtr GLContext) // Debería usarse Siempre
		{
            if (os ==dgtk.Platforms.Platform.Windows)
            {
                bool lc = dgtk.Platforms.Win32.wgl.wglShareLists(p_SharedContext, GLContext);
                if (!lc)
                {
                    int error = Marshal.GetLastWin32Error();
                    throw new Exception(new Win32Exception(error).Message);
                }
            }
			contx++;
		}

		internal static void DeslinkCntx() 
		{
			contx--;
			if (contx <= 0) // Estupidamente paranoico.
			{
                switch(os)
                {
                    case dgtk.Platforms.Platform.Windows:
                        dgtk.Platforms.Win32.wgl.wglDeleteContext(p_SharedContext);
                        if (dgtk.Platforms.Win32.Imports.ReleaseDC(WinDummy.Handle, DeviceC_SurfaceHandle) == 0)
                        {
                            throw new Exception("kk");
                        }
                        WinDummy.Dispose();
                        break;
                    case dgtk.Platforms.Platform.Linux_X11:
                        dgtk.Platforms.X11.glx.glXMakeCurrent(Display, IntPtr.Zero, IntPtr.Zero);
				        dgtk.Platforms.X11.glx.glXDestroyContext(Display, p_SharedContext);
                        break;
                }
			}
		}
        #endregion

		public static bool MakeCurrent()
		{
            bool mc = false;
            if (os == dgtk.Platforms.Platform.Windows)
            {
                mc = dgtk.Platforms.Win32.wgl.wglMakeCurrent(DeviceC_SurfaceHandle, p_SharedContext);
            }
            else
            {
                mc = dgtk.Platforms.X11.glx.glXMakeContextCurrent(Display, DeviceC_SurfaceHandle, DeviceC_SurfaceHandle, p_SharedContext);
            }
            #if DEBUG
			if(!mc)
			{
				Console.WriteLine("ERROR: OpenGL.SharedContext.MakeCurrent() FAIL!");
			}
            #endif
            return mc;
		}

		public static bool UnMakeCurrent()
		{
            bool mc = false;
            if (os == dgtk.Platforms.Platform.Windows)
            {
                mc = dgtk.Platforms.Win32.wgl.wglMakeCurrent(IntPtr.Zero, IntPtr.Zero);
            }
            else
            {
                mc = dgtk.Platforms.X11.glx.glXMakeContextCurrent(Display, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero);
            }
            #if DEBUG
			if(!mc)
			{
				Console.WriteLine("ERROR: OpenGL.SharedContext.UnMakeCurrent() FAIL!");
			}
            #endif
            return mc;
		}

        public static IntPtr Context
        {
            get { return p_SharedContext; }
        }
    }
}