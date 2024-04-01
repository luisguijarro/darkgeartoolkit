using  System;

namespace dgtk
{
    public class dgtk_MouseEnterLeaveEventArgs : EventArgs
    {
        private EnterLeave el_action;
        public dgtk_MouseEnterLeaveEventArgs(EnterLeave action)
        {
            this.el_action = action;
        }
        public EnterLeave action
        {
            get { return this.el_action; }
        }
    }
}
