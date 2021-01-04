using System;
using dgtk.OpenAL;


namespace dgtk
{
    public static class SoundSystem
    {
        public static OAL_Context OpenAlContext;
        public static void Init()
        {
            OpenAlContext = new OAL_Context();
        }
    }
}