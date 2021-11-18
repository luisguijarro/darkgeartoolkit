using System;

namespace dgtk.Platforms
{
    internal interface I_Window
    {
        string Title {get; set;}
        IntPtr Handle { get; }
		bool IsRunning {get; set;}
        event EventHandler<dgtk_WinCloseEventArgs> WindowClose;
		event EventHandler<dgtk_ResizeEventArgs> WindowSizeChange;
		event EventHandler<dgtk_WinStateChangeEventArgs> WindowStateChange;
		event EventHandler<dgtk_KeyBoardKeysEventArgs> KeyPulsed;
		event EventHandler<dgtk_KeyBoardKeysEventArgs> KeyReleased;
		event EventHandler<dgtk_KeyBoardTextEventArgs> KeyCharReturned;
		event EventHandler<dgtk_MouseButtonEventArgs> MouseDown;
		event EventHandler<dgtk_MouseButtonEventArgs> MouseUp;
		event EventHandler<dgtk_MouseMoveEventArgs> MouseMove;
		event EventHandler<dgtk_MouseWheelEventArgs> MouseWheel;
		event EventHandler<dgtk_MouseEnterLeaveEventArgs> MouseEnter;
		event EventHandler<dgtk_MouseEnterLeaveEventArgs> MouseLeave;
		event EventHandler<dgtk_OnRenderEventArgs> RenderFrame;
		void ProcessEvent(ref uint ups);	
		bool MakeCurrent();		
		bool UnMakeCurrent();		
		void SwapBuffers();
		void Redraw();
		void SetIcon(int width, int height, IntPtr icon_ptr);
		dgtk.Math.Size Size {get; set;}
		dgtk.Math.Point Position {get; set;}
		WindowState WindowState {get; set;}
		void Close();
		bool Created {get;}
		void EnableVSync();
		void DisableVSync();
		bool VSyncEnabled {get;}
		//OpenAL.OAL_Context OpenAlContext { get; }
    }
}