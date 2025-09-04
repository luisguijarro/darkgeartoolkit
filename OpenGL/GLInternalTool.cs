// OpenGL Internal Tool.
// File Created with OpenGL Parser 3.
// Developed by Luis Guijarro Pérez.

using System;
using System.Runtime.InteropServices;

namespace dgtk.OpenGL
{
	internal static class InternalTool
	{
		internal static IntPtr lib;
		internal static Delegate GetGLMethodAdress(String MethodName, Type type_origen)
		{
			IntPtr p_ret = IntPtr.Zero;
			if (OS == OperatingSystem.None) {GetOS();}
			switch(OS)
			{
				case OperatingSystem.Windows:
					p_ret = wglGetProcAddress(MethodName);
					if (p_ret == IntPtr.Zero)
					{
						p_ret = GetProcAddress(lib, MethodName);
					}
					break;
				case OperatingSystem.Linux_X11:
					p_ret = glXGetProcAddress(MethodName);
					break;
				default:
					p_ret = IntPtr.Zero;
					break;
			}

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

		[System.Security.SuppressUnmanagedCodeSecurity]
		[DllImport("kernel32.dll", SetLastError=true)] 
		internal static extern IntPtr GetProcAddress(IntPtr library, string Name);

		[DllImport("opengl32.dll", EntryPoint = "wglGetProcAddress", SetLastError = true)]
		internal extern static IntPtr wglGetProcAddress(String lpszProc);

		[DllImport("libGL.so.1", EntryPoint = "glXGetProcAddress")]
		internal extern static IntPtr glXGetProcAddress(String MethodName);

		[DllImport("libX11", EntryPoint = "XOpenDisplay")]
		internal extern static IntPtr XOpenDisplay(IntPtr display);

		[DllImport("libX11", EntryPoint = "XCloseDisplay")]
		internal extern static void XCloseDisplay(IntPtr display);

		[DllImport("kernel32.dll", SetLastError = true)]
		internal static extern IntPtr LoadLibrary(string dllName);

		internal static OperatingSystem OS;
		internal static void GetOS()
		{
			if (!isX11())
			{
				if (!isWindows())
				{
					OS = OperatingSystem.NotSuported;
				}
				else
				{
					lib = LoadLibrary("opengl32.dll");
				}
			}
		}

		internal static bool isX11()
		{
			try
			{
				IntPtr displaytemp;
				if ((displaytemp = XOpenDisplay(IntPtr.Zero)) != IntPtr.Zero)
				{
					XCloseDisplay(displaytemp);
					OS = OperatingSystem.Linux_X11;
					return true;
				}
				return false;
			}
			catch { return false; }
		}

		internal static bool isWindows()
		{
			switch(Environment.OSVersion.Platform)
			{
				case PlatformID.Win32NT:
				case PlatformID.Win32S:
				case PlatformID.Win32Windows:
				case PlatformID.WinCE:
					OS = OperatingSystem.Windows;
					return true;
			}
			return false;
		}

		internal enum OperatingSystem
		{
			None = 0, Windows, Linux_X11, Linux_Wayland, MacOS, NotSuported
		}
	}
}

