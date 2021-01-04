using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace dgtk.Platforms.Win32
{
    internal class W32Dummy : IDisposable
    {
        internal IntPtr Handle;	
        //private MSG win32msg;

        [DllImport("uxtheme", ExactSpelling = true, CharSet = CharSet.Unicode)]
        internal extern static Int32 SetWindowTheme (IntPtr hWnd, String textSubAppName, String textSubIdList);
        public W32Dummy()
        {
            IntPtr mInstancia = Marshal.GetHINSTANCE(typeof(W32Dummy).Module);
			IntPtr mClassName = Marshal.StringToHGlobalAuto(Guid.NewGuid().ToString()+"Dummy"); 
			WndClassEx wce;
			wce = new WndClassEx();
			wce.Size = WndClassEx.SizeInBytes;
			wce.Style = WinClassStyle.OwnDC;
			wce.Instance = mInstancia;
			wce.WndProc = this.WinProcDelegate;
			wce.ClassName = mClassName;
            ushort atom = Imports.RegisterClassEx(ref wce);
            if (atom == 0)
	        {
	          	throw new Exception(String.Format("Failed to register window class. Error: {0}", Marshal.GetLastWin32Error()));
	        }
			try
			{
				this.Handle = Imports.CreateWindowEx((ExWindowStyle.WS_EX_APPWINDOW | ExWindowStyle.WS_EX_WINDOWEDGE), 
                                mClassName, 
                                Marshal.StringToHGlobalAuto("DummyWindow"), 
                                (WindowStyle.Disabled),
                                0, 0, 256, 256, 
                                IntPtr.Zero, 
                                IntPtr.Zero, 
                                mInstancia, 
                                IntPtr.Zero);
				
				SetWindowTheme(this.Handle, " ", " ");
				
				if (this.Handle == IntPtr.Zero)
				{
					Console.WriteLine("FAIL! in Dummy Window Creation.");
				}
				//this.DummyHilo = Thread.CurrentThread;
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw new Exception(String.Format("Error: {0} - FAIL! in Dummy Window Creation.", new Win32Exception(Marshal.GetLastWin32Error()).Message));
			}
        }
        IntPtr WinProcDelegate(IntPtr handle, WindowMessage msg, IntPtr wParam, IntPtr lParam)
		{
            return Imports.DefWindowProcW(handle, msg, wParam, lParam);
        }

		public void Dispose()
		{
			Win32.Imports.DestroyWindow(this.Handle);
			GC.SuppressFinalize(this);
		}
    }
}