using System;
using System.Security;
using System.Runtime.InteropServices;

namespace dgtk.Platforms.Win32
{
    internal static class Imports
    {
        [System.Security.SuppressUnmanagedCodeSecurity]
        [DllImport("User32.dll", SetLastError = true)]
        internal static extern System.Int32 GetMessage(ref MSG msg, IntPtr windowHandle, int messageFilterMin, int messageFilterMax);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("User32.dll", SetLastError = true)]
        internal static extern Boolean TranslateMessage(ref MSG lpMsg);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("User32.dll", SetLastError = true)]
        internal static extern IntPtr DispatchMessage(ref MSG msg);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        internal static extern ushort RegisterClassEx(ref WndClassEx window_class_Ex);

        [DllImport("User32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		internal static extern IntPtr DefWindowProcW(IntPtr hWnd, WindowMessage msg, IntPtr wParam, IntPtr lParam);

		[DllImport("user32.dll", SetLastError = true)]
		internal static extern bool GetClientRect(IntPtr Ventana, out Win32Rect lpRect);

		[DllImport("user32.dll", CharSet=CharSet.Auto, SetLastError = true)]
		internal static extern bool SetWindowPos(IntPtr ventana, IntPtr InsertAfter, int X, int Y, int Ancho, int Alto, uint FlagsAttribute);
		
		[DllImport("user32.dll", CharSet=CharSet.Auto, SetLastError = true)]
		internal static extern bool GetCursorPos(out Point punto);

		[DllImport("user32.dll", CharSet=CharSet.Auto, SetLastError = true)]
		internal static extern bool TrackMouseEvent(ref TRACKMOUSEEVENT tme_struct);

        [DllImport("user32.dll", EntryPoint = "AdjustWindowRectEx", CallingConvention = CallingConvention.StdCall, SetLastError = true), SuppressUnmanagedCodeSecurity]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool AdjustWindowRectEx(
            ref Win32Rect lpRect,
            WindowStyle dwStyle,
            [MarshalAs(UnmanagedType.Bool)] bool bMenu,
            ExWindowStyle dwExStyle);

        [DllImport("user32.dll")]
		internal static extern IntPtr LoadCursor(IntPtr hInstance, IntPtr lpCursorName);
		internal static IntPtr LoadCursor(CursorName CursorName)
        {
            return LoadCursor(IntPtr.Zero, new IntPtr((int)CursorName));
        }

		[DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        internal static extern IntPtr CreateWindowEx(
			ExWindowStyle ExStyle,
            IntPtr ClassName,
            IntPtr WindowName,
            WindowStyle Style,
            int X, int Y,
            int Width, int Height,
            IntPtr HandleToParentWindow,
            IntPtr Menu,
            IntPtr Instance,
            IntPtr Param);

		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool SetForegroundWindow(IntPtr hWnd);

		[DllImport("user32.dll", SetLastError = true)]
		internal static extern IntPtr SetFocus(IntPtr hWnd);

        [DllImport("user32.dll", SetLastError = true), SuppressUnmanagedCodeSecurity]
        internal static extern Boolean ShowWindow(IntPtr hWnd, showCmd nCmdShow);

		[DllImport("user32.dll", SetLastError = true)]
		internal static extern bool UpdateWindow(IntPtr hWnd);

		[DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool DestroyWindow(IntPtr windowHandle);

		[System.Security.SuppressUnmanagedCodeSecurity]
    	[DllImport("kernel32.dll", SetLastError=true)]
    	internal static extern IntPtr GetProcAddress(IntPtr library, string Name);

		[DllImport("kernel32.dll", SetLastError = true)]
        internal static extern IntPtr LoadLibrary(string dllName);

		[DllImport("gdi32.dll", SetLastError = true)]
		internal static extern bool SwapBuffers(IntPtr hdc);

		[DllImport("user32.dll", SetLastError=true)]
		internal static extern IntPtr GetDC(IntPtr hWnd);	
		
		[DllImport("gdi32.dll", EntryPoint = "ChoosePixelFormat", SetLastError = true)]
		internal static extern int ChoosePixelFormat(IntPtr hdc, [In] ref PIXELFORMATDESCRIPTOR ppfd);
		
		[DllImport("gdi32.dll", EntryPoint = "SetPixelFormat", SetLastError = true)]
		internal static extern bool SetPixelFormat(IntPtr hdc, int iPixelFormat, ref PIXELFORMATDESCRIPTOR ppfd);
		
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern bool SetWindowText(IntPtr hwnd, String lpString);
    }
}
