using System;
using System.Security;
using System.Runtime.InteropServices;

namespace dgtk.OpenAL
{
    public static partial class ALC // OpenAL: Commandos de Contexto.
    {
        public static IntPtr alcCreateContext( IntPtr device, int[] attrlist )
        {
            return internalsALC.alcCreateContext( device, attrlist );
        }

        public static bool alcMakeContextCurrent( IntPtr context )
        {
            return internalsALC.alcMakeContextCurrent( context );
        }

        public static void alcProcessContext( IntPtr context )
        {
            internalsALC.alcProcessContext(context);
        }

        public static void alcSuspendContext( IntPtr context )
        {
            internalsALC.alcSuspendContext( context );
        }

        public static void alcDestroyContext( IntPtr context )
        {
            internalsALC.alcDestroyContext( context );
        }

        public static IntPtr alcGetCurrentContext()
        {
            return internalsALC.alcGetCurrentContext();
        }

        public static IntPtr alcGetContextsDevice( IntPtr context )
        {
            return internalsALC.alcGetContextsDevice( context );
        }

        public static IntPtr alcOpenDevice( string devicename )
        {
            return internalsALC.alcOpenDevice( devicename );
        }

        public static bool alcCloseDevice( IntPtr device )
        {
            return internalsALC.alcCloseDevice( device );
        }

        public static ALC_ERROR alcGetError( IntPtr device )
        {
            return internalsALC.alcGetError( device );
        }

        public static bool alcIsExtensionPresent( IntPtr device, string extname )
        {
            return internalsALC.alcIsExtensionPresent( device, extname );
        }

        public static IntPtr alcGetProcAddress( IntPtr device, string funcname )
        {
            return alcGetProcAddress( device, funcname );
        }

        public static ALCEnum alcGetEnumValue( IntPtr device, string enumname )
        {
            return internalsALC.alcGetEnumValue( device, enumname );
        }

        public static IntPtr alcGetString( IntPtr device, ALC_GetStringParam param )
        {
            return internalsALC.alcGetString( device, param );
        }

        public static void alcGetIntegerv( IntPtr device, ALC_GetIntegerParam param, int size, int[] data )
        {
            internalsALC.alcGetIntegerv( device, param, size, data );
        }

        public static IntPtr alcCaptureOpenDevice( string devicename, uint frequency, ALC_BufferFormat format, int buffersize )
        {
            return internalsALC.alcCaptureOpenDevice( devicename, frequency, format, buffersize );
        }

        public static bool alcCaptureCloseDevice( IntPtr device )
        {
            return internalsALC.alcCaptureCloseDevice( device );
        }

        public static void alcCaptureStart( IntPtr device )
        {
            internalsALC.alcCaptureStart( device );
        }

        public static void alcCaptureStop( IntPtr device )
        {
            internalsALC.alcCaptureStop( device );
        }

        public static void alcCaptureSamples( IntPtr device, IntPtr buffer, int samples )
        {
            internalsALC.alcCaptureSamples( device, buffer, samples );
        }
    }
    
    public static partial class AL // OpenAL: Comandos miscelaneos
    {
        public static void alEnable( ALEnum capability )
        {
            internalsAL.alEnable( capability );
        }

        public static void alDisable( ALEnum capability )
        {
            internalsAL.alDisable( capability );
        }

        public static bool alIsEnabled( ALEnum capability )
        {
            return internalsAL.alIsEnabled( capability );
        } 

        public static IntPtr alGetString( AL_GetStringParam param )
        {
            return internalsAL.alGetString( param );
        }

        public static unsafe void alGetBooleanv( AL_GetParam param, bool* data )
        {
            internalsAL.alGetBooleanv( param, data );
        }

        public static unsafe void alGetIntegerv( AL_GetParam param, int* data )
        {
            internalsAL.alGetIntegerv( param, data );
        }

        public static unsafe void alGetFloatv( AL_GetParam param, float* data )
        {
            internalsAL.alGetFloatv( param, data );
        }

        public static unsafe void alGetDoublev( AL_GetParam param, double* data )
        {
            internalsAL.alGetDoublev( param, data );
        }

        public static bool alGetBoolean( AL_GetParam param )
        {
            return internalsAL.alGetBoolean( param );
        }

        public static int alGetInteger( AL_GetParam param )
        {
            return internalsAL.alGetInteger( param );
        }

        public static float alGetFloat( AL_GetParam param )
        {
            return internalsAL.alGetFloat( param );
        }

        public static double alGetDouble( AL_GetParam param )
        {
            return internalsAL.alGetDouble( param );
        }

        public static AL_ERROR alGetError()
        {
            return internalsAL.alGetError();
        }

        public static bool alIsExtensionPresent( string extname )
        {
            return internalsAL.alIsExtensionPresent( extname );
        }

        public static IntPtr alGetProcAddress( string fname )
        {
            return internalsAL.alGetProcAddress( fname );
        }

        public static bool alGetEnumValue( string ename )
        {
            return internalsAL.alGetEnumValue( ename );
        }

        public static void alListenerf( AL_ListenerifParam param, float value )
        {
            internalsAL.alListenerf( param, value );
        }

        public static void alListener3f( AL_Listener3vParam param, float value1, float value2, float value3 )
        {
            internalsAL.alListener3f( param, value1, value2, value3 );
        }

        public static void alListenerfv( AL_Listener3vParam param, float[] values )
        {
            internalsAL.alListenerfv( param, values );
        } 

        public static void alListeneri( AL_ListenerifParam param, int value )
        {
            internalsAL.alListeneri( param, value );
        }

        public static void alListener3i( AL_Listener3vParam param, int value1, int value2, int value3 )
        {
            internalsAL.alListener3i( param, value1, value2, value3 );
        }

        public static void alListeneriv( AL_ListenerifParam param, int[] values )
        {
            internalsAL.alListeneriv( param, values );
        }

        public static unsafe void alGetListenerf( AL_ListenerifParam param, [Out] float* value )
        {
            internalsAL.alGetListenerf( param, value );
        }

        public static unsafe void alGetListener3f( AL_Listener3vParam param, [Out] float* value1, [Out] float* value2, [Out] float* value3 )
        {
            internalsAL.alGetListener3f( param, value1, value2, value3 );
        }

        public static unsafe void alGetListenerfv( AL_Listener3vParam param, [Out] float* values )
        {
            internalsAL.alGetListenerfv( param, values );
        }

        public static unsafe void alGetListeneri( AL_ListenerifParam param, [Out] int* value )
        {
            internalsAL.alGetListeneri( param, value );
        }

        public static unsafe void alGetListener3i( AL_Listener3vParam param, [Out] int* value1, [Out] int* value2, [Out] int* value3 )
        {
            internalsAL.alGetListener3i( param, value1, value2, value3 );
        }

        public static unsafe void alGetListeneriv( AL_Listener3vParam param, [Out] int* values )
        {
            internalsAL.alGetListeneriv( param, values );
        }

        public static unsafe void alGenSources(Int32 n, [Out] UInt32* idsources)
        {
            internalsAL.alGenSources(n, idsources);
        }

        public static unsafe void alDeleteSources( int n, uint* sources )
        {
            internalsAL.alDeleteSources( n, sources );
        }

        public static bool alIsSource( uint sid )
        {
            return internalsAL.alIsSource( sid );
        } 

        public static void alSourcef( uint sid, AL_SourcefParam param, float value )
        {
            internalsAL.alSourcef( sid, param, value );
        } 

        public static void alSource3f( uint sid, AL_Source3Param param, float value1, float value2, float value3 )
        {
            internalsAL.alSource3f( sid, param, value1, value2, value3 );
        }

        public static unsafe void alSourcefv( uint sid, AL_Source3Param param, float* values )
        {
            internalsAL.alSourcefv( sid, param, values );
        } 

        public static void alSourcei( uint sid, AL_SourceiParam param, int value )
        {
            internalsAL.alSourcei( sid, param, value );
        } 

        public static void alSource3i( uint sid, AL_Source3Param param, int value1, int value2, int value3 )
        {
            internalsAL.alSource3i( sid, param, value1, value2, value3 );
        }

        public static unsafe void alSourceiv( uint sid, AL_Source3Param param, int* values )
        {
            internalsAL.alSourceiv( sid, param, values );
        }

        public static unsafe void alGetSourcef( uint sid, AL_SourcefParam param, [Out] float* value )
        {
            internalsAL.alGetSourcef( sid, param, value );
        }

        public static unsafe void alGetSource3f( uint sid, AL_Source3Param param, [Out] float* value1, [Out] float* value2, [Out] float* value3)
        {
            internalsAL.alGetSource3f( sid, param, value1, value2, value3);
        }

        public static unsafe void alGetSourcefv( uint sid, AL_Source3Param param, [Out] float* values )
        {
            internalsAL.alGetSourcefv( sid, param, values );
        }

        public static unsafe void alGetSourcei( uint sid,  AL_GetSourceiParam param, [Out] int* value )
        {
            internalsAL.alGetSourcei( sid, param, value );
        }

        public static unsafe void alGetSource3i( uint sid, AL_Source3Param param, [Out] int* value1, [Out] int* value2, [Out] int* value3)
        {
            internalsAL.alGetSource3i( sid, param, value1, value2, value3);
        }

        public static unsafe void alGetSourceiv( uint sid,  AL_Source3Param param, [Out] int* values )
        {
            internalsAL.alGetSourceiv( sid,  param, values );
        }

        public static unsafe void alSourcePlayv( int ns, uint* sids )
        {
            internalsAL.alSourcePlayv( ns, sids );
        }

        public static unsafe void alSourceStopv( int ns, uint* sids )
        {
            internalsAL.alSourceStopv( ns, sids );
        }

        public static unsafe void alSourceRewindv( int ns, uint* sids )
        {
            internalsAL.alSourceRewindv( ns, sids );
        }

        public static unsafe void alSourcePausev( int ns, uint* sids )
        {
            internalsAL.alSourcePausev( ns, sids );
        }

        public static void alSourcePlay( uint sid )
        {
            internalsAL.alSourcePlay( sid );
        }

        public static void alSourceStop( uint sid )
        {
            internalsAL.alSourceStop( sid );
        }

        public static void alSourceRewind( uint sid )
        {
            internalsAL.alSourceRewind( sid );
        }

        public static void alSourcePause( uint sid )
        {
            internalsAL.alSourcePause( sid );
        }

        public static unsafe void alSourceQueueBuffers( uint sid, int numEntries, uint* bids )
        {
            internalsAL.alSourceQueueBuffers( sid, numEntries, bids );
        }

        public static unsafe void alSourceUnqueueBuffers( uint sid, int numEntries, uint* bids )
        {
            internalsAL.alSourceUnqueueBuffers( sid, numEntries, bids );
        }

        public static unsafe void alGenBuffers( int n, [Out] uint* buffers )
        {
            internalsAL.alGenBuffers( n, buffers );
        }

        public static unsafe void alDeleteBuffers( int n, uint* buffers )
        {
            internalsAL.alDeleteBuffers( n, buffers );
        }

        public static bool alIsBuffer( uint bid )
        {
            return internalsAL.alIsBuffer( bid );
        }

        public static void alBufferData( uint bid, AL_FORMAT format, IntPtr data, int size, int freq )
        {
            internalsAL.alBufferData( bid, format, data, size, freq );
        }

        public static void alBufferf( uint bid, AL_BufferParam param, float value )
        {
            internalsAL.alBufferf( bid, param, value );
        }

        public static void alBuffer3f( uint bid, AL_BufferParam param, float value1, float value2, float value3 )
        {
            internalsAL.alBuffer3f( bid, param, value1, value2, value3 );
        }

        public static unsafe void alBufferfv( uint bid, AL_BufferParam param, float* values )
        {
            internalsAL.alBufferfv( bid, param, values );
        }

        public static void alBufferi( uint bid, AL_BufferParam param, int value )
        {
            internalsAL.alBufferi( bid, param, value );
        }

        public static void alBuffer3i( uint bid, AL_BufferParam param, int value1, int value2, int value3 )
        {
            internalsAL.alBuffer3i( bid, param, value1, value2, value3 );
        }

        public static unsafe void alBufferiv( uint bid, AL_BufferParam param, int* values )
        {
            internalsAL.alBufferiv( bid, param, values );
        }

        public static void alGetBufferf( uint bid, AL_BufferParam param, out float value )
        {
            internalsAL.alGetBufferf( bid, param, out value );
        }

        public static void alGetBuffer3f( uint bid, AL_BufferParam param, out float value1, out float value2, out float value3)
        {
            internalsAL.alGetBuffer3f( bid, param, out value1, out value2, out value3);
        }

        public static unsafe void alGetBufferfv( uint bid, AL_BufferParam param, [Out] float* values )
        {
            internalsAL.alGetBufferfv( bid, param, values );
        }

        public static void alGetBufferi( uint bid, AL_BufferParam param, out int value )
        {
            internalsAL.alGetBufferi( bid, param, out value );
        }

        public static void alGetBuffer3i( uint bid, AL_BufferParam param, out int value1, out int value2, out int value3)
        {
            internalsAL.alGetBuffer3i( bid, param, out value1, out value2, out value3);
        }

        public static unsafe void alGetBufferiv( uint bid, AL_BufferParam param, [Out] int* values )
        {
            internalsAL.alGetBufferiv( bid, param, values );
        }

        public static void alDopplerFactor( float value )
        {
            internalsAL.alDopplerFactor( value );
        }

        public static void alDopplerVelocity( float value )
        {
            internalsAL.alDopplerVelocity( value );
        }

        public static void alSpeedOfSound( float value )
        {
            internalsAL.alSpeedOfSound( value );
        }

        public static void alDistanceModel( AL_DistanceModel distanceModel )
        {
            internalsAL.alDistanceModel( distanceModel );
        }
    }

    public static partial class EFX
    {
        public static unsafe void alGenEffects( int n, uint* effects )
        {
            internalsEFX.alGenEffects( n, effects );
        }

        public static unsafe void alDeleteEffects( int n, uint* effects )
        {
            internalsEFX.alDeleteEffects( n, effects );
        }

        public static bool alIsEffect( uint eid )
        {
            return internalsEFX.alIsEffect( eid );
        }

        public static void alEffecti( uint eid, AL_EffectParam param, int value)
        {
            internalsEFX.alEffecti( eid, param, value);
        } 

        public static unsafe void alEffectiv( uint eid, AL_EffectParam param, int* values )
        {
            internalsEFX.alEffectiv( eid, param, values );
        } 

        public static void alEffectf( uint eid, AL_EffectParam param, float value)
        {
            internalsEFX.alEffectf( eid, param, value);
        } 

        public static unsafe void alEffectfv( uint eid, AL_EffectParam param, float* values )
        {
            internalsEFX.alEffectfv( eid, param, values );
        } 

        public static unsafe void alGetEffecti( uint eid, AL_EffectParam pname, int* value )
        {
            internalsEFX.alGetEffecti( eid, pname, value );
        }

        public static unsafe void alGetEffrctiv( uint eid, AL_EffectParam pname, int* values )
        {
            internalsEFX.alGetEffrctiv( eid, pname, values );
        }

        public static unsafe void alGetEffectf( uint eid, AL_EffectParam pname, float* value )
        {
            internalsEFX.alGetEffectf( eid, pname, value );
        }

        public static unsafe void alGetEffectfv( uint eid, AL_EffectParam pname, float* values )
        {
            internalsEFX.alGetEffectfv( eid, pname, values );
        }

        public static unsafe void alGenFilters( int n, uint* filters )
        {
            internalsEFX.alGenFilters( n, filters );
        } 

        public static unsafe void alDeleteFilters( int n, uint* filters )
        {
            internalsEFX.alDeleteFilters( n, filters );
        }

        public static bool alIsFilter( uint fid )
        {
            return internalsEFX.alIsFilter( fid );
        }

        public static void alFilteri( uint fid, AL_FilterParam param, int value )
        {
            internalsEFX.alFilteri( fid, param, value );
        } 

        public static unsafe void alFilteriv( uint fid, AL_FilterParam param, int* values )
        {
            internalsEFX.alFilteriv( fid, param, values );
        } 

        public static void alFilterf( uint fid, AL_FilterPassParam param, float value)
        {
            internalsEFX.alFilterf( fid, param, value);
        } 

        public static unsafe void alFilterfv( uint fid, AL_FilterPassParam param, float* values )
        {
            internalsEFX.alFilterfv( fid, param, values );
        } 

        public static unsafe void alGetFilteri( uint fid, AL_FilterParam pname, int* value )
        {
            internalsEFX.alGetFilteri( fid, pname, value );
        }

        public static unsafe void alGetFilteriv( uint fid, AL_FilterParam pname, int* values )
        {
            internalsEFX.alGetFilteriv( fid, pname, values );
        }

        public static unsafe void alGetFilterf( uint fid, AL_FilterPassParam pname, float* value )
        {
            internalsEFX.alGetFilterf( fid, pname, value );
        }

        public static unsafe void alGetFilterfv( uint fid, AL_FilterPassParam pname, float* values )
        {
            internalsEFX.alGetFilterfv( fid, pname, values );
        }

        public static unsafe void alGenAuxiliaryEffectSlots( int n, uint* slots )
        {
            internalsEFX.alGenAuxiliaryEffectSlots( n, slots );
        } 

        public static unsafe void alDdeleteAuxiliaryEffectSlots( int n, uint* slots )
        {
            internalsEFX.alDdeleteAuxiliaryEffectSlots( n, slots );
        }

        public static bool alIsAuxiliaryEffectSlot( uint slot )
        {
            return internalsEFX.alIsAuxiliaryEffectSlot( slot );
        } 

        public static void alAuxiliaryEffectSloti( uint asid, AL_AuxiliaryEffectSlot param, int value )
        {
            internalsEFX.alAuxiliaryEffectSloti( asid, param, value );
        } 

        public static unsafe void alAuxiliaryEffectSlotiv( uint asid, AL_AuxiliaryEffectSlot param, int* values )
        {
            internalsEFX.alAuxiliaryEffectSlotiv( asid, param, values );
        } 

        public static void alAuxiliaryEffectSlotf( uint asid, AL_AuxiliaryEffectSlot param, float value )
        {
            internalsEFX.alAuxiliaryEffectSlotf( asid, param, value );
        } 

        public static unsafe void alAuxiliaryEffectSlotfv( uint asid, AL_AuxiliaryEffectSlot param, float* values )
        {
            internalsEFX.alAuxiliaryEffectSlotfv( asid, param, values );
        } 

        public static unsafe void alGetAuxiliaryEffectSloti( uint asid, AL_AuxiliaryEffectSlot pname, int* value )
        {
            internalsEFX.alGetAuxiliaryEffectSloti( asid, pname, value );
        }

        public static unsafe void alGetAuxiliaryEffectSlotiv( uint asid, AL_AuxiliaryEffectSlot pname, int* values )
        {
            internalsEFX.alGetAuxiliaryEffectSlotiv( asid, pname, values );
        }

        public static unsafe void alGetAuxiliaryEffectSlotf( uint asid, AL_AuxiliaryEffectSlot pname, float* value )
        {
            internalsEFX.alGetAuxiliaryEffectSlotf( asid, pname, value );
        }

        public static unsafe void alGetAuxiliaryEffectSlotfv( uint asid, AL_AuxiliaryEffectSlot pname, float* values )
        {
            internalsEFX.alGetAuxiliaryEffectSlotfv( asid, pname, values );
        }
    }
}