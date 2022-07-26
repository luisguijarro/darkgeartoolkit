// OpenGL|ES Internal Tool.
// File Created with OpenGL Parser 3.
// Developed by Luis Guijarro Pérez.

using System;
using System.Runtime.InteropServices;

namespace dgtk.OpenGL
{
	internal static class InternalGLesTool
	{
		// internal static IntPtr lib; // Solo pa Windows no es útil.
		internal static Delegate GetGLesMethodAdress(String MethodName, Type type_origen)
		{
			IntPtr p_ret = IntPtr.Zero;
			p_ret = eglGetProcAddress(MethodName);
			if (p_ret != IntPtr.Zero)
			{
				try
				{
					return Marshal.GetDelegateForFunctionPointer(p_ret, type_origen);
				}
				catch
				{
					#if DEBUG
					Console.WriteLine(type_origen.ToString());
					#endif
					return null;
				}
			}
			else
			{
				return null;
			}
		}

		[DllImport("libEGL.so.1", EntryPoint = "eglGetProcAddress")]
		internal extern static IntPtr eglGetProcAddress(String MethodName);

		[DllImport("libX11.so.6", EntryPoint = "XOpenDisplay")]
		internal extern static IntPtr XOpenDisplay(IntPtr display);

		[DllImport("libX11.so.6", EntryPoint = "XCloseDisplay")]
		internal extern static void XCloseDisplay(IntPtr display);

	}
}

