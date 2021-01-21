using System;
using System.Threading;
using System.Runtime.InteropServices;

namespace dgtk.Platforms.X11
{
    internal class X11Window : I_Window
    {
        private IntPtr ptr_handle;
		private bool isRunning;
		private bool isDrawing;
		private bool b_created;
		private object lockobject;
        private IntPtr ptr_display;
        private int ScreenId;
        private IntPtr ptr_rootwin;
        private EventMask eventMask;
		private IntPtr ptr_Visual;
        private XVisualInfo Visual;
        private XSetWindowAttributes XWA;
		private OpenGL.OGL_Context GL_Context;

		private OpenAL.OAL_Context OpenAL_Cntx;

		private LinuxSwapControlExt SwapControlSupported;

		private bool vSyncEnabled;

		#region Atoms
		IntPtr WM_DELETE_WINDOW;
		IntPtr WM_STATE;
		IntPtr WM_STATE_ADD;
		IntPtr WM_STATE_REMOVE;
		IntPtr WM_STATE_TOGGLE;
		IntPtr WM_STATE_HIDDEN;
		IntPtr WM_STATE_MINIMIZED;
		IntPtr WM_STATE_MAXIMIZED_HOR;
		IntPtr WM_STATE_MAXIMIZED_VER;
		IntPtr WM_ALLOWED_ACTION;
		IntPtr WM_ACTION_RESIZE;
		IntPtr WM_ICON;
		#endregion

        private string s_title;
        private WindowState WinState;
		private int ancho;
		private int alto;

		#region AttributeEvents
		public event EventHandler<dgtk_WinCloseEventArgs> WindowClose;
        public event EventHandler<dgtk_WinResizeEventArgs> WindowSizeChange;
		public event EventHandler<dgtk_WinStateChangeEventArgs> WindowStateChange;
		public event EventHandler<dgtk_KeyBoardKeysEventArgs> KeyPulsed;
		public event EventHandler<dgtk_KeyBoardKeysEventArgs> KeyReleased;
		public event EventHandler<dgtk_KeyBoardTextEventArgs> KeyCharReturned;
		public event EventHandler<dgtk_MouseButtonEventArgs> MouseDown;
		public event EventHandler<dgtk_MouseButtonEventArgs> MouseUp;
		public event EventHandler<dgtk_MouseMoveEventArgs> MouseMove;
		public event EventHandler<dgtk_MouseWheelEventArgs> MouseWheel;
		public event EventHandler<dgtk_MouseEnterLeaveEventArgs> MouseEnter;
		public event EventHandler<dgtk_MouseEnterLeaveEventArgs> MouseLeave;
		public event EventHandler<dgtk_OnRenderEventArgs> RenderFrame;
		#endregion

		internal X11Window() : this(0, 0, 800, 450, "dgtk Window")
        {

		}
		internal X11Window(uint width, uint height, string title) : this(0, 0, width, height, title)
        {
			
		}
        internal X11Window(int posX, int posY, uint width, uint height, string title)
        {
            this.s_title = title;
            this.WinState = WindowState.Normal;
			this.lockobject = new object();

            this.WindowClose += delegate {};
			this.WindowSizeChange += delegate {};
			this.WindowStateChange += delegate {};
			this.KeyPulsed += delegate {};
			this.KeyReleased += delegate {};
			this.KeyCharReturned += delegate {};
			this.MouseDown += delegate { };
			this.MouseUp += delegate { };
			this.MouseMove += delegate { };
			this.MouseWheel += delegate { };
			this.MouseEnter += delegate { };
			this.MouseLeave += delegate { };
			this.RenderFrame += delegate { };

            if (Imports.XInitThreads() == 0) // Esencial.
			{
				throw new Exception("XInitThreads(): fails");
			}
            this.ptr_display = Imports.XOpenDisplay(null);
			// Imports.XSynchronize(this.ptr_display, true); //It slows everything down. Use only for x11 debug
			
            this.ScreenId = Imports.XDefaultScreen(this.ptr_display);
            
			this.SwapControlSupported = VSync.SupportedVSync(this.ptr_display, this.ScreenId);

			IntPtr FBConfig = IntPtr.Zero;
			OGLPreparation.PreparationOGLContext(this.ptr_display, this.ScreenId, ref FBConfig, out this.Visual, out this.ptr_Visual);

            this.eventMask = (EventMask.ExposureMask | EventMask.EnterWindowMask | EventMask.LeaveWindowMask | EventMask.KeyPressMask | EventMask.KeyReleaseMask | 
				EventMask.StructureNotifyMask | EventMask.FocusChangeMask | EventMask.ButtonPressMask | EventMask.ButtonReleaseMask | 
				EventMask.PropertyChangeMask | EventMask.PointerMotionMask);

			this.ptr_rootwin = Imports.XRootWindow(this.ptr_display, this.Visual.screen);
			
			this.XWA = new XSetWindowAttributes();
			XWA.colormap = Imports.XCreateColormap(this.ptr_display, this.ptr_rootwin, this.Visual.Visual, 0);
			XWA.background_pixel  = Imports.XBlackPixel(this.ptr_display, this.Visual.screen);
			XWA.border_pixel = Imports.XWhitePixel(this.ptr_display, this.Visual.screen);
			XWA.event_mask = (IntPtr)this.eventMask;
            
			WinValueMask wvm = (WinValueMask.BackPixmap | WinValueMask.BorderPixmap | WinValueMask.BorderPixel | WinValueMask.ColorMap | WinValueMask.EventMask | WinValueMask.BackPixel);
			
			//Console.WriteLine("Depth: "+this.Visual.depth);
			//Console.WriteLine("BitsPerRGB: "+this.Visual.BitsPerRGB);
			//Console.WriteLine("screen: "+this.Visual.screen);
			//Console.WriteLine("ColorMapSize: "+this.Visual.ColorMapSize);
			
			Imports.XLockDisplay(this.ptr_display);
			this.ptr_handle = Imports.XCreateWindow(this.ptr_display, this.ptr_rootwin, 0, 0, (uint)width, (uint)height, 0, (int)this.Visual.depth, CreateWindowClass.InputOutput, this.Visual.Visual, wvm, this.XWA);
			
			Imports.XStoreName(this.ptr_display, this.ptr_handle, this.s_title);
			//Imports.XUnlockDisplay(this.ptr_display);

			this.RegisterEventsAtoms();
			Imports.XSelectInput(this.ptr_display, this.ptr_handle, this.eventMask);
			Imports.XMapWindow(this.ptr_display, this.ptr_handle);
			
			Imports.XUnlockDisplay(this.ptr_display);
			
			this.GetSize();

			IntPtr xglwin = OGLPreparation.Getglxwin(this.ptr_display, FBConfig, this.ptr_handle);

			if (dgtk.OpenGL.OGL_SharedContext.p_SharedContext == IntPtr.Zero)
			{
				dgtk.OpenGL.OGL_SharedContext.InitSharedContext();
			}

			this.GL_Context = OGLPreparation.GenerateOGL_Context(this.ptr_display, xglwin, ref this.Visual, dgtk.OpenGL.OGL_SharedContext.p_SharedContext, true);
			this.GL_Context.X11UnMakeCurrent();

			this.OpenAL_Cntx = new OpenAL.OAL_Context();
			
			this.b_created = true;
			this.isRunning = true; //Lo quitamos del método Run() 
        }

		#region Public Methods

		public void Redraw()
		{
			isDrawing = true;
			lock(this.lockobject)
			{
				if (this.GL_Context.X11MakeCurrent())
				{
					this.RenderFrame(this, new dgtk_OnRenderEventArgs());
					
					this.GL_Context.X11UnMakeCurrent();
				}
			}
			isDrawing = false;
		}

		public bool MakeCurrent()
		{
			return this.GL_Context.X11MakeCurrent();
		}
		public bool UnMakeCurrent()
		{
			return this.GL_Context.X11UnMakeCurrent();
		}
		public void SwapBuffers()
		{
			this.GL_Context.X11SwapBuffers();
		}

		public void EnableVSync()
		{
			switch(this.SwapControlSupported)
			{
				case LinuxSwapControlExt.GLX_EXT_swap_control:
					glx.glXSwapIntervalEXT(this.ptr_display, this.GL_Context.ptr_xglwin, 1);
					this.vSyncEnabled = true;
					break;
				case LinuxSwapControlExt.GLX_MESA_swap_control:
					glx.glXSwapIntervalMESA(1);
					this.vSyncEnabled = true;
					break;
				case LinuxSwapControlExt.GLX_SGI_swap_control:
					glx.glXSwapIntervalSGI(1);
					this.vSyncEnabled = true;
					break;
			}
			this.vSyncEnabled = false;
		}

		public void DisableVSync()
		{
			switch(this.SwapControlSupported)
			{
				case LinuxSwapControlExt.GLX_EXT_swap_control:
					glx.glXSwapIntervalEXT(this.ptr_display, this.GL_Context.ptr_xglwin, 0);
					this.vSyncEnabled = false;
					break;
				case LinuxSwapControlExt.GLX_MESA_swap_control:
					glx.glXSwapIntervalMESA(0);
					this.vSyncEnabled = false;
					break;
				case LinuxSwapControlExt.GLX_SGI_swap_control:
					//glx.glXSwapIntervalSGI(0); //No soportado GLX_BAD_VALUE
					break;
			}
		}

		public void Close()
		{
			this.WindowClose(this, new dgtk_WinCloseEventArgs());
			this.OpenAL_Cntx.Dispose();
			this.isRunning = false;
		}
		#endregion

		#region PRIVATES
        private void RegisterEventsAtoms()
        {
            Imports.XLockDisplay(this.ptr_display);
			this.WM_DELETE_WINDOW = Imports.XInternAtom(this.ptr_display, "WM_DELETE_WINDOW", true);
			this.WM_STATE = Imports.XInternAtom(this.ptr_display, "_NET_WM_STATE", false);
			this.WM_STATE_HIDDEN = Imports.XInternAtom(this.ptr_display, "_NET_WM_STATE_HIDDEN", false);
			this.WM_STATE_MINIMIZED = Imports.XInternAtom(this.ptr_display, "_NET_WM_STATE_MINIMIZED", false);
			this.WM_STATE_MAXIMIZED_HOR = Imports.XInternAtom(this.ptr_display, "_NET_WM_STATE_MAXIMIZED_HORZ", false);
			this.WM_STATE_MAXIMIZED_VER = Imports.XInternAtom(this.ptr_display, "_NET_WM_STATE_MAXIMIZED_VERT", false);
			this.WM_ACTION_RESIZE = Imports.XInternAtom(this.ptr_display, "_NET_WM_ACTION_RESIZE", false);
			this.WM_ICON = Imports.XInternAtom(this.ptr_display, "_NEW_WM_ICON", false);
			this.WM_STATE_TOGGLE = (IntPtr)2;
			this.WM_STATE_ADD = (IntPtr)1;
			this.WM_STATE_REMOVE = (IntPtr)0;
			this.WM_ALLOWED_ACTION = Imports.XInternAtom(this.ptr_display, "_NET_WM_ALLOWED_ACTIONS", false);
			Imports.XSetWMProtocols(this.ptr_display, this.ptr_handle, new IntPtr[]{ this.WM_DELETE_WINDOW/*, this.WM_ACTION_RESIZE*/}, 1);

			Imports.XUnlockDisplay(this.ptr_display);
        }

		public void ProcessEvent(ref uint ups)
		{
			while(this.isRunning)
			{
				DateTime dt_ini = DateTime.Now;
				dgtk.GameControlsManager.DetectNewDevices();
                
				XEvent xevento = new XEvent();
				
				while(Imports.XPending(this.ptr_display)>0)
				{				
					Imports.XLockDisplay(this.ptr_display);	
					Imports.XCheckWindowEvent(this.ptr_display, this.ptr_handle, this.eventMask, ref xevento);
					Imports.XCheckTypedWindowEvent(this.ptr_display, this.ptr_handle, XEventType.ClientMessage, ref xevento);
					Imports.XUnlockDisplay(this.ptr_display);
					KeyCode kc;
					switch(xevento.type)
					{
						case XEventType.ButtonPress:
							if (xevento.xbutton.button == 4)
							{
								//if Button4 or Button5 => WHEEL;
								this.MouseWheel(this, new dgtk_MouseWheelEventArgs(1f));
							}
							else if (xevento.xbutton.button == 5)
							{
								//if Button4 or Button5 => WHEEL;
								this.MouseWheel(this, new dgtk_MouseWheelEventArgs(-1f));
							}
							else
							{
								this.MouseDown(this, new dgtk_MouseButtonEventArgs(xevento.xbutton.x, xevento.xbutton.y, (MouseButtons)xevento.xbutton.button, PushRelease.Push));
							}

							break;

						case XEventType.ButtonRelease:
							if ((xevento.xbutton.button > 3) && (xevento.xbutton.button < 6))
							{
								//if Button4 or Button5 => WHEEL; (in release not make nothing)
							}
							else
							{
								this.MouseUp(this, new dgtk_MouseButtonEventArgs(xevento.xbutton.x, xevento.xbutton.y, (MouseButtons)xevento.xbutton.button, PushRelease.Release));
							}
							break;
						
						case XEventType.MotionNotify:
							this.MouseMove(this, new dgtk_MouseMoveEventArgs(xevento.xmotion.x, xevento.xmotion.y, xevento.xmotion.x_root, xevento.xmotion.y_root));
							break;		

						case XEventType.EnterNotify:
							this.MouseEnter(this, new dgtk_MouseEnterLeaveEventArgs(EnterLeave.Enter));
							break;
						case XEventType.LeaveNotify:
							this.MouseLeave(this, new dgtk_MouseEnterLeaveEventArgs(EnterLeave.Leave));
							break;

						case XEventType.KeyPress:
							//Console.WriteLine("-------------");
							//Console.WriteLine("xKeyCode: " + this.xevento.xkey.keycode);
							kc = EventsTools.X11key(xevento.xkey.keycode);
							this.KeyPulsed(this, new dgtk_KeyBoardKeysEventArgs(new KeyBoard_Status(kc, PushRelease.Push)));
							
							
							ushort ks = 0;
							char chRet;
							int longi = Imports.XLookupString(ref xevento.xkey, out chRet, 256, ref ks, IntPtr.Zero);
							//Console.WriteLine("Longi: " + longi);
							if(longi > 0)
							{
								Console.WriteLine("chRet: "+chRet);
								Console.WriteLine("ks: "+ks);
								if ((ks != 65293) && (ks != 65288) && (ks != 65307)) // Discriminar Return, Backspace y ESC
								{
									this.KeyCharReturned(this, new dgtk_KeyBoardTextEventArgs(chRet));//LANZAR EVENTO CHARACTER
								}
							} 
							break;
							
						case XEventType.KeyRelease:
							kc = EventsTools.X11key(xevento.xkey.keycode);
							this.KeyReleased(this, new dgtk_KeyBoardKeysEventArgs(new KeyBoard_Status(kc, PushRelease.Release)));
							break;

						case XEventType.ClientMessage:
							if(xevento.xclient.puntero1 == this.WM_DELETE_WINDOW)
							{
								this.Close();
							}
							break;
						case XEventType.PropertyNotify:		//WINDOW STATE					
							if(xevento.xproperty.atom == this.WM_STATE)
							{
								this.GetState();
							} 
							break;
						case XEventType.ConfigureNotify:
							this.GetSize(); //IF SIZE IS DIFFERENT, LAUNCH EVENT ONRESIZE | If POSITION IS DIFFERENT, LAUNCH ONPOSITIONED
							break;
						case XEventType.ConfigureRequest:
							this.GetSize(); //IF SIZE IS DIFFERENT, LAUNCH EVENT ONRESIZE | If POSITION IS DIFFERENT, LAUNCH ONPOSITIONED
							break;
						default:
							break;
					}
					
				}
				TimeSpan retraso = DateTime.Now - dt_ini;
                if (retraso.TotalMilliseconds < (1f/(float)ups)*1000f)
                {
                    Thread.Sleep((int)(((1f/(float)ups)*1000f)-retraso.TotalMilliseconds));
                }
			}
			while(this.isDrawing){ /* ESPERAR POR RENDER: Evita crash en Cierre */}
			Imports.XUnmapWindow(this.ptr_display, this.ptr_handle);
			this.GL_Context.Dispose();
			Imports.XDestroyWindow(this.ptr_display, this.ptr_handle);
			Imports.XCloseDisplay(this.ptr_display);
			//Thread.CurrentThread.Abort();
		}

		private void GetState()
		{
			IntPtr atom_actual, n_items, n_bytes;
			int format;
			IntPtr prop = IntPtr.Zero;
			int maximized = 0;
			bool minimized = false;
			Imports.XGetWindowProperty(this.ptr_display, this.Handle, this.WM_STATE, IntPtr.Zero, new IntPtr(256), false, new IntPtr(4), out atom_actual, out format, out n_items, out n_bytes, ref prop);
			if(n_items.ToInt32() > 0)
			{
				for(int i = 0;i < n_items.ToInt32();i++)
				{
					IntPtr atomo = (IntPtr)Marshal.ReadIntPtr(prop, i * IntPtr.Size);

					if(atomo == this.WM_STATE_MAXIMIZED_HOR || atomo == this.WM_STATE_MAXIMIZED_VER)
					{
						maximized++;
					} else if(atomo == this.WM_STATE_MINIMIZED || atomo == this.WM_STATE_HIDDEN)
					{
						minimized = true;
					}
				}
			}
			if(minimized)
			{
				this.WinState = WindowState.Minimized;
			} 
			else if(maximized == 2)
			{
				this.WinState = WindowState.Maximized;
			} 
			else
			{
				this.WinState = WindowState.Normal;
			}
			this.WindowStateChange(this, new dgtk_WinStateChangeEventArgs(this.WinState));
			Imports.XFree(prop);
		}

		private void GetSize()
		{
			IntPtr ventroottemp;
			int bxp_temp, grosorborde, x, y;
			//dgtk.Math.Vector2 v2_s = new dgtk.Math.Vector2 (this.ancho, this.alto);
			Imports.XGetGeometry(this.ptr_display, this.ptr_handle, out ventroottemp, out x, out y, out this.ancho, out this.alto, out grosorborde, out bxp_temp);
			//if ((v2_s.X.Equals(this.ancho)) || (v2_s.Y.Equals(this.alto)))
			//{
				this.WindowSizeChange(this, new dgtk_WinResizeEventArgs(this.ancho, this.alto));
			//}
		}

		private void Maximizar()
		{
			XEvent xev = new XEvent();
			xev.type = XEventType.ClientMessage;
			xev.xclient.type = XEventType.ClientMessage;
			xev.xclient.window = this.ptr_handle;
			xev.xclient.message_type = this.WM_STATE;
			xev.xclient.format = 32;
			xev.xclient.send_event = true;
			xev.xclient.puntero1 = this.WM_STATE_TOGGLE;
			xev.xclient.puntero2 = this.WM_STATE_MAXIMIZED_HOR;
			xev.xclient.puntero3 = this.WM_STATE_MAXIMIZED_VER;
			Imports.XSendEvent(this.ptr_display, this.ptr_rootwin, false, (EventMask.SubstructureRedirectMask | EventMask.SubstructureNotifyMask), ref xev);
		}

		private void Des_Maximizar()
		{
			XEvent xev = new XEvent();
			xev.type = XEventType.ClientMessage;
			xev.xclient.type = XEventType.ClientMessage;
			xev.xclient.window = this.ptr_handle;
			xev.xclient.message_type = this.WM_STATE;
			xev.xclient.format = 32;
			xev.xclient.send_event = true;
			xev.xclient.puntero1 = this.WM_STATE_REMOVE;
			xev.xclient.puntero2 = this.WM_STATE_MAXIMIZED_HOR;
			xev.xclient.puntero3 = this.WM_STATE_MAXIMIZED_VER;
			Imports.XSendEvent(this.ptr_display, this.ptr_rootwin, false, (EventMask.SubstructureRedirectMask | EventMask.SubstructureNotifyMask), ref xev);
		}
		#endregion

		#region PROPERTIES
        public string Title
        {
            get { return this.s_title;}
            set { this.s_title = value; Imports.XStoreName(this.ptr_display, this.ptr_handle, value);}
        }
		public OpenAL.OAL_Context OpenAlContext
		{
			get { return this.OpenAL_Cntx; }
		}
        public IntPtr Handle
        {
            get { return this.ptr_handle; }
        }        
		public object LockObject
        {
            get { return this.lockobject; }
        }

		public WindowState WindowState
		{
			get
			{ 
				return this.WinState;
			}
			set
			{
				switch(value)
				{
					case WindowState.Minimized:
						Imports.XIconifyWindow(this.ptr_display, this.ptr_handle, this.ScreenId);
						break;
					case WindowState.Maximized:
						this.Maximizar();
						break;
					case WindowState.Normal:
						if(this.WinState == WindowState.Maximized)
						{
							this.Des_Maximizar();
						}
						break;
				}
				this.WinState = value;
			}
		}
		public bool Created {get{return b_created;}}
	
		public bool IsRunning 
		{
			get { return this.isRunning; }
			set { this.isRunning = value;}
		}	

		public dgtk.Math.Size Size
		{
			set { Imports.XResizeWindow (this.ptr_display, this.ptr_handle, (uint)value.Width, (uint)value.Height); /*this.ancho = (int)value.X; this.alto = (int)value.Y;*/}
			get { return new dgtk.Math.Size(this.ancho, this.alto); }
		}

		public bool VSyncEnabled { get { return this.vSyncEnabled; } }

		#endregion
    }
}
