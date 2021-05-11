using  System;

namespace dgtk
{
    public class dgtk_InputHatsEventArgs : EventArgs
    {
        int i_id;
        int i_hat;
        HatPosition hp_value;
        GameControlState gcs;
        public dgtk_InputHatsEventArgs(int id, int hat, HatPosition value, GameControlState state)
        {
            this.i_id = id;
            this.i_hat = hat;
            this.hp_value = value;
            this.gcs = state;
        }

        public int ID
        {
            get { return this.i_id; }
        }

        public int Hat
        {
            get { return this.i_hat; }
        }

        public HatPosition Value
        {
            get { return this.hp_value; }
        }
        public GameControlState State
        {
            get { return this.gcs; }
        }
    }
}
