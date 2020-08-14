using System;
using System.Threading;
using System.Diagnostics;

namespace dgtk
{
    public class DGTK_Window
    {
        private Platforms.I_Window NativeWindow;

        private Thread th_redraw; //Thread for Render Proccess.
        private Thread th_update; //Thre for updates Proccess.
        private Thread th_window; //Thread for the Window Events and proccess.

        private uint f_fps; // Reference for Frames per Second.
        private uint f_ups; // Reference for Updates per Second.

        #region Attribute Events
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
        public event EventHandler<dgtk_OnUpdateEventArgs> UpdateFrame;
        public event EventHandler<dgtk_OnRenderEventArgs> RenderFrame;
        #endregion

        public DGTK_Window() : base()
        {
            
        }


        public DGTK_Window(uint Width, uint Height, string Title)
        {

        }


        private void initWindow(object @params)
        {
            th_params winparam = (th_params)@params;
            switch(Platforms.Tools.GetPlatform())
            {
                case Platforms.Platform.Windows:
                    this.NativeWindow = new Platforms.Win32.W32Window(50, 50, winparam.Width, winparam.Height, winparam.Title);
                    break;
                case Platforms.Platform.Linux_X11:
                    this.NativeWindow = new Platforms.X11.X11Window(50, 50, winparam.Width, winparam.Height, winparam.Title);
                    break;
                case Platforms.Platform.Linux_Wayland:
                    this.NativeWindow = new Platforms.X11.X11Window(50, 50, winparam.Width, winparam.Height, winparam.Title); //Implementar Wayland
                    break;
                default:
                throw new Exception("Operating System Not Supported");
            }

            this.WindowClose += delegate {};
            this.WindowSizeChange += delegate {};
            this.WindowStateChange += delegate {};
            this.KeyPulsed += delegate {};
            this.KeyReleased += delegate {};
            this.KeyCharReturned += delegate {};
            this.MouseDown += delegate {};
            this.MouseUp += delegate {};
            this.MouseMove += delegate {};
            this.MouseWheel += delegate {};
            this.MouseEnter += delegate {};
            this.MouseLeave += delegate {};
			this.UpdateFrame += delegate { };
			this.RenderFrame += delegate { };
/*
            this.NativeWindow.WindowClose += NativeWindowClose;
            this.NativeWindow.WindowSizeChange += NativeWindowSizeChange;
            this.NativeWindow.WindowStateChange += NativeWindowStateChange;
            this.NativeWindow.KeyPulsed += NativeWindowKeyPulsed;
            this.NativeWindow.KeyReleased += NativeWindowKeyReleased;
            this.NativeWindow.KeyCharReturned += NativeWindowKeyCharReturned;
            this.NativeWindow.MouseDown += NativeWindowMouseDown;
            this.NativeWindow.MouseUp += NativeWindowMouseUp;
            this.NativeWindow.MouseMove += NativeWindowMouseMove;
            this.NativeWindow.MouseWheel += NativeWindowMouseWheel;
            this.NativeWindow.MouseEnter += NativeWindowMouseEnter;
            this.NativeWindow.MouseLeave += NativeWindowMouseLeave;
            this.NativeWindow.RenderFrame += NativeRenderFrame;
*/
            while(!this.NativeWindow.IsRunning)
            {
                Thread.Sleep(1000);
            }
            Process.GetCurrentProcess().ProcessorAffinity = (IntPtr)15;
            this.ProcessEvents();
        }

        private void ProcessEvents()
        {
            this.NativeWindow.ProcessEvent(500); // No use Full CPU core
        }

    }
}
