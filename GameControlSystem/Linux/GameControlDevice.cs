using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;

namespace dgtk.GameControlSystem.Linux
{
    internal class GameControlDevice : dgtk.GameControlSystem.I_GameControlDevice
    {
        internal int file;
        internal IntPtr dev; // Puntero de dispositivo de libevdev.
        internal string s_name; // Nombre del dispositivo.
        internal int id;
        internal Thread hilo;
        internal Dictionary<uint, Axis> Axis; // Ejes <id, value>
        internal Dictionary<uint, int> Hats; // Hats <id, value>
        internal Dictionary<uint, bool> Btns; // Botones <id, value>
        public event EventHandler<dgtk_InputAxisEventArgs> EventAxis; // Evento de accionamiento de Eje.
        public event EventHandler<dgtk_InputHatsEventArgs> EventHats; // Evento de accionamiento de Hat.
        public event EventHandler<dgtk_InputButtonsEventArgs> EventButtons; // Evento de accionamiento de Botones.
        public event EventHandler<dgtk_GameControllerStatusEventArgs> EventStatusChanged; // Evento que se lanza cuando salta algún evento.

        internal GameControlDevice(IntPtr ptr_dev, int f) // CONSTRUCTOR
        {
            this.dev = ptr_dev; // Puntero a dispositivo evdev.
            this.file = f; // Fichero origen de dev y a liberar en caso de unplug.

            this.Axis = new Dictionary<uint, Axis>();
            this.Hats = new Dictionary<uint, int>();
            this.Btns = new Dictionary<uint, bool>();
            
            this.EventAxis += this.InputAxisEvent;
            this.EventHats += this.InputHatsEvent;
            this.EventButtons += this.InputBTNsEvent;
            this.EventStatusChanged += this.StatusChangedEvent;

            this.hilo = new Thread(new ThreadStart(this.ProcessEvents)); // Definir hilo procesador de eventos.
            this.hilo.Start(); // Iniciar hilo de procesamiento de eventos.
            
        }

        #region Events:

        private void InputAxisEvent(object sender, dgtk_InputAxisEventArgs e)
        {
            foreach(dgtk_Window win in Core.windows) // Recorremos todas las ventanas abiertas para lanzarles los eventos
            {
                win.LaunchEventAxis(sender, e); // LLamar Lanzamiento de eventos en ventana.
            }
        }

        private void InputHatsEvent(object sender, dgtk_InputHatsEventArgs e)
        {
            foreach(dgtk_Window win in Core.windows) // Recorremos todas las ventanas abiertas para lanzarles los eventos
            {
                win.LaunchEventHats(sender, e); // LLamar Lanzamiento de eventos en ventana.
            }
        }

        private void InputBTNsEvent(object sender, dgtk_InputButtonsEventArgs e)
        {
            foreach(dgtk_Window win in Core.windows) // Recorremos todas las ventanas abiertas para lanzarles los eventos
            {
                win.LaunchEventBTNs(sender, e); // LLamar Lanzamiento de eventos en ventana.
            }
        }

        private void StatusChangedEvent(object sender, dgtk_GameControllerStatusEventArgs e)
        {
            foreach(dgtk_Window win in Core.windows) // Recorremos todas las ventanas abiertas para lanzarles los eventos
            {
                win.LaunchGameControllerStatusChanged(sender, e); // LLamar Lanzamiento de eventos en ventana.
            }
        }

        #endregion

        private void ProcessEvents()
        {
            input_event ev = new input_event(); // Generamos la estructura receptora d elos eventos.
            Imports.libevdev_next_event(this.dev, libevdev_read_flag.LIBEVDEV_READ_FLAG_NORMAL, ref ev); // Inicializamos lectura de eventos para que el hilo no consuma todo el procesador posible.
            while(true) // no dejar de trabajar nunca salvo que el hilo de nuestra vida sea cortado.
            {
                int hasPending = Imports.libevdev_has_event_pending(this.dev); // Revisar si hay eventos pendientes de recoger.
                while (hasPending != 0) // si hay eventos pendientes hay que recogerlos para que no se pierdan.
                {                        
                    int result = Imports.libevdev_next_event(this.dev, libevdev_read_flag.LIBEVDEV_READ_FLAG_NORMAL, ref ev);
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
                                    Console.WriteLine((int)ev.value);

                                    this.EventHats(this, new dgtk_InputHatsEventArgs(this.id, ev.code, hp));
                                }
                                else // Es Eje.
                                {
                                    float ax_value = (100f/(float)((this.Axis[ev.code].MAX-this.Axis[ev.code].MIN)))*ev.value;
                                    if (this.Axis[ev.code].VALUE != ax_value) // Solo lanzar evento si valor cambia.
                                    {
                                        this.Axis[ev.code].VALUE = ax_value;
                                        //ax.VALUE = ax_value;
                                        this.EventAxis(this, new dgtk_InputAxisEventArgs(this.id, ev.code, ax_value));
                                    }
                                }
                                break;
                            case GameControlEventType.EV_KEY:
                                this.EventButtons(this, new dgtk_InputButtonsEventArgs(this.id, ev.code, ev.value> 0));
                                break;
                            default:
                                // Ignorar el resto.
                                break;
                        }
                    }
                }    
            }
        }

        private HatPosition GetHatPosition(int hori, int vert)
        {
            int suma=hori+4*vert;
            switch(suma)
            {
                case -4:return (HatPosition.Up); // 0
                case -3:return (HatPosition.UpRight); // 1
                case 1:return (HatPosition.Right); // 2
                case 5:return (HatPosition.DownRight); // 3
                case 4:return (HatPosition.Down); // 4
                case  3:return (HatPosition.DownLeft); // 5
                case -1:return (HatPosition.Left); // 6
                case -5:return (HatPosition.UpLeft); // 7
                default:return (HatPosition.Center); // 8
            }
        }

        public void Dispose()
        {
            this.hilo.Abort(); // Abortamos hilo que gestiona la recepción de eventos dle hardware.

            this.EventAxis -= this.InputAxisEvent;
            this.EventHats -= this.InputHatsEvent;
            this.EventButtons -= this.InputBTNsEvent;
            this.EventStatusChanged -= this.StatusChangedEvent;

            //Imports.libevdev_free(this.dev); // Liberar Recurso. // Casca la segunda vez
            Imports.close(this.file); // Cerrando Fichero
        }

        public int ID
        {
            get { return this.id; }
        }

        public string Name
        {
            get { return this.s_name; }
        }
    }
}