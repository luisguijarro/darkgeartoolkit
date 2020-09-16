using  System;

namespace dgtk
{
    public class dgtk_InputAxisEventArgs : EventArgs
    {
        int i_id;
        int i_axis;
        float f_value;
        public dgtk_InputAxisEventArgs(int id, int axis, float value)
        {
            this.i_id = id;
            this.i_axis = axis;
            this.f_value = value;
        }
        public int ID
        {
            get { return this.i_id; }
        }
        public int Axis
        {
            get { return this.i_axis; }
        }
        public float Value
        {
            get { return this.f_value; }
        }
    }
}
