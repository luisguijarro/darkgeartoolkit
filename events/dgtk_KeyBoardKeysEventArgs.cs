using  System;

namespace dgtk
{
    public class dgtk_KeyBoardKeysEventArgs : EventArgs
    {
		private KeyBoard_Status ks;
        public dgtk_KeyBoardKeysEventArgs(KeyBoard_Status KS)
        {
            this.ks = KS;
        }
		public KeyBoard_Status KeyStatus 
		{ 
			get { return this.ks; }
		}
    }
}
