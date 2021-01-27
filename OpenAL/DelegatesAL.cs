using System;
using System.Security;
using System.Runtime.InteropServices;

namespace dgtk.OpenAL
{
    internal static class delegatesALC // OpenAL: Commandos de Contexto.
    {
        internal delegate IntPtr alcCreateContext( IntPtr device, int[] attrlist );

        internal delegate bool alcMakeContextCurrent( IntPtr context );

        internal delegate void alcProcessContext( IntPtr context );

        internal delegate void alcSuspendContext( IntPtr context );

        internal delegate void alcDestroyContext( IntPtr context );

        internal delegate IntPtr alcGetCurrentContext();

        internal delegate IntPtr alcGetContextsDevice( IntPtr context );

        internal delegate IntPtr alcOpenDevice( string devicename );

        internal delegate bool alcCloseDevice( IntPtr device );

        internal delegate ALC_ERROR alcGetError( IntPtr device );

        internal delegate bool alcIsExtensionPresent( IntPtr device, string extname );

        internal delegate IntPtr alcGetProcAddress( IntPtr device, string funcname );

        internal delegate ALCEnum alcGetEnumValue( IntPtr device, string enumname );

        internal delegate IntPtr alcGetString( IntPtr device, ALC_GetStringParam param );

        internal delegate void alcGetIntegerv( IntPtr device, ALC_GetIntegerParam param, int size, int[] data );

        internal delegate IntPtr alcCaptureOpenDevice( string devicename, uint frequency, ALC_BufferFormat format, int buffersize );

        internal delegate bool alcCaptureCloseDevice( IntPtr device );

        internal delegate void alcCaptureStart( IntPtr device );

        internal delegate void alcCaptureStop( IntPtr device );

        internal delegate void alcCaptureSamples( IntPtr device, IntPtr buffer, int samples );
    }
    
    internal static partial class delegatesAL // OpenAL: Comandos miscelaneos
    {
        internal delegate void alEnable( ALEnum capability );

        internal delegate void alDisable( ALEnum capability );

        internal delegate bool alIsEnabled( ALEnum capability ); 

        internal delegate IntPtr alGetString( AL_GetStringParam param );

        internal unsafe delegate void alGetBooleanv( AL_GetParam param, bool* data );

        internal unsafe delegate void alGetIntegerv( AL_GetParam param, int* data );

        internal unsafe delegate void alGetFloatv( AL_GetParam param, float* data );

        internal unsafe delegate void alGetDoublev( AL_GetParam param, double* data );

        internal delegate bool alGetBoolean( AL_GetParam param );

        internal delegate int alGetInteger( AL_GetParam param );

        internal delegate float alGetFloat( AL_GetParam param );

        internal delegate double alGetDouble( AL_GetParam param );

        internal delegate AL_ERROR alGetError();

        internal delegate bool alIsExtensionPresent( string extname );

        internal delegate IntPtr alGetProcAddress( string fname );

        internal delegate bool alGetEnumValue( string ename );

        internal delegate void alListenerf( AL_ListenerifParam param, float value );

        internal delegate void alListener3f( AL_Listener3vParam param, float value1, float value2, float value3 );

        internal delegate void alListenerfv( AL_Listener3vParam param, float[] values ); 

        internal delegate void alListeneri( AL_ListenerifParam param, int value );

        internal delegate void alListener3i( AL_Listener3vParam param, int value1, int value2, int value3 );

        internal delegate void alListeneriv( AL_ListenerifParam param, int[] values );

        internal unsafe delegate void alGetListenerf( AL_ListenerifParam param, [Out] float* value );

        internal unsafe delegate void alGetListener3f( AL_Listener3vParam param, [Out] float* value1, [Out] float* value2, [Out] float* value3 );

        internal unsafe delegate void alGetListenerfv( AL_Listener3vParam param, [Out] float* values );

        internal unsafe delegate void alGetListeneri( AL_ListenerifParam param, [Out] int* value );

        internal unsafe delegate void alGetListener3i( AL_Listener3vParam param, [Out] int* value1, [Out] int* value2, [Out] int* value3 );

        internal unsafe delegate void alGetListeneriv( AL_Listener3vParam param, [Out] int* values );

        internal unsafe delegate void alGenSources(Int32 n, [Out] UInt32* idsources);

        internal unsafe delegate void alDeleteSources( int n, uint* sources );

        internal delegate bool alIsSource( uint sid ); 

        internal delegate void alSourcef( uint sid, AL_SourcefParam param, float value ); 

        internal delegate void alSource3f( uint sid, AL_Source3Param param, float value1, float value2, float value3 );

        internal unsafe delegate void alSourcefv( uint sid, AL_Source3Param param, float* values ); 

        internal delegate void alSourcei( uint sid, AL_SourceiParam param, int value ); 

        internal delegate void alSource3i( uint sid, AL_Source3Param param, int value1, int value2, int value3 );

        internal unsafe delegate void alSourceiv( uint sid, AL_Source3Param param, int* values );

        internal unsafe delegate void alGetSourcef( uint sid, AL_SourcefParam param, [Out] float* value );

        internal unsafe delegate void alGetSource3f( uint sid, AL_Source3Param param, [Out] float* value1, [Out] float* value2, [Out] float* value3);

        internal unsafe delegate void alGetSourcefv( uint sid, AL_Source3Param param, [Out] float* values );

        internal unsafe delegate void alGetSourcei( uint sid,  AL_GetSourceiParam param, [Out] int* value );

        internal unsafe delegate void alGetSource3i( uint sid, AL_Source3Param param, [Out] int* value1, [Out] int* value2, [Out] int* value3);

        internal unsafe delegate void alGetSourceiv( uint sid,  AL_Source3Param param, [Out] int* values );

        internal unsafe delegate void alSourcePlayv( int ns, uint* sids );

        internal unsafe delegate void alSourceStopv( int ns, uint* sids );

        internal unsafe delegate void alSourceRewindv( int ns, uint* sids );

        internal unsafe delegate void alSourcePausev( int ns, uint* sids );

        internal delegate void alSourcePlay( uint sid );

        internal delegate void alSourceStop( uint sid );

        internal delegate void alSourceRewind( uint sid );

        internal delegate void alSourcePause( uint sid );

        internal unsafe delegate void alSourceQueueBuffers( uint sid, int numEntries, uint* bids );

        internal unsafe delegate void alSourceUnqueueBuffers( uint sid, int numEntries, uint* bids );

        internal unsafe delegate void alGenBuffers( int n, [Out] uint* buffers );

        internal unsafe delegate void alDeleteBuffers( int n, uint* buffers );

        internal delegate bool alIsBuffer( uint bid );

        internal delegate void alBufferData( uint bid, AL_FORMAT format, IntPtr data, int size, int freq );

        internal delegate void alBufferf( uint bid, AL_BufferParam param, float value );

        internal delegate void alBuffer3f( uint bid, AL_BufferParam param, float value1, float value2, float value3 );

        internal unsafe delegate void alBufferfv( uint bid, AL_BufferParam param, float* values );

        internal delegate void alBufferi( uint bid, AL_BufferParam param, int value );

        internal delegate void alBuffer3i( uint bid, AL_BufferParam param, int value1, int value2, int value3 );

        internal unsafe delegate void alBufferiv( uint bid, AL_BufferParam param, int* values );

        internal delegate void alGetBufferf( uint bid, AL_BufferParam param, out float value );

        internal delegate void alGetBuffer3f( uint bid, AL_BufferParam param, out float value1, out float value2, out float value3);

        internal unsafe delegate void alGetBufferfv( uint bid, AL_BufferParam param, [Out] float* values );

        internal delegate void alGetBufferi( uint bid, AL_BufferParam param, out int value );

        internal delegate void alGetBuffer3i( uint bid, AL_BufferParam param, out int value1, out int value2, out int value3);

        internal unsafe delegate void alGetBufferiv( uint bid, AL_BufferParam param, [Out] int* values );

        internal delegate void alDopplerFactor( float value );

        internal delegate void alDopplerVelocity( float value );

        internal delegate void alSpeedOfSound( float value );

        internal delegate void alDistanceModel( AL_DistanceModel distanceModel );
    }

    internal static partial class delegatesEFX
    {
        internal unsafe delegate void alGenEffects( int n, uint* effects );

        internal unsafe delegate void alDeleteEffects( int n, uint* effects );

        internal delegate bool alIsEffect( uint eid );

        internal delegate void alEffecti( uint eid, AL_EffectParam param, int value); 

        internal unsafe delegate void alEffectiv( uint eid, AL_EffectParam param, int* values ); 

        internal delegate void alEffectf( uint eid, AL_EffectParam param, float value); 

        internal unsafe delegate void alEffectfv( uint eid, AL_EffectParam param, float* values ); 

        internal unsafe delegate void alGetEffecti( uint eid, AL_EffectParam pname, int* value );

        internal unsafe delegate void alGetEffrctiv( uint eid, AL_EffectParam pname, int* values );

        internal unsafe delegate void alGetEffectf( uint eid, AL_EffectParam pname, float* value );

        internal unsafe delegate void alGetEffectfv( uint eid, AL_EffectParam pname, float* values );

        internal unsafe delegate void alGenFilters( int n, uint* filters ); 

        internal unsafe delegate void alDeleteFilters( int n, uint* filters );

        internal delegate bool alIsFilter( uint fid );

        internal delegate void alFilteri( uint fid, AL_FilterParam param, int value ); 

        internal unsafe delegate void alFilteriv( uint fid, AL_FilterParam param, int* values ); 

        internal delegate void alFilterf( uint fid, AL_FilterPassParam param, float value); 

        internal unsafe delegate void alFilterfv( uint fid, AL_FilterPassParam param, float* values ); 

        internal unsafe delegate void alGetFilteri( uint fid, AL_FilterParam pname, int* value );

        internal unsafe delegate void alGetFilteriv( uint fid, AL_FilterParam pname, int* values );

        internal unsafe delegate void alGetFilterf( uint fid, AL_FilterPassParam pname, float* value );

        internal unsafe delegate void alGetFilterfv( uint fid, AL_FilterPassParam pname, float* values );

        internal unsafe delegate void alGenAuxiliaryEffectSlots( int n, uint* slots ); 

        internal unsafe delegate void alDdeleteAuxiliaryEffectSlots( int n, uint* slots );

        internal delegate bool alIsAuxiliaryEffectSlot( uint slot ); 

        internal delegate void alAuxiliaryEffectSloti( uint asid, AL_AuxiliaryEffectSlot param, int value ); 

        internal unsafe delegate void alAuxiliaryEffectSlotiv( uint asid, AL_AuxiliaryEffectSlot param, int* values ); 

        internal delegate void alAuxiliaryEffectSlotf( uint asid, AL_AuxiliaryEffectSlot param, float value ); 

        internal unsafe delegate void alAuxiliaryEffectSlotfv( uint asid, AL_AuxiliaryEffectSlot param, float* values ); 

        internal unsafe delegate void alGetAuxiliaryEffectSloti( uint asid, AL_AuxiliaryEffectSlot pname, int* value );

        internal unsafe delegate void alGetAuxiliaryEffectSlotiv( uint asid, AL_AuxiliaryEffectSlot pname, int* values );

        internal unsafe delegate void alGetAuxiliaryEffectSlotf( uint asid, AL_AuxiliaryEffectSlot pname, float* value );

        internal unsafe delegate void alGetAuxiliaryEffectSlotfv( uint asid, AL_AuxiliaryEffectSlot pname, float* values );
    }
}