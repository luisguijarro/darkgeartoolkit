using System;
using System.Runtime.InteropServices;
using System.ComponentModel;

using dgtk.Platforms.X11;
using dgtk.Platforms.EGL;

namespace dgtk.OpenGL
{
    public static class OGL_SharedContext
    {
        internal static IntPtr p_SharedContext;
        private static IntPtr DeviceC_SurfaceHandle;
        private static IntPtr eglSurface;
        internal static IntPtr Display;
        internal static IntPtr eglDisplay;
        private static dgtk.Platforms.Platform os;

        internal static int contx; // Contador de contextos ¿Es necesario?

        internal static dgtk.Platforms.Win32.W32Dummy WinDummy;

        internal static bool IsEGLContext;
        internal static bool isGLES;

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

        internal static bool InitSharedEGLContext(bool isGLES)
        {
            os = dgtk.Platforms.Tools.GetPlatform();
            switch (os)
            {
                case dgtk.Platforms.Platform.Windows:
                    //Not Supported Yet.
                    //CreateWin32Context();
                    break;
                case dgtk.Platforms.Platform.Linux_X11:
                    return CreateLinuxEGLContext(isGLES);
                    break;
                case dgtk.Platforms.Platform.Linux_Wayland:
                    break;
            }
            return false;
        }

        private static bool CreateLinuxEGLContext(bool isGLES)
        {
            Display = dgtk.Platforms.X11.Imports.XOpenDisplay(IntPtr.Zero);
            int screen = dgtk.Platforms.X11.Imports.XDefaultScreen(Display);

            DeviceC_SurfaceHandle = dgtk.Platforms.X11.Imports.XRootWindow(Display, screen);
            
            eglDisplay = dgtk.Platforms.EGL.Imports.eglGetDisplay(Display); //IntPtr.Zero);
            
            if (Marshal.ReadInt64(eglDisplay) == (long)EGL_ENUM.EGL_NO_DISPLAY)
            {
                #if DEBUG
                    Console.WriteLine("EGL Shared Context: EGL CANT GET DISPLAY");
                #endif
                IsEGLContext = false;
            }

            int VersionMayor = 0;
            int VersionMinor = 0;

            if (!dgtk.Platforms.EGL.Imports.eglInitialize(eglDisplay, ref VersionMayor, ref VersionMinor)) // ¿Inicializa?
            {
                #if DEBUG
                    Console.WriteLine("EGL Shared Context: FAIL INITIALIZE EGL");
                #endif
                IsEGLContext = false;
            }

            //#if DEBUG
                Console.WriteLine("EGL Shared Context: EGL Version {0},{1} Inicialized", VersionMayor, VersionMinor);
            //#endif

            if (!dgtk.Platforms.EGL.Imports.eglBindAPI(EGL_API.EGL_OPENGL_API) && !isGLES)
            {
                #if DEBUG
                    Console.WriteLine("EGL Shared Context: OPENGL API IS NOT SUPPORTED");
                #endif
            }
            else
            {
                if (!dgtk.Platforms.EGL.Imports.eglBindAPI(EGL_API.EGL_OPENGL_ES_API))
                {
                    #if DEBUG
                        Console.WriteLine("EGL Shared Context: OPENGL|ES API IS NOT SUPPORTED");
                    #endif
                    IsEGLContext = false;
                    isGLES = true;
                }
            }

            

            int[] configAttributes = new int[]
            {
                (int)EGL_ENUM.EGL_COLOR_BUFFER_TYPE, (int)EGL_ENUM.EGL_RGB_BUFFER,
                (int)EGL_ENUM.EGL_RENDERABLE_TYPE, isGLES ? (int)EGL_ENUM.EGL_OPENGL_ES2_BIT : (int)EGL_ENUM.EGL_OPENGL_BIT,
                (int)EGL_ENUM.EGL_SURFACE_TYPE, (int)EGL_ENUM.EGL_WINDOW_BIT,
                (int)EGL_ENUM.EGL_DEPTH_SIZE, 24,
                (int)EGL_ENUM.EGL_RED_SIZE, 8,
                (int)EGL_ENUM.EGL_GREEN_SIZE, 8,
                (int)EGL_ENUM.EGL_BLUE_SIZE, 8,
                (int)EGL_ENUM.EGL_ALPHA_SIZE, 8,
                (int)EGL_ENUM.EGL_NONE
            };
            
            int numConfigs = 0;
            
            IntPtr windowConfig; 
            
            if (!dgtk.Platforms.EGL.Imports.eglChooseConfig(eglDisplay, configAttributes, out windowConfig, 1, out numConfigs))
            {
                //#if DEBUG
                    Console.WriteLine("EGL Shared Context: eglChooseConfig FAIL!!!");
                    EGL_ERRORS error = dgtk.Platforms.EGL.Imports.eglGetError();
                    Console.WriteLine("  - Error: "+error.ToString());
                    Console.WriteLine("Num Configs: "+numConfigs);

                //#endif
                IsEGLContext = false;
            }
            Console.WriteLine("Num Configs: "+numConfigs);
            Console.WriteLine("windowConfig: "+windowConfig);

            int[] eglSurfaceAttributes = new int[] {(int)EGL_ENUM.EGL_NONE};
            eglSurface = dgtk.Platforms.EGL.Imports.eglCreateWindowSurface(eglDisplay, windowConfig, DeviceC_SurfaceHandle, eglSurfaceAttributes);
            
            Console.WriteLine("WriteLine de control.");

            if (dgtk.Platforms.EGL.Imports.eglBindAPI(EGL_API.EGL_OPENGL_API)) // si no soporta OpenGL será OpenGL|ES o nada.
            {
                p_SharedContext = dgtk.Platforms.EGL.Imports.eglCreateContext(eglDisplay, windowConfig, IntPtr.Zero, null);
            }
            else
            {
                int[] eglContextAttributes = new int[] { (int)EGL_ENUM.EGL_CONTEXT_CLIENT_VERSION, 2, (int)EGL_ENUM.EGL_NONE};
                p_SharedContext = dgtk.Platforms.EGL.Imports.eglCreateContext(eglDisplay, windowConfig, IntPtr.Zero, eglContextAttributes);
            }

            if (p_SharedContext == IntPtr.Zero)
            {
                IsEGLContext = false;
                throw new Exception("CAN NOT BE POSIBLE CREATE EGL SHARED CONTEXT!");                
            }
            else
            {
                #if DEBUG
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("EGL Shared Context CREATED");
                    Console.ResetColor();
                #endif
                IsEGLContext = true;
            }

            //IsEGLContext = true;
            Console.WriteLine("Is EGL Context? "+IsEGLContext);
            return IsEGLContext;
        }

        private static void CreateLinuxContext()
        {
            /*IntPtr display*/Display = dgtk.Platforms.X11.Imports.XOpenDisplay(IntPtr.Zero);
            int screen = dgtk.Platforms.X11.Imports.XDefaultScreen(Display);
            
            DeviceC_SurfaceHandle = dgtk.Platforms.X11.Imports.XRootWindow(Display, screen);
            
            //int[] att = new int[]{ (int)dgtk.Platforms.X11.glxVisualAttributes.GLX_RGBA, (int)dgtk.Platforms.X11.glxVisualAttributes.GLX_DEPTH_SIZE, 1, (int)dgtk.Platforms.X11.glxVisualFBAttributes.GLX_DRAWABLE_TYPE, (int)dgtk.Platforms.X11.glxVisualFBAttributes.GLX_PIXMAP_BIT, (int)dgtk.Platforms.X11.glxVisualAttributes.GLX_DOUBLEBUFFER, 0 };
            
            int[] att = new int[] {
							(int)glxVisualAttributes.GLX_RGBA, 
							(int)glxVisualAttributes.GLX_DOUBLEBUFFER,
							(int)glxVisualAttributes.GLX_RED_SIZE, 1, 
							(int)glxVisualAttributes.GLX_GREEN_SIZE, 1, 
							(int)glxVisualAttributes.GLX_BLUE_SIZE, 1,
							0
						};

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
			pfd.nSize = (ushort)dgtk.Platforms.Win32.PIXELFORMATDESCRIPTOR.SizeInBytes;
			pfd.nVersion = 1;

            pfd.dwFlags = (dgtk.Platforms.Win32.dwFlags.DRAW_TO_BITMAP | dgtk.Platforms.Win32.dwFlags.DRAW_TO_WINDOW | dgtk.Platforms.Win32.dwFlags.DOUBLEBUFFER | dgtk.Platforms.Win32.dwFlags.SUPPORT_OPENGL | dgtk.Platforms.Win32.dwFlags.GENERIC_ACCELERATED);

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
            if (os ==dgtk.Platforms.Platform.Windows) // Solo se usa en Windows por que en linux el enlazado se hace durante la creación de los nuevos contextos.
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
                        if (IsEGLContext)
                        {
                            dgtk.Platforms.EGL.Imports.eglMakeCurrent(Display, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero);
                            dgtk.Platforms.EGL.Imports.eglDestroyContext(Display, p_SharedContext);
                        }
                        else
                        {
                            dgtk.Platforms.X11.glx.glXMakeCurrent(Display, IntPtr.Zero, IntPtr.Zero);
                            dgtk.Platforms.X11.glx.glXDestroyContext(Display, p_SharedContext);
                        }
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
                if (IsEGLContext)
                {
                    mc = dgtk.Platforms.EGL.Imports.eglMakeCurrent(eglDisplay, eglSurface, eglSurface, p_SharedContext);
                }
                else
                {
                    mc = dgtk.Platforms.X11.glx.glXMakeContextCurrent(Display, DeviceC_SurfaceHandle, DeviceC_SurfaceHandle, p_SharedContext);
                }                
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
                if (IsEGLContext)
                {
                    mc = dgtk.Platforms.EGL.Imports.eglMakeCurrent(Display, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero);
                }
                else
                {
                    mc = dgtk.Platforms.X11.glx.glXMakeContextCurrent(Display, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero);
                }
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