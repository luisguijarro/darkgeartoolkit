using  System;

namespace dgtk
{
    public class dgtk_InputButtonsEventArgs : EventArgs
    {
        int i_id;
        int i_button;
        bool b_pressed;
        GameControlState gcs;
        public dgtk_InputButtonsEventArgs(int id, int button, bool pressed, GameControlState state)
        {
            this.i_id = id;
            this.i_button = button;
            this.b_pressed = pressed;
            this.gcs = state;
        }

        public int ID
        {
            get { return this.i_id; }
        }

        public int Button
        {
            get { return this.i_button; }
        }

        public bool Pressed
        {
            get { return this.b_pressed; }
        }
        public GameControlState State
        {
            get { return this.gcs; }
        }
    }
}
