using System;
using System.Collections.Generic;

namespace dgtk
{    
    public struct GameControlState
    {
        public Dictionary<uint, HatPosition> d_hats_values;
        public Dictionary<uint, int> d_axis_values;
        public Dictionary<uint, bool> d_Buttons;
    }    
}