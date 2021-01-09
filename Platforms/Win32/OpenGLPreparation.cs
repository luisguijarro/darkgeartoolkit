using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace dgtk.Platforms.Win32
{
    internal static class OGLPreparation
    {
        public static void PreparationOGLContext(IntPtr SurfaceHandle, int ColorBits, int DepthBits, out IntPtr DeviceC)
        {
			int error;

            PIXELFORMATDESCRIPTOR pfd = new PIXELFORMATDESCRIPTOR();
			pfd.nSize = PIXELFORMATDESCRIPTOR.SizeInBytes;
			pfd.nVersion = 1;
			pfd.dwFlags = (Win32.dwFlags.DRAW_TO_WINDOW | Win32.dwFlags.SUPPORT_OPENGL| Win32.dwFlags.DOUBLEBUFFER | Win32.dwFlags.SUPPORT_GDI | Win32.dwFlags.GENERIC_ACCELERATED | Win32.dwFlags.SUPPORT_COMPOSITION);
			pfd.iPixelType = Win32.PixelType.PFD_TYPE_RGBA;
			pfd.cColorBits = (byte)ColorBits;
			pfd.cDepthBits = DepthBits;
            pfd.cStencilBits = 8;

            DeviceC = Win32.Imports.GetDC(SurfaceHandle);
			if (DeviceC == IntPtr.Zero)
			{
				error = Marshal.GetLastWin32Error();
				throw new Exception("Error Device_Context "+error.ToString()+": " + new Win32Exception(error).Message);
			}

            int pxlfrmt = Win32.Imports.ChoosePixelFormat(DeviceC, ref pfd);
			if (pxlfrmt < 1)
			{
				error = Marshal.GetLastWin32Error();
				throw new Exception("Error ChoosePixelFormat "+error.ToString()+": " + new Win32Exception(error).Message);
			}					

			if (!Win32.Imports.SetPixelFormat(DeviceC, pxlfrmt, ref pfd))
			{
				error = Marshal.GetLastWin32Error();
				throw new Exception("Error SetPixelFormat "+error.ToString()+": " + new Win32Exception(error).Message);
			}
			
			IntPtr GLDummyContext = wgl.wglCreateContext(DeviceC);

			if (GLDummyContext == IntPtr.Zero)
			{
				error = Marshal.GetLastWin32Error();
				throw new Exception("Error wglCreateContext "+error.ToString()+": " + new Win32Exception(error).Message);
			}

			if(!wgl.wglMakeCurrent(DeviceC, GLDummyContext))
			{
				error = Marshal.GetLastWin32Error();
				throw new Exception("MakeCurrentFail"+error.ToString()+": " + new Win32Exception(error).Message);	
			}

            //DEFINITIVE CONTEXT:
            //=====================
            if (!wgl.wglMakeCurrent(DeviceC, GLDummyContext))
			{
                error = Marshal.GetLastWin32Error();
				throw new Exception("MakeCurrentFail"+error.ToString()+": " + new Win32Exception(error).Message);
			}
			
			int[] attribList = new int[]
			{
			    (int)Win32.ChoosePixelFormarARB.WGL_ACCELERATION_ARB, (int)Win32.ChoosePixelFormatARB_Values.WGL_FULL_ACCELERATION_ARB,
				(int)Win32.ChoosePixelFormarARB.WGL_DRAW_TO_WINDOW_ARB, 1,
			    (int)Win32.ChoosePixelFormarARB.WGL_SUPPORT_OPENGL_ARB, 1,
			    (int)Win32.ChoosePixelFormarARB.WGL_DOUBLE_BUFFER_ARB, 1,
			    (int)Win32.ChoosePixelFormarARB.WGL_PIXEL_TYPE_ARB, (int)Win32.ChoosePixelFormatARB_Values.WGL_TYPE_RGBA_ARB,
			    (int)Win32.ChoosePixelFormarARB.WGL_COLOR_BITS_ARB, ColorBits,
			    (int)Win32.ChoosePixelFormarARB.WGL_DEPTH_BITS_ARB, DepthBits,
			    (int)Win32.ChoosePixelFormarARB.WGL_STENCIL_BITS_ARB, 8,
			    0,        //End
			};

            wglChoosePixelFormatARB = (wglChoosePixelFormatARBdelegate)Marshal.GetDelegateForFunctionPointer(wgl.wglGetProcAddress("wglChoosePixelFormatARB"), typeof(wglChoosePixelFormatARBdelegate));
				
            int pixelFormat;
			uint numFormats;
            if (!wglChoosePixelFormatARB(DeviceC, ref attribList, IntPtr.Zero, 1, out pixelFormat, out numFormats))
            {
				error = Marshal.GetLastWin32Error();
                throw new Exception("wglChoosePixelFormatARB FAIL!!! -> " + new Win32Exception(error).Message);
            }
        }

        public static unsafe OpenGL.OGL_Context GenerateOGLContext(IntPtr DeviceC) //, IntPtr SharedContext)
        {

            OpenGL.OGL_Context ret;
             wglCreateContextAttribsARB = (wglCreateContextAttribsARBdelegate)Marshal.GetDelegateForFunctionPointer(wgl.wglGetProcAddress("wglCreateContextAttribsARB"), typeof(wglCreateContextAttribsARBdelegate));
			
            int[] attribList = new int[]
				{
				//(int)Win32.CreateContextAttributesARB.WGL_CONTEXT_MAJOR_VERSION_ARB, 2,
				//(int)Win32.CreateContextAttributesARB.WGL_CONTEXT_MINOR_VERSION_ARB, 1,
				(int)Win32.CreateContextAttributesARB.WGL_CONTEXT_PROFILE_MASK_ARB, (int)Win32.ContextProfileMaskFlagsARB.WGL_CONTEXT_COMPATIBILITY_PROFILE_BIT_ARB, 
				0
				};

            IntPtr GLContextPointer;
			fixed(int* pattribList =&attribList[0])
			{
				GLContextPointer = wglCreateContextAttribsARB(DeviceC, IntPtr.Zero, pattribList);
			}
            if (GLContextPointer == IntPtr.Zero)
            {
                throw new Exception("wglCreateContextAttribsARB FAIL!!!");
            }
            ret = new OpenGL.OGL_Context(DeviceC, GLContextPointer);
			ret.Win32MakeCurrent();
			dgtk.OpenGL.DelegastesInitGL.InitDelegates();
			dgtk.OpenGL.DelegastesInitGL.InitDelegatesExts();
			ret.Win32UnMakeCurrent();
            return ret;
        }

		[DllImport("opengl32.dll", EntryPoint = "glGetIntegerv", SetLastError = true)]
		private static extern void glGetInteger(uint name, out int major);

        public unsafe delegate bool wglChoosePixelFormatARBdelegate(IntPtr hdc, ref int[] piAttribIList, IntPtr pfAttribFList, UInt32 nMaxFormats, out int piFormats, out UInt32 nNumFormats);
		public static wglChoosePixelFormatARBdelegate wglChoosePixelFormatARB;

        public unsafe delegate IntPtr wglCreateContextAttribsARBdelegate(IntPtr hDC, IntPtr hShareContext, int* attribList);
        public static wglCreateContextAttribsARBdelegate wglCreateContextAttribsARB;
			
    }
}