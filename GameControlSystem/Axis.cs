using System;

namespace dgtk.GameControlSystem
{
    internal class Axis
    {
        internal uint id;
        internal int MAX;
        internal int MIN;
        internal float VALUE;
        internal Axis(uint idAxis, int i_max, int i_min)
        {
            this.id = idAxis;
            this.MAX = i_max;
            this.MIN = i_min;
            this.VALUE = 100f/(float)(i_max - i_min)*50f;
        }
    }
}