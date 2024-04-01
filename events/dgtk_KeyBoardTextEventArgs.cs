using  System;

namespace dgtk
{
    public class dgtk_KeyBoardTextEventArgs : EventArgs
    {
        private char ch_character;
        public dgtk_KeyBoardTextEventArgs(char character)
        {
            this.ch_character = character;
        }
        public char Character
        {
            get { return this.ch_character; }
        }
    }
}
