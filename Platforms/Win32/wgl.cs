using System;
using System.Security;
using System.Runtime.InteropServices;

namespace dgtk.Platforms.Win32
{
    internal static class wgl
    {
        [DllImport("opengl32.dll", EntryPoint = "wglCreateContext", SetLastError=true)]
		internal static extern IntPtr wglCreateContext(IntPtr ptr);

		[DllImport("opengl32.dll", EntryPoint = "wglDeleteContext", SetLastError=true)]
		internal static extern bool wglDeleteContext(IntPtr ptr);

		[DllImport("opengl32.dll", EntryPoint = "wglMakeCurrent", SetLastError=true)]
		internal static extern bool wglMakeCurrent (IntPtr ptr1, IntPtr ptr2);

		[DllImport("opengl32.dll", EntryPoint = "wglSetPixelFormat", SetLastError = true)]
		internal static extern bool wglSetPixelFormat(IntPtr hdc, int iPixelFormat, ref PIXELFORMATDESCRIPTOR ppfd);

		[DllImport("opengl32.dll", EntryPoint = "wglChoosePixelFormat", SetLastError = true)]
		internal static extern int wglChoosePixelFormat(IntPtr hdc, [In] ref PIXELFORMATDESCRIPTOR ppfd);

		[DllImport("opengl32.dll", EntryPoint = "wglShareLists", SetLastError = true)]
		internal static extern bool wglShareLists(IntPtr Context1, IntPtr Context2);

		[DllImport("opengl32.dll", EntryPoint = "wglGetProcAddress", SetLastError = true)]
		internal extern static IntPtr wglGetProcAddress(String lpszProc);
    }
}