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
		private bool b_HaveFocus;
		//private object lockobject;
        private IntPtr ptr_display;
        private IntPtr ptr_egldisplay;
		private IntPtr ptr_XIM; // Entorno Para eventos.
		private IntPtr ptr_XIC; // Contexto Para eventos.
        private int ScreenId;
        private IntPtr ptr_rootwin;
        private EventMask eventMask;
		private IntPtr ptr_Visual;
        private XVisualInfo Visual;
        private XSetWindowAttributes XWA;
		private OpenGL.OGL_Context GL_Context;
		private bool IsEGL;

		//private OpenAL.OAL_Context OpenAL_Cntx;

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
		IntPtr WM_STATE_FULLSCREEN;
		IntPtr WM_STATE_MAXIMIZED_HOR;
		IntPtr WM_STATE_MAXIMIZED_VER;
		IntPtr WM_ALLOWED_ACTION;
		IntPtr WM_ACTION_RESIZE;
		IntPtr WM_ICON;
		IntPtr CARDINAL;
		#endregion

        private string s_title;
        private WindowState WinState;
		private bool IsInFullScreen;
		private int ancho;
		private int alto;
		private int X;
		private int Y;

		#region AttributeEvents
		public event EventHandler<dgtk_WinCloseEventArgs> WindowClose;
        public event EventHandler<dgtk_ResizeEventArgs> WindowSizeChange;
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

		internal X11Window() : this(0, 0, 800, 450, "dgtk Window", false)
        {

		}
		internal X11Window(int width, int height, string title, bool IsEGL) : this(0, 0, width, height, title, IsEGL)
        {
			
		}
        internal X11Window(int posX, int posY, int width, int height, string title, bool isGLES)
        {
            this.s_title = title;
            this.WinState = WindowState.Normal;
			//this.lockobject = new object();

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
			
			IntPtr xLocalmods = Imports.XSetLocaleModifiers("@im=none");
			// Imports.XSynchronize(this.ptr_display, true); //It slows everything down. Use only for x11 debug
			
            this.ScreenId = Imports.XDefaultScreen(this.ptr_display);
            
			this.SwapControlSupported = VSync.SupportedVSync(this.ptr_display, this.ScreenId);

			IntPtr FBConfig = IntPtr.Zero;
			bool isEglOK = false;
			bool TrynoEGL = true;

			if (dgtk.OpenGL.OGL_SharedContext.p_SharedContext == IntPtr.Zero)
			{
				if (dgtk.OpenGL.OGL_SharedContext.InitSharedEGLContext(isGLES))
				{
					this.ptr_egldisplay = dgtk.OpenGL.OGL_SharedContext.eglDisplay;
					//#if DEBUG
						if (this.ptr_egldisplay == IntPtr.Zero)
						{
							Console.WriteLine("ERROR -> X11Window.cs: this.ptr_egldisplay is null!!");
						}
						else
						{
							isEglOK = true;
						}
					//#endif
				}
				else
				{
					//#if DEBUG
						Console.WriteLine("ERROR -> X11Window.cs: InitSharedEGLContext FAILS!!");
					//#endif
				}
			}
			if (isEglOK)
			{
				if (dgtk.Platforms.EGL.EGLPreparation.PreparationEGLContext(/*this.ptr_display, */this.ptr_egldisplay, out FBConfig))
				{
					TrynoEGL = false;
					this.ptr_rootwin = Imports.XDefaultRootWindow(this.ptr_display);
					#if DEBUG
						if (this.ptr_rootwin == IntPtr.Zero)
						{
							Console.WriteLine("ERROR -> X11Window.cs: XDefaultRootWindow FAILS!!");
						}
					#endif
				}
				else
				{
					#if DEBUG
						Console.WriteLine("ERROR -> X11Window.cs: PreparationEGLContext FAILS!!");
					#endif
				}
			}

			if (TrynoEGL)
			{
				OGLPreparation.PreparationOGLContext(this.ptr_display, this.ScreenId, ref FBConfig, out this.Visual, out this.ptr_Visual);
				this.ptr_rootwin = Imports.XRootWindow(this.ptr_display, this.Visual.screen);
			}

            this.eventMask = (EventMask.ExposureMask | EventMask.EnterWindowMask | EventMask.LeaveWindowMask | EventMask.KeyPressMask | EventMask.KeyReleaseMask | 
				EventMask.StructureNotifyMask | EventMask.FocusChangeMask | EventMask.ButtonPressMask | EventMask.ButtonReleaseMask | 
				EventMask.PropertyChangeMask | EventMask.PointerMotionMask | EventMask.SubstructureRedirectMask);

			//this.ptr_rootwin = Imports.XRootWindow(this.ptr_display, this.Visual.screen);
			
			this.XWA = new XSetWindowAttributes();
			if (TrynoEGL)
			{
				XWA.colormap = Imports.XCreateColormap(this.ptr_display, this.ptr_rootwin, this.Visual.Visual, 0);
				XWA.background_pixel  = Imports.XBlackPixel(this.ptr_display, this.Visual.screen);
				XWA.border_pixel = Imports.XWhitePixel(this.ptr_display, this.Visual.screen);
			}
			XWA.override_redirect = false;
			XWA.event_mask = (IntPtr)this.eventMask;
            
			WinValueMask wvm = (WinValueMask.BackPixmap | WinValueMask.BorderPixmap | WinValueMask.BorderPixel | WinValueMask.ColorMap | WinValueMask.EventMask | WinValueMask.BackPixel);
			
			Imports.XLockDisplay(this.ptr_display);
			if (TrynoEGL)
			{
				this.ptr_handle = Imports.XCreateWindow(this.ptr_display, this.ptr_rootwin, 0, 0, (uint)width, (uint)height, 0, (int)this.Visual.depth, CreateWindowClass.InputOutput, this.Visual.Visual, wvm, this.XWA);
			}
			else
			{
				this.ptr_handle = Imports.XCreateWindow(this.ptr_display, this.ptr_rootwin, 0, 0, (uint)width, (uint)height, 0, 0, CreateWindowClass.InputOutput, new IntPtr(0), wvm, this.XWA);
			}
			
			Imports.XStoreName(this.ptr_display, this.ptr_handle, this.s_title);

			this.RegisterEventsAtoms();
			Imports.XSelectInput(this.ptr_display, this.ptr_handle, this.eventMask);
			Imports.XMapWindow(this.ptr_display, this.ptr_handle);
			
			Imports.XUnlockDisplay(this.ptr_display);
			
			this.GetSize();

			IntPtr xglwin = TrynoEGL ? OGLPreparation.Getglxwin(this.ptr_display, FBConfig, this.ptr_handle) : dgtk.Platforms.EGL.EGLPreparation.GetEGLSurface(this.ptr_egldisplay, FBConfig, this.ptr_handle);

			if (dgtk.OpenGL.OGL_SharedContext.p_SharedContext == IntPtr.Zero)
			{
				if (TrynoEGL)
				{
					dgtk.OpenGL.OGL_SharedContext.InitSharedContext();
				}
				else
				{
					// No hacer nada por que ya estará previamente hecho.
				}
			}

			if (TrynoEGL)
			{
				this.GL_Context = OGLPreparation.GenerateOGL_Context(this.ptr_display, xglwin, ref this.Visual, dgtk.OpenGL.OGL_SharedContext.p_SharedContext, true);
			}
			else
			{
				this.GL_Context = dgtk.Platforms.EGL.EGLPreparation.GenerateEGLContext(this.ptr_egldisplay, xglwin, FBConfig, dgtk.OpenGL.OGL_SharedContext.p_SharedContext, isGLES);
			}
			this.GL_Context.X11UnMakeCurrent();

			#region XMB Events
			this.ptr_XIM = Imports.XOpenIM(this.ptr_display, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero); //Obtenemos entorno de eventos.

			long xim_style = 0;
			XIMStyles xim_styles;
			IntPtr imvalret = Imports.XGetIMValues(this.ptr_XIM, "queryInputStyle", out xim_styles, IntPtr.Zero);
			if ((imvalret != IntPtr.Zero) || (xim_styles.count_styles == 0))
			{
				throw new Exception("Error XGetIMValues: AnyStyles is Supported.");
			}
			for (int i=0;i<xim_styles.count_styles;i++)
			{
				unsafe
				{
					if (((long)xim_styles.supported_styles+i) == (/*XIMPreeditNothing*/ 8 | /*XIMStatusNothing*/ 1024))
					{
						xim_style = ((long)xim_styles.supported_styles+i);
						break;
					}
				}				
			}

			this.ptr_XIC = IntPtr.Zero;
			int XCreateIC_Count = 0;
			while(this.ptr_XIC == IntPtr.Zero)
			{
				this.ptr_XIC = Imports.XCreateIC(this.ptr_XIM, "inputStyle", xim_style, "clientWindow", this.ptr_handle, "focusWindow", this.ptr_handle, IntPtr.Zero);
				System.Threading.Thread.Sleep(1000);
				XCreateIC_Count++;
				
				#if DEBUG
					Console.WriteLine("XCreateIC try: "+XCreateIC_Count);
				#endif

				if (XCreateIC_Count >= 20)
				{
					throw new Exception("Error XCreateIC: FAIL.");
				}
			}

			/*
			this.ptr_XIC = Imports.XCreateIC(this.ptr_XIM, "inputStyle", xim_style, "clientWindow", this.ptr_handle, "focusWindow", this.ptr_handle, IntPtr.Zero);
			if (ptr_XIC == IntPtr.Zero)
			{
				throw new Exception("Error XCreateIC: FAIL.");
			}
			*/
			#endregion

			dgtk.GameControlsManager.DetectNewDevices();

			this.b_created = true;
			this.isRunning = true; //Lo quitamos del método Run() 
        }

		#region Public Methods

		public void Redraw()
		{
			isDrawing = true;
			//lock(Core.lockObject)
			//{
				if (this.GL_Context.X11MakeCurrent())
				{
					this.RenderFrame(this, new dgtk_OnRenderEventArgs());
					
					this.SwapBuffers();
					this.GL_Context.X11UnMakeCurrent();
				}
			//}
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
			this.vSyncEnabled = false;
			if (this.IsEGL)
			{
				this.vSyncEnabled = Platforms.EGL.Imports.eglSwapInterval(this.ptr_display, 1);
				this.vSyncEnabled = true;
			}
			else
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
			}
		}

		public void DisableVSync()
		{
			if (this.IsEGL)
			{
				this.vSyncEnabled = Platforms.EGL.Imports.eglSwapInterval(this.ptr_display, 0);
			}
			else
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
			this.vSyncEnabled = false;
		}

		public void Close()
		{
			this.WindowClose(this, new dgtk_WinCloseEventArgs());
			//this.OpenAL_Cntx.Dispose();
			this.isRunning = false;
		}

		public void SetIcon(int width, int height, IntPtr icon_ptr) //int width, int height, byte[] bytes)
		{
			Imports.XChangeProperty(this.ptr_display, this.Handle, this.WM_ICON, this.CARDINAL, 32, XPropsMode.PropModeReplace, icon_ptr, (width*height)+2);
			Imports.XFlush(this.ptr_display);
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
			this.WM_STATE_FULLSCREEN = Imports.XInternAtom(this.ptr_display, "_NET_WM_STATE_FULLSCREEN", false);
			this.WM_STATE_MAXIMIZED_HOR = Imports.XInternAtom(this.ptr_display, "_NET_WM_STATE_MAXIMIZED_HORZ", false);
			this.WM_STATE_MAXIMIZED_VER = Imports.XInternAtom(this.ptr_display, "_NET_WM_STATE_MAXIMIZED_VERT", false);
			this.WM_ACTION_RESIZE = Imports.XInternAtom(this.ptr_display, "_NET_WM_ACTION_RESIZE", false);
			this.WM_ICON = Imports.XInternAtom(this.ptr_display, "_NET_WM_ICON", false);
			this.CARDINAL = Imports.XInternAtom(this.ptr_display, "CARDINAL", false); // (IntPtr)(long)6
			this.WM_STATE_TOGGLE = (IntPtr)2;
			this.WM_STATE_ADD = (IntPtr)1;
			this.WM_STATE_REMOVE = (IntPtr)0;
			this.WM_ALLOWED_ACTION = Imports.XInternAtom(this.ptr_display, "_NET_WM_ALLOWED_ACTIONS", false);
			Imports.XSetWMProtocols(this.ptr_display, this.ptr_handle, new IntPtr[]{ this.WM_DELETE_WINDOW/*, this.WM_ACTION_RESIZE*/}, 1);

			Imports.XUnlockDisplay(this.ptr_display);
        }

		public void ProcessEvent(ref uint ups)
		{
			System.Collections.Generic.List<uint> KeyCodesPulsed = new System.Collections.Generic.List<uint>();
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
					//lock(Core.lockObject)
					//{
						switch(xevento.type)
						{
							case XEventType.ButtonPress:
								if (xevento.xbutton.button == 4)
								{
									//if Button4 or Button5 => WHEEL;
									this.MouseWheel(this, new dgtk_MouseWheelEventArgs(xevento.xbutton.x, xevento.xbutton.y, 1f));
								}
								else if (xevento.xbutton.button == 5)
								{
									//if Button4 or Button5 => WHEEL;
									this.MouseWheel(this, new dgtk_MouseWheelEventArgs(xevento.xbutton.x, xevento.xbutton.y, -1f));
								}
								else
								{
									this.MouseDown(this, new dgtk_MouseButtonEventArgs(xevento.xbutton.x, xevento.xbutton.y, (MouseButtons)xevento.xbutton.button, PushRelease.Push));
								}

								break;

							case XEventType.ButtonRelease:
								if ((xevento.xbutton.button > 3) && (xevento.xbutton.button < 8))
								{
									//if Button4 or Button5 => VERTICAL WHEEL;
									//if Button6 or Button7 => HORIZONTAL WHEEL;
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
								kc = EventsTools.X11key(xevento.xkey.keycode);

								if (!KeyCodesPulsed.Contains(xevento.xkey.keycode)) //Si no se ha pulsado o ya ha sido soltado.
								{
									if (kc != KeyCode.BackSpace && kc != KeyCode.Del)
									{
										KeyCodesPulsed.Add(xevento.xkey.keycode);
									}
									this.KeyPulsed(this, new dgtk_KeyBoardKeysEventArgs(new KeyBoard_Status(kc, PushRelease.Push)));
									
								}

								ulong ks = 0;
								int bsize = 8;
								IntPtr ptr_chret = Marshal.AllocHGlobal(bsize);
								int i_status=0;

								int nmb = 0;
								do
								{
									nmb  = Imports.XmbLookupString(this.ptr_XIC, ref xevento.xkey, ptr_chret, bsize -1 , ref ks, ref i_status);
									if (i_status == -1)
									{
										bsize = nmb + 1;
										ptr_chret = Marshal.AllocHGlobal(bsize);
									}
								}
								while(i_status == -1);
								
								bool Filtered = Imports.XFilterEvent(ref xevento, this.ptr_handle);

								if ((!Filtered) && (nmb>0))
								{
									if ((ks != 65293) && (ks != 65288) && (ks != 65307) && (ks != 65535) && (ks != 65289)) // Discriminar Return, Backspace, ESC, Del, Tab.
									{
										//Console.WriteLine("KS: "+ks);
										char character = System.Text.Encoding.Unicode.GetString(BitConverter.GetBytes(ks))[0];
										this.KeyCharReturned(this, new dgtk_KeyBoardTextEventArgs(character));//LANZAR EVENTO CHARACTER
									}
								}

								break;							
								
							case XEventType.KeyRelease:
								bool IsReallyReleased = true;
								kc = EventsTools.X11key(xevento.xkey.keycode);
								
								if (kc != KeyCode.BackSpace && kc != KeyCode.Del)
								{
									if (Imports.XEventsQueued(this.ptr_display, 1) > 0)
									{
										XEvent tmp_event = new XEvent();
										Imports.XPeekEvent(this.ptr_display, ref tmp_event);
										
										
										if (tmp_event.type == XEventType.KeyPress && tmp_event.xkey.time == xevento.xkey.time && tmp_event.xkey.keycode == xevento.xkey.keycode)
										{
											IsReallyReleased = false;
										}
									}
								}
								if (IsReallyReleased)
								{
									if (KeyCodesPulsed.Contains(xevento.xkey.keycode)) { KeyCodesPulsed.Remove(xevento.xkey.keycode); }
									
									this.KeyReleased(this, new dgtk_KeyBoardKeysEventArgs(new KeyBoard_Status(kc, PushRelease.Release)));
								}		
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

							case XEventType.FocusIn:
								this.b_HaveFocus = true;
								break;

							case XEventType.FocusOut:
								this.b_HaveFocus = false;
								break;

							default:
								break;
						}
					//}	
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
			int bxp_temp, grosorborde;//, x, y;
			//dgtk.Math.Vector2 v2_s = new dgtk.Math.Vector2 (this.ancho, this.alto);
			Imports.XGetGeometry(this.ptr_display, this.ptr_handle, out ventroottemp, out this.X, out this.Y, out this.ancho, out this.alto, out grosorborde, out bxp_temp);
			//if ((v2_s.X.Equals(this.ancho)) || (v2_s.Y.Equals(this.alto)))
			//{
				this.WindowSizeChange(this, new dgtk_ResizeEventArgs(this.ancho, this.alto));
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

		private void SetFullScreen(bool WhantFullScreen)
		{
			if (WhantFullScreen)
			{
				XEvent xev = new XEvent();
				xev.type = XEventType.ClientMessage;
				xev.xclient.type = XEventType.ClientMessage;
				xev.xclient.window = this.ptr_handle;
				xev.xclient.message_type = this.WM_STATE;
				xev.xclient.format = 32;
				xev.xclient.send_event = true;
				xev.xclient.puntero1 = this.WM_STATE_TOGGLE;
				xev.xclient.puntero2 = this.WM_STATE_FULLSCREEN;
				Imports.XSendEvent(this.ptr_display, this.ptr_rootwin, false, (EventMask.SubstructureRedirectMask | EventMask.SubstructureNotifyMask), ref xev);
			}
			else
			{
				XEvent xev = new XEvent();
				xev.type = XEventType.ClientMessage;
				xev.xclient.type = XEventType.ClientMessage;
				xev.xclient.window = this.ptr_handle;
				xev.xclient.message_type = this.WM_STATE;
				xev.xclient.format = 32;
				xev.xclient.send_event = true;
				xev.xclient.puntero1 = this.WM_STATE_REMOVE;
				xev.xclient.puntero2 = this.WM_STATE_FULLSCREEN;
				Imports.XSendEvent(this.ptr_display, this.ptr_rootwin, false, (EventMask.SubstructureRedirectMask | EventMask.SubstructureNotifyMask), ref xev);
			}
			this.IsInFullScreen = WhantFullScreen;
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
		/*
		public OpenAL.OAL_Context OpenAlContext
		{
			get { return this.OpenAL_Cntx; }
		}
		*/
        public IntPtr Handle
        {
            get { return this.ptr_handle; }
        }        
		/*public object LockObject
        {
            get { return this.lockobject; }
        }*/

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

		public bool FullScreen
		{
			set 
			{
				this.SetFullScreen(value);
			}
			get
			{
				return this.IsInFullScreen;
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

		public dgtk.Math.Point Position 
		{
			get{ return new dgtk.Math.Point(this.X, this.Y); } 
			set{ Imports.XMoveWindow(this.ptr_display, this.ptr_handle, value.X, value.Y); }
		}

		public bool VSyncEnabled { get { return this.vSyncEnabled; } }

		public bool HaveFocus
		{
			get { return this.b_HaveFocus; }
		}

		public bool IsGLES 
		{
			get { return this.GL_Context.IsGLES; }
		}

		#endregion
    }
}
