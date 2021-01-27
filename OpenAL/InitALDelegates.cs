using System;

namespace dgtk.OpenAL
{
    internal static class Init_AL_Delegates
    {
        private static bool IniciatedAL;
        private static bool IniciatedEFX;
        internal static void InitAlcDelegates(IntPtr device)
        {
            #region ALC

            internalsALC.alcCreateContext = (delegatesALC.alcCreateContext) ALInternalTool.AlcGetMethodAddress(device, "alcCreateContext", typeof(delegatesALC.alcCreateContext));

            internalsALC.alcMakeContextCurrent = (delegatesALC.alcMakeContextCurrent) ALInternalTool.AlcGetMethodAddress(device, "alcMakeContextCurrent", typeof(delegatesALC.alcMakeContextCurrent));

            internalsALC.alcProcessContext = (delegatesALC.alcProcessContext) ALInternalTool.AlcGetMethodAddress(device, "alcProcessContext", typeof(delegatesALC.alcProcessContext));

            internalsALC.alcSuspendContext = (delegatesALC.alcSuspendContext) ALInternalTool.AlcGetMethodAddress(device, "alcSuspendContext", typeof(delegatesALC.alcSuspendContext));

            internalsALC.alcDestroyContext = (delegatesALC.alcDestroyContext) ALInternalTool.AlcGetMethodAddress(device, "alcDestroyContext", typeof(delegatesALC.alcDestroyContext));

            internalsALC.alcGetCurrentContext = (delegatesALC.alcGetCurrentContext) ALInternalTool.AlcGetMethodAddress(device, "alcGetCurrentContext", typeof(delegatesALC.alcGetCurrentContext));

            internalsALC.alcGetContextsDevice = (delegatesALC.alcGetContextsDevice) ALInternalTool.AlcGetMethodAddress(device, "alcGetContextsDevice", typeof(delegatesALC.alcGetContextsDevice));

            internalsALC.alcOpenDevice = (delegatesALC.alcOpenDevice) ALInternalTool.AlcGetMethodAddress(device, "alcOpenDevice", typeof(delegatesALC.alcOpenDevice));

            internalsALC.alcCloseDevice = (delegatesALC.alcCloseDevice) ALInternalTool.AlcGetMethodAddress(device, "alcCloseDevice", typeof(delegatesALC.alcCloseDevice));

            internalsALC.alcGetError = (delegatesALC.alcGetError) ALInternalTool.AlcGetMethodAddress(device, "alcGetError", typeof(delegatesALC.alcGetError));

            internalsALC.alcIsExtensionPresent = (delegatesALC.alcIsExtensionPresent) ALInternalTool.AlcGetMethodAddress(device, "alcIsExtensionPresent", typeof(delegatesALC.alcIsExtensionPresent));

            internalsALC.alcGetProcAddress = (delegatesALC.alcGetProcAddress) ALInternalTool.AlcGetMethodAddress(device, "alcGetProcAddress", typeof(delegatesALC.alcGetProcAddress));

            internalsALC.alcGetEnumValue = (delegatesALC.alcGetEnumValue) ALInternalTool.AlcGetMethodAddress(device, "alcGetEnumValue", typeof(delegatesALC.alcGetEnumValue));

            internalsALC.alcGetString = (delegatesALC.alcGetString) ALInternalTool.AlcGetMethodAddress(device, "alcGetString", typeof(delegatesALC.alcGetString));

            internalsALC.alcGetIntegerv = (delegatesALC.alcGetIntegerv) ALInternalTool.AlcGetMethodAddress(device, "alcGetIntegerv", typeof(delegatesALC.alcGetIntegerv));

            internalsALC.alcCaptureOpenDevice = (delegatesALC.alcCaptureOpenDevice) ALInternalTool.AlcGetMethodAddress(device, "alcCaptureOpenDevice", typeof(delegatesALC.alcCaptureOpenDevice));

            internalsALC.alcCaptureCloseDevice = (delegatesALC.alcCaptureCloseDevice) ALInternalTool.AlcGetMethodAddress(device, "alcCaptureCloseDevice", typeof(delegatesALC.alcCaptureCloseDevice));

            internalsALC.alcCaptureStart = (delegatesALC.alcCaptureStart) ALInternalTool.AlcGetMethodAddress(device, "alcCaptureStart", typeof(delegatesALC.alcCaptureStart));

            internalsALC.alcCaptureStop = (delegatesALC.alcCaptureStop) ALInternalTool.AlcGetMethodAddress(device, "alcCaptureStop", typeof(delegatesALC.alcCaptureStop));

            internalsALC.alcCaptureSamples = (delegatesALC.alcCaptureSamples) ALInternalTool.AlcGetMethodAddress(device, "alcCaptureSamples", typeof(delegatesALC.alcCaptureSamples));

            #endregion
        }

        internal static void InitAlDelegates()
        {
            if (IniciatedAL) {return;}
            IniciatedAL = true;

            #region AL

            internalsAL.alEnable = (delegatesAL.alEnable) ALInternalTool.AlGetMethodAddress("alEnable", typeof(delegatesAL.alEnable));

            internalsAL.alDisable = (delegatesAL.alDisable) ALInternalTool.AlGetMethodAddress("alDisable", typeof(delegatesAL.alDisable));

            internalsAL.alIsEnabled = (delegatesAL.alIsEnabled) ALInternalTool.AlGetMethodAddress("alIsEnabled", typeof(delegatesAL.alIsEnabled));

            internalsAL.alGetString = (delegatesAL.alGetString) ALInternalTool.AlGetMethodAddress("alGetString", typeof(delegatesAL.alGetString));

            internalsAL.alGetBooleanv = (delegatesAL.alGetBooleanv) ALInternalTool.AlGetMethodAddress("alGetBooleanv", typeof(delegatesAL.alGetBooleanv));

            internalsAL.alGetIntegerv = (delegatesAL.alGetIntegerv) ALInternalTool.AlGetMethodAddress("alGetIntegerv", typeof(delegatesAL.alGetIntegerv));

            internalsAL.alGetFloatv = (delegatesAL.alGetFloatv) ALInternalTool.AlGetMethodAddress("alGetFloatv", typeof(delegatesAL.alGetFloatv));

            internalsAL.alGetDoublev = (delegatesAL.alGetDoublev) ALInternalTool.AlGetMethodAddress("alGetDoublev", typeof(delegatesAL.alGetDoublev));

            internalsAL.alGetBoolean = (delegatesAL.alGetBoolean) ALInternalTool.AlGetMethodAddress("alGetBoolean", typeof(delegatesAL.alGetBoolean));

            internalsAL.alGetInteger = (delegatesAL.alGetInteger) ALInternalTool.AlGetMethodAddress("alGetInteger", typeof(delegatesAL.alGetInteger));

            internalsAL.alGetFloat = (delegatesAL.alGetFloat) ALInternalTool.AlGetMethodAddress("alGetFloat", typeof(delegatesAL.alGetFloat));

            internalsAL.alGetDouble = (delegatesAL.alGetDouble) ALInternalTool.AlGetMethodAddress("alGetDouble", typeof(delegatesAL.alGetDouble));

            internalsAL.alGetError = (delegatesAL.alGetError) ALInternalTool.AlGetMethodAddress("alGetError", typeof(delegatesAL.alGetError));

            internalsAL.alIsExtensionPresent = (delegatesAL.alIsExtensionPresent) ALInternalTool.AlGetMethodAddress("alIsExtensionPresent", typeof(delegatesAL.alIsExtensionPresent));

            internalsAL.alGetProcAddress = (delegatesAL.alGetProcAddress) ALInternalTool.AlGetMethodAddress("alGetProcAddress", typeof(delegatesAL.alGetProcAddress));

            internalsAL.alGetEnumValue = (delegatesAL.alGetEnumValue) ALInternalTool.AlGetMethodAddress("alGetEnumValue", typeof(delegatesAL.alGetEnumValue));

            internalsAL.alListenerf = (delegatesAL.alListenerf) ALInternalTool.AlGetMethodAddress("alListenerf", typeof(delegatesAL.alListenerf));

            internalsAL.alListener3f = (delegatesAL.alListener3f) ALInternalTool.AlGetMethodAddress("alListener3f", typeof(delegatesAL.alListener3f));

            internalsAL.alListenerfv = (delegatesAL.alListenerfv) ALInternalTool.AlGetMethodAddress("alListenerfv", typeof(delegatesAL.alListenerfv));

            internalsAL.alListeneri = (delegatesAL.alListeneri) ALInternalTool.AlGetMethodAddress("alListeneri", typeof(delegatesAL.alListeneri));

            internalsAL.alListener3i = (delegatesAL.alListener3i) ALInternalTool.AlGetMethodAddress("alListener3i", typeof(delegatesAL.alListener3i));

            internalsAL.alListeneriv = (delegatesAL.alListeneriv) ALInternalTool.AlGetMethodAddress("alListeneriv", typeof(delegatesAL.alListeneriv));

            internalsAL.alGetListenerf = (delegatesAL.alGetListenerf) ALInternalTool.AlGetMethodAddress("alGetListenerf", typeof(delegatesAL.alGetListenerf));

            internalsAL.alGetListener3f = (delegatesAL.alGetListener3f) ALInternalTool.AlGetMethodAddress("alGetListener3f", typeof(delegatesAL.alGetListener3f));

            internalsAL.alGetListenerfv = (delegatesAL.alGetListenerfv) ALInternalTool.AlGetMethodAddress("alGetListenerfv", typeof(delegatesAL.alGetListenerfv));

            internalsAL.alGetListeneri = (delegatesAL.alGetListeneri) ALInternalTool.AlGetMethodAddress("alGetListeneri", typeof(delegatesAL.alGetListeneri));

            internalsAL.alGetListener3i = (delegatesAL.alGetListener3i) ALInternalTool.AlGetMethodAddress("alGetListener3i", typeof(delegatesAL.alGetListener3i));

            internalsAL.alGetListeneriv = (delegatesAL.alGetListeneriv) ALInternalTool.AlGetMethodAddress("alGetListeneriv", typeof(delegatesAL.alGetListeneriv));

            internalsAL.alGenSources = (delegatesAL.alGenSources) ALInternalTool.AlGetMethodAddress("alGenSources", typeof(delegatesAL.alGenSources));

            internalsAL.alDeleteSources = (delegatesAL.alDeleteSources) ALInternalTool.AlGetMethodAddress("alDeleteSources", typeof(delegatesAL.alDeleteSources));

            internalsAL.alIsSource = (delegatesAL.alIsSource) ALInternalTool.AlGetMethodAddress("alIsSource", typeof(delegatesAL.alIsSource));

            internalsAL.alSourcef = (delegatesAL.alSourcef) ALInternalTool.AlGetMethodAddress("alSourcef", typeof(delegatesAL.alSourcef));

            internalsAL.alSource3f = (delegatesAL.alSource3f) ALInternalTool.AlGetMethodAddress("alSource3f", typeof(delegatesAL.alSource3f));

            internalsAL.alSourcefv = (delegatesAL.alSourcefv) ALInternalTool.AlGetMethodAddress("alSourcefv", typeof(delegatesAL.alSourcefv));

            internalsAL.alSourcei = (delegatesAL.alSourcei) ALInternalTool.AlGetMethodAddress("alSourcei", typeof(delegatesAL.alSourcei));

            internalsAL.alSource3i = (delegatesAL.alSource3i) ALInternalTool.AlGetMethodAddress("alSource3i", typeof(delegatesAL.alSource3i));

            internalsAL.alSourceiv = (delegatesAL.alSourceiv) ALInternalTool.AlGetMethodAddress("alSourceiv", typeof(delegatesAL.alSourceiv));

            internalsAL.alGetSourcef = (delegatesAL.alGetSourcef) ALInternalTool.AlGetMethodAddress("alGetSourcef", typeof(delegatesAL.alGetSourcef));

            internalsAL.alGetSource3f = (delegatesAL.alGetSource3f) ALInternalTool.AlGetMethodAddress("alGetSource3f", typeof(delegatesAL.alGetSource3f));

            internalsAL.alGetSourcefv = (delegatesAL.alGetSourcefv) ALInternalTool.AlGetMethodAddress("alGetSourcefv", typeof(delegatesAL.alGetSourcefv));

            internalsAL.alGetSourcei = (delegatesAL.alGetSourcei) ALInternalTool.AlGetMethodAddress("alGetSourcei", typeof(delegatesAL.alGetSourcei));

            internalsAL.alGetSource3i = (delegatesAL.alGetSource3i) ALInternalTool.AlGetMethodAddress("alGetSource3i", typeof(delegatesAL.alGetSource3i));

            internalsAL.alGetSourceiv = (delegatesAL.alGetSourceiv) ALInternalTool.AlGetMethodAddress("alGetSourceiv", typeof(delegatesAL.alGetSourceiv));

            internalsAL.alSourcePlayv = (delegatesAL.alSourcePlayv) ALInternalTool.AlGetMethodAddress("alSourcePlayv", typeof(delegatesAL.alSourcePlayv));

            internalsAL.alSourceStopv = (delegatesAL.alSourceStopv) ALInternalTool.AlGetMethodAddress("alSourceStopv", typeof(delegatesAL.alSourceStopv));

            internalsAL.alSourceRewindv = (delegatesAL.alSourceRewindv) ALInternalTool.AlGetMethodAddress("alSourceRewindv", typeof(delegatesAL.alSourceRewindv));

            internalsAL.alSourcePausev = (delegatesAL.alSourcePausev) ALInternalTool.AlGetMethodAddress("alSourcePausev", typeof(delegatesAL.alSourcePausev));

            internalsAL.alSourcePlay = (delegatesAL.alSourcePlay) ALInternalTool.AlGetMethodAddress("alSourcePlay", typeof(delegatesAL.alSourcePlay));

            internalsAL.alSourceStop = (delegatesAL.alSourceStop) ALInternalTool.AlGetMethodAddress("alSourceStop", typeof(delegatesAL.alSourceStop));

            internalsAL.alSourceRewind = (delegatesAL.alSourceRewind) ALInternalTool.AlGetMethodAddress("alSourceRewind", typeof(delegatesAL.alSourceRewind));

            internalsAL.alSourcePause = (delegatesAL.alSourcePause) ALInternalTool.AlGetMethodAddress("alSourcePause", typeof(delegatesAL.alSourcePause));

            internalsAL.alSourceQueueBuffers = (delegatesAL.alSourceQueueBuffers) ALInternalTool.AlGetMethodAddress("alSourceQueueBuffers", typeof(delegatesAL.alSourceQueueBuffers));

            internalsAL.alSourceUnqueueBuffers = (delegatesAL.alSourceUnqueueBuffers) ALInternalTool.AlGetMethodAddress("alSourceUnqueueBuffers", typeof(delegatesAL.alSourceUnqueueBuffers));

            internalsAL.alGenBuffers = (delegatesAL.alGenBuffers) ALInternalTool.AlGetMethodAddress("alGenBuffers", typeof(delegatesAL.alGenBuffers));

            internalsAL.alDeleteBuffers = (delegatesAL.alDeleteBuffers) ALInternalTool.AlGetMethodAddress("alDeleteBuffers", typeof(delegatesAL.alDeleteBuffers));

            internalsAL.alIsBuffer = (delegatesAL.alIsBuffer) ALInternalTool.AlGetMethodAddress("alIsBuffer", typeof(delegatesAL.alIsBuffer));

            internalsAL.alBufferData = (delegatesAL.alBufferData) ALInternalTool.AlGetMethodAddress("alBufferData", typeof(delegatesAL.alBufferData));

            internalsAL.alBufferf = (delegatesAL.alBufferf) ALInternalTool.AlGetMethodAddress("alBufferf", typeof(delegatesAL.alBufferf));

            internalsAL.alBuffer3f = (delegatesAL.alBuffer3f) ALInternalTool.AlGetMethodAddress("alBuffer3f", typeof(delegatesAL.alBuffer3f));

            internalsAL.alBufferfv = (delegatesAL.alBufferfv) ALInternalTool.AlGetMethodAddress("alBufferfv", typeof(delegatesAL.alBufferfv));

            internalsAL.alBufferi = (delegatesAL.alBufferi) ALInternalTool.AlGetMethodAddress("alBufferi", typeof(delegatesAL.alBufferi));

            internalsAL.alBuffer3i = (delegatesAL.alBuffer3i) ALInternalTool.AlGetMethodAddress("alBuffer3i", typeof(delegatesAL.alBuffer3i));

            internalsAL.alBufferiv = (delegatesAL.alBufferiv) ALInternalTool.AlGetMethodAddress("alBufferiv", typeof(delegatesAL.alBufferiv));

            internalsAL.alGetBufferf = (delegatesAL.alGetBufferf) ALInternalTool.AlGetMethodAddress("alGetBufferf", typeof(delegatesAL.alGetBufferf));

            internalsAL.alGetBuffer3f = (delegatesAL.alGetBuffer3f) ALInternalTool.AlGetMethodAddress("alGetBuffer3f", typeof(delegatesAL.alGetBuffer3f));

            internalsAL.alGetBufferfv = (delegatesAL.alGetBufferfv) ALInternalTool.AlGetMethodAddress("alGetBufferfv", typeof(delegatesAL.alGetBufferfv));

            internalsAL.alGetBufferi = (delegatesAL.alGetBufferi) ALInternalTool.AlGetMethodAddress("alGetBufferi", typeof(delegatesAL.alGetBufferi));

            internalsAL.alGetBuffer3i = (delegatesAL.alGetBuffer3i) ALInternalTool.AlGetMethodAddress("alGetBuffer3i", typeof(delegatesAL.alGetBuffer3i));

            internalsAL.alGetBufferiv = (delegatesAL.alGetBufferiv) ALInternalTool.AlGetMethodAddress("alGetBufferiv", typeof(delegatesAL.alGetBufferiv));

            internalsAL.alDopplerFactor = (delegatesAL.alDopplerFactor) ALInternalTool.AlGetMethodAddress("alDopplerFactor", typeof(delegatesAL.alDopplerFactor));

            internalsAL.alDopplerVelocity = (delegatesAL.alDopplerVelocity) ALInternalTool.AlGetMethodAddress("alDopplerVelocity", typeof(delegatesAL.alDopplerVelocity));

            internalsAL.alSpeedOfSound = (delegatesAL.alSpeedOfSound) ALInternalTool.AlGetMethodAddress("alSpeedOfSound", typeof(delegatesAL.alSpeedOfSound));

            internalsAL.alDistanceModel = (delegatesAL.alDistanceModel) ALInternalTool.AlGetMethodAddress("alDistanceModel", typeof(delegatesAL.alDistanceModel));

            #endregion        
        }

        internal static void InitEFXDelegates()
        {
            if (IniciatedEFX) {return;}
            IniciatedEFX = true;
            
            #region EFX

            internalsEFX.alGenEffects = (delegatesEFX.alGenEffects) ALInternalTool.AlGetMethodAddress("alGenEffects", typeof(delegatesEFX.alGenEffects));

            internalsEFX.alDeleteEffects = (delegatesEFX.alDeleteEffects) ALInternalTool.AlGetMethodAddress("alDeleteEffects", typeof(delegatesEFX.alDeleteEffects));

            internalsEFX.alIsEffect = (delegatesEFX.alIsEffect) ALInternalTool.AlGetMethodAddress("alIsEffect", typeof(delegatesEFX.alIsEffect)); 

            internalsEFX.alEffecti = (delegatesEFX.alEffecti) ALInternalTool.AlGetMethodAddress("alEffecti", typeof(delegatesEFX.alEffecti));

            internalsEFX.alEffectiv = (delegatesEFX.alEffectiv) ALInternalTool.AlGetMethodAddress("alEffectiv", typeof(delegatesEFX.alEffectiv));

            internalsEFX.alEffectf = (delegatesEFX.alEffectf) ALInternalTool.AlGetMethodAddress("alEffectf", typeof(delegatesEFX.alEffectf));

            internalsEFX.alEffectfv = (delegatesEFX.alEffectfv) ALInternalTool.AlGetMethodAddress("alEffectfv", typeof(delegatesEFX.alEffectfv));

            internalsEFX.alGetEffecti = (delegatesEFX.alGetEffecti) ALInternalTool.AlGetMethodAddress("alGetEffecti", typeof(delegatesEFX.alGetEffecti));

            internalsEFX.alGetEffrctiv = (delegatesEFX.alGetEffrctiv) ALInternalTool.AlGetMethodAddress("alGetEffrctiv", typeof(delegatesEFX.alGetEffrctiv));

            internalsEFX.alGetEffectf = (delegatesEFX.alGetEffectf) ALInternalTool.AlGetMethodAddress("alGetEffectf", typeof(delegatesEFX.alGetEffectf));

            internalsEFX.alGetEffectfv = (delegatesEFX.alGetEffectfv) ALInternalTool.AlGetMethodAddress("alGetEffectfv", typeof(delegatesEFX.alGetEffectfv));

            internalsEFX.alGenFilters = (delegatesEFX.alGenFilters) ALInternalTool.AlGetMethodAddress("alGenFilters", typeof(delegatesEFX.alGenFilters));

            internalsEFX.alDeleteFilters = (delegatesEFX.alDeleteFilters) ALInternalTool.AlGetMethodAddress("alDeleteFilters", typeof(delegatesEFX.alDeleteFilters));

            internalsEFX.alIsFilter = (delegatesEFX.alIsFilter) ALInternalTool.AlGetMethodAddress("alIsFilter", typeof(delegatesEFX.alIsFilter));

            internalsEFX.alFilteri = (delegatesEFX.alFilteri) ALInternalTool.AlGetMethodAddress("alFilteri", typeof(delegatesEFX.alFilteri));

            internalsEFX.alFilteriv = (delegatesEFX.alFilteriv) ALInternalTool.AlGetMethodAddress("alFilteriv", typeof(delegatesEFX.alFilteriv));

            internalsEFX.alFilterf = (delegatesEFX.alFilterf) ALInternalTool.AlGetMethodAddress("alFilterf", typeof(delegatesEFX.alFilterf));

            internalsEFX.alFilterfv = (delegatesEFX.alFilterfv) ALInternalTool.AlGetMethodAddress("alFilterfv", typeof(delegatesEFX.alFilterfv));

            internalsEFX.alGetFilteri = (delegatesEFX.alGetFilteri) ALInternalTool.AlGetMethodAddress("alGetFilteri", typeof(delegatesEFX.alGetFilteri));

            internalsEFX.alGetFilteriv = (delegatesEFX.alGetFilteriv) ALInternalTool.AlGetMethodAddress("alGetFilteriv", typeof(delegatesEFX.alGetFilteriv));

            internalsEFX.alGetFilterf = (delegatesEFX.alGetFilterf) ALInternalTool.AlGetMethodAddress("alGetFilterf", typeof(delegatesEFX.alGetFilterf));

            internalsEFX.alGetFilterfv = (delegatesEFX.alGetFilterfv) ALInternalTool.AlGetMethodAddress("alGetFilterfv", typeof(delegatesEFX.alGetFilterfv));

            internalsEFX.alGenAuxiliaryEffectSlots = (delegatesEFX.alGenAuxiliaryEffectSlots) ALInternalTool.AlGetMethodAddress("alGenAuxiliaryEffectSlots", typeof(delegatesEFX.alGenAuxiliaryEffectSlots));

            internalsEFX.alDdeleteAuxiliaryEffectSlots = (delegatesEFX.alDdeleteAuxiliaryEffectSlots) ALInternalTool.AlGetMethodAddress("alDdeleteAuxiliaryEffectSlots", typeof(delegatesEFX.alDdeleteAuxiliaryEffectSlots));

            internalsEFX.alIsAuxiliaryEffectSlot = (delegatesEFX.alIsAuxiliaryEffectSlot) ALInternalTool.AlGetMethodAddress("alIsAuxiliaryEffectSlot", typeof(delegatesEFX.alIsAuxiliaryEffectSlot));

            internalsEFX.alAuxiliaryEffectSloti = (delegatesEFX.alAuxiliaryEffectSloti) ALInternalTool.AlGetMethodAddress("alAuxiliaryEffectSloti", typeof(delegatesEFX.alAuxiliaryEffectSloti));

            internalsEFX.alAuxiliaryEffectSlotiv = (delegatesEFX.alAuxiliaryEffectSlotiv) ALInternalTool.AlGetMethodAddress("alAuxiliaryEffectSlotiv", typeof(delegatesEFX.alAuxiliaryEffectSlotiv));

            internalsEFX.alAuxiliaryEffectSlotf = (delegatesEFX.alAuxiliaryEffectSlotf) ALInternalTool.AlGetMethodAddress("alAuxiliaryEffectSlotf", typeof(delegatesEFX.alAuxiliaryEffectSlotf));

            internalsEFX.alAuxiliaryEffectSlotfv = (delegatesEFX.alAuxiliaryEffectSlotfv) ALInternalTool.AlGetMethodAddress("alAuxiliaryEffectSlotfv", typeof(delegatesEFX.alAuxiliaryEffectSlotfv));

            internalsEFX.alGetAuxiliaryEffectSloti = (delegatesEFX.alGetAuxiliaryEffectSloti) ALInternalTool.AlGetMethodAddress("alGetAuxiliaryEffectSloti", typeof(delegatesEFX.alGetAuxiliaryEffectSloti));

            internalsEFX.alGetAuxiliaryEffectSlotiv = (delegatesEFX.alGetAuxiliaryEffectSlotiv) ALInternalTool.AlGetMethodAddress("alGetAuxiliaryEffectSlotiv", typeof(delegatesEFX.alGetAuxiliaryEffectSlotiv));

            internalsEFX.alGetAuxiliaryEffectSlotf = (delegatesEFX.alGetAuxiliaryEffectSlotf) ALInternalTool.AlGetMethodAddress("alGetAuxiliaryEffectSlotf", typeof(delegatesEFX.alGetAuxiliaryEffectSlotf));

            internalsEFX.alGetAuxiliaryEffectSlotfv = (delegatesEFX.alGetAuxiliaryEffectSlotfv) ALInternalTool.AlGetMethodAddress("alGetAuxiliaryEffectSlotfv", typeof(delegatesEFX.alGetAuxiliaryEffectSlotfv));

            #endregion
        }
    }
}