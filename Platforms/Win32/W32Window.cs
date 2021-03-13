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
		//private object lockobject;
        private bool registered;
		private OpenGL.OGL_Context GL_Context;

		private OpenAL.OAL_Context OpenAL_Cntx;

		private bool SwapControlSupported;

		private bool vSyncEnabled;

        private string s_title;
        private WindowState WinState;
		private Win32Rect rect;
		private WindowStyle baseStyle;
		private ExWindowStyle ExtendStyle;
		private bool mouseinwindow;

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

        internal W32Window() : this(0, 0, 800, 450, "dgtk Window")
        {

        }
        internal W32Window(uint width, uint height, string title) : this(0, 0, width, height, title)
        {

        }
        internal W32Window(int posX, int posY, uint width, uint height, string title)
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
            this.baseStyle = ( WindowStyle.Overlapped | WindowStyle.Caption |WindowStyle.SystemMenu | WindowStyle.ThickFrame | WindowStyle.MinimizeBox | WindowStyle.MaximizeBox | WindowStyle.ClipChildren | WindowStyle.ClipSiblings | WindowStyle.Border);
            this.ExtendStyle = (ExWindowStyle.WS_EX_APPWINDOW | ExWindowStyle.WS_EX_WINDOWEDGE);

			this.rect = new Win32Rect();
			this.rect.left = posX; 
			this.rect.top = posY; 
			this.rect.right = (int)(posX + width); 
			this.rect.bottom = (int)(posY + height);
			if (Imports.AdjustWindowRectEx(ref this.rect, baseStyle, false, ExtendStyle))
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
				this.ptr_handle = Imports.CreateWindowEx(ExtendStyle, mClassName, mTitle, baseStyle, rect.left, rect.top, rect.right-rect.left, rect.bottom-rect.top, IntPtr.Zero, IntPtr.Zero, mInstancia, IntPtr.Zero);
				
				Imports.GetClientRect(this.ptr_handle, out this.rect);

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

			this.OpenAL_Cntx = new OpenAL.OAL_Context();
			
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
			this.OpenAL_Cntx.Dispose();
			Imports.UnregisterDeviceNotification(this.notificationHandle);
			this.isRunning = false;
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
            	case WindowMessage.NCACTIVATE:
            		return new IntPtr(0); // Evitar crashes.
				case WindowMessage.ERASEBKGND:
					return new IntPtr(1);
				case WindowMessage.INPUT_DEVICE_CHANGE:
				    if (wParam.ToInt64() == 1)
                    {
						#if DEBUG
                    		Console.WriteLine("Plug HID Handle: "+lParam.ToInt64());
						#endif
                    	dgtk.GameControlSystem.Windows.GMSystem.AddInputDevice(lParam);
                    }
                    if (wParam.ToInt64() == 2)
                    {
						#if DEBUG
                    		Console.WriteLine("UnPlug HID Handle: "+lParam.ToInt64());
						#endif
                    	dgtk.GameControlSystem.Windows.GMSystem.RemoveInputDevice(lParam);
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
					if (wParam.ToInt64()>=0)
					{
						this.MouseWheel(this, new dgtk_MouseWheelEventArgs(1f));
					}
					else
					{
						this.MouseWheel(this, new dgtk_MouseWheelEventArgs(-1f));
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
					if ((wParam.ToInt32() != 8) && (wParam.ToInt32() != 13) &&(wParam.ToInt32() != 27)) // Discriminar Return, Backspace y ESC
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
					Imports.GetClientRect(this.ptr_handle, out this.rect);
					int ancho = this.rect.right-this.rect.left;
					int alto = this.rect.bottom-this.rect.top;	
                    this.WindowSizeChange(this, new dgtk_WinResizeEventArgs(ancho, alto));
                    return new IntPtr(0);
            }
			if ((msg == WindowMessage.CLOSE) && (wParam != new IntPtr(1)))
            {
				this.Close();
				return  Imports.DefWindowProcW(handle, msg, wParam, lParam);
            } 
            return  Imports.DefWindowProcW(handle, msg, wParam, lParam);
        }

        public string Title
        {
            get { return this.s_title;}
            set { this.s_title = value; Imports.SetWindowText(this.Handle, this.s_title);}
        }
		public OpenAL.OAL_Context OpenAlContext
		{
			get { return this.OpenAL_Cntx; }
		}
        public IntPtr Handle
        {
            get { return this.ptr_handle; }
        } 
		/*
		public object LockObject
        {
            get { return this.lockobject; }
        }
		*/
		public dgtk.Math.Size Size
		{
			set 
			{
				lock(Core.lockObject) //this.lockobject)
				{
					this.rect.right = this.rect.left+value.Width;
					this.rect.bottom = this.rect.top+value.Height;
					if (Imports.AdjustWindowRectEx(ref this.rect, this.baseStyle, true, this.ExtendStyle))
					{
						Console.WriteLine("Ajustado");
					}
					Imports.SetWindowPos(this.ptr_handle, IntPtr.Zero, this.rect.left, this.rect.top, this.rect.right-this.rect.left, this.rect.bottom-this.rect.top, (0x0004 | 0x0002 | 0x0200));
				}
			}
			get 
			{				
				return new dgtk.Math.Size(this.rect.right-this.rect.left, this.rect.bottom-this.rect.top); 
			}
		}
		public bool Created {get{return b_created;}}
		public bool IsRunning 
		{
			get { bool ret; lock(Core.lockObject/*this.lockobject*/){ret = this.isRunning; }return ret; }
			set { this.isRunning = value;}
		}	
		public bool VSyncEnabled { get { return this.vSyncEnabled; } }
    }
}
