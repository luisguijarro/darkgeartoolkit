using  System;

namespace dgtk
{
    public class dgtk_InputAxisEventArgs : EventArgs
    {
        int i_id;
        int i_axis;
        int i_value;
        GameControlState gcs;
        public dgtk_InputAxisEventArgs(int id, int axis, int value, GameControlState state)
        {
            this.i_id = id;
            this.i_axis = axis;
            this.i_value = value;
            this.gcs = state;
        }
        public int ID
        {
            get { return this.i_id; }
        }
        public int Axis
        {
            get { return this.i_axis; }
        }
        public int Value
        {
            get { return this.i_value; }
        }
        public GameControlState State
        {
            get { return this.gcs; }
        }
    }
}
