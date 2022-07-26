using System;
using System.Reflection;
using System.Threading;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;

using SkiaSharp;

namespace dgtk
{
    public class dgtk_Window
    {
        private Platforms.I_Window NativeWindow;

        private Thread th_redraw; //Hilo dedicado al renderizado.
        private Thread th_update; //Hilo dedicado a las actualizaciones.
        private Thread th_window; //Hilo dedicado al procesamiento de la ventana nativa del sistema.

        private uint ui_fps; // Fotogramas por Segundo (ESTABLECIDOS).
        private uint ui_ups; // Actualizaciones por segundo (ESTABLECIDAS).
        private uint ui_ueps; // Actualizaciones de eventos por segundo (ESTABLECIDAS).

        private DateTime dt_lastTime; //último momento de registro de segundo para cálculos.

        private uint ui_c_fps; // Fotogramas por Segundo (CALCULADOS).
        private uint ui_c_fps_show; // Fotogramas por Segundo (CALCULADOS).

        private int i_minWidth;
        private int i_minHeight;

        #region Attribute Events
		public event EventHandler<dgtk_WinCloseEventArgs> WindowClose; // Evento de cierre de Ventana
        public event EventHandler<dgtk_ResizeEventArgs> WindowSizeChange; // Evento de cambio de tamaño de Ventana
		public event EventHandler<dgtk_WinStateChangeEventArgs> WindowStateChange; // Evento de cambio de estado de una ventana
		public event EventHandler<dgtk_KeyBoardKeysEventArgs> KeyPulsed; // Evento que se da cuando se pulsa una tecla del teclado.
		public event EventHandler<dgtk_KeyBoardKeysEventArgs> KeyReleased; // Evento que se da cuando se suelta una tecla del teclado.
		public event EventHandler<dgtk_KeyBoardTextEventArgs> KeyCharReturned; // Evento devuelto cuando se pulsa o se suelta una tecla y que devuelve el caracter asociado.
		public event EventHandler<dgtk_MouseButtonEventArgs> MouseDown; // Evento que se da cuando se pulsa un botón del ratón.
		public event EventHandler<dgtk_MouseButtonEventArgs> MouseUp; // Evento que se da cuando se suelta un botón del ratón.
		public event EventHandler<dgtk_MouseMoveEventArgs> MouseMove; // Evento que se da cuando el ratón se mueve.
		public event EventHandler<dgtk_MouseWheelEventArgs> MouseWheel; // Evento que se da cuando se acciona la rueda del ratón.
		public event EventHandler<dgtk_MouseEnterLeaveEventArgs> MouseEnter; // Evento que se da cuando el ratón entra en la ventana.
		public event EventHandler<dgtk_MouseEnterLeaveEventArgs> MouseLeave; // Evento que se da cuando el ratón sale de la ventana.
        public event EventHandler<dgtk_OnUpdateEventArgs> UpdateFrame; // Evento que gestiona la actualización de datos.
        public event EventHandler<dgtk_OnRenderEventArgs> RenderFrame; // Evento que gestiona la actualización de Renderizado de Fotogramas.
        public event EventHandler<dgtk_InputAxisEventArgs> GameControlEventAxis; // Evento de accionamiento de Eje.
        public event EventHandler<dgtk_InputHatsEventArgs> GameControlEventHats; // Evento de accionamiento de Hat.
        public event EventHandler<dgtk_InputButtonsEventArgs> GameControlEventButtons; // Evento de accionamiento de Botones.
        //public event EventHandler<dgtk_GameControllerStatusEventArgs> GameControllerStatusChanged; // Evento que se lanza cuando salta algún evento.
        
        #endregion

        public dgtk_Window() : this(1024, 600, "Dark Gear Tool Kit Window") // Consuctor Básico.
        {
            
        }

        public dgtk_Window(int width, int height, string Title) : this(width, height, Title, false)
        {
            
        }

        public dgtk_Window(int width, int height, string Title, bool UseGLES) //Constructor completo.
        {
            if (Core.lockObject == null) {Core.lockObject = new object(); }
            //Process.GetCurrentProcess().ProcessorAffinity = (IntPtr)15; // Establecer afinidad del proceso inicial
            
            this.th_window = new Thread(new ParameterizedThreadStart(this.initWindow)); // Crear nuevo hilo para la gestión de la ventana
            
            this.th_window.Start(new th_params(width, height, Title, UseGLES)); // Iniciar Hilo con los parametros de la ventana.
            while(this.NativeWindow == null) //Esperamos hasta que la ventana esté creada y no sea null.
            {
                Thread.Sleep(100);
            }
            //Console.WriteLine("Ventana Existe");
            while(!this.NativeWindow.Created) //Esperamos a que la ventana nativa indique que ha terminado su inicio.
            {
                Thread.Sleep(100);
            }
            //Console.WriteLine("Ventana Creada");
        }

        #region Metodos Privados:

        private void initWindow(object @params) //Metodo de iniciación de hilos y procesamiento de ventana.
        {
            th_params winparam = (th_params)@params; //creamos estructura para obtener los parametros pasados ene l inicio del hilo.
            switch(Platforms.Tools.GetPlatform()) // Get the Plataform.
            {
                case Platforms.Platform.Windows:
                    this.NativeWindow = new Platforms.Win32.W32Window(50, 50, winparam.Width, winparam.Height, winparam.Title);
                    break;
                case Platforms.Platform.Linux_X11:
                    this.NativeWindow = new Platforms.X11.X11Window(50, 50, winparam.Width, winparam.Height, winparam.Title, winparam.IsEGL);
                    break;
                case Platforms.Platform.Linux_Wayland:
                    this.NativeWindow = new Platforms.X11.X11Window(50, 50, winparam.Width, winparam.Height, winparam.Title, winparam.IsEGL); //Implementar Wayland
                    break;
                default:
                throw new Exception("Operating System Not Supported");
            }

            this.WindowClose += delegate { Core.RemoveWin(this); }; //Inicialización del evento por defecto.
            this.WindowSizeChange += delegate {}; //Inicialización del evento por defecto.
            this.WindowStateChange += delegate {}; //Inicialización del evento por defecto.
            this.KeyPulsed += delegate {}; //Inicialización del evento por defecto.
            this.KeyReleased += delegate {}; //Inicialización del evento por defecto.
            this.KeyCharReturned += delegate {}; //Inicialización del evento por defecto.
            this.MouseDown += delegate {}; //Inicialización del evento por defecto.
            this.MouseUp += delegate {}; //Inicialización del evento por defecto.
            this.MouseMove += delegate {}; //Inicialización del evento por defecto.
            this.MouseWheel += delegate {}; //Inicialización del evento por defecto.
            this.MouseEnter += delegate {}; //Inicialización del evento por defecto.
            this.MouseLeave += delegate {}; //Inicialización del evento por defecto.
			this.UpdateFrame += delegate { }; //Inicialización del evento por defecto.
			this.RenderFrame += delegate { }; //Inicialización del evento por defecto.

            this.GameControlEventAxis += delegate {};
            this.GameControlEventHats += delegate {};
            this.GameControlEventButtons += delegate {};
            //this.GameControllerStatusChanged += delegate {};

            #region Lanzamiento de eventos desde Clase Nativa.
            // Recogemos los eventos de la ventana nativa.
            this.NativeWindow.RenderFrame += delegate (object sender, dgtk_OnRenderEventArgs e)
            {
                this.RenderFrame(this, e); //El renderizado en ventana nativa lanza el evento.
                this.OnRenderFrame(this, e); // Lo ponemos despues para evitar glClear.
            };

            this.NativeWindow.WindowClose += delegate (object sender, dgtk_WinCloseEventArgs e)
            {
                this.OnWinClose(this, e);
                this.WindowClose(this, e); //El cierre de la ventana nativa lanza evento.
            };

            this.NativeWindow.WindowSizeChange += delegate (object sender, dgtk_ResizeEventArgs e)
            {
                this.OnWindowSizeChange(this, e);
                this.WindowSizeChange(this, e); //El cambio de tamaño de la ventana nativa lanza evento.
            };

            this.NativeWindow.WindowStateChange += delegate (object sender, dgtk_WinStateChangeEventArgs e)
            {
                this.OnWinStateChange(this, e);
                this.WindowStateChange(this, e); //El cambio de estado de la ventana nativa lanza evento.
            };

            this.NativeWindow.KeyPulsed += delegate (object sender, dgtk_KeyBoardKeysEventArgs e)
            {
                this.OnKeyPulsed(this, e);
                this.KeyPulsed(this, e); //La pulsación de la tecla en la ventana nativa lanza el evento.
            };

            this.NativeWindow.KeyReleased += delegate (object sender, dgtk_KeyBoardKeysEventArgs e)
            {
                this.OnKeyReleased(sender, e);
                this.KeyReleased(this, e);
            };

            this.NativeWindow.KeyCharReturned += delegate (object sender, dgtk_KeyBoardTextEventArgs e)
            {
                this.OnKeyCharReturned(this, e);
                this.KeyCharReturned(this, e);
            };

            this.NativeWindow.MouseDown += delegate (object sender, dgtk_MouseButtonEventArgs e)
            {
                this.OnMouseDown(this, e);
                this.MouseDown(this, e);
            };

            this.NativeWindow.MouseUp += delegate (object sender, dgtk_MouseButtonEventArgs e)
            {
                this.OnMouseUp(this, e);
                this.MouseUp(this, e);
            };

            this.NativeWindow.MouseMove += delegate (object sender, dgtk_MouseMoveEventArgs e)
            {
                this.OnMouseMove(this, e);
                this.MouseMove(this, e);
            };

            this.NativeWindow.MouseWheel += delegate (object sender, dgtk_MouseWheelEventArgs e)
            {
                this.OnMouseWheel(this, e);
                this.MouseWheel(this, e);
            };

            this.NativeWindow.MouseEnter += delegate (object sender, dgtk_MouseEnterLeaveEventArgs e)
            {
                this.OnMouseEnter(this, e);
                this.MouseEnter(this, e);
            };

            this.NativeWindow.MouseLeave += delegate (object sender, dgtk_MouseEnterLeaveEventArgs e)
            {
                this.OnMouseLeave(this, e);
                this.MouseLeave(this, e);
            };
            /*
            this.NativeWindow.RenderFrame += delegate (object sender, dgtk_OnRenderEventArgs e)
            {
                this.RenderFrame(this, e);
            };
            */
            // Update Frame no se maneja en Ventana nativa.

            #endregion

            while(!this.NativeWindow.IsRunning)
            {
                Thread.Sleep(1000); //Dar ytimepo al inicio de la ventana nativa.
            }
            Process.GetCurrentProcess().ProcessorAffinity = (IntPtr)15; // Definir Afinidad con procesador.  Cores: 1,2,3 y 4.
            Core.AddWin(this);

            this.ProcessEvents(); //Iniciar el procesamiento de Eventos de Ventana.
        }

        #region PROTECTED EVENTS:
        protected virtual void OnUpdateFrame(object sender, dgtk_OnUpdateEventArgs e)
        {
            
        }
        protected virtual void OnRenderFrame(object sender, dgtk_OnRenderEventArgs e)
        {
            
        }

        protected virtual void OnWinClose(object sender, dgtk_WinCloseEventArgs e)
        {

        }

        protected virtual void OnWindowSizeChange(object sender, dgtk_ResizeEventArgs e)
        {

        }

        protected virtual void OnWinStateChange(object sender, dgtk_WinStateChangeEventArgs e)
        {

        }

        protected virtual void OnKeyPulsed(object sender, dgtk_KeyBoardKeysEventArgs e)
        {

        }

        protected virtual void OnKeyReleased(object sender, dgtk_KeyBoardKeysEventArgs e)
        {

        }

        protected virtual void OnKeyCharReturned(object sender, dgtk_KeyBoardTextEventArgs e)
        {

        }

        protected virtual void OnMouseDown(object sender, dgtk_MouseButtonEventArgs e)
        {

        }

        protected virtual void OnMouseUp(object sender, dgtk_MouseButtonEventArgs e)
        {
            
        }

        protected virtual void OnMouseMove(object sender, dgtk_MouseMoveEventArgs e)
        {

        }

        protected virtual void OnMouseWheel(object sender, dgtk_MouseWheelEventArgs e)
        {

        }

        protected virtual void OnMouseEnter(object sender, dgtk_MouseEnterLeaveEventArgs e)
        {

        }

        protected virtual void OnMouseLeave(object sender, dgtk_MouseEnterLeaveEventArgs e)
        {

        }
        #endregion
        
        private void ProcessEvents()
        {
            //dgtk.GameControlSystem.Linux.System.RefreshDeviceList();
            this.ui_ueps = 100; //Actualizaciones de comprobación de eventos por segundo, por defecto.
            this.NativeWindow.ProcessEvent(ref this.ui_ueps); // No usar toda la CPU.
        }

        private void Render_frame()
        {
            Process.GetCurrentProcess().ProcessorAffinity = (IntPtr)15; //Definir afinidad de procesador para el hilo. Cores: 1,2,3 y 4.
            /*if (Platforms.Tools.GetPlatform() == Platforms.Platform.Windows) // Mierda de Windows.
            {
                ((Platforms.Win32.W32Window)this.NativeWindow).OGLContextGen(); // Creamos el Contexto de OpenGL para windows en el mismo hilo que el Renderizado.
            }*/
            while(!this.NativeWindow.IsRunning) // Esperar a que la ventana nativa exista.
            {
                //Esperar al inicio de ProcessEvent();
                Thread.Sleep(1000);
            }
            /*this.MakeCurrent();
            this.GLConfig(); // LLamamos al metodo de Configuración de OpenGL
            this.UnMakeCurrent();*/
            //this.IsGLConfigSeted = true;
            while(this.NativeWindow.IsRunning) // Procesar mientras la ventana nativa exista y este funcionando.
            {
                DateTime dt_ini = DateTime.Now;
                
                this.NativeWindow.Redraw(); // Lanza renderizado, el cual lanza evento de Renderizado.
                
                if ((this.ui_fps > 0) && !this.NativeWindow.VSyncEnabled)
                {
                    TimeSpan retraso = DateTime.Now - dt_ini;
                    if (retraso.TotalMilliseconds < (1f/(float)this.ui_fps)*1000f)
                    {
                        Thread.Sleep((int)(((1f/(float)this.ui_fps)*1000f)-retraso.TotalMilliseconds));
                    }
                }
                if (1000>(DateTime.Now -this.dt_lastTime).TotalMilliseconds)
                {
                    this.ui_c_fps++; //Aumentar FPS
                }
                else
                {
                    this.ui_c_fps_show = this.ui_c_fps; //Aisnar suma de fps a la variable a mostrar
                    this.ui_c_fps = 0; // Reiniciar conteo de FPS
                    this.dt_lastTime = DateTime.Now; //Reiniciar fecha de base de cálculo.
                }
            }
            //Thread.CurrentThread.Abort(); // Abortar el hilo cuando la ventana ya no esté corriendo.
        }

        private void Update_frame()
        {
            Process.GetCurrentProcess().ProcessorAffinity = (IntPtr)15; //Definir afinidad de procesador para el hilo. Cores: 1,2,3 y 4.
            while(!this.NativeWindow.IsRunning) // Esperar a que la ventana nativa exista.
            {
                //Esperar al inicio de ProcessEvent();
                Thread.Sleep(1000);
            }
            while(this.NativeWindow.IsRunning) // Procesar mientras la ventana nativa exista y este funcionando.
            {
                DateTime dt_ini = DateTime.Now;
                //lock(Core.lockObject) //this.NativeWindow.LockObject)
                //{
                    this.OnUpdateFrame(this, new dgtk_OnUpdateEventArgs()); //Lanza Protected Virtual
                    this.UpdateFrame(this, new dgtk_OnUpdateEventArgs()); //Lanza evento de Actualización de datos.
                //}
                if (this.ui_ups > 0) 
                {
                    TimeSpan retraso = DateTime.Now - dt_ini;
                    if (retraso.TotalMilliseconds < (1f/(float)this.ui_ups)*1000f)
                    {
                        Thread.Sleep((int)(((1f/(float)this.ui_ups)*1000f)-retraso.TotalMilliseconds));
                    }
                }
            }
            //Thread.CurrentThread.Abort(); // Abortar el hilo cuando la ventana ya no esté corriendo.
        }

        #endregion

        #region Metodos Publicos:

        public void Run()
        {
            this.Run(0);
        }

        public void Run(uint RefresPerSecon)
        {
            this.Run(RefresPerSecon, RefresPerSecon);
        }

        public void Run(uint fps, uint ups)
        {
            this.ui_fps = fps; 
            this.ui_ups = ups;
            this.DisableVSync();
            this.th_update = new Thread(this.Update_frame);
            this.th_update.Start();
            this.th_redraw = new Thread(this.Render_frame);
            this.th_redraw.Start();
            // this.NativeWindow.IsRunning = true; // No debería estar aquí, al menos en linux
        }

        public void Run(uint fps, uint ups, uint ueps)
        {
            this.ui_fps = fps; 
            this.ui_ups = ups;
            this.ui_ueps = ueps;
            this.DisableVSync();
            this.th_update = new Thread(this.Update_frame);
            this.th_update.Start();
            this.th_redraw = new Thread(this.Render_frame);
            this.th_redraw.Start();
            // this.NativeWindow.IsRunning = true; // No deberia estar aquí, al menos in linux
        }

        public void SetWindowIcon(string iconpath, Assembly As)
        {
            System.IO.Stream str = Core.LoadEmbeddedResource(iconpath, As);
            if (str != null)
            {
                //System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(str);
                //SetWindowIcon(bmp);
                SetWindowIcon(str);
            }            
        }

        public void SetWindowIcon(string iconpath)
        {
            if (System.IO.File.Exists(iconpath))
            {
                //System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(iconpath);
                SetWindowIcon(System.IO.File.Open(iconpath, System.IO.FileMode.Open));
            }
        }

        internal void SetWindowIcon(System.IO.Stream stream)
        {
            IntPtr icon_ptr = IntPtr.Zero;
            SkiaSharp.SKBitmap skbmp;
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            stream.CopyTo(ms);
            stream.Position = 0;
            skbmp = SkiaSharp.SKBitmap.Decode(stream);
            
            switch (Platforms.Tools.GetPlatform()) // == Platforms.Platform.Linux_X11)
            {
                case Platforms.Platform.Linux_X11:
                    IntPtr icon_ptr_sk = skbmp.GetPixels();
                    byte[] bytes = new byte[skbmp.Width*skbmp.Height*4];
                    System.Runtime.InteropServices.Marshal.Copy(icon_ptr_sk, bytes, 0, bytes.Length);

                    System.Collections.Generic.List<byte> l_SuperBytes = new System.Collections.Generic.List<byte>();
                    l_SuperBytes.AddRange(BitConverter.GetBytes((long)skbmp.Width));
                    l_SuperBytes.AddRange(BitConverter.GetBytes((long)skbmp.Height));

                    for (int i=0;i<bytes.Length;i+=4)
                    {
                        l_SuperBytes.Add(bytes[i]);
                        l_SuperBytes.Add(bytes[i+1]);
                        l_SuperBytes.Add(bytes[i+2]);
                        l_SuperBytes.Add(bytes[i+3]);
                        l_SuperBytes.AddRange(new byte[]{0, 0, 0, 0}); // Rellenar long de 64 bits del hardware con... mierda. No necesario en compilacion de 32 Bits.
                    }
                    
                    icon_ptr = System.Runtime.InteropServices.Marshal.AllocHGlobal(l_SuperBytes.Count);
                    System.Runtime.InteropServices.Marshal.Copy(l_SuperBytes.ToArray(), 0, icon_ptr, l_SuperBytes.Count);

                    break;

                case Platforms.Platform.Windows:
                    icon_ptr = new System.Drawing.Bitmap(ms).GetHicon(); // Sin equivalencias en skia
                    break;

                default:
                    //No hacer nada de momento.
                    break;
            }            

            this.NativeWindow.SetIcon(skbmp.Width, skbmp.Height, icon_ptr); 
            skbmp.Dispose();
            ms.Dispose();
        }

        public virtual void Close()
        {
            this.NativeWindow.Close();
        }

        public bool MakeCurrent()
        {
            return this.NativeWindow.MakeCurrent();
        }
        public bool UnMakeCurrent()
        {
            return this.NativeWindow.UnMakeCurrent();
        }
        public void SwapBuffers()
        {
            this.NativeWindow.SwapBuffers();
        }

        public void EnableVSync()
        {
            this.MakeCurrent();
            this.NativeWindow.EnableVSync();
            this.UnMakeCurrent();
        }

        public void DisableVSync()
        {
            this.MakeCurrent();
            this.NativeWindow.DisableVSync();
            this.UnMakeCurrent();
        }

        #endregion

        #region Metodos Internal:

        internal void LaunchEventAxis(object sender, dgtk_InputAxisEventArgs e)
        {
            if (this.NativeWindow.HaveFocus)
            {
                this.GameControlEventAxis(sender, e);
            }
        }

        internal void LaunchEventHats(object sender, dgtk_InputHatsEventArgs e)
        {
            if (this.NativeWindow.HaveFocus)
            {
                this.GameControlEventHats(sender, e);
            }
        }

        internal void LaunchEventBTNs(object sender, dgtk_InputButtonsEventArgs e)
        {
            if (this.NativeWindow.HaveFocus)
            {
                this.GameControlEventButtons(sender, e);
            }
        }
        /*
        internal void LaunchGameControllerStatusChanged(object sender, dgtk_GameControllerStatusEventArgs e)
        {
            this.GameControllerStatusChanged(sender, e);
        }
        */
        #endregion

        #region PROPIEDADES:

        public string WindowTitle
        {
            set { this.NativeWindow.Title = value;}
            get { return this.NativeWindow.Title; }
        }
        public int X
        {
            get { return this.NativeWindow.Position.X; }
        }
        public int Y
        {
            get { return this.NativeWindow.Position.Y; }
        }
        public virtual int Width
        {
            get {return this.NativeWindow.Size.Width;}
            set 
            {
                if (value>this.i_minWidth)
                {
                    this.NativeWindow.Size = new Math.Size(value, this.NativeWindow.Size.Height);
                }
                else
                {
                    this.NativeWindow.Size = new Math.Size(this.i_minWidth, this.NativeWindow.Size.Height);
                }                
            }
        }
        public virtual int Height
        {
            get {return this.NativeWindow.Size.Height;}
            set 
            {
                if (value>this.i_minHeight)
                {
                    this.NativeWindow.Size = new Math.Size(this.NativeWindow.Size.Width, value);
                }
                else
                {
                    this.NativeWindow.Size = new Math.Size(this.i_minHeight, this.NativeWindow.Size.Height);
                }     
            }
        }
        public int MinWidth
        {
            set { this.i_minWidth = value; }
            get { return this.i_minWidth; }
        }
        public int MinHeight
        {
            set { this.i_minHeight = value; }
            get { return this.i_minHeight; }
        }
        public virtual WindowState WindowState
        {
            set { this.NativeWindow.WindowState = value; }
            get { return this.NativeWindow.WindowState; }
        }
        public uint CalculatedFPS
        {
            get { return this.ui_c_fps_show;}
        }

        public object LockObject
        {
            get { return Core.lockObject; }
        }

        public bool FullScreen
        {
            set { this.NativeWindow.FullScreen = value; }
            get { return this.NativeWindow.FullScreen; }
        }

        public bool IsGLES
        {
            get { return this.NativeWindow.IsGLES; }
        }

        #endregion
    }
}
