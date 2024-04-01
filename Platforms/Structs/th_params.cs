using System;

namespace dgtk
{
    internal struct th_params
    {
        public int Width, Height;
        public string Title;
        public bool IsEGL;
        public th_params(int width, int height, string title, bool isEGL)
        {
            this.Width = width;
            this.Height = height;
            this.Title = title;
            this.IsEGL = isEGL;
        }
    }
}