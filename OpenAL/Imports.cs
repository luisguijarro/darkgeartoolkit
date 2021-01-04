using System;
using System.Security;
using System.Runtime.InteropServices;

namespace dgtk.OpenAL
{
    public static partial class ALC // OpenAL: Commandos de Contexto.
    {
        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alcCreateContext", ExactSpelling = true)]
        public static extern IntPtr alcCreateContext( IntPtr device, int[] attrlist );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alcMakeContextCurrent", ExactSpelling = true)]
        public static extern bool alcMakeContextCurrent( IntPtr context );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alcProcessContext", ExactSpelling = true)]
        public static extern void alcProcessContext( IntPtr context );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alcSuspendContext", ExactSpelling = true)]
        public static extern void alcSuspendContext( IntPtr context );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alcDestroyContext", ExactSpelling = true)]
        public static extern void alcDestroyContext( IntPtr context );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alcGetCurrentContext", ExactSpelling = true)]
        public static extern IntPtr alcGetCurrentContext();

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alcGetContextsDevice", ExactSpelling = true)]
        public static extern IntPtr alcGetContextsDevice( IntPtr context );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alcOpenDevice", ExactSpelling = true)]
        public static extern IntPtr alcOpenDevice( string devicename );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alcCloseDevice", ExactSpelling = true)]
        public static extern bool alcCloseDevice( IntPtr device );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alcGetError", ExactSpelling = true)]
        public static extern ALC_ERROR alcGetError( IntPtr device );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alcIsExtensionPresent", ExactSpelling = true)]
        public static extern bool alcIsExtensionPresent( IntPtr device, string extname );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alcGetProcAddress", ExactSpelling = true)]
        public static extern IntPtr alcGetProcAddress( IntPtr device, string funcname );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alcGetEnumValue", ExactSpelling = true)]
        public static extern ALCEnum alcGetEnumValue( IntPtr device, string enumname );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alcGetString", ExactSpelling = true)]
        public static extern IntPtr alcGetString( IntPtr device, ALC_GetStringParam param );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alcGetIntegerv", ExactSpelling = true)]
        public static extern void alcGetIntegerv( IntPtr device, ALC_GetIntegerParam param, int size, int[] data );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alcCaptureOpenDevice", ExactSpelling = true)]
        public static extern IntPtr alcCaptureOpenDevice( string devicename, uint frequency, ALC_BufferFormat format, int buffersize );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alcCaptureCloseDevice", ExactSpelling = true)]
        public static extern bool alcCaptureCloseDevice( IntPtr device );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alcCaptureStart", ExactSpelling = true)]
        public static extern void alcCaptureStart( IntPtr device );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alcCaptureStop", ExactSpelling = true)]
        public static extern void alcCaptureStop( IntPtr device );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alcCaptureSamples", ExactSpelling = true)]
        public static extern void alcCaptureSamples( IntPtr device, IntPtr buffer, int samples );
    }
    
    public static partial class AL // OpenAL: Comandos miscelaneos
    {
        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alEnable", ExactSpelling = true)]
        public static extern void alEnable( ALEnum capability );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alDisable", ExactSpelling = true)]
        public static extern void alDisable( ALEnum capability );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alIsEnabled", ExactSpelling = true)]
        public static extern bool alIsEnabled( ALEnum capability ); 

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alGetString", ExactSpelling = true)]
        public static extern IntPtr alGetString( AL_GetStringParam param );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alGetBooleanv", ExactSpelling = true)]
        public static unsafe extern void alGetBooleanv( AL_GetParam param, bool* data );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alGetIntegerv", ExactSpelling = true)]
        public static unsafe extern void alGetIntegerv( AL_GetParam param, int* data );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alGetFloatv", ExactSpelling = true)]
        public static unsafe extern void alGetFloatv( AL_GetParam param, float* data );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alGetDoublev", ExactSpelling = true)]
        public static unsafe extern void alGetDoublev( AL_GetParam param, double* data );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alGetBoolean", ExactSpelling = true)]
        public static extern bool alGetBoolean( AL_GetParam param );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alGetInteger", ExactSpelling = true)]
        public static extern int alGetInteger( AL_GetParam param );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alGetFloat", ExactSpelling = true)]
        public static extern float alGetFloat( AL_GetParam param );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alGetDouble", ExactSpelling = true)]
        public static extern double alGetDouble( AL_GetParam param );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alGetError", ExactSpelling = true)]
        public static extern AL_ERROR alGetError();

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alGetBoolean", ExactSpelling = true)]
        public static extern bool alIsExtensionPresent( string extname );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alGetProcAddress", ExactSpelling = true)]
        public static extern IntPtr alGetProcAddress( string fname );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alGetEnumValue", ExactSpelling = true)]
        public static extern bool alGetEnumValue( string ename );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alListenerf", ExactSpelling = true)]
        public static extern void alListenerf( AL_ListenerifParam param, float value );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alListener3f", ExactSpelling = true)]
        public static extern void alListener3f( AL_Listener3vParam param, float value1, float value2, float value3 );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alListenerfv", ExactSpelling = true)]
        public static extern void alListenerfv( AL_Listener3vParam param, float[] values ); 

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alListeneri", ExactSpelling = true)]
        public static extern void alListeneri( AL_ListenerifParam param, int value );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alListener3i", ExactSpelling = true)]
        public static extern void alListener3i( AL_Listener3vParam param, int value1, int value2, int value3 );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alListeneriv", ExactSpelling = true)]
        public static extern void alListeneriv( AL_ListenerifParam param, int[] values );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alGetListenerf", ExactSpelling = true)]
        public static unsafe extern void alGetListenerf( AL_ListenerifParam param, [Out] float* value );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alGetListener3f", ExactSpelling = true)]
        public static unsafe extern void alGetListener3f( AL_Listener3vParam param, [Out] float* value1, [Out] float* value2, [Out] float* value3 );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alGetListenerfv", ExactSpelling = true)]
        public static unsafe extern void alGetListenerfv( AL_Listener3vParam param, [Out] float* values );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alGetListeneri", ExactSpelling = true)]
        public static unsafe extern void alGetListeneri( AL_ListenerifParam param, [Out] int* value );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alGetListener3i", ExactSpelling = true)]
        public static unsafe extern void alGetListener3i( AL_Listener3vParam param, [Out] int* value1, [Out] int* value2, [Out] int* value3 );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alGetListeneriv", ExactSpelling = true)]
        public static unsafe extern void alGetListeneriv( AL_Listener3vParam param, [Out] int* values );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alGenSources", ExactSpelling = true)]
        public static unsafe extern void alGenSources(Int32 n, [Out] UInt32* idsources);

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alDeleteSources", ExactSpelling = true)]
        public static unsafe extern void alDeleteSources( int n, uint* sources );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alIsSource", ExactSpelling = true)]
        public static extern bool alIsSource( uint sid ); 

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alSourcef", ExactSpelling = true)]
        public static extern void alSourcef( uint sid, AL_SourcefParam param, float value ); 

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alSource3f", ExactSpelling = true)]
        public static extern void alSource3f( uint sid, AL_Source3Param param, float value1, float value2, float value3 );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alSourcefv", ExactSpelling = true)]
        public static unsafe extern void alSourcefv( uint sid, AL_Source3Param param, float* values ); 

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alSourcei", ExactSpelling = true)]
        public static extern void alSourcei( uint sid, AL_SourceiParam param, int value ); 

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alSource3i", ExactSpelling = true)]
        public static extern void alSource3i( uint sid, AL_Source3Param param, int value1, int value2, int value3 );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alSourceiv", ExactSpelling = true)]
        public static unsafe extern void alSourceiv( uint sid, AL_Source3Param param, int* values );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alGetSourcef", ExactSpelling = true)]
        public static unsafe extern void alGetSourcef( uint sid, AL_SourcefParam param, [Out] float* value );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alGetSource3f", ExactSpelling = true)]
        public static unsafe extern void alGetSource3f( uint sid, AL_Source3Param param, [Out] float* value1, [Out] float* value2, [Out] float* value3);

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alGetSourcefv", ExactSpelling = true)]
        public static unsafe extern void alGetSourcefv( uint sid, AL_Source3Param param, [Out] float* values );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alGetSourcei", ExactSpelling = true)]
        public static unsafe extern void alGetSourcei( uint sid,  AL_GetSourceiParam param, [Out] int* value );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alGetSource3i", ExactSpelling = true)]
        public static unsafe extern void alGetSource3i( uint sid, AL_Source3Param param, [Out] int* value1, [Out] int* value2, [Out] int* value3);

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alGetSourceiv", ExactSpelling = true)]
        public static unsafe extern void alGetSourceiv( uint sid,  AL_Source3Param param, [Out] int* values );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alSourcePlayv", ExactSpelling = true)]
        public static unsafe extern void alSourcePlayv( int ns, uint* sids );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alSourceStopv", ExactSpelling = true)]
        public static unsafe extern void alSourceStopv( int ns, uint* sids );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alSourceRewindv", ExactSpelling = true)]
        public static unsafe extern void alSourceRewindv( int ns, uint* sids );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alSourcePausev", ExactSpelling = true)]
        public static unsafe extern void alSourcePausev( int ns, uint* sids );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alSourcePlay", ExactSpelling = true)]
        public static extern void alSourcePlay( uint sid );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alSourceStop", ExactSpelling = true)]
        public static extern void alSourceStop( uint sid );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alSourceRewind", ExactSpelling = true)]
        public static extern void alSourceRewind( uint sid );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alSourcePause", ExactSpelling = true)]
        public static extern void alSourcePause( uint sid );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alSourceQueueBuffers", ExactSpelling = true)]
        public static unsafe extern void alSourceQueueBuffers( uint sid, int numEntries, uint* bids );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alSourceUnqueueBuffers", ExactSpelling = true)]
        public static unsafe extern void alSourceUnqueueBuffers( uint sid, int numEntries, uint* bids );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alGenBuffers", ExactSpelling = true)]
        public static unsafe extern void alGenBuffers( int n, [Out] uint* buffers );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alDeleteBuffers", ExactSpelling = true)]
        public static unsafe extern void alDeleteBuffers( int n, uint* buffers );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alIsBuffer", ExactSpelling = true)]
        public static extern bool alIsBuffer( uint bid );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alBufferData", ExactSpelling = true)]
        public static extern void alBufferData( uint bid, AL_FORMAT format, IntPtr data, int size, int freq );



        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alBufferf", ExactSpelling = true)]
        public static extern void alBufferf( uint bid, AL_BufferParam param, float value );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alBuffer3f", ExactSpelling = true)]
        public static extern void alBuffer3f( uint bid, AL_BufferParam param, float value1, float value2, float value3 );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alBufferfv", ExactSpelling = true)]
        public static unsafe extern void alBufferfv( uint bid, AL_BufferParam param, float* values );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alBufferi", ExactSpelling = true)]
        public static extern void alBufferi( uint bid, AL_BufferParam param, int value );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alBuffer3i", ExactSpelling = true)]
        public static extern void alBuffer3i( uint bid, AL_BufferParam param, int value1, int value2, int value3 );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alBufferiv", ExactSpelling = true)]
        public static unsafe extern void alBufferiv( uint bid, AL_BufferParam param, int* values );



        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alGetBufferf", ExactSpelling = true)]
        public static extern void alGetBufferf( uint bid, AL_BufferParam param, out float value );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alGetBuffer3f", ExactSpelling = true)]
        public static extern void alGetBuffer3f( uint bid, AL_BufferParam param, out float value1, out float value2, out float value3);

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alGetBufferfv", ExactSpelling = true)]
        public static unsafe extern void alGetBufferfv( uint bid, AL_BufferParam param, [Out] float* values );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alGetBufferi", ExactSpelling = true)]
        public static extern void alGetBufferi( uint bid, AL_BufferParam param, out int value );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alGetBuffer3i", ExactSpelling = true)]
        public static extern void alGetBuffer3i( uint bid, AL_BufferParam param, out int value1, out int value2, out int value3);

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alGetBufferiv", ExactSpelling = true)]
        public static unsafe extern void alGetBufferiv( uint bid, AL_BufferParam param, [Out] int* values );



        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alDopplerFactor", ExactSpelling = true)]
        public static extern void alDopplerFactor( float value );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alDopplerVelocity", ExactSpelling = true)]
        public static extern void alDopplerVelocity( float value );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alSpeedOfSound", ExactSpelling = true)]
        public static extern void alSpeedOfSound( float value );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alDistanceModel", ExactSpelling = true)]
        public static extern void alDistanceModel( AL_DistanceModel distanceModel );
    }

    public static partial class EFX
    {
        /* Create Effect objects. */
        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alGenEffects", ExactSpelling = true)]
        public static unsafe extern void alGenEffects( int n, uint* effects );

        /* Delete Effect objects. */
        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alDeleteEffects", ExactSpelling = true)]
        public static unsafe extern void alDeleteEffects( int n, uint* effects );

        /* Verify a handle is a valid Effect. */ 
        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alIsEffect", ExactSpelling = true)]
        public static extern bool alIsEffect( uint eid );

        /* Set an integer parameter for an Effect object. */
        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alEffecti", ExactSpelling = true)]
        public static extern void alEffecti( uint eid, AL_EffectParam param, int value); 


        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alEffectiv", ExactSpelling = true)]
        public static unsafe extern void alEffectiv( uint eid, AL_EffectParam param, int* values ); 

        /* Set a floating point parameter for an Effect object. */
        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alEffectf", ExactSpelling = true)]
        public static extern void alEffectf( uint eid, AL_EffectParam param, float value); 

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alEffectfv", ExactSpelling = true)]
        public static unsafe extern void alEffectfv( uint eid, AL_EffectParam param, float* values ); 

        /* Get an integer parameter for an Effect object. */
        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alGetEffecti", ExactSpelling = true)]
        public static unsafe extern void alGetEffecti( uint eid, AL_EffectParam pname, int* value );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alGetEffrctiv", ExactSpelling = true)]
        public static unsafe extern void alGetEffrctiv( uint eid, AL_EffectParam pname, int* values );

        /* Get a floating point parameter for an Effect object. */
        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alGetEffectf", ExactSpelling = true)]
        public static unsafe extern void alGetEffectf( uint eid, AL_EffectParam pname, float* value );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alGetEffectfv", ExactSpelling = true)]
        public static unsafe extern void alGetEffectfv( uint eid, AL_EffectParam pname, float* values );


        /**
        * Filter object functions
        */

        /* Create Filter objects. */
        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alGenFilters", ExactSpelling = true)]
        public static unsafe extern void alGenFilters( int n, uint* filters ); 

        /* Delete Filter objects. */
        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alDeleteFilters", ExactSpelling = true)]
        public static unsafe extern void alDeleteFilters( int n, uint* filters );

        /* Verify a handle is a valid Filter. */ 
        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alIsFilter", ExactSpelling = true)]
        public static extern bool alIsFilter( uint fid );

        /* Set an integer parameter for a Filter object. */
        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alFilteri", ExactSpelling = true)]
        public static extern void alFilteri( uint fid, AL_FilterParam param, int value ); 

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alFilteriv", ExactSpelling = true)]
        public static unsafe extern void alFilteriv( uint fid, AL_FilterParam param, int* values ); 

        /* Set a floating point parameter for an Filter object. */
        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alFilterf", ExactSpelling = true)]
        public static extern void alFilterf( uint fid, AL_FilterParam param, float value); 

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alFilterfv", ExactSpelling = true)]
        public static unsafe extern void alFilterfv( uint fid, AL_FilterParam param, float* values ); 

        /* Get an integer parameter for a Filter object. */
        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alGetFilteri", ExactSpelling = true)]
        public static unsafe extern void alGetFilteri( uint fid, AL_FilterParam pname, int* value );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alGetFilteriv", ExactSpelling = true)]
        public static unsafe extern void alGetFilteriv( uint fid, AL_FilterParam pname, int* values );

        /* Get a floating point parameter for a Filter object. */
        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alGetFilterf", ExactSpelling = true)]
        public static unsafe extern void alGetFilterf( uint fid, AL_FilterParam pname, float* value );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alGetFilterfv", ExactSpelling = true)]
        public static unsafe extern void alGetFilterfv( uint fid, AL_FilterParam pname, float* values );


        /**
        * Auxiliary Slot object functions
        */

        /* Create Auxiliary Slot objects. */
        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alGenAuxiliaryEffectSlots", ExactSpelling = true)]
        public static unsafe extern void alGenAuxiliaryEffectSlots( int n, uint* slots ); 

        /* Delete Auxiliary Slot objects. */
        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alDdeleteAuxiliaryEffectSlots", ExactSpelling = true)]
        public static unsafe extern void alDdeleteAuxiliaryEffectSlots( int n, uint* slots );

        /* Verify a handle is a valid Auxiliary Slot. */ 
        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alIsAuxiliaryEffectSlot", ExactSpelling = true)]
        public static extern bool alIsAuxiliaryEffectSlot( uint slot ); 

        /* Set an integer parameter for a Auxiliary Slot object. */
        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alAuxiliaryEffectSloti", ExactSpelling = true)]
        public static extern void alAuxiliaryEffectSloti( uint asid, AL_AuxiliaryEffectSlot param, int value ); 

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alAuxiliaryEffectSlotiv", ExactSpelling = true)]
        public static unsafe extern void alAuxiliaryEffectSlotiv( uint asid, AL_AuxiliaryEffectSlot param, int* values ); 

        /* Set a floating point parameter for an Auxiliary Slot object. */
        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alAuxiliaryEffectSlotf", ExactSpelling = true)]
        public static extern void alAuxiliaryEffectSlotf( uint asid, AL_AuxiliaryEffectSlot param, float value ); 

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alAuxiliaryEffectSlotfv", ExactSpelling = true)]
        public static unsafe extern void alAuxiliaryEffectSlotfv( uint asid, AL_AuxiliaryEffectSlot param, float* values ); 

        /* Get an integer parameter for a Auxiliary Slot object. */
        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alGetAuxiliaryEffectSloti", ExactSpelling = true)]
        public static unsafe extern void alGetAuxiliaryEffectSloti( uint asid, AL_AuxiliaryEffectSlot pname, int* value );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alGetAuxiliaryEffectSlotiv", ExactSpelling = true)]
        public static unsafe extern void alGetAuxiliaryEffectSlotiv( uint asid, AL_AuxiliaryEffectSlot pname, int* values );

        /* Get a floating point parameter for a Auxiliary Slot object. */
        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alGetAuxiliaryEffectSlotf", ExactSpelling = true)]
        public static unsafe extern void alGetAuxiliaryEffectSlotf( uint asid, AL_AuxiliaryEffectSlot pname, float* value );

        [SuppressUnmanagedCodeSecurity]
		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alGetAuxiliaryEffectSlotfv", ExactSpelling = true)]
        public static unsafe extern void alGetAuxiliaryEffectSlotfv( uint asid, AL_AuxiliaryEffectSlot pname, float* values );
    }
}