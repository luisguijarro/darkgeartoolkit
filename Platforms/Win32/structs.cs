using System;
using System.Security;
using System.Runtime.InteropServices;

namespace dgtk.Platforms.Win32
{

	[StructLayout(LayoutKind.Sequential)]
    internal struct MSG
    {
        internal IntPtr HWnd;
        internal WindowMessage msg;
        internal IntPtr WParam;
        internal IntPtr LParam;
        internal uint Time;
        internal Point Point;
        //internal object RefObject;
        public override string ToString()
        {
            return String.Format("Mensaje=0x{0:x} ({1}) hwnd=0x{2:x} wparam=0x{3:x} lparam=0x{4:x} pt=0x{5:x}", (int)msg, msg.ToString(), HWnd.ToInt32(), WParam.ToInt32(), LParam.ToInt32(), Point);
        }
    }

	[StructLayout(LayoutKind.Sequential)]
    internal struct Point
    {
        public int X;
        public  int Y;
        internal Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public override string ToString()
        {
        	return String.Format("Punto: {0}, {1}", X.ToString(), Y.ToString());
        }
    }

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	internal struct WndClassEx
    {
        public uint Size;
        public WinClassStyle Style;
        //public WNDPROC WndProc;
        [MarshalAs(UnmanagedType.FunctionPtr)]
        public WndProc WndProc;
        public int cbClsExtra;
        public int cbWndExtra;
        public IntPtr Instance;
        public IntPtr Icon;
        public IntPtr Cursor;
        public IntPtr Background;
        public IntPtr MenuName;
        public IntPtr ClassName;
        public IntPtr IconSm;

        public static uint SizeInBytes = (uint)Marshal.SizeOf(default(WndClassEx));
    }

    [StructLayout(LayoutKind.Sequential)]
	internal struct Win32Rect
    {
    	internal System.Int32 left;
        internal System.Int32 top;
        internal System.Int32 right;
        internal System.Int32 bottom;
    }

    [StructLayout(LayoutKind.Sequential)]
	internal struct TRACKMOUSEEVENT 
	{
		public UInt32 cbSize;
		public UInt32 dwFlags;
		public IntPtr hwndTrack;
		public UInt32 dwHoverTime;
	} 
	
    [SuppressUnmanagedCodeSecurity]
	[UnmanagedFunctionPointer(CallingConvention.Winapi)]
	internal delegate IntPtr WndProc(IntPtr handle, WindowMessage message, IntPtr wParam, IntPtr lParam);


	[StructLayout(LayoutKind.Sequential)]
	internal struct PIXELFORMATDESCRIPTOR 
	{ // pfd
	    internal uint   nSize; 			// size of this structure
	    internal int   nVersion; 		// version	
	    internal dwFlags  dwFlags; 		// properties of the pixel buffer
	    internal PixelType  iPixelType; 		// specifies the type of pixel data
	    internal int  cColorBits; 		// color depth of pixels
	    internal int  cRedBits; 		// ...the following bytes we're not
	    internal int  cRedShift; 		// interested in during initialization...
	    internal int  cGreenBits; 
	    internal int  cGreenShift; 
	    internal int  cBlueBits; 
	    internal int  cBlueShift; 
	    internal int  cAlphaBits; 
	    internal int  cAlphaShift; 
	    internal int  cAccumBits; 
	    internal int  cAccumRedBits; 
	    internal int  cAccumGreenBits; 
	    internal int  cAccumBlueBits; 
	    internal int  cAccumAlphaBits; 
	    internal int  cDepthBits; 		// size of depth buffer
	    internal int  cStencilBits; 	// number of bits used for stencil buffer
	    internal int  cAuxBuffers; 
	    internal int  iLayerType; 
	    internal int  bReserved; 
	    internal short dwLayerMask; 
	    internal short dwVisibleMask; 
	    internal short dwDamageMask; 
	    
	    public static uint SizeInBytes = (uint)Marshal.SizeOf(default(PIXELFORMATDESCRIPTOR));
	}
    
}
