using System;
using System.Security;
using System.Runtime.InteropServices;

namespace dgtk.Platforms.X11
{
    internal static class Glx
    {
        [DllImport("libGL.so.1", EntryPoint = "glXCreateContext")]
		internal extern static IntPtr glXCreateContext(IntPtr display, ref XVisualInfo XVisualInf, IntPtr GLXContextShareList, bool direct);

		[DllImport("libGL.so.1", EntryPoint = "glXCreateContext")]
		internal extern static IntPtr glXCreateContext(IntPtr display, ref IntPtr XVisualInf, IntPtr GLXContextShareList, bool direct);

		[DllImport("libGL.so.1", EntryPoint = "glXCreateNewContext")]
		internal extern static IntPtr glXCreateNewContext(IntPtr Display, IntPtr  FBconfig, int  renderType, IntPtr  GLXContextShareList, bool direct);

		[DllImport("libGL.so.1", EntryPoint = "glXMakeContextCurrent")]
		internal extern static bool glXMakeContextCurrent (IntPtr Display, IntPtr draw, IntPtr read, IntPtr context);

		[DllImport("libGL.so.1", EntryPoint = "glXMakeCurrent")]
		internal extern static bool glXMakeCurrent(IntPtr display, IntPtr Drawable, IntPtr glxContext);

		[DllImport("libGL.so.1", EntryPoint = "glXQueryVersion")]
		internal extern static bool glXQueryVersion(IntPtr display, ref int MayorGL, ref int MenorGL);

		[DllImport("libGL.so.1", EntryPoint = "glXChooseVisual")]
		internal extern static IntPtr glXChooseVisual(IntPtr Display, int screen, IntPtr glxVisualAttribs);

		internal static XVisualInfo glXChooseVisual(IntPtr Display, int screen, int[] glxVisualAttribs)
		{
			unsafe
			{
				fixed(int* attr = glxVisualAttribs)
				{
					IntPtr ret = glXChooseVisual(Display, screen, (IntPtr)attr);
					if(ret == IntPtr.Zero)
					{
						throw new Exception("glXChooseVisual Fail");
					}
					return (XVisualInfo)Marshal.PtrToStructure(ret, typeof(XVisualInfo));
				}
			}
		}

		[DllImport("libGL.so.1", EntryPoint = "glXChooseFBConfig")]
		internal unsafe extern static IntPtr* glXChooseFBConfig(IntPtr dpy, int screen, int[] attriblist, out int fbount);

		[DllImport("libGL.so.1", EntryPoint = "glXGetVisualFromFBConfig")]
		internal unsafe extern static IntPtr glXGetVisualFromFBConfig(IntPtr dpy, IntPtr fbconfig);

		[DllImport("libGL.so.1", EntryPoint = "glXGetFBConfigAttrib")]
		internal unsafe extern static int glXGetFBConfigAttrib(	IntPtr dpy, IntPtr config, int attribute, out int value);

		[DllImport("libGL.so.1", EntryPoint = "glXSwapBuffers")]
		internal extern static void glXSwapBuffers(IntPtr Display, IntPtr ventana);

		[DllImport("libGL.so.1", EntryPoint = "glXDestroyContext")]
		internal extern static void glXDestroyContext(IntPtr Display, IntPtr context);

		[DllImport("libGL.so.1", EntryPoint = "glXCreateWindow")]
		internal extern static IntPtr glXCreateWindow(IntPtr Display,IntPtr fbconfig, IntPtr Ventana, IntPtr AttributeList);

		[DllImport("libGL.so.1", EntryPoint = "glXGetConfig")]
		internal static extern int glXGetConfig(IntPtr dpy, ref XVisualInfo vis, int attrib, out int value);

		[DllImport("libGL.so.1", EntryPoint = "glXGetProcAddress")]
		internal extern static IntPtr glXGetProcAddress(String MethodName);

		[DllImport("libGL.so.1", EntryPoint = "glXQueryExtensionsString")]
		internal extern unsafe static  char* glXQueryExtensionsString(	IntPtr dpy,int screen);
 
		
		internal delegate void d_glXSwapIntervalEXT(IntPtr dpy, IntPtr drawable, int interval);
		internal static d_glXSwapIntervalEXT glXSwapIntervalEXT;
		
		
		internal delegate int d_glXSwapIntervalMESA(uint interval);
		internal static d_glXSwapIntervalMESA glXSwapIntervalMESA;


		internal delegate int d_glXSwapIntervalSGI(int interval);
		internal static d_glXSwapIntervalSGI glXSwapIntervalSGI;
    }

	internal enum glxVisualAttributes : int //<=1.2
	{
		GLX_USE_GL = 1,
		GLX_BUFFER_SIZE = 2,
		GLX_LEVEL = 3,
		GLX_RGBA = 4,
		GLX_DOUBLEBUFFER = 5,
		GLX_STEREO = 6,
		GLX_AUX_BUFFERS = 7,
		GLX_RED_SIZE = 8,
		GLX_GREEN_SIZE = 9,
		GLX_BLUE_SIZE = 10,
		GLX_ALPHA_SIZE = 11,
		GLX_DEPTH_SIZE = 12,
		GLX_STENCIL_SIZE = 13,
		GLX_ACCUM_RED_SIZE = 14,
		GLX_ACCUM_GREEN_SIZE = 15,
		GLX_ACCUM_BLUE_SIZE = 16,
		GLX_ACCUM_ALPHA_SIZE = 17,
		GLX_NONE = 32768
	}

	public enum glxVisualFBAttributes: int //= 1.3
	{
		GLX_CONFIG_CAVEAT =	0x20,
		GLX_SLOW_CONFIG	= 0x8001,
		GLX_NON_CONFORMANT_CONFIG = 0x800D,
		GLX_X_VISUAL_TYPE = 0x22,
		GLX_TRANSPARENT_TYPE = 0x23,
		GLX_TRANSPARENT_INDEX_VALUE = 0x24,
		GLX_TRANSPARENT_RED_VALUE = 0x25,
		GLX_TRANSPARENT_GREEN_VALUE = 0x26,
		GLX_TRANSPARENT_BLUE_VALUE = 0x27,
		GLX_TRANSPARENT_ALPHA_VALUE = 0x28,
		GLX_MAX_PBUFFER_WIDTH = 0x8016,
		GLX_MAX_PBUFFER_HEIGHT = 0x8017,
		GLX_MAX_PBUFFER_PIXELS = 0x8018,
		GLX_PRESERVED_CONTENTS = 0x801B,
		GLX_LARGEST_PBUFFER = 0x801C,
		GLX_WIDTH = 0x801D,
		GLX_HEIGHT = 0x801E,
		GLX_EVENT_MASK = 0x801F,
		GLX_DRAWABLE_TYPE = 0x8010,
		GLX_FBCONFIG_ID = 0x8013,
		GLX_VISUAL_ID = 0x800B,
		GLX_WINDOW_BIT = 0x00000001,
		GLX_PIXMAP_BIT = 0x00000002,
		GLX_PBUFFER_BIT = 0x00000004,
		GLX_AUX_BUFFERS_BIT = 0x00000010,
		GLX_FRONT_LEFT_BUFFER_BIT = 0x00000001,
		GLX_FRONT_RIGHT_BUFFER_BIT = 0x00000002,
		GLX_BACK_LEFT_BUFFER_BIT = 0x00000004,
		GLX_BACK_RIGHT_BUFFER_BIT = 0x00000008,
		GLX_DEPTH_BUFFER_BIT = 0x00000020,
		GLX_STENCIL_BUFFER_BIT = 0x00000040,
		GLX_ACCUM_BUFFER_BIT = 0x00000080,
		GLX_RENDER_TYPE = 0x8011,
		GLX_X_RENDERABLE = 0x8012,
		GLX_DONT_CARE = unchecked((int)0xFFFFFFFF),
		GLX_NONE = 0x8000,
		GLX_TRUE_COLOR = 0x8002,
		GLX_DIRECT_COLOR = 0x8003,
		GLX_PSEUDO_COLOR = 0x8004,
		GLX_STATIC_COLOR = 0x8005,
		GLX_GRAY_SCALE = 0x8006,
		GLX_STATIC_GRAY = 0x8007,
		GLX_TRANSPARENT_RGB = 0x8008,
		GLX_TRANSPARENT_INDEX = 0x8009,
		GLX_RGBA_TYPE = 0x8014,
		GLX_COLOR_INDEX_TYPE = 0x8015,
		GLX_COLOR_INDEX_BIT = 0x00000002,
		GLX_RGBA_BIT = 0x00000001,
		GLX_SCREEN = 0x800C,
		GLX_PBUFFER_CLOBBER_MASK = 0x08000000,
		GLX_DAMAGED = 0x8020,
		GLX_SAVED = 0x8021,
		GLX_WINDOW = 0x8022,
		GLX_PBUFFER = 0x8023,
		GLX_PBUFFER_HEIGHT = 0x8040,
		GLX_PBUFFER_WIDTH = 0x8041,			
			//1.4
		GLX_SAMPLE_BUFFERS = 0x186a0, /*100000*/
		GLX_SAMPLES = 0x186a1, /*100001*/
		GLX_DOUBLEBUFFER = 5
	}
	
}