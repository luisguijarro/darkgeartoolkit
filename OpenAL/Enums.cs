using System;

namespace dgtk.OpenAL
{
    public enum ALC_ERROR :uint
	{
		ALC_NO_ERROR = ALCEnum.ALC_NO_ERROR,
		ALC_INVALID_DEVICE = ALCEnum.ALC_INVALID_DEVICE,
		ALC_INVALID_CONTEXT = ALCEnum.ALC_INVALID_CONTEXT,
		ALC_INVALID_ENUM = ALCEnum.ALC_INVALID_ENUM,
		ALC_INVALID_VALUE = ALCEnum.ALC_INVALID_VALUE,
		ALC_OUT_OF_MEMORY = ALCEnum.ALC_OUT_OF_MEMORY
	}	

    public enum AL_DistanceModel
    {
        AL_NONE = ALEnum.AL_NONE,
        AL_INVERSE_DISTANCE = ALEnum.AL_INVERSE_DISTANCE,
        AL_INVERSE_DISTANCE_CLAMPED = ALEnum.AL_INVERSE_DISTANCE_CLAMPED,
        AL_LINEAR_DISTANCE = ALEnum.AL_LINEAR_DISTANCE,
        AL_LINEAR_DISTANCE_CLAMPED = ALEnum.AL_LINEAR_DISTANCE_CLAMPED,
        AL_EXPONENT_DISTANCE = ALEnum.AL_EXPONENT_DISTANCE,
        AL_EXPONENT_DISTANCE_CLAMPED = ALEnum.AL_EXPONENT_DISTANCE_CLAMPED
    }
	
	public enum ALC_GetStringParam : uint
	{
		ALC_DEFAULT_DEVICE_SPECIFIER = ALCEnum.ALC_DEFAULT_DEVICE_SPECIFIER, 
		ALC_DEVICE_SPECIFIER = ALCEnum.ALC_DEVICE_SPECIFIER, 
		ALC_EXTENSIONS = ALCEnum.ALC_EXTENSIONS,
		ALC_CAPTURE_DEVICE_SPECIFIER = ALCEnum.ALC_CAPTURE_DEVICE_SPECIFIER,	
		ALC_CAPTURE_DEFAULT_DEVICE_SPECIFIER = ALCEnum.ALC_CAPTURE_DEFAULT_DEVICE_SPECIFIER, 
		ALC_DEFAULT_ALL_DEVICES_SPECIFIER = ALCEnum.ALC_DEFAULT_ALL_DEVICES_SPECIFIER,
		ALC_ALL_DEVICES_SPECIFIER = ALCEnum.ALC_ALL_DEVICES_SPECIFIER
	}
	
	public enum ALC_GetIntegerParam : uint
	{
		ALC_MAJOR_VERSION = ALCEnum.ALC_MAJOR_VERSION, 
		ALC_MINOR_VERSION = ALCEnum.ALC_MINOR_VERSION,  
		ALC_ATTRIBUTES_SIZE = ALCEnum.ALC_ATTRIBUTES_SIZE, 
		ALC_ALL_ATTRIBUTES = ALCEnum.ALC_ALL_ATTRIBUTES
	}
	
	public enum ALC_BufferFormat : int
	{
		AL_FORMAT_MONO8 = ALEnum.AL_FORMAT_MONO8, 
		AL_FORMAT_MONO16 = ALEnum.AL_FORMAT_MONO16, 
		AL_FORMAT_STEREO8 = ALEnum.AL_FORMAT_STEREO8, 
		AL_FORMAT_STEREO16 = ALEnum.AL_FORMAT_STEREO16
	}
	
	public enum AL_FORMAT : int
	{
		AL_FORMAT_MONO8 = ALEnum.AL_FORMAT_MONO8, 
		AL_FORMAT_MONO16 = ALEnum.AL_FORMAT_MONO16, 
		AL_FORMAT_STEREO8 = ALEnum.AL_FORMAT_STEREO8, 
		AL_FORMAT_STEREO16 = ALEnum.AL_FORMAT_STEREO16
	}

	public enum AL_BufferParam : int
	{
		AL_FREQUENCY = ALEnum.AL_FREQUENCY, 
		AL_BITS = ALEnum.AL_BITS, 
		AL_CHANNELS = ALEnum.AL_CHANNELS,  
		AL_SIZE = ALEnum.AL_SIZE, 
		//AL_DATA
	}
	
	public enum AL_SourcefParam : int
	{
		AL_PITCH = ALEnum.AL_PITCH, 
		AL_GAIN = ALEnum.AL_GAIN, 
		AL_MIN_GAIN = ALEnum.AL_MIN_GAIN, 
		AL_MAX_GAIN = ALEnum.AL_MAX_GAIN, 
		AL_MAX_DISTANCE = ALEnum.AL_MAX_DISTANCE, 
		AL_ROLLOFF_FACTOR = ALEnum.AL_ROLLOFF_FACTOR, 
		AL_CONE_OUTER_GAIN = ALEnum.AL_CONE_OUTER_GAIN, 
		AL_CONE_INNER_ANGLE = ALEnum.AL_CONE_INNER_ANGLE, 
		AL_CONE_OUTER_ANGLE = ALEnum.AL_CONE_OUTER_ANGLE, 
		AL_REFERENCE_DISTANCE = ALEnum.AL_REFERENCE_DISTANCE,
		AL_SEC_OFFSET = ALEnum.AL_SEC_OFFSET
	}
	
	public enum AL_Source3Param : int
	{
		AL_POSITION = ALEnum.AL_POSITION, 
		AL_VELOCITY = ALEnum.AL_VELOCITY, 
		AL_DIRECTION = ALEnum.AL_DIRECTION
	}
	
	public enum AL_SourceiParam : int
	{
		AL_SOURCE_RELATIVE = ALEnum.AL_SOURCE_RELATIVE, 
		AL_CONE_INNER_ANGLE = ALEnum.AL_CONE_INNER_ANGLE, 
		AL_CONE_OUTER_ANGLE = ALEnum.AL_CONE_OUTER_ANGLE, 
		AL_SOURCE_TYPE = ALEnum.AL_SOURCE_TYPE,
		AL_BUFFER = ALEnum.AL_BUFFER, 
		AL_SOURCE_STATE = ALEnum.AL_SOURCE_STATE
	}
	
	public enum AL_SourcebParam : int
	{
		AL_LOOPING = ALEnum.AL_LOOPING, 
	}
	
	public enum AL_GetSourceiParam : int
	{
		AL_SOURCE_RELATIVE = ALEnum.AL_SOURCE_RELATIVE, 
		AL_BUFFER = ALEnum.AL_BUFFER,  
		AL_SOURCE_TYPE = ALEnum.AL_SOURCE_TYPE,
		AL_SOURCE_STATE = ALEnum.AL_SOURCE_STATE, 
		AL_BUFFERS_QUEUED = ALEnum.AL_BUFFERS_QUEUED, 
		AL_BUFFERS_PROCESSED = ALEnum.AL_BUFFERS_PROCESSED
	}
	
	public enum AL_ListenerParam : int
	{
		AL_GAIN = ALEnum.AL_GAIN,
		AL_POSITION = ALEnum.AL_POSITION, 
		AL_VELOCITY = ALEnum.AL_VELOCITY, 
		AL_ORIENTATION = ALEnum.AL_ORIENTATION
	}	
	
	public enum AL_GetParam : int
	{
		AL_DOPPLER_FACTOR = ALEnum.AL_DOPPLER_FACTOR, 
		AL_SPEED_OF_SOUND = ALEnum.AL_SPEED_OF_SOUND, 
		AL_DISTANCE_MODEL = ALEnum.AL_DISTANCE_MODEL
	}
	
	public enum AL_GetStringParam : int
	{
		AL_VENDOR = ALEnum.AL_VENDOR,  
		AL_VERSION = ALEnum.AL_VERSION, 
		AL_RENDERER = ALEnum.AL_RENDERER, 
		AL_EXTENSIONS = ALEnum.AL_EXTENSIONS
	}
	
	public enum AL_ERROR : int
	{
		AL_INVALID = ALEnum.AL_INVALID,
		AL_NO_ERROR = ALEnum.AL_NO_ERROR, 
		AL_INVALID_NAME = ALEnum.AL_INVALID_NAME, 
		AL_INVALID_ENUM = ALEnum.AL_INVALID_ENUM, 
		AL_INVALID_VALUE = ALEnum.AL_INVALID_VALUE, 
		AL_INVALID_OPERATION = ALEnum.AL_INVALID_OPERATION, 
		AL_OUT_OF_MEMORY = ALEnum.AL_OUT_OF_MEMORY
	}
	
	public enum AL_SourceState : uint
	{
		AL_INITIAL = ALEnum.AL_INITIAL,
		AL_PLAYING = ALEnum.AL_PLAYING,
		AL_PAUSED = ALEnum.AL_PAUSED,
		AL_STOPPED = ALEnum.AL_STOPPED
	}
	
	public enum AL_SourceType : uint
	{
		AL_STATIC = ALEnum.AL_STATIC,
		AL_STREAMING = ALEnum.AL_STREAMING,
		AL_UNDETERMINED = ALEnum.AL_UNDETERMINED,
	}

    public enum ALEnum : int
    {
        /* Enumerant values begin at column 50. No tabs. */

        /* bad value */
        AL_INVALID = -1,

        AL_NONE = 0,

        /* Boolean False. */
        AL_FALSE = 0,

        /** Boolean True. */
        AL_TRUE = 1,

        /** Indicate Source has relative coordinates. */
        AL_SOURCE_RELATIVE = 0x202,



        /**
        * Directional source, inner cone angle, in degrees.
        * Range:    [0-360] 
        * Default:  360
        */
        AL_CONE_INNER_ANGLE = 0x1001,

        /**
        * Directional source, outer cone angle, in degrees.
        * Range:    [0-360] 
        * Default:  360
        */
        AL_CONE_OUTER_ANGLE = 0x1002,

        /**
        * Specify the pitch to be applied, either at source,
        *  or on mixer results, at listener.
        * Range:   [0.5-2.0]
        * Default: 1.0
        */
        AL_PITCH = 0x1003,
        
        /** 
        * Specify the current location in three dimensional space.
        * OpenAL, like OpenGL, uses a right handed coordinate system,
        *  where in a frontal default view X (thumb) points right, 
        *  Y points up (index finger), and Z points towards the
        *  viewer/camera (middle finger). 
        * To switch from a left handed coordinate system, flip the
        *  sign on the Z coordinate.
        * Listener position is always in the world coordinate system.
        */ 
        AL_POSITION = 0x1004,
        
        /** Specify the current direction. */
        AL_DIRECTION = 0x1005,
        
        /** Specify the current velocity in three dimensional space. */
        AL_VELOCITY = 0x1006,

        /**
        * Indicate whether source is looping.
        * Type: ALboolean?
        * Range:   [AL_TRUE, AL_FALSE]
        * Default: FALSE.
        */
        AL_LOOPING = 0x1007,

        /**
        * Indicate the buffer to provide sound samples. 
        * Type: ALuint.
        * Range: any valid Buffer id.
        */
        AL_BUFFER = 0x1009,
        
        /**
        * Indicate the gain (volume amplification) applied. 
        * Type:   ALfloat.
        * Range:  ]0.0-  ]
        * A value of 1.0 means un-attenuated/unchanged.
        * Each division by 2 equals an attenuation of -6dB.
        * Each multiplicaton with 2 equals an amplification of +6dB.
        * A value of 0.0 is meaningless with respect to a logarithmic
        *  scale; it is interpreted as zero volume - the channel
        *  is effectively disabled.
        */
        AL_GAIN = 0x100A,

        /*
        * Indicate minimum source attenuation
        * Type: ALfloat
        * Range:  [0.0 - 1.0]
        *
        * Logarthmic
        */
        AL_MIN_GAIN = 0x100D,

        /**
        * Indicate maximum source attenuation
        * Type: ALfloat
        * Range:  [0.0 - 1.0]
        *
        * Logarthmic
        */
        AL_MAX_GAIN = 0x100E,

        /**
        * Indicate listener orientation.
        *
        * at/up 
        */
        AL_ORIENTATION = 0x100F,

        /**
        * Specify the channel mask. (Creative)
        * Type: ALuint
        * Range: [0 - 255]
        */
        AL_CHANNEL_MASK = 0x3000,


        /**
        * Source state information.
        */
        AL_SOURCE_STATE = 0x1010,
        AL_INITIAL = 0x1011,
        AL_PLAYING = 0x1012,
        AL_PAUSED = 0x1013,
        AL_STOPPED = 0x1014,

        /**
        * Buffer Queue params
        */
        AL_BUFFERS_QUEUED = 0x1015,
        AL_BUFFERS_PROCESSED = 0x1016,

        /**
        * Source buffer position information
        */
        AL_SEC_OFFSET = 0x1024,
        AL_SAMPLE_OFFSET = 0x1025,
        AL_BYTE_OFFSET = 0x1026,

        /*
        * Source type (Static, Streaming or undetermined)
        * Source is Static if a Buffer has been attached using AL_BUFFER
        * Source is Streaming if one or more Buffers have been attached using alSourceQueueBuffers
        * Source is undetermined when it has the NULL buffer attached
        */
        AL_SOURCE_TYPE = 0x1027,
        AL_STATIC = 0x1028,
        AL_STREAMING = 0x1029,
        AL_UNDETERMINED = 0x1030,

        /** Sound samples: format specifier. */
        AL_FORMAT_MONO8 = 0x1100,
        AL_FORMAT_MONO16 = 0x1101,
        AL_FORMAT_STEREO8 = 0x1102,
        AL_FORMAT_STEREO16 = 0x1103,

        /**
        * source specific reference distance
        * Type: ALfloat
        * Range:  0.0 - +inf
        *
        * At 0.0, no distance attenuation occurs.  Default is
        * 1.0.
        */
        AL_REFERENCE_DISTANCE = 0x1020,

        /**
        * source specific rolloff factor
        * Type: ALfloat
        * Range:  0.0 - +inf
        *
        */
        AL_ROLLOFF_FACTOR = 0x1021,

        /**
        * Directional source, outer cone gain.
        *
        * Default:  0.0
        * Range:    [0.0 - 1.0]
        * Logarithmic
        */
        AL_CONE_OUTER_GAIN = 0x1022,

        /**
        * Indicate distance above which sources are not
        * attenuated using the inverse clamped distance model.
        *
        * Default: +inf
        * Type: ALfloat
        * Range:  0.0 - +inf
        */
        AL_MAX_DISTANCE = 0x1023,

        /** 
        * Sound samples: frequency, in units of Hertz [Hz].
        * This is the number of samples per second. Half of the
        *  sample frequency marks the maximum significant
        *  frequency component.
        */
        AL_FREQUENCY = 0x2001,
        AL_BITS = 0x2002,
        AL_CHANNELS = 0x2003,
        AL_SIZE = 0x2004,

        /**
        * Buffer state.
        *
        * Not supported for public use (yet).
        */
        AL_UNUSED = 0x2010,
        AL_PENDING = 0x2011,
        AL_PROCESSED = 0x2012,


        /** Errors: No Error. */
        AL_NO_ERROR = AL_FALSE,

        /** 
        * Invalid Name paramater passed to AL call.
        */
        AL_INVALID_NAME = 0xA001,

        /** 
        * Invalid parameter passed to AL call.
        */
        AL_ILLEGAL_ENUM = 0xA002,
        AL_INVALID_ENUM = 0xA002,

        /** 
        * Invalid enum parameter value.
        */
        AL_INVALID_VALUE = 0xA003,

        /** 
        * Illegal call.
        */
        AL_ILLEGAL_COMMAND = 0xA004,
        AL_INVALID_OPERATION = 0xA004,

        
        /**
        * No mojo.
        */
        AL_OUT_OF_MEMORY = 0xA005,


        /** Context strings: Vendor Name. */
        AL_VENDOR = 0xB001,
        AL_VERSION = 0xB002,
        AL_RENDERER = 0xB003,
        AL_EXTENSIONS = 0xB004,

        /** Global tweakage. */

        /**
        * Doppler scale.  Default 1.0
        */
        AL_DOPPLER_FACTOR = 0xC000,

        /**
        * Tweaks speed of propagation.
        */
        AL_DOPPLER_VELOCITY = 0xC001,

        /**
        * Speed of Sound in units per second
        */
        AL_SPEED_OF_SOUND = 0xC003,

        /**
        * Distance models
        *
        * used in conjunction with DistanceModel
        *
        * implicit: NONE, which disances distance attenuation.
        */
        AL_DISTANCE_MODEL = 0xD000,
        AL_INVERSE_DISTANCE = 0xD001,
        AL_INVERSE_DISTANCE_CLAMPED = 0xD002,
        AL_LINEAR_DISTANCE = 0xD003,
        AL_LINEAR_DISTANCE_CLAMPED = 0xD004,
        AL_EXPONENT_DISTANCE = 0xD005,
        AL_EXPONENT_DISTANCE_CLAMPED = 0xD006        
    }

    public enum ALCEnum : uint
    {
        /* Enumerant values begin at column 50. No tabs. */

        /* Boolean False. */
        ALC_FALSE = 0,

        /* Boolean True. */
        ALC_TRUE = 1,

        /**
        * followed by <int> Hz
        */
        ALC_FREQUENCY = 0x1007,

        /**
        * followed by <int> Hz
        */
        ALC_REFRESH = 0x1008,

        /**
        * followed by AL_TRUE, AL_FALSE
        */
        ALC_SYNC = 0x1009,

        /**
        * followed by <int> Num of requested Mono (3D) Sources
        */
        ALC_MONO_SOURCES = 0x1010,

        /**
        * followed by <int> Num of requested Stereo Sources
        */
        ALC_STEREO_SOURCES = 0x1011,

        /**
        * errors
        */

        /**
        * No error
        */
        ALC_NO_ERROR = ALC_FALSE,

        /**
        * No device
        */
        ALC_INVALID_DEVICE = 0xA001,

        /**
        * invalid context ID
        */
        ALC_INVALID_CONTEXT = 0xA002,

        /**
        * bad enum
        */
        ALC_INVALID_ENUM = 0xA003,

        /**
        * bad value
        */
        ALC_INVALID_VALUE = 0xA004,

        /**
        * Out of memory.
        */
        ALC_OUT_OF_MEMORY = 0xA005,


        /**
        * The Specifier string for default device
        */
        ALC_DEFAULT_DEVICE_SPECIFIER = 0x1004,
        ALC_DEVICE_SPECIFIER = 0x1005,
        ALC_EXTENSIONS = 0x1006,

        ALC_MAJOR_VERSION = 0x1000,
        ALC_MINOR_VERSION = 0x1001,

        ALC_ATTRIBUTES_SIZE = 0x1002,
        ALC_ALL_ATTRIBUTES = 0x1003,

        /**
        * ALC_ENUMERATE_ALL_EXT enums
        */
        ALC_DEFAULT_ALL_DEVICES_SPECIFIER = 0x1012,
        ALC_ALL_DEVICES_SPECIFIER = 0x1013,

        /**
        * Capture extension
        */
        ALC_CAPTURE_DEVICE_SPECIFIER = 0x310,
        ALC_CAPTURE_DEFAULT_DEVICE_SPECIFIER = 0x311,
        ALC_CAPTURE_SAMPLES = 0x312
    }
}