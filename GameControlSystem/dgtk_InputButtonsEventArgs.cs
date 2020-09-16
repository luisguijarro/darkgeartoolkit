using  System;

namespace dgtk
{
    public class dgtk_InputButtonsEventArgs : EventArgs
    {
        int i_id;
        int i_button;
        bool b_pressed;
        public dgtk_InputButtonsEventArgs(int id, int button, bool pressed)
        {
            this.i_id = id;
            this.i_button = button;
            this.b_pressed = pressed;
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
    }
}
