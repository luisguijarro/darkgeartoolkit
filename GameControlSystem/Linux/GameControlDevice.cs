using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;

namespace dgtk.GameControlSystem.Linux
{
    internal class GameControlDevice : dgtk.GameControlSystem.I_GameControlDevice
    {
        private input_event ev;
        internal bool disposed;
        internal int file;
        internal IntPtr dev; // Puntero de dispositivo de libevdev.
        internal string s_name; // Nombre del dispositivo.
        internal uint id;
        internal Thread hilo;
        internal Dictionary<uint, Axis> Axis; // Ejes <id, value>
        internal Dictionary<uint, int> Hats; // Hats <id, value>
        internal Dictionary<uint, bool> Btns; // Botones <id, value>
        internal GameControlState gameControlState_state;
        public event EventHandler<dgtk_InputAxisEventArgs> EventAxis; // Evento de accionamiento de Eje.
        public event EventHandler<dgtk_InputHatsEventArgs> EventHats; // Evento de accionamiento de Hat.
        public event EventHandler<dgtk_InputButtonsEventArgs> EventButtons; // Evento de accionamiento de Botones.
        //public event EventHandler<dgtk_GameControllerStatusEventArgs> EventStatusChanged; // Evento que se lanza cuando salta algún evento.

        internal GameControlDevice(IntPtr ptr_dev, int f) // CONSTRUCTOR
        {
            this.dev = ptr_dev; // Puntero a dispositivo evdev.
            this.file = f; // Fichero origen de dev y a liberar en caso de unplug.

            this.Axis = new Dictionary<uint, Axis>();
            this.Hats = new Dictionary<uint, int>();
            this.Btns = new Dictionary<uint, bool>();

            this.gameControlState_state = new GameControlState()
            {
                d_hats_values = new Dictionary<uint, HatPosition>(),
                d_axis_values = new Dictionary<uint, int>(),
                d_Buttons = new Dictionary<uint, bool>()
            };
            
            this.EventAxis += this.InputAxisEvent;
            this.EventHats += this.InputHatsEvent;
            this.EventButtons += this.InputBTNsEvent;
            //this.EventStatusChanged += this.StatusChangedEvent;

            this.hilo = new Thread(new ThreadStart(this.ProcessEvents)); // Definir hilo procesador de eventos.
            this.hilo.Start(); // Iniciar hilo de procesamiento de eventos.            
        }

        #region Events:

        private void InputAxisEvent(object sender, dgtk_InputAxisEventArgs e)
        {
            this.gameControlState_state.d_axis_values[(uint)e.Axis] = e.Value;
            foreach(dgtk_Window win in Core.windows) // Recorremos todas las ventanas abiertas para lanzarles los eventos
            {
                win.LaunchEventAxis(sender, e); // LLamar Lanzamiento de eventos en ventana.
            }
        }

        private void InputHatsEvent(object sender, dgtk_InputHatsEventArgs e)
        {
            this.gameControlState_state.d_hats_values[(uint)e.Hat] = e.Value;
            foreach(dgtk_Window win in Core.windows) // Recorremos todas las ventanas abiertas para lanzarles los eventos
            {
                win.LaunchEventHats(sender, e); // LLamar Lanzamiento de eventos en ventana.
            }
        }

        private void InputBTNsEvent(object sender, dgtk_InputButtonsEventArgs e)
        {
            this.gameControlState_state.d_Buttons[(uint)e.Button] = e.Pressed;
            foreach(dgtk_Window win in Core.windows) // Recorremos todas las ventanas abiertas para lanzarles los eventos
            {
                win.LaunchEventBTNs(sender, e); // LLamar Lanzamiento de eventos en ventana.
            }
        }
        /*
        private void StatusChangedEvent(object sender, dgtk_GameControllerStatusEventArgs e)
        {
            foreach(dgtk_Window win in Core.windows) // Recorremos todas las ventanas abiertas para lanzarles los eventos
            {
                win.LaunchGameControllerStatusChanged(sender, e); // LLamar Lanzamiento de eventos en ventana.
            }
        }
        */
        #endregion

        private void ProcessEvents()
        {
            this.ev = new input_event(); // Generamos la estructura receptora de los eventos.
            while(!disposed) // no dejar de trabajar nunca salvo llamada a Dispose.
            {
                //int hasPending = Imports.libevdev_has_event_pending(this.dev); // Revisar si hay eventos pendientes de recoger.
                //if (hasPending > 0) // si hay eventos pendientes hay que recogerlos para que no se pierdan.
                while (Imports.libevdev_has_event_pending(this.dev) >0) // No perdemos ningún evento
                {                
                    int result = Imports.libevdev_next_event(this.dev, libevdev_read_flag.LIBEVDEV_READ_FLAG_NORMAL /*| libevdev_read_flag.LIBEVDEV_READ_FLAG_SYNC*/, out this.ev);
                    if (result == 0) // Si no hay fallos en la recogida de eventos...
                    {
                        //Leer eventos.
                        switch(ev.type)
                        {
                            case GameControlEventType.EV_ABS:
                                if ((ev.code > 15) && (ev.code < 24)) // ¿Es HAT?
                                {
                                    //Calcular HatPosition
                                    HatPosition hp;
                                    if (ev.code%2 == 0) //Si es PAR...
                                    {
                                        hp = GetHatPosition((int)ev.value, (int)this.Hats[(uint)(ev.code+1)]);
                                    }
                                    else
                                    {
                                        hp = GetHatPosition((int)this.Hats[(uint)(ev.code-1)], (int)ev.value);
                                    }
                                    this.Hats[ev.code] = (int)ev.value;
                                    //Console.WriteLine((int)ev.value);
                                    #if DEBUG
                                        Console.WriteLine("Game Control "+this.id+" | Hat: "+((GameControlABS_EventCode)ev.code).ToString()+ " -> Value: "+(ev.value == 1).ToString());
                                    #endif

                                    this.EventHats(this, new dgtk_InputHatsEventArgs(this.id, ev.code, hp, this.gameControlState_state));
                                }
                                else // Es Eje.
                                {
                                    int ax_value = (int)((100f/(float)((this.Axis[ev.code].MAX-this.Axis[ev.code].MIN)))*ev.value);
                                    if (this.Axis[ev.code].VALUE != ax_value) // Solo lanzar evento si valor cambia.
                                    {
                                        this.Axis[ev.code].VALUE = ax_value;
                                        //ax.VALUE = ax_value;
                                        #if DEBUG
                                            Console.WriteLine("Game Control "+this.id+" | Axis: "+((GameControlABS_EventCode)ev.code).ToString()+ " -> Value: "+ax_value);
                                        #endif

                                        this.EventAxis(this, new dgtk_InputAxisEventArgs(this.id, ev.code, ax_value, this.gameControlState_state));
                                    }
                                }
                                break;
                            case GameControlEventType.EV_KEY:
                                #if DEBUG
                                    Console.WriteLine("Game Control "+this.id+" | Button: "+((GameControlBTN_EventCode)ev.code).ToString()+ " -> Value: "+(ev.value == 1).ToString());
                                #endif

                                this.EventButtons(this, new dgtk_InputButtonsEventArgs(this.id, ev.code, ev.value> 0, this.gameControlState_state));
                                break;
                            default:
                                // Ignorar el resto.
                                break;
                        }
                    }
                }
                Thread.Sleep(100);  // Descargamos carga de CPU.
            }
        }

        private HatPosition GetHatPosition(int hori, int vert)
        {
            int suma=hori+4*vert;
            switch(suma)
            {
                case -4:return (HatPosition.Up); // 0
                case -3:return (HatPosition.UpRight); // 1
                case  1:return (HatPosition.Right); // 2
                case  5:return (HatPosition.DownRight); // 3
                case  4:return (HatPosition.Down); // 4
                case  3:return (HatPosition.DownLeft); // 5
                case -1:return (HatPosition.Left); // 6
                case -5:return (HatPosition.UpLeft); // 7
                default:return (HatPosition.Center); // 8
            }
        }

        public void Dispose()
        {
            //this.hilo.Abort(); // Abortamos hilo que gestiona la recepción de eventos dle hardware.
            this.disposed = true; // Thread.Abort() Obsoleto.
            //Console.WriteLine("GameControl Device: this.disposed = true;");

            this.EventAxis -= this.InputAxisEvent;
            this.EventHats -= this.InputHatsEvent;
            this.EventButtons -= this.InputBTNsEvent;
            //this.EventStatusChanged -= this.StatusChangedEvent;

            //Imports.libevdev_free(this.dev); // Liberar Recurso. // Casca la segunda vez
            Imports.close(this.file); // Cerrando Fichero
        }

        public uint ID
        {
            get { return this.id; }
        }

        public string Name
        {
            get { return this.s_name; }
        }

        public GameControlState State
        {
            get { return this.gameControlState_state; }
        }
    }
}