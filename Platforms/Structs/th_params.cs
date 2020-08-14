using System;

namespace dgtk
{
    internal struct th_params
    {
        public uint Width, Height;
        public string Title;
        public th_params(uint width, uint height, string title)
        {
            this.Width = width;
            this.Height = height;
            this.Title = title;
        }
    }
}