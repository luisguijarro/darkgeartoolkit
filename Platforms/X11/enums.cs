using System;

namespace dgtk.Platforms.X11
{
    [Flags]
	internal enum EventMask
	{
		NoEventMask = 0,
		KeyPressMask = 1,
		KeyReleaseMask = 2,
		ButtonPressMask = 4,
		ButtonReleaseMask = 8,
		EnterWindowMask = 16,
		LeaveWindowMask = 32,
		PointerMotionMask = 64,
		PointerMotionHintMask = 128,
		Button1MotionMask = 256,
		Button2MotionMask = 512,
		Button3MotionMask = 1024,
		Button4MotionMask = 2048,
		Button5MotionMask = 4096,
		ButtonMotionMask = 8192,
		KeymapStateMask = 16384,
		ExposureMask = 32768,
		VisibilityChangeMask = 65536,
		StructureNotifyMask = 131072,
		ResizeRedirectMask = 262144,
		SubstructureNotifyMask = 524288,
		SubstructureRedirectMask = 1048576,
		FocusChangeMask = 2097152,
		PropertyChangeMask = 4194304,
		ColormapChangeMask = 8388608,
		OwnerGrabButtonMask = 16777216
	}

    [Flags]
	internal enum WinValueMask : long
	{
		Nothing = 0,
		BackPixmap = 1 << 0,
		BackPixel = 1 << 1,
		BorderPixmap = 1 << 2,
		BorderPixel = 1 << 3,
		BitGravity = 1 << 4,
		WinGravity = 1 << 5,
		BackingStore = 1 << 6,
		BackingPlanes = 1 << 7,
		BackingPixel = 1 << 8,
		OverrideRedirect = 1 << 9,
		SaveUnder = 1 << 10,
		EventMask = 1 << 11,
		DontPropagate = 1 << 12,
		ColorMap = 1 << 13,
		Cursor = 1 << 14,
	}

	[Flags]
	internal enum CreateWindowClass : int
	{
		CopyFromParent = 0,
		ParentRelative = 1,
		InputOutput = 1,
		InputOnly = 2
	}

	internal enum XEventType : int
	{
		KeyPress = 2,
		KeyRelease = 3,
		ButtonPress = 4, 
		ButtonRelease = 5,
		MotionNotify = 6,
		EnterNotify = 7, 
		LeaveNotify = 8, 
		FocusIn = 9, 
		FocusOut = 10, 
		KeyMapNotify = 11,
		Expose = 12, 
		GraphicsExpose = 13, 
		NoExpose = 14, 
		VisibilityNotify = 15, 
		CreateNotify = 16,
		DestroyNotify = 17, 
		UnMapNotify = 18, 
		MapNotify = 19, 
		MapRequest = 20, 
		ReparentNotify = 21, 
		ConfigureNotify = 22, 
		ConfigureRequest = 23, 
		GravityNotify = 24, 
		ResizeRequest = 25, 
		CirculateNotify = 26, 
		CirculateRequest = 27, 
		PropertyNotify = 28, 
		SelectionClear = 29, 
		SelectionRequest = 30, 
		SelectionNotify = 31, 
		ColorMapNotify = 32, 
		ClientMessage = 33, 
		MappingNotify = 34, 
		GenericEvent = 35
	}

	internal enum XMapRequest : byte
	{
		XCreateWindow = 1,
		XChangeWindowAttributes = 2,
		XGetWindowAttributes = 3,
		XDestroyWindow = 4,
		XDestroySubwindows = 5,
		XChangeSaveSet = 6,
		XReparentWindow = 7,
		XMapWindow = 8,
		XMapSubwindows = 9,
		XUnmapWindow = 10,
		XUnmapSubwindows = 11,
		XConfigureWindow = 12,
		XCirculateWindow = 13,
		XGetGeometry = 14,
		XQueryTree = 15,
		XInternAtom = 16,
		XGetAtomName = 17,
		XChangeProperty = 18,
		XDeleteProperty = 19,
		XGetProperty = 20,
		XListProperties = 21,
		XSetSelectionOwner = 22,
		XGetSelectionOwner = 23,
		XConvertSelection = 24,
		XSendEvent = 25,
		XGrabPointer = 26,
		XUngrabPointer = 27,
		XGrabButton = 28,
		XUngrabButton = 29,
		XChangeActivePointerGrab = 30,
		XGrabKeyboard = 31,
		XUngrabKeyboard = 32,
		XGrabKey = 33,
		XUngrabKey = 34,
		XAllowEvents = 35,
		XGrabServer = 36,
		XUngrabServer = 37,
		XQueryPointer = 38,
		XGetMotionEvents = 39,
		XTranslateCoords = 40,
		XWarpPointer = 41,
		XSetInputFocus = 42,
		XGetInputFocus = 43,
		XQueryKeymap = 44,
		XOpenFont = 45,
		XCloseFont = 46,
		XQueryFont = 47,
		XQueryTextExtents = 48,
		XListFonts = 49,
		XListFontsWithInfo = 50,
		XSetFontPath = 51,
		XGetFontPath = 52,
		XCreatePixmap = 53,
		XFreePixmap = 54,
		XCreateGC = 55,
		XChangeGC = 56,
		XCopyGC = 57,
		XSetDashes = 58,
		XSetClipRectangles = 59,
		XFreeGC = 60,
		XClearArea = 61,
		XCopyArea = 62,
		XCopyPlane = 63,
		XPolyPoint = 64,
		XPolyLine = 65,
		XPolySegment = 66,
		XPolyRectangle = 67,
		XPolyArc = 68,
		XFillPoly = 69,
		XPolyFillRectangle = 70,
		XPolyFillArc = 71,
		XPutImage = 72,
		XGetImage = 73,
		XPolyText8 = 74,
		XPolyText16 = 75,
		XImageText8 = 76,
		XImageText16 = 77,
		XCreateColormap = 78,
		XFreeColormap = 79,
		XCopyColormapAndFree = 80,
		XInstallColormap = 81,
		XUninstallColormap = 82,
		XListInstalledColormaps = 83,
		XAllocColor = 84,
		XAllocNamedColor = 85,
		XAllocColorCells = 86,
		XAllocColorPlanes = 87,
		XFreeColors = 88,
		XStoreColors = 89,
		XStoreNamedColor = 90,
		XQueryColors = 91,
		XLookupColor = 92,
		XCreateCursor = 93,
		XCreateGlyphCursor = 94,
		XFreeCursor = 95,
		XRecolorCursor = 96,
		XQueryBestSize = 97,
		XQueryExtension = 98,
		XListExtensions = 99,
		XChangeKeyboardMapping = 100,
		XGetKeyboardMapping = 101,
		XChangeKeyboardControl = 102,
		XGetKeyboardControl = 103,
		XBell = 104,
		XChangePointerControl = 105,
		XGetPointerControl = 106,
		XSetScreenSaver = 107,
		XGetScreenSaver = 108,
		XChangeHosts = 109,
		XListHosts = 110,
		XSetAccessControl = 111,
		XSetCloseDownMode = 112,
		XKillClient = 113,
		XRotateProperties = 114,
		XForceScreenSaver = 115,
		XSetPointerMapping = 116,
		XGetPointerMapping = 117,
		XSetModifierMapping = 118,
		XGetModifierMapping = 119,
		XNoOperation = 127
	}

}
