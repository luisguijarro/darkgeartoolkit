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
    
    [StructLayout(LayoutKind.Sequential)]
    internal struct DevBroadcastDeviceinterface
    {
        internal int Size;
        internal int DeviceType;
        internal int Reserved;
        internal Guid ClassGuid;
        internal short Name;
    }
    
	[StructLayout(LayoutKind.Sequential)]
    internal struct RAWINPUTDEVICE 
    {
        internal ushort usUsagePage;
        internal ushort usUsage;
        internal uint dwFlags;
        internal IntPtr hwndTarget;
    } 
    
	[StructLayout(LayoutKind.Sequential)]
	internal struct RawInput
    {
        internal RawInputHeader Header;
        internal Union Data;       
    }
	
	[StructLayout(LayoutKind.Sequential)]
	internal struct RawInputHeader 
	{
		internal dgtk.GameControlSystem.Windows.RawInputDeviceType  dwType;
		internal int  dwSize;
		internal IntPtr hDevice;
		internal IntPtr wParam;
	}
	
	[StructLayout(LayoutKind.Explicit)]
    internal struct Union
    {
        [FieldOffset(0)]
        internal RawMouse Mouse;
        [FieldOffset(0)]
        internal RawKeyboard Keyboard;
        [FieldOffset(0)]
        internal RawHID HID;
    }	

	[Flags()]
    internal enum RawMouseFlags : ushort
    {
        MoveRelative = 0,
        MoveAbsolute = 1,
        VirtualDesktop = 2,
        AttributesChanged = 4
    }
    
    [StructLayout(LayoutKind.Explicit)]
    internal struct RawMouse
    {
    	[FieldOffset(0)]
        internal RawMouseFlags Flags;
        [FieldOffset(4)]
        internal RawMouseButtons ButtonFlags;
        [FieldOffset(6)]
        internal ushort ButtonData;
        [FieldOffset(8)]
        internal ulong RawButtons;
        [FieldOffset(12)]
        internal long LastX;
        [FieldOffset(16)]
        internal long LastY;
        [FieldOffset(20)]
        internal ulong ExtraInformation;
    }
	
    [StructLayout(LayoutKind.Sequential)]
    internal struct RawKeyboard
    {
        internal short MakeCode;
        internal RawKeyboardFlags Flags;
        internal ushort Reserved;
        internal short VirtualKey;
        internal int Message;
        internal long ExtraInformation;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct RawHID
    {
        internal int Size;
        internal int Count;
        internal byte Data;
        internal byte this[int index]
        {
            get
            {
                if (index < 0 || index > Size * Count)
                    throw new ArgumentOutOfRangeException("index");
                unsafe
                {
                    fixed (byte* data = &Data)
                    {
                        return *(data + index);
                    }
                }
            }
        }
    }
    
}
