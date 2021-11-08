using System;
using System.Runtime.InteropServices;

namespace dgtk.Platforms.X11
{
    internal static class Imports
    {
        [DllImport("libX11", EntryPoint = "XInitThreads")]
		internal extern static int XInitThreads();

		[DllImport("libX11", EntryPoint = "XOpenDisplay")]
		internal extern static IntPtr XOpenDisplay(IntPtr display);

		[DllImport("libX11", EntryPoint = "XOpenDisplay")]
		internal extern static IntPtr XOpenDisplay(string display);

		[DllImport("libX11", EntryPoint = "XCloseDisplay")]
		internal extern static void XCloseDisplay(IntPtr display);

        [DllImport("libX11", EntryPoint = "XLockDisplay")]
        internal extern static void XLockDisplay(IntPtr display);
 		
		 [DllImport("libX11", EntryPoint = "XFlush")]
        internal extern static int XFlush(IntPtr display);

        
		[DllImport("libX11", EntryPoint = "XDefaultScreen")]
		internal extern static int XDefaultScreen(IntPtr ptr_display);

		[DllImport("libX11", EntryPoint = "XUnlockDisplay")]
        internal extern static void XUnlockDisplay(IntPtr display);

        [DllImport("libX11", EntryPoint = "XDefaultRootWindow")]
        internal extern static IntPtr XDefaultRootWindow(IntPtr display);

		[DllImport("libX11", EntryPoint = "XRootWindow")]
        internal extern static IntPtr XRootWindow(IntPtr display, int screen);

		[DllImport("libX11", EntryPoint = "XBlackPixel")]
		internal extern static IntPtr XBlackPixel(IntPtr display, int screen);

		[DllImport("libX11", EntryPoint = "XWhitePixel")]
		internal extern static IntPtr XWhitePixel(IntPtr display, int screen);

		[DllImport("libX11", EntryPoint = "XCreateColormap")]
		internal extern static IntPtr XCreateColormap(IntPtr display, IntPtr w, IntPtr visual, int alloc);

        [DllImport("libX11", EntryPoint = "XCreateWindow")]
		unsafe private extern static IntPtr XCreateWindow(
			IntPtr display,
			IntPtr parent,
			int x, int y,
			uint width, uint height,
			uint border_width,
			int depth,
			int Class,
			IntPtr visual,
			IntPtr /*WinValueMask*/ valuemask,
			XSetWindowAttributes* atributos
		);
		unsafe internal static IntPtr XCreateWindow(
			IntPtr display,
			IntPtr parent,
			int x, int y,
			uint width, uint height,
			uint border_width,
			int depth,
			CreateWindowClass Class,
			IntPtr visual,
			WinValueMask valuemask,
			XSetWindowAttributes atributos
		)
		{
			return XCreateWindow(
				display,
				parent,
				x, y,
				(uint)width, (uint)height,
				(uint)border_width,
				depth,
				(int)Class,
				visual,
				/*WinValueMask*/ (IntPtr)valuemask,
				&atributos);
		}

		[DllImport("libX11", EntryPoint = "XSynchronize")]
		internal extern static void XSynchronize(IntPtr ptr_display, bool synchronize);

        [DllImport("libX11", EntryPoint = "XStoreName")]
		internal extern static void XStoreName(IntPtr display, IntPtr w, string Name);

		[DllImport("libX11", EntryPoint = "XSelectInput")]
		internal extern static void XSelectInput(IntPtr display, IntPtr w, EventMask Mask);

        [DllImport("libX11", EntryPoint = "XMapWindow")]
        internal extern static void XMapWindow(IntPtr display, IntPtr w);

        [DllImport("libX11", EntryPoint = "XUnmapWindow")]
        internal extern static void XUnmapWindow(IntPtr display, IntPtr w);

		[DllImport("libX11", EntryPoint = "XDestroyWindow")]
		internal extern static int XDestroyWindow(IntPtr display, IntPtr w);

		[DllImport("libX11", EntryPoint = "XInternAtom")]
		internal extern static IntPtr XInternAtom(IntPtr display, string atom_name, bool only_if_exists);
		
		[DllImport("libX11", EntryPoint = "XInternAtom")]
		internal extern static IntPtr XInternAtom(IntPtr display, string atom_name, int only_if_exists);

		[DllImport("libX11", EntryPoint = "XSetWMProtocols")]
		internal extern static int XSetWMProtocols(IntPtr display, IntPtr w, IntPtr[] protocols, int count);

		[DllImport("libX11", EntryPoint = "XPending")]
		internal extern static int XPending(IntPtr Display);

		[DllImport("libX11", EntryPoint = "XCheckWindowEvent")]
		internal extern static bool XCheckWindowEvent(IntPtr display, IntPtr w, EventMask mask, ref XEvent evento);

		[DllImport("libX11", EntryPoint = "XCheckTypedWindowEvent")]
		internal extern static bool XCheckTypedWindowEvent(IntPtr display, IntPtr w, XEventType type, ref XEvent evento);
				
		[DllImport("libX11", EntryPoint = "XGetWindowProperty")]
		internal extern static int XGetWindowProperty(IntPtr display, IntPtr w, IntPtr atom, IntPtr offset, IntPtr longitud, bool delete, IntPtr tipo, out IntPtr TipoActual, out int formato_actual, out IntPtr n_items, out IntPtr bytes, ref IntPtr prop);

		[DllImport("libX11", EntryPoint = "XChangeProperty")]
		internal extern static int XChangeProperty(IntPtr display, IntPtr w, IntPtr atom, IntPtr type, int format, XPropsMode mode, IntPtr data, int nelements);

		[DllImport("libX11", EntryPoint = "XFree")]
		internal extern static void XFree(IntPtr data);

		[DllImport("libX11", EntryPoint = "XFree")]
		internal extern static unsafe void XFree(IntPtr* data);

		[DllImport("libX11", EntryPoint = "XGetGeometry")]
		internal extern static int XGetGeometry(IntPtr Display, IntPtr drawable, out IntPtr VentanaRoot, out Int32 xpos, out Int32 ypos, out Int32 ancho, out Int32 alto, out Int32 grosorBorde, out Int32 bits_por_pixel); 

		[DllImport("libX11", EntryPoint = "XLookupString", CallingConvention = CallingConvention.Cdecl)]
		internal extern static int XLookupString(ref XKeyEvent evento, out char CharsReturned, int lengReturned, ref ulong keysym, IntPtr xCompEstatus);

		//[DllImport("libX11", EntryPoint = "XmbLookUpString")]
		//internal extern static int XmbLookupString(XIC ic, ref XKeyEvent event, out char[] buffer_return, int bytes_buffer, ref ushort keysym_return, out int/*Status */status_return);

		[DllImport("libX11", EntryPoint = "XIconifyWindow")]
		internal extern static int XIconifyWindow(IntPtr display, IntPtr w, int screen);

		[DllImport("libX11", EntryPoint = "XResizeWindow")]
		internal extern static void XResizeWindow(IntPtr Display, IntPtr ventana, uint width, uint height);


		[DllImport("libX11", EntryPoint = "XMoveWindow")]
		internal extern static void XMoveWindow(IntPtr display, IntPtr ventana, int x, int y);

        [DllImport("libX11", EntryPoint = "XSendEvent")]
        internal static unsafe extern int XSendEvent(IntPtr Display, IntPtr w, bool propagate, EventMask mask, ref XEvent @event);

        [DllImport("libX11", EntryPoint = "XDefaultVisual")]
        internal static unsafe extern IntPtr XDefaultVisual(IntPtr display, int screen_number);

		[DllImport("libX11", EntryPoint = "XDefaultVisual")]
		internal extern static unsafe void XGetErrorText(IntPtr display, int code, out char* buffer_return, out int length);

		[DllImport("libX11", EntryPoint = "XOpenIM")]
		internal extern static IntPtr XOpenIM(IntPtr display, IntPtr XrmDatabase, IntPtr res_name, IntPtr res_class);

		[DllImport("libX11", EntryPoint = "XCreateIC")]
		internal extern static IntPtr XCreateIC (IntPtr xim, string XNInputStyle, long xim_style, string XNClientWindow, IntPtr cwin, string XNFocusWindow, IntPtr win, IntPtr IDontKnowThatIsIt);

		[DllImport("libX11", EntryPoint = "XGetIMValues")]
		internal extern static /* char* */ IntPtr XGetIMValues (IntPtr xim, string XNQueryInputStyle, out XIMStyles xim_styles, IntPtr IDontKnowThatIsIt);

		[DllImport("libX11", EntryPoint = "XmbLookupString")]
		internal extern static int XmbLookupString( IntPtr XIC, ref XKeyEvent XKeyPressedEvent, IntPtr buffer_return, int bytes_buffer, ref ulong KeySym, ref int Status);

		[DllImport("libX11", EntryPoint = "XKeysymToString")]
		internal extern static IntPtr XKeysymToString(ulong keysym);

		[DllImport("libX11", EntryPoint = "XSetLocaleModifiers")]
		internal extern static IntPtr /*string*/XSetLocaleModifiers(string localemod);

		[DllImport("libX11", EntryPoint = "XFilterEvent")]
		internal extern static bool XFilterEvent(ref XEvent e, IntPtr win);
    }
}
