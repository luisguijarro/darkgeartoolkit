using  System;

namespace dgtk
{
    public class dgtk_WinStateChangeEventArgs : EventArgs
    {
        private WindowState ws_state;
        public dgtk_WinStateChangeEventArgs(WindowState state)
        {
            this.ws_state = state;
        }

        public WindowState WindowState
        {
            get { return this.ws_state; }
        }
    }
}
