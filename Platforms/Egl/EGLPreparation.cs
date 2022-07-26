using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace dgtk.Platforms.EGL
{
    internal static class EGLPreparation
    {
        public static bool PreparationEGLContext(/*IntPtr ptr_Display, */IntPtr eglDisplay,/*IntPtr SurfaceHandle, int ColorBits, int DepthBits, */out IntPtr windowConfig)
        {
            windowConfig = IntPtr.Zero;
            
            if (!EGL.Imports.eglBindAPI(EGL.EGL_API.EGL_OPENGL_ES_API))
            {
                //#if DEBUG
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No Shared EGL Context: OPENGL|ES API IS NOT SUPPORTED");
                    Console.ResetColor();
                //#endif
                return false;
            }

            int[] configAttributes = new int[]
            {
                (int)EGL_ENUM.EGL_COLOR_BUFFER_TYPE, (int)EGL_ENUM.EGL_RGB_BUFFER,
                (int)EGL_ENUM.EGL_RENDERABLE_TYPE, (int)EGL_ENUM.EGL_OPENGL_ES2_BIT,
                (int)EGL_ENUM.EGL_SURFACE_TYPE, (int)EGL_ENUM.EGL_WINDOW_BIT,
                (int)EGL_ENUM.EGL_DEPTH_SIZE, 24,
                (int)EGL_ENUM.EGL_RED_SIZE, 8,
                (int)EGL_ENUM.EGL_GREEN_SIZE, 8,
                (int)EGL_ENUM.EGL_BLUE_SIZE, 8,
                (int)EGL_ENUM.EGL_ALPHA_SIZE, 8,
                (int)EGL_ENUM.EGL_STENCIL_SIZE, 8,
                (int)EGL_ENUM.EGL_NONE
            };

            int numConfigs;
            
            if (!Imports.eglChooseConfig(eglDisplay, configAttributes, out windowConfig, 1, out numConfigs))
            {
                //#if DEBUG
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No Shared EGL Context: eglChooseConfig FAIL!!!");
                    Console.ResetColor();
                //#endif
                return false;
            }
            else
            {
                //#if DEBUG
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("No Shared EGL Context WindowConfig: "+windowConfig.ToInt64());
                    Console.ResetColor();
                //#endif
            }

            return true;
        }

		public static IntPtr GetEGLSurface(IntPtr eglDisplay, IntPtr windowConfig, IntPtr WinHandle)
		{
            int[] eglSurfaceAttributes = new int[] {(int)EGL_ENUM.EGL_NONE};
            IntPtr ret = Imports.eglCreateWindowSurface(eglDisplay, windowConfig, WinHandle, eglSurfaceAttributes);
            #if DEBUG
                if (ret == IntPtr.Zero)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No Shared EGL Context: eglCreateWindowSurface FAIL!!!");
                    Console.ResetColor();
                }
            #endif
            return ret;
        }

        public static unsafe OpenGL.OGL_Context GenerateEGLContext(IntPtr eglDisplay, IntPtr eglSurface, IntPtr windowConfig, IntPtr SharedContext, bool IsGLES)
        {
            
            OpenGL.OGL_Context ret;
            IntPtr eglContext;
            if (dgtk.Platforms.EGL.Imports.eglBindAPI(EGL_API.EGL_OPENGL_API) && !IsGLES) // si no soporta OpenGL será OpenGL|ES o nada.
            {
                eglContext = Imports.eglCreateContext(eglDisplay, windowConfig, SharedContext, null);
                IsGLES = false;
                //Console Output:
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Is OpenGL Conext");
                Console.ResetColor();
            }
            else
            {
                int[] eglContextAttributes = new int[] { (int)EGL_ENUM.EGL_CONTEXT_CLIENT_VERSION, 2, (int)EGL_ENUM.EGL_NONE, (int)EGL_ENUM.EGL_NONE};
                eglContext = Imports.eglCreateContext(eglDisplay, windowConfig, SharedContext, eglContextAttributes);

                //Console Output:
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Is OpenGL");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("|ES");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" Conext");
                Console.ResetColor();
            }
            
            
            #if DEBUG
                if (eglContext == IntPtr.Zero)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No Shared EGL Context eglCreateContext: FAIL!");
                    Console.WriteLine("EGL ERROR: " + ((EGL_ENUM)Imports.eglGetError()).ToString());
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("No Shared EGL Context CREATED!");
                    Console.WriteLine("EGL LOG: " + ((EGL_ENUM)Imports.eglGetError()).ToString());
                    Console.ResetColor();
                }
            #endif

            ret = new OpenGL.OGL_Context(eglDisplay, eglSurface, eglContext, true, IsGLES);
			bool isCurrent = ret.X11MakeCurrent();
            if (IsGLES)
            {
			    dgtk.OpenGL.DelegastesInitGLes.InitDelegatesGLes();
            }
            else
            {
                dgtk.OpenGL.DelegastesInitGL.InitDelegates();
                dgtk.OpenGL.DelegastesInitGL.isLinux = true;
                dgtk.OpenGL.DelegastesInitGL.InitDelegatesExts();
            }
			ret.X11UnMakeCurrent();
			return ret;
        }
    }
}