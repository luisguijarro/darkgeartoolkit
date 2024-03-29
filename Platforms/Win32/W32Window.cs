using System;
using System.Threading;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace dgtk.Platforms.Win32
{
    internal class W32Window : I_Window
    {
		private IntPtr DeviceC;
        private IntPtr ptr_handle;
		private IntPtr notificationHandle; // InPtr para notificaciones de cambio de dispositivos (Plug y UnPlug).
		private WndClassEx wce; // Al ponerlo aqui evitamos que se lo coma el Recolector de basura y se provoque un fallo total.
		private MSG w32msg; //Evitar al recolector de Basura en la estructura de eventos.
		private bool isRunning;
		private bool isDrawing;
		private bool b_created;
		private bool b_HaveFocus;
		//private object lockobject;
        private bool registered;
		private OpenGL.OGL_Context GL_Context;

		//private OpenAL.OAL_Context OpenAL_Cntx;

		private bool SwapControlSupported;

		private bool vSyncEnabled;

        private string s_title;
        private WindowState WinState;
		private bool IsInFullScreen;
		private Win32Rect clientrect;
		private Win32Rect winrect;
		private bool fullscreenchange; 
		private WindowStyle baseStyle;
		private ExWindowStyle ExtendStyle;
		private WindowStyle FullScreenStyle;
		private bool mouseinwindow;

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

        internal W32Window() : this(0, 0, 800, 450, "dgtk Window")
        {

        }
        internal W32Window(int width, int height, string title) : this(0, 0, width, height, title)
        {

        }
        internal W32Window(int posX, int posY, int width, int height, string title)
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


            IntPtr mTitle = Marshal.StringToHGlobalAuto(title);
            string s_guid = Guid.NewGuid().ToString();
            IntPtr mClassName = Marshal.StringToHGlobalAuto(s_guid);
            IntPtr mInstancia = Marshal.GetHINSTANCE(typeof(W32Window).Module);
            this.baseStyle = ( WindowStyle.Visible | WindowStyle.Overlapped | WindowStyle.Caption |WindowStyle.SystemMenu | WindowStyle.ThickFrame | WindowStyle.MinimizeBox | WindowStyle.MaximizeBox | WindowStyle.ClipChildren | WindowStyle.ClipSiblings | WindowStyle.Border);
            this.ExtendStyle = (ExWindowStyle.WS_EX_APPWINDOW | ExWindowStyle.WS_EX_WINDOWEDGE);
			this.FullScreenStyle = WindowStyle.ClipSiblings | WindowStyle.Visible | WindowStyle.Overlapped;

			this.clientrect = new Win32Rect();
			this.clientrect.left = posX; 
			this.clientrect.top = posY; 
			this.clientrect.right = (int)(posX + width); 
			this.clientrect.bottom = (int)(posY + height);
			if (Imports.AdjustWindowRectEx(ref this.clientrect, baseStyle, false, ExtendStyle))
			{
				//Console.WriteLine("Ajustado");
			}
			
			if (!this.registered)
			{
				this.wce = new WndClassEx();
				this.wce.Size = WndClassEx.SizeInBytes;
				this.wce.Style = WinClassStyle.OwnDC | WinClassStyle.HRedraw | WinClassStyle.VRedraw;
				this.wce.Instance = mInstancia;
				this.wce.WndProc = WinProcDelegate;
				this.wce.ClassName = mClassName;
				this.wce.Background = IntPtr.Zero;
				//wce.Icon = IntPtr.Zero;
				//wce.IconSm = IntPtr.Zero;
				this.wce.Cursor = Imports.LoadCursor(CursorName.Arrow);
				ushort atom = Imports.RegisterClassEx(ref this.wce);
				if (atom == 0)
				{
					throw new Exception(String.Format("Failed to register window class. Error: {0}", Marshal.GetLastWin32Error()));
				}
				this.registered = true;
			}

		#if DEBUG
			try
			{			
		#endif
				this.ptr_handle = Imports.CreateWindowEx(ExtendStyle, mClassName, mTitle, baseStyle, clientrect.left, clientrect.top, clientrect.right-clientrect.left, clientrect.bottom-clientrect.top, IntPtr.Zero, IntPtr.Zero, mInstancia, IntPtr.Zero);
				
				Imports.GetClientRect(this.ptr_handle, out this.clientrect);

				Imports.SetForegroundWindow(this.ptr_handle); //Mejorar la prioridad de la ventana.
				Imports.SetFocus(this.ptr_handle);			
				Imports.ShowWindow(this.ptr_handle, showCmd.SW_SHOW);
				Imports.UpdateWindow(this.ptr_handle);
		#if DEBUG
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw new Exception(String.Format("Error: {0} - Fallo en la Creación de la Ventana.", Marshal.GetLastWin32Error()));
			}
		#endif
			if (this.ptr_handle == IntPtr.Zero)
			{
				throw new Exception(String.Format("Error: {0} - Fallo en la Creación de la Ventana.", Marshal.GetLastWin32Error()));
			}

			#region Registrar EVentos de Plug y Unplug para esta ventana.

			DevBroadcastDeviceinterface dbi = new DevBroadcastDeviceinterface
			{
				DeviceType = 5,
				Reserved = 0,
				ClassGuid = new Guid("A5DCBF10-6530-11D2-901F-00C04FB951ED"),
				Name = 0
			};

			IntPtr dbibuffer = Marshal.AllocHGlobal(Marshal.SizeOf(dbi));
			Marshal.StructureToPtr(dbi, dbibuffer, true);

			notificationHandle = Imports.RegisterDeviceNotification(this.ptr_handle, dbibuffer, 0);

			#endregion

			#region Registrar Eventos Input

			RAWINPUTDEVICE[] RID = new RAWINPUTDEVICE[2];
			RID[0] = new RAWINPUTDEVICE
			{
				usUsagePage = (ushort)dgtk.GameControlSystem.Windows.HIDUsagePage.Generic,
				usUsage = (ushort)dgtk.GameControlSystem.Windows.HIDUsage.Joystick,
				dwFlags = (uint)(RawInputDeviceFlags.InputSink | RawInputDeviceFlags.DevNotify),
				hwndTarget = this.ptr_handle
			};
			RID[1] = new RAWINPUTDEVICE
			{
				usUsagePage = (ushort)dgtk.GameControlSystem.Windows.HIDUsagePage.Generic,
				usUsage = (ushort)dgtk.GameControlSystem.Windows.HIDUsage.Gamepad,
				dwFlags = (uint)(RawInputDeviceFlags.InputSink | RawInputDeviceFlags.DevNotify),
				hwndTarget = this.ptr_handle
			};

			if (!Imports.RegisterRawInputDevices(RID, 2, Marshal.SizeOf(typeof(RAWINPUTDEVICE))))
			{
				throw new Exception("What the fuck!!!");
			}

			#endregion

			#region OpenGL Context
			
			OGLPreparation.PreparationOGLContext(this.ptr_handle, 32, 24, out DeviceC);
			this.GL_Context = OGLPreparation.GenerateOGLContext(DeviceC);
			this.GL_Context.Win32MakeCurrent();
			this.SwapControlSupported = VSync.SupportedVSync();
			this.GL_Context.Win32UnMakeCurrent();

			#endregion

			//this.OpenAL_Cntx = new OpenAL.OAL_Context();

			dgtk.GameControlsManager.DetectNewDevices();
			
			this.b_created = true;
            this.isRunning = true;
        }

		#region Public Methods

		public void Redraw()
		{
			isDrawing = true;
			lock(Core.lockObject) //this.lockobject)
			{
				if (this.GL_Context.Win32MakeCurrent())
				{
				
					this.RenderFrame(this, new dgtk_OnRenderEventArgs());

					this.SwapBuffers();
					this.GL_Context.Win32UnMakeCurrent();
				}
			}
			isDrawing = false;
		}
		public bool MakeCurrent()
		{
			return this.GL_Context.Win32MakeCurrent();
		}
		public bool UnMakeCurrent()
		{
			return this.GL_Context.Win32UnMakeCurrent();
		}
		public void SwapBuffers()
		{
			this.GL_Context.Win32SwapBuffers();
		}

		public void EnableVSync()
		{
			if (this.SwapControlSupported) { wgl.wglSwapIntervalEXT(1); this.vSyncEnabled = true; }
		}

		public void DisableVSync()
		{
			if (this.SwapControlSupported) { wgl.wglSwapIntervalEXT(0); this.vSyncEnabled = false; }
		}

		public void Close()
		{
			this.WindowClose(this, new dgtk_WinCloseEventArgs());
			//this.OpenAL_Cntx.Dispose();
			Imports.UnregisterDeviceNotification(this.notificationHandle);
			this.isRunning = false;
		}
		public void SetIcon(int width, int height, IntPtr icon_ptr)
		{
			Imports.SendMessage(this.Handle, 0x0080, (IntPtr)0, icon_ptr);
			Imports.SendMessage(this.Handle, 0x0080, (IntPtr)1, icon_ptr);
		}
		#endregion

		public void ProcessEvent(ref uint ups)
		{
			this.w32msg = new MSG();
			dgtk.GameControlsManager.DetectNewDevices(); // Puesto aquí para las pruebas.
			
			while(this.isRunning)
			{				
				DateTime dt_ini = DateTime.Now;

				//int GetMsgResult;                
				//while((GetMsgResult = Imports.GetMessage(ref w32msg, this.ptr_handle, 0, 0)) > 0)
				while(Imports.PeekMessage(ref w32msg, new IntPtr(0), 0, 0, 0x0001)) // 0x0001 es REMOVE.
				{
					Imports.TranslateMessage(ref w32msg); 
					Imports.DispatchMessage(ref w32msg); 
				}
				TimeSpan retraso = DateTime.Now - dt_ini;
				if (retraso.TotalMilliseconds < (1f/(float)ups)*1000f)
				{
					Thread.Sleep((int)(((1f/(float)ups)*1000f)-retraso.TotalMilliseconds));
				}
            }
			while(this.isDrawing){ /* WAIT FOR RENDER: Avoid crash in close */}
			this.GL_Context.Dispose();
			Imports.DestroyWindow(this.ptr_handle);
			//Thread.CurrentThread.Abort();
		}

        IntPtr WinProcDelegate(IntPtr handle, WindowMessage msg, IntPtr wParam, IntPtr lParam)
		{
			KeyCode kc;
            switch(msg)
			{
				case WindowMessage.ERASEBKGND:
					return new IntPtr(1);
				case WindowMessage.INPUT_DEVICE_CHANGE:
				    if (wParam.ToInt64() == 1) // Conexión
                    {
						#if DEBUG
                    		Console.WriteLine("Plug HID Handle: "+lParam.ToInt64());
						#endif
                    	//dgtk.GameControlSystem.Windows.GMSystem.AddInputDevice(lParam);
                    	dgtk.GameControlSystem.Windows.GMSystem.RefreshDeviceList();
                    }
                    if (wParam.ToInt64() == 2) // Desconexión
                    {
						#if DEBUG
                    		Console.WriteLine("UnPlug HID Handle: "+lParam.ToInt64());
						#endif
                    	//dgtk.GameControlSystem.Windows.GMSystem.RemoveInputDevice(lParam);
                    	dgtk.GameControlSystem.Windows.GMSystem.RefreshDeviceList();
                    }
                    break;

				case WindowMessage.INPUT:
					uint pcbsize=0;
					int result;
                    if ((result = Imports.GetRawInputData(lParam, GetRawInputData_Command.RID_INPUT, IntPtr.Zero, ref pcbsize, Marshal.SizeOf(typeof(RawInputHeader)))) < 0)
                    { 
						break;                  	
                    }
					RawInput ri;
					if (Imports.GetRawInputData(lParam, GetRawInputData_Command.RID_INPUT, out ri, ref pcbsize, Marshal.SizeOf(typeof(RawInputHeader))) < 0)
					{
						break;
					}
					dgtk.GameControlSystem.Windows.GMSystem.SetGameControlDevice_Status(ri);
					break;

				case WindowMessage.LBUTTONDOWN:				
					this.MouseDown(this, new dgtk_MouseButtonEventArgs((int)unchecked((short)(long)lParam), (int)unchecked((short)((long)lParam >> 16)), MouseButtons.Left, PushRelease.Push));
					break;
				case WindowMessage.MBUTTONDOWN:	
					this.MouseDown(this, new dgtk_MouseButtonEventArgs((int)unchecked((short)(long)lParam), (int)unchecked((short)((long)lParam >> 16)), MouseButtons.Center, PushRelease.Push));				
					break;
				case WindowMessage.RBUTTONDOWN:	
					this.MouseDown(this, new dgtk_MouseButtonEventArgs((int)unchecked((short)(long)lParam), (int)unchecked((short)((long)lParam >> 16)), MouseButtons.Right, PushRelease.Push));				
					break;
				case WindowMessage.LBUTTONUP:
					this.MouseUp(this, new dgtk_MouseButtonEventArgs((int)unchecked((short)(long)lParam), (int)unchecked((short)((long)lParam >> 16)), MouseButtons.Left, PushRelease.Release));
					break;
				case WindowMessage.MBUTTONUP:
					this.MouseUp(this, new dgtk_MouseButtonEventArgs((int)unchecked((short)(long)lParam), (int)unchecked((short)((long)lParam >> 16)), MouseButtons.Center, PushRelease.Release));
					break;
				case WindowMessage.RBUTTONUP:
					this.MouseUp(this, new dgtk_MouseButtonEventArgs((int)unchecked((short)(long)lParam), (int)unchecked((short)((long)lParam >> 16)), MouseButtons.Right, PushRelease.Release));
					break;
				case WindowMessage.MOUSEWHEEL:
					ushort wheelValue = (ushort)((((long)wParam.ToInt64()) >> 0x10) & 0xffff);
					if (wheelValue<=120)
					{
						this.MouseWheel(this, new dgtk_MouseWheelEventArgs((int)unchecked((short)(long)lParam), (int)unchecked((short)((long)lParam >> 16)), 1f));
					}
					else
					{
						this.MouseWheel(this, new dgtk_MouseWheelEventArgs((int)unchecked((short)(long)lParam), (int)unchecked((short)((long)lParam >> 16)), -1f));
					}
					break;
				case WindowMessage.MOUSEMOVE:
					int x = (int)(lParam.ToInt32() & 0x0000FFFF);
					int y = (int)((lParam.ToInt32() & 0xFFFF0000)>>16);
					Point scp;
					Imports.GetCursorPos(out scp);
					this.MouseMove(this, new dgtk_MouseMoveEventArgs(x, y, scp.X, scp.Y));					
					
					//Simulate ENTER & LEAVE mouse Event
					TRACKMOUSEEVENT tme0 = new TRACKMOUSEEVENT();
					tme0.cbSize = (uint)Marshal.SizeOf(tme0);
					tme0.hwndTrack = this.Handle;
					tme0.dwHoverTime = 10;
					tme0.dwFlags = (0x00000001 | 0x00000002);  //MOUSE ENTER & LEAVE
					Imports.TrackMouseEvent(ref tme0);
					break;
				
				case WindowMessage.MOUSEHOVER: //MouseEnter
					if (!this.mouseinwindow)
					{
						this.mouseinwindow = true;
						this.MouseEnter(this, new dgtk_MouseEnterLeaveEventArgs(EnterLeave.Enter));
					}
					break;
					
				case WindowMessage.MOUSELEAVE:
					this.mouseinwindow = false;
					this.MouseLeave(this, new dgtk_MouseEnterLeaveEventArgs(EnterLeave.Leave));
					break;
									
				case WindowMessage.CHAR: //wParam es ASCII CODE
					if ((wParam.ToInt32() != 8) && (wParam.ToInt32() != 9) && (wParam.ToInt32() != 13) && (wParam.ToInt32() != 27)) // Discriminar Return, Tab, Backspace y ESC
					{
						this.KeyCharReturned(this, new dgtk_KeyBoardTextEventArgs((char)wParam));
					} 
					return IntPtr.Zero; 
					
				case WindowMessage.KEYDOWN: //wParam es VIRTUAL KEY CODE
					kc = EventsTools.Winkey(lParam.ToInt64());
					this.KeyPulsed(this, new dgtk_KeyBoardKeysEventArgs(new KeyBoard_Status(kc, PushRelease.Push)));
					break;
					
				case WindowMessage.KEYUP: //wParam es VIRTUAL KEY CODE
					kc = EventsTools.Winkey(lParam.ToInt64());
					this.KeyReleased(this, new dgtk_KeyBoardKeysEventArgs(new KeyBoard_Status(kc, PushRelease.Release)));
					break;

                case WindowMessage.SIZE:
					if (!this.fullscreenchange) //Si el cambio no está motivado por FullScreen cambiamos estado.
					{						
						if (wParam.ToInt64() == 0)
						{
							if(this.WinState != WindowState.Normal)
							{
								this.WinState = WindowState.Normal;
								this.WindowStateChange(this, new dgtk_WinStateChangeEventArgs(this.WinState));
							}
						}
						if (wParam.ToInt64() == 1)
						{
							if(this.WinState != WindowState.Minimized)
							{
								this.WinState = WindowState.Minimized;
								this.WindowStateChange(this, new dgtk_WinStateChangeEventArgs(this.WinState));
							}
						}
						if (wParam.ToInt64() == 2)
						{
							if (this.WinState != WindowState.Maximized)
							{
								this.WinState = WindowState.Maximized;
								this.WindowStateChange(this, new dgtk_WinStateChangeEventArgs(this.WinState));
							}
						}
					}
					else
					{
						this.fullscreenchange = false;
					}
					
					Imports.GetClientRect(this.ptr_handle, out this.clientrect);
					int ancho = this.clientrect.right-this.clientrect.left;
					int alto = this.clientrect.bottom-this.clientrect.top;	
                    this.WindowSizeChange(this, new dgtk_ResizeEventArgs(ancho, alto));
                    break; //return new IntPtr(0);
				
                case WindowMessage.MOVE:
					Imports.GetClientRect(this.ptr_handle, out this.clientrect);
					return new IntPtr(0);
				case WindowMessage.KILLFOCUS:
					this.b_HaveFocus = false;
					break;
				case WindowMessage.SETFOCUS:
					this.b_HaveFocus = true;
					break;
            }
			if ((msg == WindowMessage.CLOSE) && (wParam != new IntPtr(1)))
            {
				this.Close();
				return  Imports.DefWindowProcW(handle, msg, wParam, lParam);
            } 
            return  Imports.DefWindowProcW(handle, msg, wParam, lParam);
        }

		private void SetFullScreen(bool WhantFullScreen)
		{
			if (WhantFullScreen != this.IsInFullScreen)
			{

				if (WhantFullScreen)
				{
					Imports.GetWindowRect(this.Handle, out this.winrect);  // Obtenemos tamaño de la Ventana con marcos y todo

					Win32Rect Fullrect; // = new Win32Rect();
					IntPtr desktop = Imports.GetDesktopWindow();
					Imports.GetWindowRect(desktop, out Fullrect); // Obtenemos tamaño del escritorio.

					WindowState winstate_temp = this.WinState; // conservamos estado previo de ventana. SetWindowPos lo establece siempre en normal.

					this.fullscreenchange = true;

					Imports.SetWindowLong(this.ptr_handle, -16/*GWL_STYLE*/, (uint)this.FullScreenStyle);
					Imports.SetWindowPos(this.ptr_handle, IntPtr.Zero, Fullrect.left, Fullrect.top, Fullrect.right-Fullrect.left, Fullrect.bottom-Fullrect.top, 0); //(0x0001 | 0x0002 | 0x0004 | 0x0200));
				}
				else
				{
					this.fullscreenchange = true;

					WindowState winstate_temp = this.WinState;

					Imports.SetWindowLong(this.ptr_handle, -16/*GWL_STYLE*/, (uint)this.baseStyle); //Lo ponemos aquí para evitar reescalado.
					Imports.SetWindowPos(this.ptr_handle, IntPtr.Zero, this.winrect.left, this.winrect.top, this.winrect.right-this.winrect.left, this.winrect.bottom-this.winrect.top, 0); //(0x0001 | 0x0002 | 0x0004 | 0x0200));
					Imports.SetWindowLong(this.ptr_handle, -16/*GWL_STYLE*/, (uint)this.baseStyle); //Lo ponemos aquí para evitar reescalado.
					
					this.WindowState = this.WindowState; //Restore Preview State
				}
				this.IsInFullScreen = WhantFullScreen;
			}
		}

        public string Title
        {
            get { return this.s_title;}
            set { this.s_title = value; Imports.SetWindowText(this.Handle, this.s_title);}
        }

        public IntPtr Handle
        {
            get { return this.ptr_handle; }
        }

		public dgtk.Math.Size Size
		{
			set 
			{
				lock(Core.lockObject)
				{
					this.clientrect.right = this.clientrect.left+value.Width;
					this.clientrect.bottom = this.clientrect.top+value.Height;

					this.winrect = this.clientrect;
					if (Imports.AdjustWindowRectEx(ref this.winrect, this.baseStyle, false, this.ExtendStyle))
					{						
						#if DEBUG
						Console.WriteLine("Ajustado (Size)");
						#endif
					}
					Imports.SetWindowPos(this.ptr_handle, IntPtr.Zero, 0, 0, this.winrect.right-this.winrect.left, this.winrect.bottom-this.winrect.top, (0x0004 | 0x0002/*NO_MOVE*/ | 0x0200));
				}
			}
			get 
			{				
				return new dgtk.Math.Size(this.clientrect.right-this.clientrect.left, this.clientrect.bottom-this.clientrect.top); 
			}
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
						Imports.ShowWindow(this.ptr_handle, 2);
						break;
					case WindowState.Maximized:
						Imports.ShowWindow(this.ptr_handle, 3);
						break;
					case WindowState.Normal:
						Imports.ShowWindow(this.ptr_handle, 1);
						break;
				}
				this.WinState = value;
			}
		}

		public bool FullScreen
		{
			set 
			{
				if (value != this.IsInFullScreen)
				{
					this.SetFullScreen(value);
				}
			}
			get
			{
				return this.IsInFullScreen;
			}
		}

		public bool Created {get{return b_created;}}
		public bool IsRunning 
		{
			get { bool ret; lock(Core.lockObject){ret = this.isRunning; }return ret; }
			set { this.isRunning = value;}
		}	

		public dgtk.Math.Point Position 
		{
			get{ return new dgtk.Math.Point(this.winrect.left, this.winrect.top); } 
			set
			{
				lock(Core.lockObject)
				{
					this.clientrect.right += value.X - this.clientrect.left;
					this.clientrect.bottom += value.Y - this.clientrect.top;
					this.clientrect.left = value.X;
					this.clientrect.top = value.Y;
					this.winrect = this.clientrect;
					if (Imports.AdjustWindowRectEx(ref this.winrect, this.baseStyle, true, this.ExtendStyle))
					{
						#if DEBUG
						Console.WriteLine("Ajustado (Position)");
						#endif
					}
					Imports.SetWindowPos(this.ptr_handle, IntPtr.Zero, this.winrect.left, this.winrect.top, 0, 0, (0x0004 | 0x0001/*NO_RESIZE*/ | 0x0200));
				}
			}
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


    }
}
