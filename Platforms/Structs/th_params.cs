using System;

namespace dgtk
{
    internal struct th_params
    {
        public int Width, Height;
        public string Title;
        public th_params(int width, int height, string title)
        {
            this.Width = width;
            this.Height = height;
            this.Title = title;
        }
    }
}