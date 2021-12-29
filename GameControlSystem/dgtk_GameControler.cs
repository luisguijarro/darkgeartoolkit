using System;
using dgtk.GameControlSystem;

namespace dgtk
{
    public class dgtk_GameControler : IDisposable
    {
        internal I_GameControlDevice device; // De Dispositivo nativo de linux o Windows.
        public event EventHandler<dgtk_InputAxisEventArgs> EventAxis; // Evento de accionamiento de Eje.
        public event EventHandler<dgtk_InputHatsEventArgs> EventHats; // Evento de accionamiento de Hat.
        public event EventHandler<dgtk_InputButtonsEventArgs> EventButtons; // Evento de accionamiento de Botones.
        //public event EventHandler<dgtk_GameControllerStatusEventArgs> EventStatusChanged; // Evento que se lanza cuando salta algún evento.
        internal dgtk_GameControler(I_GameControlDevice nativedev)
        {
            this.device = nativedev;

            this.EventAxis += delegate{};
            this.EventHats += delegate{};
            this.EventButtons += delegate{};
            //this.EventStatusChanged += delegate{};
            device.EventAxis += delegate(object sender, dgtk_InputAxisEventArgs e)
            {
                this.EventAxis(sender, e);
            };
            device.EventHats += delegate(object sender, dgtk_InputHatsEventArgs e)
            {
                this.EventHats(sender, e);
            };
            device.EventButtons += delegate(object sender, dgtk_InputButtonsEventArgs e)
            {
                this.EventButtons(sender, e);
            };
            /*device.EventStatusChanged += delegate(object sender, dgtk_GameControllerStatusEventArgs e)
            {
                this.EventStatusChanged(sender, e);
            };*/
        }
        public uint ID
        {
            get { return this.device.ID; }
        }
        public string Name
        {
            get { return device.Name; }
        }
        public void Dispose()
        {
            device.Dispose();
        }
        public GameControlState State
        {
            get { return this.device.State; }
        }
    }
}