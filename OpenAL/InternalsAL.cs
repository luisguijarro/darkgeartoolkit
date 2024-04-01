using System;
using System.Security;
using System.Runtime.InteropServices;

namespace dgtk.OpenAL
{
    public static class internalsALC // OpenAL: Commandos de Contexto.
    {
        internal static delegatesALC.alcCreateContext alcCreateContext;

        internal static delegatesALC.alcMakeContextCurrent alcMakeContextCurrent;

        internal static delegatesALC.alcProcessContext alcProcessContext;

        internal static delegatesALC.alcSuspendContext alcSuspendContext;

        internal static delegatesALC.alcDestroyContext alcDestroyContext;

        internal static delegatesALC.alcGetCurrentContext alcGetCurrentContext;

        internal static delegatesALC.alcGetContextsDevice alcGetContextsDevice;

        internal static delegatesALC.alcOpenDevice alcOpenDevice;

        internal static delegatesALC.alcCloseDevice alcCloseDevice;

        internal static delegatesALC.alcGetError alcGetError;

        internal static delegatesALC.alcIsExtensionPresent alcIsExtensionPresent;

        internal static delegatesALC.alcGetProcAddress alcGetProcAddress;

        internal static delegatesALC.alcGetEnumValue alcGetEnumValue;

        internal static delegatesALC.alcGetString alcGetString;

        internal static delegatesALC.alcGetIntegerv alcGetIntegerv;

        internal static delegatesALC.alcCaptureOpenDevice alcCaptureOpenDevice;

        internal static delegatesALC.alcCaptureCloseDevice alcCaptureCloseDevice;

        internal static delegatesALC.alcCaptureStart alcCaptureStart;

        internal static delegatesALC.alcCaptureStop alcCaptureStop;

        internal static delegatesALC.alcCaptureSamples alcCaptureSamples;
    }
    
    public static class internalsAL // OpenAL: Comandos miscelaneos
    {
        internal static delegatesAL.alEnable alEnable;

        internal static delegatesAL.alDisable alDisable;

        internal static delegatesAL.alIsEnabled alIsEnabled;

        internal static delegatesAL.alGetString alGetString;

        internal static delegatesAL.alGetBooleanv alGetBooleanv;

        internal static delegatesAL.alGetIntegerv alGetIntegerv;

        internal static delegatesAL.alGetFloatv alGetFloatv;

        internal static delegatesAL.alGetDoublev alGetDoublev;

        internal static delegatesAL.alGetBoolean alGetBoolean;

        internal static delegatesAL.alGetInteger alGetInteger;

        internal static delegatesAL.alGetFloat alGetFloat;

        internal static delegatesAL.alGetDouble alGetDouble;

        internal static delegatesAL.alGetError alGetError;

        internal static delegatesAL.alIsExtensionPresent alIsExtensionPresent;

        internal static delegatesAL.alGetProcAddress alGetProcAddress;

        internal static delegatesAL.alGetEnumValue alGetEnumValue;

        internal static delegatesAL.alListenerf alListenerf;

        internal static delegatesAL.alListener3f alListener3f;

        internal static delegatesAL.alListenerfv alListenerfv;

        internal static delegatesAL.alListeneri alListeneri;

        internal static delegatesAL.alListener3i alListener3i;

        internal static delegatesAL.alListeneriv alListeneriv;

        internal static delegatesAL.alGetListenerf alGetListenerf;

        internal static delegatesAL.alGetListener3f alGetListener3f;

        internal static delegatesAL.alGetListenerfv alGetListenerfv;

        internal static delegatesAL.alGetListeneri alGetListeneri;

        internal static delegatesAL.alGetListener3i alGetListener3i;

        internal static delegatesAL.alGetListeneriv alGetListeneriv;

        internal static delegatesAL.alGenSources alGenSources;

        internal static delegatesAL.alDeleteSources alDeleteSources;

        internal static delegatesAL.alIsSource alIsSource;

        internal static delegatesAL.alSourcef alSourcef;

        internal static delegatesAL.alSource3f alSource3f;

        internal static delegatesAL.alSourcefv alSourcefv;

        internal static delegatesAL.alSourcei alSourcei;

        internal static delegatesAL.alSource3i alSource3i;

        internal static delegatesAL.alSourceiv alSourceiv;

        internal static delegatesAL.alGetSourcef alGetSourcef;

        internal static delegatesAL.alGetSource3f alGetSource3f;

        internal static delegatesAL.alGetSourcefv alGetSourcefv;

        internal static delegatesAL.alGetSourcei alGetSourcei;

        internal static delegatesAL.alGetSource3i alGetSource3i;

        internal static delegatesAL.alGetSourceiv alGetSourceiv;

        internal static delegatesAL.alSourcePlayv alSourcePlayv;

        internal static delegatesAL.alSourceStopv alSourceStopv;

        internal static delegatesAL.alSourceRewindv alSourceRewindv;

        internal static delegatesAL.alSourcePausev alSourcePausev;

        internal static delegatesAL.alSourcePlay alSourcePlay;

        internal static delegatesAL.alSourceStop alSourceStop;

        internal static delegatesAL.alSourceRewind alSourceRewind;

        internal static delegatesAL.alSourcePause alSourcePause;

        internal static delegatesAL.alSourceQueueBuffers alSourceQueueBuffers;

        internal static delegatesAL.alSourceUnqueueBuffers alSourceUnqueueBuffers;

        internal static delegatesAL.alGenBuffers alGenBuffers;

        internal static delegatesAL.alDeleteBuffers alDeleteBuffers;

        internal static delegatesAL.alIsBuffer alIsBuffer;

        internal static delegatesAL.alBufferData alBufferData;

        internal static delegatesAL.alBufferf alBufferf;

        internal static delegatesAL.alBuffer3f alBuffer3f;

        internal static delegatesAL.alBufferfv alBufferfv;

        internal static delegatesAL.alBufferi alBufferi;

        internal static delegatesAL.alBuffer3i alBuffer3i;

        internal static delegatesAL.alBufferiv alBufferiv;

        internal static delegatesAL.alGetBufferf alGetBufferf;

        internal static delegatesAL.alGetBuffer3f alGetBuffer3f;

        internal static delegatesAL.alGetBufferfv alGetBufferfv;

        internal static delegatesAL.alGetBufferi alGetBufferi;

        internal static delegatesAL.alGetBuffer3i alGetBuffer3i;

        internal static delegatesAL.alGetBufferiv alGetBufferiv;

        internal static delegatesAL.alDopplerFactor alDopplerFactor;

        internal static delegatesAL.alDopplerVelocity alDopplerVelocity;

        internal static delegatesAL.alSpeedOfSound alSpeedOfSound;

        internal static delegatesAL.alDistanceModel alDistanceModel;
    }

    public static class internalsEFX
    {
        internal static delegatesEFX.alGenEffects alGenEffects;

        internal static delegatesEFX.alDeleteEffects alDeleteEffects;

        internal static delegatesEFX.alIsEffect alIsEffect;

        internal static delegatesEFX.alEffecti alEffecti;

        internal static delegatesEFX.alEffectiv alEffectiv;

        internal static delegatesEFX.alEffectf alEffectf;

        internal static delegatesEFX.alEffectfv alEffectfv;

        internal static delegatesEFX.alGetEffecti alGetEffecti;

        internal static delegatesEFX.alGetEffrctiv alGetEffrctiv;

        internal static delegatesEFX.alGetEffectf alGetEffectf;

        internal static delegatesEFX.alGetEffectfv alGetEffectfv;

        internal static delegatesEFX.alGenFilters alGenFilters;

        internal static delegatesEFX.alDeleteFilters alDeleteFilters;

        internal static delegatesEFX.alIsFilter alIsFilter;

        internal static delegatesEFX.alFilteri alFilteri;

        internal static delegatesEFX.alFilteriv alFilteriv;

        internal static delegatesEFX.alFilterf alFilterf;

        internal static delegatesEFX.alFilterfv alFilterfv;

        internal static delegatesEFX.alGetFilteri alGetFilteri;

        internal static delegatesEFX.alGetFilteriv alGetFilteriv;

        internal static delegatesEFX.alGetFilterf alGetFilterf;

        internal static delegatesEFX.alGetFilterfv alGetFilterfv;

        internal static delegatesEFX.alGenAuxiliaryEffectSlots alGenAuxiliaryEffectSlots;

        internal static delegatesEFX.alDdeleteAuxiliaryEffectSlots alDdeleteAuxiliaryEffectSlots;

        internal static delegatesEFX.alIsAuxiliaryEffectSlot alIsAuxiliaryEffectSlot;

        internal static delegatesEFX.alAuxiliaryEffectSloti alAuxiliaryEffectSloti;

        internal static delegatesEFX.alAuxiliaryEffectSlotiv alAuxiliaryEffectSlotiv;

        internal static delegatesEFX.alAuxiliaryEffectSlotf alAuxiliaryEffectSlotf;

        internal static delegatesEFX.alAuxiliaryEffectSlotfv alAuxiliaryEffectSlotfv;

        internal static delegatesEFX.alGetAuxiliaryEffectSloti alGetAuxiliaryEffectSloti;

        internal static delegatesEFX.alGetAuxiliaryEffectSlotiv alGetAuxiliaryEffectSlotiv;

        internal static delegatesEFX.alGetAuxiliaryEffectSlotf alGetAuxiliaryEffectSlotf;

        internal static delegatesEFX.alGetAuxiliaryEffectSlotfv alGetAuxiliaryEffectSlotfv;
    }
}