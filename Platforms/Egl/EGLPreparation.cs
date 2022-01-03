using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace dgtk.Platforms.EGL
{
    internal static class EGLPreparation
    {
        public static bool PreparationEGLContext(IntPtr SurfaceHandle, int ColorBits, int DepthBits, out IntPtr DeviceC, out IntPtr eglDisplay)
        {
            eglDisplay = EGL.Imports.eglGetDisplay(SurfaceHandle);
            if (Marshal.ReadInt64(eglDisplay) == (long)EGL.EGL_ENUM.EGL_NO_DISPLAY)
            {
                #if DEBUG
                    Console.WriteLine("EGL CANT GET DISPLAY");
                #endif
                DeviceC = IntPtr.Zero;
                return false;
            }

            int VersionMayor = 0;
            int VersionMinor = 0;

            if (!EGL.Imports.eglInitialize(eglDisplay, ref VersionMayor, ref VersionMinor)) // ¿Inicializa?
            {
                #if DEBUG
                    Console.WriteLine("FAIL INITIALIZE EGL");
                #endif
                DeviceC = IntPtr.Zero;
                return false;
            }

            #if DEBUG
                Console.WriteLine("EGL Version {0},{1} Inicialized", VersionMayor, VersionMinor);
            #endif

            if (!EGL.Imports.eglBindAPI(EGL.EGL_API.EGL_OPENGL_API))
            {
                #if DEBUG
                    Console.WriteLine("OPENGL API IS NOT SUPPORTED");
                #endif
                DeviceC = IntPtr.Zero;
                return false;
            }

            int[] configAttributes = new int[]
            {
                (int)EGL_ENUM.EGL_COLOR_BUFFER_TYPE, (int)EGL_ENUM.EGL_RGB_BUFFER,
                (int)EGL_ENUM.EGL_RENDERABLE_TYPE, (int)EGL_ENUM.EGL_OPENGL_BIT,
                (int)EGL_ENUM.EGL_SURFACE_TYPE, (int)EGL_ENUM.EGL_WINDOW_BIT,
                (int)EGL_ENUM.EGL_DEPTH_SIZE, 24,
                (int)EGL_ENUM.EGL_RED_SIZE, 8,
                (int)EGL_ENUM.EGL_GREEN_SIZE, 8,
                (int)EGL_ENUM.EGL_BLUE_SIZE, 8,
                (int)EGL_ENUM.EGL_ALPHA_SIZE, 8,
                (int)EGL_ENUM.EGL_STENCIL_SIZE, 0,
    	        (int)EGL_ENUM.EGL_LEVEL, (int)EGL_ENUM.EGL_DONT_CARE,
                (int)EGL_ENUM.EGL_SAMPLE_BUFFERS, (int)EGL_ENUM.EGL_DONT_CARE,
                (int)EGL_ENUM.EGL_SAMPLES, (int)EGL_ENUM.EGL_DONT_CARE,
                (int)EGL_ENUM.EGL_TRANSPARENT_TYPE, (int)EGL_ENUM.EGL_DONT_CARE,
                (int)EGL_ENUM.EGL_TRANSPARENT_RED_VALUE, (int)EGL_ENUM.EGL_DONT_CARE,
                (int)EGL_ENUM.EGL_TRANSPARENT_GREEN_VALUE, (int)EGL_ENUM.EGL_DONT_CARE,
                (int)EGL_ENUM.EGL_TRANSPARENT_BLUE_VALUE, (int)EGL_ENUM.EGL_DONT_CARE,
                (int)EGL_ENUM.EGL_CONFIG_CAVEAT, (int)EGL_ENUM.EGL_DONT_CARE,
                (int)EGL_ENUM.EGL_CONFIG_ID, (int)EGL_ENUM.EGL_DONT_CARE,
                (int)EGL_ENUM.EGL_MAX_SWAP_INTERVAL, (int)EGL_ENUM.EGL_DONT_CARE,
                (int)EGL_ENUM.EGL_MIN_SWAP_INTERVAL, (int)EGL_ENUM.EGL_DONT_CARE,
                (int)EGL_ENUM.EGL_NATIVE_RENDERABLE, (int)EGL_ENUM.EGL_DONT_CARE,
                (int)EGL_ENUM.EGL_NATIVE_VISUAL_TYPE, (int)EGL_ENUM.EGL_DONT_CARE,
                0
            };

            int numConfigs;
            IntPtr windowConfig;
            if (!Imports.eglChooseConfig(eglDisplay, ref configAttributes, out windowConfig, 1, out numConfigs))
            {
                #if DEBUG
                    Console.WriteLine("eglChooseConfig FAIL!!!");
                #endif
                DeviceC = IntPtr.Zero;
                return false;
            }

            return true;
        }

        public static unsafe OpenGL.OGL_Context GenerateEGLContext(IntPtr DeviceC) //, IntPtr SharedContext)
        {

        }
    }
}