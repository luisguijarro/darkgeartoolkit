using System;
using System.Security;
using System.Runtime.InteropServices;

namespace dgtk.Platforms.EGL
{
    internal static class Imports
    {
    #if IsWin        
        internal const string LibEgl = "libEGL.dll";
    #else
        internal const string LibEgl = "libEGL.so.1";
    #endif

        [DllImport(LibEgl, EntryPoint = "eglBindAPI")]
        internal static extern bool eglBindAPI (EGL_API api);

        [DllImport(LibEgl, EntryPoint = "eglBindTexImage")]
        internal static extern bool eglBindTexImage (IntPtr dpy, IntPtr surface, int buffer);

        [DllImport(LibEgl, EntryPoint = "eglChooseConfig")]
        internal static unsafe extern bool eglChooseConfig (IntPtr dpy, ref int[] attrib_list, out IntPtr configs, int config_size, out int num_config);

        [DllImport(LibEgl, EntryPoint = "eglClientWaitSync")]
        internal static extern int eglClientWaitSync (IntPtr dpy, IntPtr sync, int flags, long timeout);

        [DllImport(LibEgl, EntryPoint = "eglCopyBuffers")]
        internal static extern bool eglCopyBuffers (IntPtr dpy, IntPtr surface, IntPtr target);

        [DllImport(LibEgl, EntryPoint = "eglCreateContext")]
        internal static unsafe extern IntPtr eglCreateContext (IntPtr dpy, IntPtr config, IntPtr share_context, /*const*/ref int[] attrib_list);

        [DllImport(LibEgl, EntryPoint = "eglCreateImage")]
        internal static unsafe extern IntPtr eglCreateImage (IntPtr dpy, IntPtr ctx, EGL_ENUM target, IntPtr buffer, /*const*/ref IntPtr attrib_list);

        [DllImport(LibEgl, EntryPoint = "eglCreatePbufferFromClientBuffer")]
        internal static unsafe extern IntPtr eglCreatePbufferFromClientBuffer (IntPtr dpy, EGL_ENUM buftype, IntPtr buffer, IntPtr config, /*const*/ref int[] attrib_list);

        [DllImport(LibEgl, EntryPoint = "eglCreatePbufferSurface")]
        internal static unsafe extern IntPtr eglCreatePbufferSurface (IntPtr dpy, IntPtr config, /*const*/ref int[] attrib_list);

        [DllImport(LibEgl, EntryPoint = "eglCreatePixmapSurface")]
        internal static unsafe extern IntPtr eglCreatePixmapSurface (IntPtr dpy, IntPtr config, IntPtr pixmap, /*const*/ref int[] attrib_list);

        [DllImport(LibEgl, EntryPoint = "eglCreatePlatformPixmapSurface")]
        internal static unsafe extern IntPtr eglCreatePlatformPixmapSurface (IntPtr dpy, IntPtr config, IntPtr native_pixmap, /*const*/ref IntPtr attrib_list);

        [DllImport(LibEgl, EntryPoint = "eglCreatePlatformWindowSurface")]
        internal static unsafe extern IntPtr eglCreatePlatformWindowSurface (IntPtr dpy, IntPtr config, IntPtr native_window, /*const*/ref IntPtr attrib_list);

        [DllImport(LibEgl, EntryPoint = "eglCreateSync")]
        internal static unsafe extern IntPtr eglCreateSync (IntPtr dpy, EGL_ENUM type, /*const*/ref IntPtr attrib_list);

        [DllImport(LibEgl, EntryPoint = "eglCreateWindowSurface")]
        internal static unsafe extern IntPtr eglCreateWindowSurface (IntPtr dpy, IntPtr config, IntPtr win, /*const*/ref int[] attrib_list);

        [DllImport(LibEgl, EntryPoint = "eglDestroyContext")]
        internal static extern bool eglDestroyContext (IntPtr dpy, IntPtr ctx);

        [DllImport(LibEgl, EntryPoint = "eglDestroyImage")]
        internal static extern bool eglDestroyImage (IntPtr dpy, IntPtr image);

        [DllImport(LibEgl, EntryPoint = "eglDestroySurface")]
        internal static extern bool eglDestroySurface (IntPtr dpy, IntPtr surface);

        [DllImport(LibEgl, EntryPoint = "eglDestroySync")]
        internal static extern bool eglDestroySync (IntPtr dpy, IntPtr sync);

        [DllImport(LibEgl, EntryPoint = "eglGetConfigAttrib")]
        internal static extern bool eglGetConfigAttrib (IntPtr dpy, IntPtr config, int attribute, ref int value);

        [DllImport(LibEgl, EntryPoint = "eglGetConfigs")]
        internal static unsafe extern bool eglGetConfigs (IntPtr dpy, IntPtr configs, int config_size, ref int num_config);

        [DllImport(LibEgl, EntryPoint = "eglGetCurrentContext")]
        internal static extern IntPtr eglGetCurrentContext ();

        [DllImport(LibEgl, EntryPoint = "eglGetCurrentDisplay")]
        internal static extern IntPtr eglGetCurrentDisplay ();

        [DllImport(LibEgl, EntryPoint = "eglGetCurrentSurface")]
        internal static extern IntPtr eglGetCurrentSurface (int readdraw);

        [DllImport(LibEgl, EntryPoint = "eglGetDisplay")]
        internal static extern IntPtr eglGetDisplay (IntPtr display_id);

        [DllImport(LibEgl, EntryPoint = "eglGetError")]
        internal static extern int eglGetError ();

        [DllImport(LibEgl, EntryPoint = "eglGetPlatformDisplay")]
        internal static unsafe extern IntPtr eglGetPlatformDisplay (EGL_ENUM platform, IntPtr native_display, /*const*/ref IntPtr attrib_list);

        [DllImport(LibEgl, EntryPoint = "eglGetProcAddress")]
        internal static extern IntPtr eglGetProcAddress (string procname);

        [DllImport(LibEgl, EntryPoint = "eglGetSyncAttrib")]
        internal static unsafe extern bool eglGetSyncAttrib (IntPtr dpy, IntPtr sync, int attribute, IntPtr *value);

        [DllImport(LibEgl, EntryPoint = "eglInitialize")]
        internal static extern bool eglInitialize (IntPtr dpy, ref int major, ref int minor);

        [DllImport(LibEgl, EntryPoint = "eglMakeCurrent")]
        internal static extern bool eglMakeCurrent (IntPtr dpy, IntPtr draw, IntPtr read, IntPtr ctx);

        [DllImport(LibEgl, EntryPoint = "eglQueryAPI")]
        internal static extern EGL_ENUM eglQueryAPI ();

        [DllImport(LibEgl, EntryPoint = "eglQueryContext")]
        internal static extern bool eglQueryContext (IntPtr dpy, IntPtr ctx, int attribute, ref int value);

        [DllImport(LibEgl, EntryPoint = "eglQueryString")]
        internal static extern string eglQueryString (IntPtr dpy, int name);

        [DllImport(LibEgl, EntryPoint = "eglQuerySurface")]
        internal static extern bool eglQuerySurface (IntPtr dpy, IntPtr surface, int attribute, ref int value);

        [DllImport(LibEgl, EntryPoint = "eglReleaseTexImage")]
        internal static extern bool eglReleaseTexImage (IntPtr dpy, IntPtr surface, int buffer);

        [DllImport(LibEgl, EntryPoint = "eglReleaseThread")]
        internal static extern bool eglReleaseThread ();

        [DllImport(LibEgl, EntryPoint = "IntPtrAttrib")]
        internal static extern bool IntPtrAttrib (IntPtr dpy, IntPtr surface, int attribute, int value);

        [DllImport(LibEgl, EntryPoint = "eglSwapBuffers")]
        internal static extern bool eglSwapBuffers (IntPtr dpy, IntPtr surface);

        [DllImport(LibEgl, EntryPoint = "eglSwapInterval")]
        internal static extern bool eglSwapInterval (IntPtr dpy, int interval);

        [DllImport(LibEgl, EntryPoint = "eglTerminate")]
        internal static extern bool eglTerminate (IntPtr dpy);

        [DllImport(LibEgl, EntryPoint = "eglWaitClient")]
        internal static extern bool eglWaitClient ();

        [DllImport(LibEgl, EntryPoint = "eglWaitGL")]
        internal static extern bool eglWaitGL ();

        [DllImport(LibEgl, EntryPoint = "eglWaitNative")]
        internal static extern bool eglWaitNative (int engine);

        [DllImport(LibEgl, EntryPoint = "eglWaitSync")]
        internal static extern bool eglWaitSync (IntPtr dpy, IntPtr sync, int flags);
    }
}