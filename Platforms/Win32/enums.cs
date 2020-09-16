using System;

namespace dgtk.Platforms.Win32
{

	[Flags]
    internal enum WindowStyle : uint
    {
        Border = 0x00800000,
        Caption = 0x00C00000,
        Child = 0x40000000,
        ClipChildren = 0x02000000,
        ClipSiblings = 0x04000000,
        Disabled = 0x08000000,
        DialogFrame = 0x00400000,
        Group = 0x00020000,
        HScroll = 0x00100000,
        Maximize = 0x01000000,
        MaximizeBox = 0x00010000,
        Minimize = 0x20000000,
        MinimizeBox = 0x00020000,
        Overlapped = 0x00000000,
        Popup = 0x80000000,
        SystemMenu = 0x00080000,
        TabStop = 0x00010000,
        ThickFrame = 0x00040000,
        Visible = 0x10000000,
        VScroll = 0x00200000
    }
	
	[Flags]
    internal enum ExWindowStyle : uint
    {
    	WS_EX_ACCEPTFILES = 0x00000010,
    	WS_EX_APPWINDOW = 0x00040000,
    	WS_EX_CLIENTEDGE = 0x00000200,
    	WS_EX_COMPOSITED = 0x02000000,
    	WS_EX_CONTEXTHELP = 0x00000400,
    	WS_EX_CONTROLPARENT = 0x00010000,
    	WS_EX_DLGMODALFRAME = 0x00000001,
    	WS_EX_LAYERED = 0x00080000,
    	WS_EX_LAYOUTRTL = 0x00400000,
    	WS_EX_LEFT = 0x00000000,
    	WS_EX_LEFTSCROLLBAR = 0x00004000,
    	WS_EX_LTRREADING = 0x00000000,
    	WS_EX_MDICHILD = 0x00000040,
    	WS_EX_NOACTIVATE = 0x08000000,
    	WS_EX_NOINHERITLAYOUT = 0x00100000,
    	WS_EX_NOPARENTNOTIFY = 0x00000004,
    	WS_EX_OVERLAPPEDWINDOW = WS_EX_WINDOWEDGE | WS_EX_CLIENTEDGE,
    	WS_EX_PALETTEWINDOW = WS_EX_WINDOWEDGE | WS_EX_TOOLWINDOW | WS_EX_TOPMOST,
    	WS_EX_RIGHT = 0x00001000,
    	WS_EX_RIGHTSCROLLBAR = 0x00000000,
    	WS_EX_RTLREADING = 0x00002000,
    	WS_EX_STATICEDGE = 0x00020000,
    	WS_EX_TOOLWINDOW = 0x00000080,
    	WS_EX_TOPMOST = 0x00000008,
    	WS_EX_TRANSPARENT = 0x00000020,
    	WS_EX_WINDOWEDGE = 0x00000100
    }


    [Flags]
    internal enum WinClassStyle
    {
        ByteAlignClient = 0x1000,
        ByteAlignWindow = 0x2000,
        ClassDC = 0x0040,
        DoubleClicks = 0x0008,
        DropShadow = 0x00020000,
        GlobalClass = 0x4000,
        HRedraw = 0x0002,
        NoClose = 0x0200,
        OwnDC = 0x0020,
        ParentDC = 0x0080,
        SaveBits = 0x0800,
        VRedraw = 0x0001
    }
    
	internal enum WM_SYSCOMMANDS : uint
	{
		SC_CLOSE = 0xF060,
		SC_CONTEXTHELP = 0xF180,
		SC_DEFAULT = 0xF160,
		SC_HOTKEY = 0xF150,
		SC_HSCROLL = 0xF080,
		SCF_ISSECUR = 0x00000001,
		SC_KEYMENU = 0xF100,
		SC_MAXIMIZE = 0xF030,
		SC_MINIMIZE = 0xF020,
		SC_MONITORPOWER = 0xF170,
		SC_MOUSEMENU = 0xF090,
		SC_MOVE = 0xF010,
		SC_NEXTWINDOW = 0x0F40,
		SC_PREVWINDOW = 0xF050,
		SC_RESTORE = 0xF120,
		SC_SCREENSAVE = 0xF140,
		SC_SIZE = 0xF000,
		SC_TASKLICT = 0xF130,
		SC_VSCROLL = 0xF070
	}
	    
	internal enum CursorName : int
    {
        Arrow = 32512
    }

	[Flags]
	internal enum showCmd : uint
	{
		SW_HIDE = 0,
		SW_MAXIMIZE = 3,
		SW_MINIMIZE = 6,
		SW_RESTORE = 9,
		SW_SHOW = 5,
		SW_SHOWMAXIMIZED = 3,
		SW_SHOWMINIMIZED = 2,
		SW_SHOWMINNOACTIVE = 7,
		SW_SHOWNA = 8,
		SW_SHOWNOACTIVATE = 4,
		SW_SHOWNORMAL = 1
	}

	[Flags()]
	internal enum dwFlags
	{
        DOUBLEBUFFER = 0x01,
        STEREO = 0x02,
        DRAW_TO_WINDOW = 0x04,
        DRAW_TO_BITMAP = 0x08,
        SUPPORT_GDI = 0x10,
        SUPPORT_OPENGL = 0x20,
        GENERIC_FORMAT = 0x40,
        NEED_PALETTE = 0x80,
        NEED_SYSTEM_PALETTE = 0x100,
        SWAP_EXCHANGE = 0x200,
        SWAP_COPY = 0x400,
        SWAP_LAYER_BUFFERS = 0x800,
        GENERIC_ACCELERATED = 0x1000,
        SUPPORT_DIRECTDRAW = 0x2000,
        SUPPORT_COMPOSITION = 0x8000
	}
	
	internal enum PixelType : byte
    {
        PFD_TYPE_RGBA = 0,
        PFD_TYPE_COLORINDEX = 1
    }
	
    internal enum xVisualMask : ulong
    {
        VisualNoMask = 0x0,
        VisualIDMask = 0x1,
        VisualScreenMask = 0x2,
        VisualDepthMask = 0x4,
        VisualClassMask = 0x8,
        VisualRedMaskMask = 0x10,
        VisualGreenMaskMask = 0x20,
        VisualBlueMaskMask = 0x40,
        VisualColormapSizeMask = 0x80,
        VisualBitsPerRGBMask = 0x100,
        VisualAllMask = 0x1FF
    }

    internal enum WindowMessage : uint
    {
        NULL = 0x0000,
        CREATE = 0x0001,
        DESTROY = 0x0002,
        MOVE = 0x0003,
        SIZE = 0x0005,
        ACTIVATE = 0x0006,
        SETFOCUS = 0x0007,
        KILLFOCUS = 0x0008,
        ENABLE = 0x000A,
        SETREDRAW = 0x000B,
        SETTEXT = 0x000C,
        GETTEXT = 0x000D,
        GETTEXTLENGTH = 0x000E,
        PAINT = 0x000F,
        CLOSE = 0x0010,
        QUERYENDSESSION = 0x0011,
        QUERYOPEN = 0x0013,
        ENDSESSION = 0x0016,
        QUIT = 0x0012,
        ERASEBKGND = 0x0014,
        SYSCOLORCHANGE = 0x0015,
        SHOWWINDOW = 0x0018,
        WININICHANGE = 0x001A,
        SETTINGCHANGE = WININICHANGE,
        DEVMODECHANGE = 0x001B,
        ACTIVATEAPP = 0x001C,
        FONTCHANGE = 0x001D,
        TIMECHANGE = 0x001E,
        CANCELMODE = 0x001F,
        SETCURSOR = 0x0020,
        MOUSEACTIVATE = 0x0021,
        CHILDACTIVATE = 0x0022,
        QUEUESYNC = 0x0023,
        GETMINMAXINFO = 0x0024,
        PAINTICON = 0x0026,
        ICONERASEBKGND = 0x0027,
        NEXTDLGCTL = 0x0028,
        SPOOLERSTATUS = 0x002A,
        DRAWITEM = 0x002B,
        MEASUREITEM = 0x002C,
        DELETEITEM = 0x002D,
        VKEYTOITEM = 0x002E,
        CHARTOITEM = 0x002F,
        SETFONT = 0x0030,
        GETFONT = 0x0031,
        SETHOTKEY = 0x0032,
        GETHOTKEY = 0x0033,
        QUERYDRAGICON = 0x0037,
        COMPAREITEM = 0x0039,
        GETOBJECT = 0x003D,
        COMPACTING = 0x0041,
        [Obsolete]
        COMMNOTIFY = 0x0044,
        WINDOWPOSCHANGING = 0x0046,
        WINDOWPOSCHANGED = 0x0047,
        [Obsolete]
        POWER = 0x0048,
        COPYDATA = 0x004A,
        CANCELJOURNAL = 0x004B,
        NOTIFY = 0x004E,
        INPUTLANGCHANGEREQUEST = 0x0050,
        INPUTLANGCHANGE = 0x0051,
        TCARD = 0x0052,
        HELP = 0x0053,
        USERCHANGED = 0x0054,
        NOTIFYFORMAT = 0x0055,
        CONTEXTMENU = 0x007B,
        STYLECHANGING = 0x007C,
        STYLECHANGED = 0x007D,
        DISPLAYCHANGE = 0x007E,
        GETICON = 0x007F,
        SETICON = 0x0080,
        NCCREATE = 0x0081,
        NCDESTROY = 0x0082,
        NCCALCSIZE = 0x0083,
        NCHITTEST = 0x0084,
        NCPAINT = 0x0085,
        NCACTIVATE = 0x0086,
        GETDLGCODE = 0x0087,
        SYNCPAINT = 0x0088,
        NCMOUSEMOVE = 0x00A0,
        NCLBUTTONDOWN = 0x00A1,
        NCLBUTTONUP = 0x00A2,
        NCLBUTTONDBLCLK = 0x00A3,
        NCRBUTTONDOWN = 0x00A4,
        NCRBUTTONUP = 0x00A5,
        NCRBUTTONDBLCLK = 0x00A6,
        NCMBUTTONDOWN = 0x00A7,
        NCMBUTTONUP = 0x00A8,
        NCMBUTTONDBLCLK = 0x00A9,
        NCXBUTTONDOWN = 0x00AB,
        NCXBUTTONUP = 0x00AC,
        NCXBUTTONDBLCLK = 0x00AD,
        INPUT_DEVICE_CHANGE = 0x00FE,
        INPUT = 0x00FF,
        KEYFIRST = 0x0100,
        KEYDOWN = 0x0100,
        KEYUP = 0x0101,
        CHAR = 0x0102,
        DEADCHAR = 0x0103,
        SYSKEYDOWN = 0x0104,
        SYSKEYUP = 0x0105,
        SYSCHAR = 0x0106,
        SYSDEADCHAR = 0x0107,
        UNICHAR = 0x0109,
        KEYLAST = 0x0109,
        IME_STARTCOMPOSITION = 0x010D,
        IME_ENDCOMPOSITION = 0x010E,
        IME_COMPOSITION = 0x010F,
        IME_KEYLAST = 0x010F,
        INITDIALOG = 0x0110,
        COMMAND = 0x0111,
        SYSCOMMAND = 0x0112,
        TIMER = 0x0113,
        HSCROLL = 0x0114,
        VSCROLL = 0x0115,
        INITMENU = 0x0116,
        INITMENUPOPUP = 0x0117,
        GESTURE = 0x0119, 
        TOUCH = 0x0240, 
        MENUSELECT = 0x011F,
        MENUCHAR = 0x0120,
        ENTERIDLE = 0x0121,
        MENURBUTTONUP = 0x0122,
        MENUDRAG = 0x0123,
        MENUGETOBJECT = 0x0124,
        UNINITMENUPOPUP = 0x0125,
        MENUCOMMAND = 0x0126,
        CHANGEUISTATE = 0x0127,
        UPDATEUISTATE = 0x0128,
        QUERYUISTATE = 0x0129,
        CTLCOLORMSGBOX = 0x0132,
        CTLCOLOREDIT = 0x0133,
        CTLCOLORLISTBOX = 0x0134,
        CTLCOLORBTN = 0x0135,
        CTLCOLORDLG = 0x0136,
        CTLCOLORSCROLLBAR = 0x0137,
        CTLCOLORSTATIC = 0x0138,
        MOUSEFIRST = 0x0200,
        MOUSEMOVE = 0x0200,
        LBUTTONDOWN = 0x0201,
        LBUTTONUP = 0x0202,
        LBUTTONDBLCLK = 0x0203,
        RBUTTONDOWN = 0x0204,
        RBUTTONUP = 0x0205,
        RBUTTONDBLCLK = 0x0206,
        MBUTTONDOWN = 0x0207,
        MBUTTONUP = 0x0208,
        MBUTTONDBLCLK = 0x0209,
        MOUSEWHEEL = 0x020A,
        XBUTTONDOWN = 0x020B,
        XBUTTONUP = 0x020C,
        XBUTTONDBLCLK = 0x020D,
        MOUSEHWHEEL = 0x020E,
        MOUSELAST = 0x020E,
        PARENTNOTIFY = 0x0210,
        ENTERMENULOOP = 0x0211,
        EXITMENULOOP = 0x0212,
        NEXTMENU = 0x0213,
        SIZING = 0x0214,
        CAPTURECHANGED = 0x0215,
        MOVING = 0x0216,
        POWERBROADCAST = 0x0218,
        DEVICECHANGE = 0x0219,
        MDICREATE = 0x0220,
        MDIDESTROY = 0x0221,
        MDIACTIVATE = 0x0222,
        MDIRESTORE = 0x0223,
        MDINEXT = 0x0224,
        MDIMAXIMIZE = 0x0225,
        MDITILE = 0x0226,
        MDICASCADE = 0x0227,
        MDIICONARRANGE = 0x0228,
        MDIGETACTIVE = 0x0229,
        MDISETMENU = 0x0230,
        ENTERSIZEMOVE = 0x0231,
        EXITSIZEMOVE = 0x0232,
        DROPFILES = 0x0233,
        MDIREFRESHMENU = 0x0234,
        IME_SETCONTEXT = 0x0281,
        IME_NOTIFY = 0x0282,
        IME_CONTROL = 0x0283,
        IME_COMPOSITIONFULL = 0x0284,
        IME_SELECT = 0x0285,
        IME_CHAR = 0x0286,
        IME_REQUEST = 0x0288,
        IME_KEYDOWN = 0x0290,
        IME_KEYUP = 0x0291,
        MOUSEHOVER = 0x02A1,
        MOUSELEAVE = 0x02A3,
        NCMOUSEHOVER = 0x02A0,
        NCMOUSELEAVE = 0x02A2,
        WTSSESSION_CHANGE = 0x02B1,
        TABLET_FIRST = 0x02c0,
        TABLET_LAST = 0x02df,
        CUT = 0x0300,
        COPY = 0x0301,
        PASTE = 0x0302,
        CLEAR = 0x0303,
        UNDO = 0x0304,
        RENDERFORMAT = 0x0305,
        RENDERALLFORMATS = 0x0306,
        DESTROYCLIPBOARD = 0x0307,
        DRAWCLIPBOARD = 0x0308,
        PAINTCLIPBOARD = 0x0309,
        VSCROLLCLIPBOARD = 0x030A,
        SIZECLIPBOARD = 0x030B,
        ASKCBFORMATNAME = 0x030C,
        CHANGECBCHAIN = 0x030D,
        HSCROLLCLIPBOARD = 0x030E,
        QUERYNEWPALETTE = 0x030F,
        PALETTEISCHANGING = 0x0310,
        PALETTECHANGED = 0x0311,
        HOTKEY = 0x0312,
        PRINT = 0x0317,
        PRINTCLIENT = 0x0318,
        APPCOMMAND = 0x0319,
        THEMECHANGED = 0x031A,
        CLIPBOARDUPDATE = 0x031D,
        DWMCOMPOSITIONCHANGED = 0x031E,
        DWMNCRENDERINGCHANGED = 0x031F,
        DWMCOLORIZATIONCOLORCHANGED = 0x0320,
        DWMWINDOWMAXIMIZEDCHANGE = 0x0321,
        GETTITLEBARINFOEX = 0x033F,
        HANDHELDFIRST = 0x0358,
        HANDHELDLAST = 0x035F,
        AFXFIRST = 0x0360,
        AFXLAST = 0x037F,
        PENWINFIRST = 0x0380,
        PENWINLAST = 0x038F,
        APP = 0x8000,
        USER = 0x0400,
        CPL_LAUNCH = USER+0x1000,
        CPL_LAUNCHED = USER+0x1001,
        SYSTIMER = 0x118,

        HSHELL_ACCESSIBILITYSTATE = 11,
        HSHELL_ACTIVATESHELLWINDOW = 3,
        HSHELL_APPCOMMAND = 12,
        HSHELL_GETMINRECT = 5,
        HSHELL_LANGUAGE = 8,
        HSHELL_REDRAW = 6,
        HSHELL_TASKMAN = 7,
        HSHELL_WINDOWCREATED = 1,
        HSHELL_WINDOWDESTROYED = 2,
        HSHELL_WINDOWACTIVATED = 4,
        HSHELL_WINDOWREPLACED = 13
    }
    [Flags]
	internal enum ChoosePixelFormarARB : int
	{
		WGL_NUMBER_PIXEL_FORMATS_ARB = 0x2000,
        WGL_DRAW_TO_WINDOW_ARB = 0x2001,
        WGL_DRAW_TO_BITMAP_ARB = 0x2002,
        WGL_ACCELERATION_ARB = 0x2003,
        WGL_NEED_PALETTE_ARB = 0x2004,
        WGL_NEED_SYSTEM_PALETTE_ARB = 0x2005,
        WGL_SWAP_LAYER_BUFFERS_ARB = 0x2006,
        WGL_SWAP_METHOD_ARB = 0x2007,
        WGL_NUMBER_OVERLAYS_ARB = 0x2008,
        WGL_NUMBER_UNDERLAYS_ARB = 0x2009,
        WGL_TRANSPARENT_ARB = 0x200A,
        WGL_TRANSPARENT_RED_VALUE_ARB = 0x2037,
        WGL_TRANSPARENT_GREEN_VALUE_ARB = 0x2038,
        WGL_TRANSPARENT_BLUE_VALUE_ARB = 0x2039,
        WGL_TRANSPARENT_ALPHA_VALUE_ARB = 0x203A,
        WGL_TRANSPARENT_INDEX_VALUE_ARB = 0x203B,
        WGL_SHARE_DEPTH_ARB = 0x200C,
        WGL_SHARE_STENCIL_ARB = 0x200D,
        WGL_SHARE_ACCUM_ARB = 0x200E,
        WGL_SUPPORT_GDI_ARB = 0x200F,
        WGL_SUPPORT_OPENGL_ARB = 0x2010,
        WGL_DOUBLE_BUFFER_ARB = 0x2011,
        WGL_STEREO_ARB = 0x2012,
        WGL_PIXEL_TYPE_ARB = 0x2013,
        WGL_COLOR_BITS_ARB = 0x2014,
        WGL_RED_BITS_ARB = 0x2015,
        WGL_RED_SHIFT_ARB = 0x2016,
        WGL_GREEN_BITS_ARB = 0x2017,
        WGL_GREEN_SHIFT_ARB = 0x2018,
        WGL_BLUE_BITS_ARB = 0x2019,
        WGL_BLUE_SHIFT_ARB = 0x201A,
        WGL_ALPHA_BITS_ARB = 0x201B,
        WGL_ALPHA_SHIFT_ARB = 0x201C,
        WGL_ACCUM_BITS_ARB = 0x201D,
        WGL_ACCUM_RED_BITS_ARB = 0x201E,
        WGL_ACCUM_GREEN_BITS_ARB = 0x201F,
        WGL_ACCUM_BLUE_BITS_ARB = 0x2020,
        WGL_ACCUM_ALPHA_BITS_ARB = 0x2021,
        WGL_DEPTH_BITS_ARB = 0x2022,
        WGL_STENCIL_BITS_ARB = 0x2023,
        WGL_AUX_BUFFERS_ARB = 0x2024
	}

    [Flags]
	internal enum ChoosePixelFormatARB_Values : int
	{
		WGL_NO_ACCELERATION_ARB = 0x2025,
        WGL_GENERIC_ACCELERATION_ARB = 0x2026,
        WGL_FULL_ACCELERATION_ARB = 0x2027,

        WGL_SWAP_EXCHANGE_ARB = 0x2028,
        WGL_SWAP_COPY_ARB = 0x2029,
        WGL_SWAP_UNDEFINED_ARB = 0x202A,

        WGL_TYPE_RGBA_ARB = 0x202B,
        WGL_TYPE_COLORINDEX_ARB = 0x202C,
	}

	internal enum CreateContextAttributesARB : int
	{                	
        WGL_CONTEXT_MAJOR_VERSION_ARB = 0x2091,
        WGL_CONTEXT_MINOR_VERSION_ARB = 0x2092,
        WGL_CONTEXT_LAYER_PLANE_ARB = 0x2093,
        WGL_CONTEXT_FLAGS_ARB = 0x2094,
        WGL_CONTEXT_PROFILE_MASK_ARB = 0x9126
	}
	
	internal enum ContextProfileMaskFlagsARB : int
	{
		WGL_CONTEXT_CORE_PROFILE_BIT_ARB = 0x00000001,
        WGL_CONTEXT_COMPATIBILITY_PROFILE_BIT_ARB = 0x00000002,
	}
	
	internal enum GetRawInputData_Command : uint
	{
		RID_HEADER = 0x10000005,
		RID_INPUT = 0x10000003
	}

	[Flags()]
    public enum RawInputDeviceFlags
    {        
        None = 0,
        Remove = 0x00000001,
        Exclude = 0x00000010,
        PageOnly = 0x00000020,
        NoLegacy = 0x00000030,
        InputSink = 0x00000100,
        CaptureMouse = 0x00000200,
        NoHotKeys = 0x00000200,
        AppKeys = 0x00000400,
        DevNotify = 0x00002000,
    }


    [Flags]
    internal enum RawKeyboardFlags : short
    {
        KeyMake = 0,
        KeyBreak = 1,
        KeyE0 = 2,
        KeyE1 = 4,
        TerminalServerSetLED = 8,
        TerminalServerShadow = 0x10, 
        TerminalServerVKPACKET = 0x20
    }
    
    [Flags()]
    internal enum RawMouseButtons : ushort
    {
        None = 0,
        LeftDown = 0x0001,
        LeftUp = 0x0002,
        RightDown = 0x0004,
        RightUp = 0x0008,
        MiddleDown = 0x0010,
        MiddleUp = 0x0020,
        Button4Down = 0x0040,
        Button4Up = 0x0080,
        Button5Down = 0x0100,
        Button5Up = 0x0200,
        MouseWheel = 0x0400
    }
    
}