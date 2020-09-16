using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;

namespace dgtk.GameControlSystem.Windows
{
    internal class GameControlDevice : dgtk.GameControlSystem.I_GameControlDevice
    {
        internal IntPtr dev;
        internal string s_name;  
        internal int id;        
        internal Dictionary<uint, HIDP_VALUE_CAPS> Axis; // Ejes <id, value>
        internal Dictionary<uint, HIDP_VALUE_CAPS> Hats; // Hats <id, value>
        internal Dictionary<uint, HIDP_BUTTON_CAPS> Btns; // Botones <id, value>

        internal Dictionary<uint, long> AxisValues;
        internal Dictionary<uint, HatPosition> HatsValues;
        internal Dictionary<uint, bool> BtnsValues;

        public event EventHandler<dgtk_InputAxisEventArgs> EventAxis; // Evento de accionamiento de Eje.
        public event EventHandler<dgtk_InputHatsEventArgs> EventHats; // Evento de accionamiento de Hat.
        public event EventHandler<dgtk_InputButtonsEventArgs> EventButtons; // Evento de accionamiento de Botones.
        public event EventHandler<dgtk_GameControllerStatusEventArgs> EventStatusChanged; // Evento que se lanza cuando salta algún evento.

        internal GameControlDevice(IntPtr ptr_dev, int in_id)
        {
            this.dev = ptr_dev;
            this.id = in_id;

            this.Axis = new Dictionary<uint, HIDP_VALUE_CAPS>();
            this.Hats = new Dictionary<uint, HIDP_VALUE_CAPS>();
            this.Btns = new Dictionary<uint, HIDP_BUTTON_CAPS>();

            this.AxisValues = new Dictionary<uint, long>();
            this.HatsValues = new Dictionary<uint, HatPosition>();
            this.BtnsValues = new Dictionary<uint, bool>();

            this.EventAxis += this.InputAxisEvent;
            this.EventHats += this.InputHatsEvent;
            this.EventButtons += this.InputBTNsEvent;
            this.EventStatusChanged += this.StatusChangedEvent;
        }

        #region Events:

        internal void LanzarEventAxis(object sender, dgtk_InputAxisEventArgs e)
        {
            this.EventAxis(sender, e);
        }
        internal void LanzarEventHats(object sender, dgtk_InputHatsEventArgs e)
        {
            this.EventHats(sender, e);
        }
        internal void LanzarEventBTNs(object sender, dgtk_InputButtonsEventArgs e)
        {
            this.EventButtons(sender, e);
        }

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

        public void Dispose()
        {
            this.EventAxis -= this.InputAxisEvent;
            this.EventHats -= this.InputHatsEvent;
            this.EventButtons -= this.InputBTNsEvent;
            this.EventStatusChanged -= this.StatusChangedEvent;
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