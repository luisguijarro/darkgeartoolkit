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
            //eglDisplay = EGL.Imports.eglGetDisplay(ptr_Display);
            if (Marshal.ReadInt64(eglDisplay) == (long)EGL.EGL_ENUM.EGL_NO_DISPLAY)
            {
                #if DEBUG
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No Shared EGL Context: EGL CANT GET DISPLAY");
                    Console.ResetColor();
                #endif
                return false;
            }
            if (!EGL.Imports.eglBindAPI(EGL.EGL_API.EGL_OPENGL_ES_API))
            {
                #if DEBUG
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No Shared EGL Context: OPENGL|ES API IS NOT SUPPORTED");
                    Console.ResetColor();
                #endif
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
    	        //(int)EGL_ENUM.EGL_LEVEL, (int)EGL_ENUM.EGL_DONT_CARE,
                (int)EGL_ENUM.EGL_SAMPLE_BUFFERS, 1,
                /*(int)EGL_ENUM.EGL_SAMPLES, (int)EGL_ENUM.EGL_DONT_CARE,
                (int)EGL_ENUM.EGL_TRANSPARENT_TYPE, (int)EGL_ENUM.EGL_NONE,
                (int)EGL_ENUM.EGL_TRANSPARENT_RED_VALUE, (int)EGL_ENUM.EGL_DONT_CARE,
                (int)EGL_ENUM.EGL_TRANSPARENT_GREEN_VALUE, (int)EGL_ENUM.EGL_DONT_CARE,
                (int)EGL_ENUM.EGL_TRANSPARENT_BLUE_VALUE, (int)EGL_ENUM.EGL_DONT_CARE,
                (int)EGL_ENUM.EGL_CONFIG_CAVEAT, (int)EGL_ENUM.EGL_DONT_CARE,
                (int)EGL_ENUM.EGL_CONFIG_ID, (int)EGL_ENUM.EGL_DONT_CARE,
                (int)EGL_ENUM.EGL_MAX_SWAP_INTERVAL, (int)EGL_ENUM.EGL_DONT_CARE,
                (int)EGL_ENUM.EGL_MIN_SWAP_INTERVAL, (int)EGL_ENUM.EGL_DONT_CARE,
                (int)EGL_ENUM.EGL_NATIVE_RENDERABLE, (int)EGL_ENUM.EGL_DONT_CARE,
                (int)EGL_ENUM.EGL_NATIVE_VISUAL_TYPE, (int)EGL_ENUM.EGL_DONT_CARE,*/
                (int)EGL_ENUM.EGL_NONE
            };

            int numConfigs;

            if (!Imports.eglGetConfigs(eglDisplay, IntPtr.Zero, 0, out numConfigs))
            {
                #if DEBUG
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No Shared EGL Context: eglGetConfigs FAIL!!!");
                    Console.ResetColor();
                #endif
                return false;
            }

            //IntPtr windowConfig;
            if (!Imports.eglChooseConfig(eglDisplay, configAttributes, ref windowConfig, 1, ref numConfigs))
            {
                #if DEBUG
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No Shared EGL Context: eglChooseConfig FAIL!!!");
                    Console.ResetColor();
                #endif
                return false;
            }
            else
            {
                #if DEBUG
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("No Shared EGL Context WindowConfig: "+windowConfig.ToInt64());
                    Console.ResetColor();
                #endif
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

        public static unsafe OpenGL.OGL_Context GenerateEGLContext(IntPtr eglDisplay, IntPtr eglSurface, IntPtr windowConfig, IntPtr SharedContext)
        {
            OpenGL.OGL_Context ret;
            int[] eglContextAttributes = new int[] { (int)EGL_ENUM.EGL_CONTEXT_CLIENT_VERSION, 2, (int)EGL_ENUM.EGL_NONE, (int)EGL_ENUM.EGL_NONE};
            IntPtr eglContext = Imports.eglCreateContext(eglDisplay, windowConfig, SharedContext, eglContextAttributes);
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

            ret = new OpenGL.OGL_Context(eglDisplay, eglSurface, eglContext, true);
			bool isCurrent = ret.X11MakeCurrent();
			dgtk.OpenGL.DelegastesInitGLes.InitDelegatesGLes();
			ret.X11UnMakeCurrent();
			return ret;
        }
    }
}