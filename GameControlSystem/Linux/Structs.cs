using System;
using System.Runtime.InteropServices;

namespace dgtk.GameControlSystem.Linux
{
	[StructLayout(LayoutKind.Sequential)]internal struct input_event 
    {
            internal timeval time;
            internal GameControlEventType type;
            internal ushort code;
            internal uint value;
    }

	[StructLayout(LayoutKind.Sequential)]
    internal struct timeval
    {
        internal long seconds;
        internal long microseconds;
    }


	[StructLayout(LayoutKind.Sequential)]
    internal struct input_absinfo 
    {
    	internal  int value;
    	internal  int minimum;
    	internal  int maximum;
    	internal  int fuzz;
    	internal  int flat;
    	internal  int resolution;
	}

    [StructLayout(LayoutKind.Sequential)]
    internal struct ff_replay 
    {
	    ushort length;
	    ushort delay;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct ff_trigger 
    {
	    ushort button;
	    ushort interval;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct ff_envelope 
    {
	    ushort attack_length;
	    ushort attack_level;
	    ushort fade_length;
	    ushort fade_level;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct ff_constant_effect 
    {
	    ushort level;
	    ff_envelope envelope;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct ff_ramp_effect 
    {
        short start_level;
        short end_level;
        ff_envelope envelope;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct ff_condition_effect 
    {
        ushort right_saturation;
        ushort left_saturation;

        short right_coeff;
        short left_coeff;

        ushort deadband;
        short center;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct ff_periodic_effect 
    {
        ushort waveform;
        ushort period;
        short magnitude;
        short offset;
        ushort phase;

        ff_envelope envelope;

        uint custom_len;
        IntPtr custom_data; //short*
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct ff_rumble_effect 
    {
        ushort strong_magnitude;
        ushort weak_magnitude;
    }

    [StructLayout(LayoutKind.Explicit)]
    internal struct ff_effect 
    {
        [FieldOffset(0)] ushort type;
        [FieldOffset(2)] short id;
        [FieldOffset(4)] ushort direction;
        [FieldOffset(6)] ff_trigger trigger;
        [FieldOffset(10)] ff_replay replay;

        [FieldOffset(14)] ff_constant_effect constant;
        [FieldOffset(14)] ff_ramp_effect ramp;
        [FieldOffset(14)] ff_periodic_effect periodic;
        [FieldOffset(14)] ff_condition_effect[] condition; /* One for each axis */ //[2]
        [FieldOffset(14)] ff_rumble_effect rumble;
    }
}