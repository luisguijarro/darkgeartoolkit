using System;
using System.Threading;
using System.Windows.Forms;
using System.ComponentModel;

using dgtk.OpenGL;

namespace dgtk
{
    public partial class dgtk_WFControl : UserControl
    {
        private uint ui_ups;
        private uint ui_fps;
        private uint ui_fps_ToShow;
        private DateTime dt_lastTime;
        private dgtk.Platforms.Platform platform;
        private Thread RenderTh;
        private Thread UpdateTh;
        private dgtk.OpenGL.OGL_Context context;
        private dgtk.Graphics.Color4 c4_backColor;
        public event EventHandler<dgtk_OnUpdateEventArgs> UpdateFrame; // Evento que gestiona la actualización de datos.
        public event EventHandler<dgtk_OnRenderEventArgs> RenderFrame; // Evento que gestiona la actualización de Renderizado de Fotogramas.
        private System.ComponentModel.IContainer components = null;
        
        private bool b_IsRunning;
        public dgtk_WFControl()
        {
            this.ui_fps = 25;
            this.ui_ups = 25;
            this.ui_fps_ToShow = 0;
            this.dt_lastTime = DateTime.Now;
            this.platform = dgtk.Platforms.Tools.GetPlatform();


            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			this.SetStyle(ControlStyles.OptimizedDoubleBuffer, false);
			this.SetStyle(ControlStyles.Opaque, true);
			this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			this.SetStyle(ControlStyles.UserPaint, true);

            this.InitializeComponent();

            float variable = 1f/255f;
            this.c4_backColor = new Graphics.Color4(base.BackColor.R*variable, base.BackColor.G*variable, base.BackColor.B*variable, base.BackColor.A*variable);
			
            if (!this.DesignMode) // Si el control se esta visualizando en ejecución...
			{
                this.InitGLContext();
            }

            this.RenderTh = new Thread(new ThreadStart(this.pOnRender));
            this.UpdateTh = new Thread(new ThreadStart(this.pOnUpdate));

            if (!this.DesignMode) // Si el control se esta visualizando en ejecución...
			{
                this.RenderTh.Start();
                this.UpdateTh.Start();
                this.b_IsRunning = true;
            }
        }

        public void InitializeComponent() 
        {
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.MinimumSize = new System.Drawing.Size(10, 10);
			this.Name = "GLControl";
			this.Size = new System.Drawing.Size(257, 199);
        }

        private void InitGLContext()
        {
            switch(this.platform)
            {
                case dgtk.Platforms.Platform.Windows:
                    this.PrepareWin32glContext();
                    break;
                case dgtk.Platforms.Platform.Linux_X11:
                    this.PrepareX11glContext();
                    break;
                default:
                    throw new Exception("Platform not implemented.");
            }
        }

        protected virtual void OnRender()
		{
            dgtk.OpenGL.GL.glClearColor(this.c4_backColor);
            dgtk.OpenGL.GL.glClear(ClearBufferMask.GL_COLOR_BUFFER_BIT | ClearBufferMask.GL_DEPTH_BUFFER_BIT);
        }

        protected virtual void OnUpdate()
		{
            
        }

		private void pOnRender()
		{
			if (!this.DesignMode) // Si el control se esta visualizando en ejecución...
			{
                if (this.context != null) // Si existe contexto de OpenGL
                {
                    while (!this.b_IsRunning)
                    {
                        Thread.Sleep(1000);
                    }
                    while (this.b_IsRunning)
                    {
                        if (this.ParentForm == null)
                        {
                            this.RenderTh.Abort();
                        }
                        if (this.Visible && this.ParentForm.WindowState != FormWindowState.Minimized)
                        {
                            DateTime dt_ini = DateTime.Now;
                            //---------------------------------------------------
                            this.MakeCurrent();
                            this.OnRender();
                            this.RenderFrame(this, new dgtk_OnRenderEventArgs());
                            this.SwapBuffers();
                            this.UnMakeCurrent();
                            //---------------------------------------------------
                            if ((this.ui_fps > 0))
                            {
                                TimeSpan retraso = DateTime.Now - dt_ini;
                                if (retraso.TotalMilliseconds < (1f/(float)this.ui_fps)*1000f)
                                {
                                    Thread.Sleep((int)(((1f/(float)this.ui_fps)*1000f)-retraso.TotalMilliseconds));
                                }
                            }
                            if (1000>(DateTime.Now -this.dt_lastTime).TotalMilliseconds)
                            {
                                this.ui_fps_ToShow++; //Aumentar FPS
                            }
                            else
                            {
                                //this.ui_c_fps_show = this.ui_c_fps; //Aisnar suma de fps a la variable a mostrar
                                this.ui_fps_ToShow = 0; // Reiniciar conteo de FPS
                                this.dt_lastTime = DateTime.Now; //Reiniciar fecha de base de cálculo.
                            }
                        }
                    }
                }
            }
        }

        private void pOnUpdate()
        {
            if (!this.DesignMode) // Si el control se esta visualizando en ejecución...
			{
                if (this.context != null) // Si existe contexto de OpenGL
                {
                    while (!this.b_IsRunning)
                    {
                        Thread.Sleep(1000);
                    }
                    while (this.b_IsRunning)
                    {
                        if (this.ParentForm == null)
                        {
                            this.UpdateTh.Abort();
                        }
                        if (this.Visible && this.ParentForm.WindowState != FormWindowState.Minimized)
                        {
                            DateTime dt_ini = DateTime.Now;
                            
                            this.OnUpdate();
                            this.UpdateFrame(this, new dgtk_OnUpdateEventArgs()); //Lanza evento de Actualización de datos.

                            if (this.ui_ups > 0) 
                            {
                                TimeSpan retraso = DateTime.Now - dt_ini;
                                if (retraso.TotalMilliseconds < (1f/(float)this.ui_ups)*1000f)
                                {
                                    Thread.Sleep((int)(((1f/(float)this.ui_ups)*1000f)-retraso.TotalMilliseconds));
                                }
                            }
                        }
                    }
                }
            }
        }

        protected override void Dispose(bool disposing)
		{
			if (disposing) {
				this.b_IsRunning = false;
				if ((this.RenderTh.ThreadState != System.Threading.ThreadState.Aborted)  && !this.DesignMode)
				{
					this.RenderTh.Abort();
				}
                if ((this.UpdateTh.ThreadState != System.Threading.ThreadState.Aborted)  && !this.DesignMode)
				{
					this.UpdateTh.Abort();
				}
				if (components != null) {
					components.Dispose();
				}
				//this.corriendo = false;
			}
			base.Dispose(disposing);
		}

		[Browsable(true)]
		[Category("OpenGL")]
		[Description("Get or Set de number of Frames per second of render rate. A value of 0 is not limit the Frame Rate.")]
		[DefaultValue(25)]
        public uint FPS
        {
            set { this.ui_fps = value; }
            get { return this.ui_fps; }
        }

		[Browsable(true)]
		[Category("OpenGL")]
		[Description("Get or Set de number of Frames per second of updtae rate. A value of 0 is not limit the Frame Rate.")]
		[DefaultValue(25)]
        public uint UPS
        {
            set { this.ui_ups = value; }
            get { return this.ui_ups; }
        }

        [Browsable(false)]
        public uint UpdatedFPS
        {
            get { return this.ui_fps_ToShow; }
        }

        public override System.Drawing.Color BackColor
        {
            get { return base.BackColor; }
            set 
            { 
                base.BackColor = value; 
                float variable = 1f/255f;
                this.c4_backColor = new Graphics.Color4(base.BackColor.R*variable, base.BackColor.G*variable, base.BackColor.B*variable, base.BackColor.A*variable);
            }
        }
    }
}