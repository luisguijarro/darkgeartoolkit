using System;
using System.Runtime.InteropServices;

namespace dgtk.Platforms.X11
{
	[StructLayout(LayoutKind.Sequential)]
	internal struct XSetWindowAttributes
	{
		public IntPtr background_pixmap;	/* background, None, or ParentRelative */
		public IntPtr background_pixel;	/* background pixel */
		public IntPtr border_pixmap;		/* border of the window or CopyFromParent */
		public IntPtr border_pixel;	/* border pixel value */
		public int bit_gravity;		/* one of bit gravity values */
		public int win_gravity;		/* one of the window gravity values */
		public int backing_store;		/* NotUseful, WhenMapped, Always */
		public IntPtr backing_planes;	/* planes to be preserved if possible */
		public IntPtr backing_pixel;	/* value to use in restoring planes */
		public bool save_under;		/* should bits under be saved? (popups) */
		public IntPtr event_mask;		/* set of events that should be saved */
		public IntPtr do_not_propagate_mask;	/* set of events that should not propagate */
		public bool override_redirect;		/* boolean value for override_redirect */
		public IntPtr colormap;		/* color map to be associated with window */
		public IntPtr cursor;			/* cursor to be displayed (or None) */
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct XVisualInfo
	{
		public IntPtr Visual;
		public IntPtr VisualID;
		public int screen;
		public uint depth;
		public int Class;
		public ulong RedMask;
		public ulong GreenMask;
		public ulong BlueMask;
		public int ColorMapSize;
		public int BitsPerRGB;
	}

	[StructLayout(LayoutKind.Explicit)]
	internal struct XEvent 
	{
		[FieldOffset(0)]
		public XEventType type;	/* must not be changed */
		[FieldOffset(0)]
		public XAnyEvent xany;
		[FieldOffset(0)]
		public XKeyEvent xkey;
		[FieldOffset(0)]
		public XButtonEvent xbutton;
		[FieldOffset(0)]
		public XMotionEvent xmotion;
		[FieldOffset(0)]
		public XCrossingEvent xcrossing;
		[FieldOffset(0)]
		public XFocusChangeEvent xfocus;
		[FieldOffset(0)]
		public XExposeEvent xexpose;
		[FieldOffset(0)]
		public XGraphicsExposeEvent xgraphicsexpose;
		[FieldOffset(0)]
		public XNoExposeEvent xnoexpose;
		[FieldOffset(0)]
		public XVisibilityEvent xvisibility;
		[FieldOffset(0)]
		public XCreateWindowEvent xcreatewindow;
		[FieldOffset(0)]
		public XDestroyWindowEvent xdestroywindow;
		[FieldOffset(0)]
		public XUnmapEvent xunmap;
		[FieldOffset(0)]
		public XMapEvent xmap;
		[FieldOffset(0)]
		public XMapRequestEvent xmaprequest;
		[FieldOffset(0)]
		public XReparentEvent xreparent;
		[FieldOffset(0)]
		public XConfigureEvent xconfigure;
		[FieldOffset(0)]
		public XGravityEvent xgravity;
		[FieldOffset(0)]
		public XResizeRequestEvent xresizerequest;
		[FieldOffset(0)]
		public XConfigureRequestEvent xconfigurerequest;
		[FieldOffset(0)]
		public XCirculateEvent xcirculate;
		[FieldOffset(0)]
		public XCirculateRequestEvent xcirculaterequest;
		[FieldOffset(0)]
		public XPropertyEvent xproperty;
		[FieldOffset(0)]
		public XSelectionClearEvent xselectionclear;
		[FieldOffset(0)]
		public XSelectionRequestEvent xselectionrequest;
		[FieldOffset(0)]
		public XSelectionEvent xselection;
		[FieldOffset(0)]
		public XColormapEvent xcolormap;
		[FieldOffset(0)]
		public XClientMessageEvent xclient;
		[FieldOffset(0)]
		public XMappingEvent xmapping;
		[FieldOffset(0)]
		public XErrorEvent xerror;
		[FieldOffset(0)]
		public XKeymapEvent xkeymap;
		[FieldOffset(0)]
		public XEventPad Xpad;
	}


	[StructLayout(LayoutKind.Sequential)]
	internal struct XAnyEvent
	{
		public XEventType type;
		public IntPtr serial;	/* # of last request processed by server */
		public bool send_event;	/* true if this came from a SendEvent request */
		public IntPtr display;	/* Display the event was read from */
		public IntPtr window;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct XButtonEvent
	{
		public XEventType type;		/* ButtonPress or ButtonRelease */
		public IntPtr serial;	/* # of last request processed by server */
		public bool send_event;	/* true if this came from a SendEvent request */
		public IntPtr display;	/* Display the event was read from */
		public IntPtr window;		/* ``event'' window it is reported relative to */
		public IntPtr root;		/* root window that the event occurred on */
		public IntPtr subwindow;	/* child window */
		public IntPtr time;		/* milliseconds */
		public int x, y;		/* pointer x, y coordinates in event window */
		public int x_root, y_root;	/* coordinates relative to root */
		public uint state;	/* key or button mask */
		public uint button;	/* detail */
		public bool same_screen;	/* same screen flag */
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct XKeyEvent
	{
		public XEventType type;		/* KeyPress or KeyRelease */
		public IntPtr serial;	/* # of last request processed by server */
		public bool send_event;	/* true if this came from a SendEvent request */
		public IntPtr display;	/* Display the event was read from */
		public IntPtr window;		/* ``event'' window it is reported relative to */
		public IntPtr root;		/* root window that the event occurred on */
		public IntPtr subwindow;	/* child window */
		public IntPtr time;		/* milliseconds */
		public int x, y;		/* pointer x, y coordinates in event window */
		public int x_root, y_root;	/* coordinates relative to root */
		public uint state;	/* key or button mask */
		public uint keycode;	/* detail */
		public bool same_screen;	/* same screen flag */
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct XMotionEvent
	{
		public XEventType type;		/* MotionNotify */
		public IntPtr serial;	/* # of last request processed by server */
		public bool send_event;	/* true if this came from a SendEvent request */
		public IntPtr display;	/* Display the event was read from */
		public IntPtr window;		/* ``event'' window reported relative to */
		public IntPtr root;		/* root window that the event occurred on */
		public IntPtr subwindow;	/* child window */
		public IntPtr time;		/* milliseconds */
		public int x, y;		/* pointer x, y coordinates in event window */
		public int x_root, y_root;	/* coordinates relative to root */
		public uint state;	/* key or button mask */
		public char is_hint;		/* detail */
		public bool same_screen;	/* same screen flag */
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct XCrossingEvent
	{
		public XEventType type;		/* EnterNotify or LeaveNotify */
		public IntPtr serial;	/* # of last request processed by server */
		public bool send_event;	/* true if this came from a SendEvent request */
		public IntPtr display;	/* Display the event was read from */
		public IntPtr window;		/* ``event'' window reported relative to */
		public IntPtr root;		/* root window that the event occurred on */
		public IntPtr subwindow;	/* child window */
		public IntPtr time;		/* milliseconds */
		public int x, y;		/* pointer x, y coordinates in event window */
		public int x_root, y_root;	/* coordinates relative to root */
		public int mode;		/* NotifyNormal, NotifyGrab, NotifyUngrab */
		public int detail;
		/*
	 	* NotifyAncestor, NotifyVirtual, NotifyInferior, 
	 	* NotifyNonlinear,NotifyNonlinearVirtual
	 	*/
		public bool same_screen;	/* same screen flag */
		public bool focus;		/* boolean focus */
		public uint state;	/* key or button mask */
	} 

	[StructLayout(LayoutKind.Sequential)]
	internal struct XFocusChangeEvent
	{
		public XEventType type;		/* FocusIn or FocusOut */
		public IntPtr serial;	/* # of last request processed by server */
		public bool send_event;	/* true if this came from a SendEvent request */
		public IntPtr display;	/* Display the event was read from */
		public IntPtr window;		/* window of event */
		public int mode;		/* NotifyNormal, NotifyGrab, NotifyUngrab */
		public int detail;
		/*
	 	* NotifyAncestor, NotifyVirtual, NotifyInferior, 
	 	* NotifyNonlinear,NotifyNonlinearVirtual, NotifyPointer,
	 	* NotifyPointerRoot, NotifyDetailNone 
	 	*/
	} 

	[StructLayout(LayoutKind.Sequential)]
	internal struct XExposeEvent
	{
		public XEventType type;		/* Expose */
		public IntPtr serial;	/* # of last request processed by server */
		public bool send_event;	/* true if this came from a SendEvent request */
		public IntPtr display;	/* Display the event was read from */
		public IntPtr window;
		public int x, y;
		public int width, height;
		public int count;		/* if nonzero, at least this many more */
	} 

	[StructLayout(LayoutKind.Sequential)]
	internal struct XGraphicsExposeEvent
	{
		public XEventType type;		/* GraphicsExpose */
		public IntPtr serial;	/* # of last request processed by server */
		public bool send_event;	/* true if this came from a SendEvent request */
		public IntPtr display;	/* Display the event was read from */
		public IntPtr drawable;
		public int x, y;
		public int width, height;
		public int count;		/* if nonzero, at least this many more */
		public int major_code;		/* core is CopyArea or CopyPlane */
		public int minor_code;		/* not defined in the core */
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct XNoExposeEvent
	{
		public XEventType type;	/* NoExpose */
		public IntPtr serial;	/* # of last request processed by server */
		public bool send_event;	/* true if this came from a SendEvent request */
		public IntPtr display;	/* Display the event was read from */
		public IntPtr drawable;
		public int major_code;	/* core is CopyArea or CopyPlane */
		public int minor_code;	/* not defined in the core */
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct XVisibilityEvent
	{
		public XEventType type;		/* VisibiltyNotify */
		public IntPtr serial;	/* # of last request processed by server */
		public bool send_event;	/* true if this came from a SendEvent request */
		public IntPtr display;	/* Display the event was read from */
		public IntPtr window;
		public int state;
	} 

	[StructLayout(LayoutKind.Sequential)]
	internal struct XCreateWindowEvent
	{
		public XEventType type;		/* CreateNotify */
		public IntPtr serial;	/* # of last request processed by server */
		public bool send_event;	/* true if this came from a SendEvent request */
		public IntPtr display;	/* Display the event was read from */
		public IntPtr parent;		/* parent of the window */
		public IntPtr window;		/* window id of window created */
		public int x, y;		/* window location */
		public int width, height;	/* size of window */
		public int border_width;	/* border width */
		public bool override_redirect;	/* creation should be overridden */
	} 

	[StructLayout(LayoutKind.Sequential)]
	internal struct XDestroyWindowEvent
	{
		public XEventType type;		/* DestroyNotify */
		public IntPtr serial;	/* # of last request processed by server */
		public bool send_event;	/* true if this came from a SendEvent request */
		public IntPtr display;	/* Display the event was read from */
		public IntPtr evento;
		public IntPtr window;
	} 

	[StructLayout(LayoutKind.Sequential)]
	internal struct XUnmapEvent
	{
		public XEventType type;	/* UnmapNotify */
		public IntPtr serial;	/* # of last request processed by server */
		public bool send_event;	/* true if this came from a SendEvent request */
		public IntPtr display;	/* Display the event was read from */
		public IntPtr evento;
		public IntPtr window;
		public bool from_configure;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct XMapEvent
	{
		public XEventType type;		/* MapNotify */
		public IntPtr serial;	/* # of last request processed by server */
		public bool send_event;	/* true if this came from a SendEvent request */
		public IntPtr display;	/* Display the event was read from */
		public IntPtr evento;
		public IntPtr window;
		public bool override_redirect;	/* boolean, is override set... */
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct XMapRequestEvent
	{
		public XEventType type;	/* MapRequest */
		public IntPtr serial;	/* # of last request processed by server */
		public bool send_event;	/* true if this came from a SendEvent request */
		public IntPtr display;	/* Display the event was read from */
		public IntPtr parent;
		public IntPtr window;
	} 

	[StructLayout(LayoutKind.Sequential)]
	internal struct XReparentEvent
	{
		public XEventType type;               /* ReparentNotify */
		public IntPtr serial;	/* # of last request processed by server */
		public bool send_event;	/* true if this came from a SendEvent request */
		public IntPtr display;	/* Display the event was read from */
		public IntPtr evento;
		public IntPtr window;
		public IntPtr parent;
		public int x, y;
		public bool override_redirect;
	} 

	[StructLayout(LayoutKind.Sequential)]
	internal struct XConfigureEvent
	{
		public XEventType type;	        /* ConfigureNotify */
		public IntPtr serial;	/* # of last request processed by server */
		public bool send_event;	/* true if this came from a SendEvent request */
		public IntPtr display;	/* Display the event was read from */
		public IntPtr evento;
		public IntPtr window;
		public int x, y;
		public int width, height;
		public int border_width;
		public IntPtr above;
		public bool override_redirect;
	} 

	[StructLayout(LayoutKind.Sequential)]
	internal struct XGravityEvent
	{
		public XEventType type;	        /* GravityNotify */
		public IntPtr serial;	/* # of last request processed by server */
		public bool send_event;	/* true if this came from a SendEvent request */
		public IntPtr display;	/* Display the event was read from */
		public IntPtr evento;
		public IntPtr window;
		public int x, y;
	} 

	[StructLayout(LayoutKind.Sequential)]
	internal struct XResizeRequestEvent
	{
		public XEventType type;	/* ResizeRequest */
		public IntPtr serial;	/* # of last request processed by server */
		public bool send_event;	/* true if this came from a SendEvent request */
		public IntPtr display;	/* Display the event was read from */
		public IntPtr window;
		public int width, height;
	} 

	[StructLayout(LayoutKind.Sequential)]
	internal struct XConfigureRequestEvent
	{
		public XEventType type;		/* ConfigureRequest */
		public IntPtr serial;	/* # of last request processed by server */
		public bool send_event;	/* true if this came from a SendEvent request */
		public IntPtr display;	/* Display the event was read from */
		public IntPtr parent;
		public IntPtr window;
		public int x, y;
		public int width, height;
		public int border_width;
		public IntPtr above;
		public int detail;		/* Above, Below, TopIf, BottomIf, Opposite */
		public ulong value_mask;
	} 

	[StructLayout(LayoutKind.Sequential)]
	internal struct XCirculateEvent
	{
		public XEventType type;		/* CirculateNotify */
		public IntPtr serial;	/* # of last request processed by server */
		public bool send_event;	/* true if this came from a SendEvent request */
		public IntPtr display;	/* Display the event was read from */
		public IntPtr evento;
		public IntPtr window;
		public int place;		/* PlaceOnTop, PlaceOnBottom */
	} 

	[StructLayout(LayoutKind.Sequential)]
	internal struct XCirculateRequestEvent
	{
		public XEventType type;		/* CirculateRequest */
		public IntPtr serial;	/* # of last request processed by server */
		public bool send_event;	/* true if this came from a SendEvent request */
		public IntPtr display;	/* Display the event was read from */
		public IntPtr parent;
		public IntPtr window;
		public int place;		/* PlaceOnTop, PlaceOnBottom */
	} 

	[StructLayout(LayoutKind.Sequential)]
	internal struct XPropertyEvent
	{
		public XEventType type;		/* PropertyNotify */
		public IntPtr serial;	/* # of last request processed by server */
		public bool send_event;	/* true if this came from a SendEvent request */
		public IntPtr display;	/* Display the event was read from */
		public IntPtr window;
		public IntPtr atom;
		public IntPtr time;
		public int state;		/* PropertyNewValue or PropertyDelete */
	} 

	[StructLayout(LayoutKind.Sequential)]
	internal struct XSelectionClearEvent
	{
		public XEventType type;		/* SelectionClear */
		public IntPtr serial;	/* # of last request processed by server */
		public bool send_event;	/* true if this came from a SendEvent request */
		public IntPtr display;	/* Display the event was read from */
		public IntPtr window;
		public IntPtr selection;
		public IntPtr time;
	} 

	[StructLayout(LayoutKind.Sequential)]
	internal struct XSelectionRequestEvent
	{
		public XEventType type;		/* SelectionRequest */
		public IntPtr serial;	/* # of last request processed by server */
		public bool send_event;	/* true if this came from a SendEvent request */
		public IntPtr display;	/* Display the event was read from */
		public IntPtr owner;
		public IntPtr requestor;
		public IntPtr selection;
		public IntPtr target;
		public IntPtr property;
		public IntPtr time;
	} 

	[StructLayout(LayoutKind.Sequential)]
	internal struct XSelectionEvent
	{
		public XEventType type;		/* SelectionNotify */
		public IntPtr serial;	/* # of last request processed by server */
		public bool send_event;	/* true if this came from a SendEvent request */
		public IntPtr display;	/* Display the event was read from */
		public IntPtr requestor;
		public IntPtr selection;
		public IntPtr target;
		public IntPtr property;		/* atom or None */
		public IntPtr time;
	} 

	[StructLayout(LayoutKind.Sequential)]
	internal struct XColormapEvent
	{
		public XEventType type;	/* ColormapNotify */
		public IntPtr serial;	/* # of last request processed by server */
		public bool send_event;	/* true if this came from a SendEvent request */
		public IntPtr display;	/* Display the event was read from */
		public IntPtr window;
		public IntPtr colormap;	/* colormap or None */
		public bool nuevo;
		public int state;	/* ColormapInstalled, ColormapUninstalled */
	} 

	[StructLayout(LayoutKind.Sequential)]
	internal struct XClientMessageEvent
	{
		public XEventType type;			/* ClientMessage */
		public IntPtr serial;		/* # of last request processed by server */
		public bool send_event;		/* true if this came from a SendEvent request */
		public IntPtr display;		/* Display the event was read from */
		public IntPtr window;
		public IntPtr message_type;
		public int format;
		public IntPtr puntero1;
		public IntPtr puntero2;
		public IntPtr puntero3;
		public IntPtr puntero4;
		public IntPtr puntero5;
	} 
	/*
	struct xcmeData
	{
		
	}
	*/
	[StructLayout(LayoutKind.Sequential)]
	internal struct XMappingEvent
	{
		public XEventType type;		/* MappingNotify */
		public IntPtr serial;	/* # of last request processed by server */
		public bool send_event;	/* true if this came from a SendEvent request */
		public IntPtr display;	/* Display the event was read from */
		public IntPtr window;		/* unused */
		public int request;		/* one of MappingModifier, MappingKeyboard, MappingPointer */
		public int first_keycode;	/* first keycode */
		public int count;		/* defines range of change w. first_keycode*/
	} 

	[StructLayout(LayoutKind.Sequential)]
	internal struct XKeymapEvent
	{
		public XEventType type;		/* KeymapNotify */
		public IntPtr serial;	/* # of last request processed by server */
		public bool send_event;	/* true if this came from a SendEvent request */
		public IntPtr display;	/* Display the event was read from */
		public IntPtr window;
        public byte key_vector0;
        public byte key_vector1;
        public byte key_vector2;
        public byte key_vector3;
        public byte key_vector4;
        public byte key_vector5;
        public byte key_vector6;
        public byte key_vector7;
        public byte key_vector8;
        public byte key_vector9;
        public byte key_vector10;
        public byte key_vector11;
        public byte key_vector12;
        public byte key_vector13;
        public byte key_vector14;
        public byte key_vector15;
        public byte key_vector16;
        public byte key_vector17;
        public byte key_vector18;
        public byte key_vector19;
        public byte key_vector20;
        public byte key_vector21;
        public byte key_vector22;
        public byte key_vector23;
        public byte key_vector24;
        public byte key_vector25;
        public byte key_vector26;
        public byte key_vector27;
        public byte key_vector28;
        public byte key_vector29;
        public byte key_vector30;
        public byte key_vector31;
	} 

	[StructLayout(LayoutKind.Sequential)]
	internal struct XErrorEvent
	{
		public XEventType type;
		public IntPtr Display;
		public IntPtr serial;
		public IntPtr ResID;
		public byte ErrorCode;
		public XMapRequest RequestCode;
		public byte minCode;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct XEventPad
	{
		public IntPtr PAD00;
		public IntPtr PAD01;
		public IntPtr PAD02;
		public IntPtr PAD03;
		public IntPtr PAD04;
		public IntPtr PAD05;
		public IntPtr PAD06;
		public IntPtr PAD07;
		public IntPtr PAD08;
		public IntPtr PAD09;
		public IntPtr PAD10;
		public IntPtr PAD11;
		public IntPtr PAD12;
		public IntPtr PAD13;
		public IntPtr PAD14;
		public IntPtr PAD15;
		public IntPtr PAD16;
		public IntPtr PAD17;
		public IntPtr PAD18;
		public IntPtr PAD19;
		public IntPtr PAD20;
		public IntPtr PAD21;
		public IntPtr PAD22;
		public IntPtr PAD23;
	}

}
