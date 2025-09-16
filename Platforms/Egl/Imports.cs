using System;
using System.Runtime.InteropServices;

namespace dgtk.Platforms.EGL;

internal static class Imports
{
    private static readonly IntPtr _libHandle;

    #region Delegates

    internal delegate bool eglBindAPIDelegate(EGL_API api);
    internal delegate bool eglBindTexImageDelegate(IntPtr dpy, IntPtr surface, int buffer);
    internal delegate bool eglChooseConfigDelegate(IntPtr dpy, int[] attrib_list, out IntPtr configs, int config_size, out int num_config);
    internal delegate int eglClientWaitSyncDelegate(IntPtr dpy, IntPtr sync, int flags, long timeout);
    internal delegate bool eglCopyBuffersDelegate(IntPtr dpy, IntPtr surface, IntPtr target);
    internal delegate IntPtr eglCreateContextDelegate(IntPtr dpy, IntPtr config, IntPtr share_context, int[] attrib_list);
    internal delegate IntPtr eglCreateImageDelegate(IntPtr dpy, IntPtr ctx, EGL_ENUM target, IntPtr buffer, ref IntPtr attrib_list);
    internal delegate IntPtr eglCreatePbufferFromClientBufferDelegate(IntPtr dpy, EGL_ENUM buftype, IntPtr buffer, IntPtr config, ref int[] attrib_list);
    internal delegate IntPtr eglCreatePbufferSurfaceDelegate(IntPtr dpy, IntPtr config, ref int[] attrib_list);
    internal delegate IntPtr eglCreatePixmapSurfaceDelegate(IntPtr dpy, IntPtr config, IntPtr pixmap, ref int[] attrib_list);
    internal delegate IntPtr eglCreatePlatformPixmapSurfaceDelegate(IntPtr dpy, IntPtr config, IntPtr native_pixmap, ref IntPtr attrib_list);
    internal delegate IntPtr eglCreatePlatformWindowSurfaceDelegate(IntPtr dpy, IntPtr config, IntPtr native_window, ref IntPtr attrib_list);
    internal delegate IntPtr eglCreateSyncDelegate(IntPtr dpy, EGL_ENUM type, ref IntPtr attrib_list);
    internal delegate IntPtr eglCreateWindowSurfaceDelegate(IntPtr dpy, IntPtr config, IntPtr win, int[] attrib_list);
    internal delegate bool eglDestroyContextDelegate(IntPtr dpy, IntPtr ctx);
    internal delegate bool eglDestroyImageDelegate(IntPtr dpy, IntPtr image);
    internal delegate bool eglDestroySurfaceDelegate(IntPtr dpy, IntPtr surface);
    internal delegate bool eglDestroySyncDelegate(IntPtr dpy, IntPtr sync);
    internal delegate bool eglGetConfigAttribDelegate(IntPtr dpy, IntPtr config, int attribute, ref int value);
    internal delegate bool eglGetConfigsDelegate(IntPtr dpy, IntPtr configs, int config_size, out int num_config);
    internal delegate IntPtr eglGetCurrentContextDelegate();
    internal delegate IntPtr eglGetCurrentDisplayDelegate();
    internal delegate IntPtr eglGetCurrentSurfaceDelegate(int readdraw);
    internal delegate IntPtr eglGetDisplayDelegate(IntPtr display_id);
    internal delegate EGL_ERRORS eglGetErrorDelegate();
    internal delegate IntPtr eglGetPlatformDisplayDelegate(EGL_ENUM platform, IntPtr native_display, ref IntPtr attrib_list);
    internal delegate IntPtr eglGetProcAddressDelegate(string procname);
    internal delegate bool eglGetSyncAttribDelegate(IntPtr dpy, IntPtr sync, int attribute, ref IntPtr value);
    internal delegate bool eglInitializeDelegate(IntPtr dpy, ref int major, ref int minor);
    internal delegate bool eglMakeCurrentDelegate(IntPtr dpy, IntPtr draw, IntPtr read, IntPtr ctx);
    internal delegate EGL_ENUM eglQueryAPIDelegate();
    internal delegate bool eglQueryContextDelegate(IntPtr dpy, IntPtr ctx, int attribute, ref int value);
    internal delegate string eglQueryStringDelegate(IntPtr dpy, int name);
    internal delegate bool eglQuerySurfaceDelegate(IntPtr dpy, IntPtr surface, int attribute, ref int value);
    internal delegate bool eglReleaseTexImageDelegate(IntPtr dpy, IntPtr surface, int buffer);
    internal delegate bool eglReleaseThreadDelegate();
    internal delegate bool IntPtrAttribDelegate(IntPtr dpy, IntPtr surface, int attribute, int value);
    internal delegate bool eglSwapBuffersDelegate(IntPtr dpy, IntPtr surface);
    internal delegate bool eglSwapIntervalDelegate(IntPtr dpy, int interval);
    internal delegate bool eglTerminateDelegate(IntPtr dpy);
    internal delegate bool eglWaitClientDelegate();
    internal delegate bool eglWaitGLDelegate();
    internal delegate bool eglWaitNativeDelegate(int engine);
    internal delegate bool eglWaitSyncDelegate(IntPtr dpy, IntPtr sync, int flags);

    #endregion

    #region Internal Functions

    internal static readonly eglBindAPIDelegate eglBindAPI;
    internal static readonly eglBindTexImageDelegate eglBindTexImage;
    internal static readonly eglChooseConfigDelegate eglChooseConfig;
    internal static readonly eglClientWaitSyncDelegate eglClientWaitSync;
    internal static readonly eglCopyBuffersDelegate eglCopyBuffers;
    internal static readonly eglCreateContextDelegate eglCreateContext;
    internal static readonly eglCreateImageDelegate eglCreateImage;
    internal static readonly eglCreatePbufferFromClientBufferDelegate eglCreatePbufferFromClientBuffer;
    internal static readonly eglCreatePbufferSurfaceDelegate eglCreatePbufferSurface;
    internal static readonly eglCreatePixmapSurfaceDelegate eglCreatePixmapSurface;
    internal static readonly eglCreatePlatformPixmapSurfaceDelegate eglCreatePlatformPixmapSurface;
    internal static readonly eglCreatePlatformWindowSurfaceDelegate eglCreatePlatformWindowSurface;
    internal static readonly eglCreateSyncDelegate eglCreateSync;
    internal static readonly eglCreateWindowSurfaceDelegate eglCreateWindowSurface;
    internal static readonly eglDestroyContextDelegate eglDestroyContext;
    internal static readonly eglDestroyImageDelegate eglDestroyImage;
    internal static readonly eglDestroySurfaceDelegate eglDestroySurface;
    internal static readonly eglDestroySyncDelegate eglDestroySync;
    internal static readonly eglGetConfigAttribDelegate eglGetConfigAttrib;
    internal static readonly eglGetConfigsDelegate eglGetConfigs;
    internal static readonly eglGetCurrentContextDelegate eglGetCurrentContext;
    internal static readonly eglGetCurrentDisplayDelegate eglGetCurrentDisplay;
    internal static readonly eglGetCurrentSurfaceDelegate eglGetCurrentSurface;
    internal static readonly eglGetDisplayDelegate eglGetDisplay;
    internal static readonly eglGetErrorDelegate eglGetError;
    internal static readonly eglGetPlatformDisplayDelegate eglGetPlatformDisplay;
    internal static readonly eglGetProcAddressDelegate eglGetProcAddress;
    internal static readonly eglGetSyncAttribDelegate eglGetSyncAttrib;
    internal static readonly eglInitializeDelegate eglInitialize;
    internal static readonly eglMakeCurrentDelegate eglMakeCurrent;
    internal static readonly eglQueryAPIDelegate eglQueryAPI;
    internal static readonly eglQueryContextDelegate eglQueryContext;
    internal static readonly eglQueryStringDelegate eglQueryString;
    internal static readonly eglQuerySurfaceDelegate eglQuerySurface;
    internal static readonly eglReleaseTexImageDelegate eglReleaseTexImage;
    internal static readonly eglReleaseThreadDelegate eglReleaseThread;
    internal static readonly IntPtrAttribDelegate IntPtrAttrib;
    internal static readonly eglSwapBuffersDelegate eglSwapBuffers;
    internal static readonly eglSwapIntervalDelegate eglSwapInterval;
    internal static readonly eglTerminateDelegate eglTerminate;
    internal static readonly eglWaitClientDelegate eglWaitClient;
    internal static readonly eglWaitGLDelegate eglWaitGL;
    internal static readonly eglWaitNativeDelegate eglWaitNative;
    internal static readonly eglWaitSyncDelegate eglWaitSync;

    #endregion

    // Inicialización estática
    static Imports()
    {
        string libName = RuntimeInformation.IsOSPlatform(OSPlatform.Windows)
            ? "libEGL.dll"
            : "libEGL.so.1";

        _libHandle = NativeLibrary.Load(libName);

        eglBindAPI = GetFunction<eglBindAPIDelegate>("eglBindAPI");
        eglBindTexImage = GetFunction<eglBindTexImageDelegate>("eglBindTexImage");
        eglChooseConfig = GetFunction<eglChooseConfigDelegate>("eglChooseConfig");
        eglClientWaitSync = GetFunction<eglClientWaitSyncDelegate>("eglClientWaitSync");
        eglCopyBuffers = GetFunction<eglCopyBuffersDelegate>("eglCopyBuffers");
        eglCreateContext = GetFunction<eglCreateContextDelegate>("eglCreateContext");
        eglCreateImage = GetFunction<eglCreateImageDelegate>("eglCreateImage");
        eglCreatePbufferFromClientBuffer = GetFunction<eglCreatePbufferFromClientBufferDelegate>("eglCreatePbufferFromClientBuffer");
        eglCreatePbufferSurface = GetFunction<eglCreatePbufferSurfaceDelegate>("eglCreatePbufferSurface");
        eglCreatePixmapSurface = GetFunction<eglCreatePixmapSurfaceDelegate>("eglCreatePixmapSurface");
        eglCreatePlatformPixmapSurface = GetFunction<eglCreatePlatformPixmapSurfaceDelegate>("eglCreatePlatformPixmapSurface");
        eglCreatePlatformWindowSurface = GetFunction<eglCreatePlatformWindowSurfaceDelegate>("eglCreatePlatformWindowSurface");
        eglCreateSync = GetFunction<eglCreateSyncDelegate>("eglCreateSync");
        eglCreateWindowSurface = GetFunction<eglCreateWindowSurfaceDelegate>("eglCreateWindowSurface");
        eglDestroyContext = GetFunction<eglDestroyContextDelegate>("eglDestroyContext");
        eglDestroyImage = GetFunction<eglDestroyImageDelegate>("eglDestroyImage");
        eglDestroySurface = GetFunction<eglDestroySurfaceDelegate>("eglDestroySurface");
        eglDestroySync = GetFunction<eglDestroySyncDelegate>("eglDestroySync");
        eglGetConfigAttrib = GetFunction<eglGetConfigAttribDelegate>("eglGetConfigAttrib");
        eglGetConfigs = GetFunction<eglGetConfigsDelegate>("eglGetConfigs");
        eglGetCurrentContext = GetFunction<eglGetCurrentContextDelegate>("eglGetCurrentContext");
        eglGetCurrentDisplay = GetFunction<eglGetCurrentDisplayDelegate>("eglGetCurrentDisplay");
        eglGetCurrentSurface = GetFunction<eglGetCurrentSurfaceDelegate>("eglGetCurrentSurface");
        eglGetDisplay = GetFunction<eglGetDisplayDelegate>("eglGetDisplay");
        eglGetError = GetFunction<eglGetErrorDelegate>("eglGetError");
        eglGetPlatformDisplay = GetFunction<eglGetPlatformDisplayDelegate>("eglGetPlatformDisplay");
        eglGetProcAddress = GetFunction<eglGetProcAddressDelegate>("eglGetProcAddress");
        eglGetSyncAttrib = GetFunction<eglGetSyncAttribDelegate>("eglGetSyncAttrib");
        eglInitialize = GetFunction<eglInitializeDelegate>("eglInitialize");
        eglMakeCurrent = GetFunction<eglMakeCurrentDelegate>("eglMakeCurrent");
        eglQueryAPI = GetFunction<eglQueryAPIDelegate>("eglQueryAPI");
        eglQueryContext = GetFunction<eglQueryContextDelegate>("eglQueryContext");
        eglQueryString = GetFunction<eglQueryStringDelegate>("eglQueryString");
        eglQuerySurface = GetFunction<eglQuerySurfaceDelegate>("eglQuerySurface");
        eglReleaseTexImage = GetFunction<eglReleaseTexImageDelegate>("eglReleaseTexImage");
        eglReleaseThread = GetFunction<eglReleaseThreadDelegate>("eglReleaseThread");
        eglSwapBuffers = GetFunction<eglSwapBuffersDelegate>("eglSwapBuffers");
        eglSwapInterval = GetFunction<eglSwapIntervalDelegate>("eglSwapInterval");
        eglTerminate = GetFunction<eglTerminateDelegate>("eglTerminate");
        eglWaitClient = GetFunction<eglWaitClientDelegate>("eglWaitClient");
        eglWaitGL = GetFunction<eglWaitGLDelegate>("eglWaitGL");
        eglWaitNative = GetFunction<eglWaitNativeDelegate>("eglWaitNative");
        eglWaitSync = GetFunction<eglWaitSyncDelegate>("eglWaitSync");
    }

    private static T GetFunction<T>(string name) where T : Delegate
    {
        if (NativeLibrary.TryGetExport(_libHandle, name, out IntPtr ptr))
        {
            return Marshal.GetDelegateForFunctionPointer<T>(ptr);
        }
        else
        {
            throw new EntryPointNotFoundException($"No se encontró la función {name} en la librería EGL.");
        }
    }
}

