using  System;

namespace dgtk
{
    public class dgtk_MouseWheelEventArgs : EventArgs
    {
        float f_delta;
        public dgtk_MouseWheelEventArgs(float delta)
        {
            this.f_delta = delta;
        }
        public float Delta
        {
            get { return this. f_delta; }
        }
    }
}
