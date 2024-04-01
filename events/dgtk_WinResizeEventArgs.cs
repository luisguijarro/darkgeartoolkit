using  System;

namespace dgtk
{
    public class dgtk_ResizeEventArgs : EventArgs
    {
        private int i_ancho;
        private int i_alto;
        public dgtk_ResizeEventArgs(int width, int height)
        {
            this.i_ancho = width;
            this.i_alto = height;
        }
        public int Width
        {
            get { return this.i_ancho; }
        }
        public int Height
        {
            get{ return this.i_alto; }
        }
    }
}
