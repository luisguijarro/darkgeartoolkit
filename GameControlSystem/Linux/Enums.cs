using System;

namespace dgtk.GameControlSystem.Linux
{
    [Flags]
    internal enum libevdev_read_flag 
    {
        LIBEVDEV_READ_FLAG_SYNC = 1, 
        LIBEVDEV_READ_FLAG_NORMAL = 2, 
        LIBEVDEV_READ_FLAG_FORCE_SYNC = 4, 
        LIBEVDEV_READ_FLAG_BLOCKING = 8
    }

    internal enum libevdev_read_status 
    { 
        LIBEVDEV_READ_STATUS_SUCCESS = 0, 
        LIBEVDEV_READ_STATUS_SYNC = 1
    }

    internal enum GameControlEventType : ushort
    {
        EV_SYN = 0x00,
        EV_KEY = 0x01,
        EV_REL = 0x02,
        EV_ABS = 0x03,
        EV_MSC = 0x04,
        EV_SW = 0x05,
        EV_LED = 0x11,
        EV_SND = 0x12,
        EV_REP = 0x14,
        EV_FF = 0x15,
        EV_PWR = 0x16,
        EV_FF_STATUS = 0x17,
        EV_MAX = 0x1f,
        EV_CNT = (EV_MAX+1),
    }

    internal enum SincronizationEvents
    {
        SYN_REPORT = 0,
        SYN_CONFIG = 1,
        SYN_MT_REPORT = 2,
        SYN_DROPPED = 3,
        SYN_MAX = 0xf,
        SYN_CNT = (SYN_MAX+1)
    }

    internal enum GameControlBTN_EventCode
    {
        BTN_MISC = 0x100,
        BTN_0 = 0x100,
        BTN_1 = 0x101,
        BTN_2 = 0x102,
        BTN_3 = 0x103,
        BTN_4 = 0x104,
        BTN_5 = 0x105,
        BTN_6 = 0x106,
        BTN_7 = 0x107,
        BTN_8 = 0x108,
        BTN_9 = 0x109,

        BTN_MOUSE = 0x110,
        BTN_LEFT = 0x110,
        BTN_RIGHT = 0x111,
        BTN_MIDDLE = 0x112,
        BTN_SIDE = 0x113,
        BTN_EXTRA = 0x114,
        BTN_FORWARD = 0x115,
        BTN_BACK = 0x116,
        BTN_TASK = 0x117,

        BTN_JOYSTICK = 0x120,
        BTN_TRIGGER = 0x120,
        BTN_THUMB = 0x121,
        BTN_THUMB2 = 0x122,
        BTN_TOP = 0x123,
        BTN_TOP2 = 0x124,
        BTN_PINKIE = 0x125,
        BTN_BASE = 0x126,
        BTN_BASE2 = 0x127,
        BTN_BASE3 = 0x128,
        BTN_BASE4 = 0x129,
        BTN_BASE5 = 0x12a,
        BTN_BASE6 = 0x12b,
        BTN_DEAD = 0x12f,

        BTN_GAMEPAD = 0x130,
        BTN_SOUTH = 0x130,
        BTN_A = BTN_SOUTH,
        BTN_EAST = 0x131,
        BTN_B = BTN_EAST,
        BTN_C = 0x132,
        BTN_NORTH = 0x133,
        BTN_X = BTN_NORTH,
        BTN_WEST = 0x134,
        BTN_Y = BTN_WEST,
        BTN_Z = 0x135,
        BTN_TL = 0x136,
        BTN_TR = 0x137,
        BTN_TL2 = 0x138,
        BTN_TR2 = 0x139,
        BTN_SELECT = 0x13a,
        BTN_START = 0x13b,
        BTN_MODE = 0x13c,
        BTN_THUMBL = 0x13d,
        BTN_THUMBR = 0x13e,

        BTN_DIGI = 0x140,
        BTN_TOOL_PEN = 0x140,
        BTN_TOOL_RUBBER = 0x141,
        BTN_TOOL_BRUSH = 0x142,
        BTN_TOOL_PENCIL = 0x143,
        BTN_TOOL_AIRBRUSH = 0x144,
        BTN_TOOL_FINGER = 0x145,
        BTN_TOOL_MOUSE = 0x146,
        BTN_TOOL_LENS = 0x147,
        BTN_TOOL_QUINTTAP = 0x148,	/* Five fingers on trackpad */
        BTN_STYLUS3 = 0x149,
        BTN_TOUCH = 0x14a,
        BTN_STYLUS = 0x14b,
        BTN_STYLUS2 = 0x14c,
        BTN_TOOL_DOUBLETAP = 0x14d,
        BTN_TOOL_TRIPLETAP = 0x14e,
        BTN_TOOL_QUADTAP = 0x14f,	/* Four fingers on trackpad */

        BTN_WHEEL = 0x150,
        BTN_GEAR_DOWN = 0x150,
        BTN_GEAR_UP = 0x151,

        BTN_DPAD_UP = 0x220,
        BTN_DPAD_DOWN = 0x221,
        BTN_DPAD_LEFT = 0x222,
        BTN_DPAD_RIGHT = 0x223,

        BTN_TRIGGER_HAPPY = 0x2c0,
        BTN_TRIGGER_HAPPY1 = 0x2c0,
        BTN_TRIGGER_HAPPY2 = 0x2c1,
        BTN_TRIGGER_HAPPY3 = 0x2c2,
        BTN_TRIGGER_HAPPY4 = 0x2c3,
        BTN_TRIGGER_HAPPY5 = 0x2c4,
        BTN_TRIGGER_HAPPY6 = 0x2c5,
        BTN_TRIGGER_HAPPY7 = 0x2c6,
        BTN_TRIGGER_HAPPY8 = 0x2c7,
        BTN_TRIGGER_HAPPY9 = 0x2c8,
        BTN_TRIGGER_HAPPY10 = 0x2c9,
        BTN_TRIGGER_HAPPY11 = 0x2ca,
        BTN_TRIGGER_HAPPY12 = 0x2cb,
        BTN_TRIGGER_HAPPY13 = 0x2cc,
        BTN_TRIGGER_HAPPY14 = 0x2cd,
        BTN_TRIGGER_HAPPY15 = 0x2ce,
        BTN_TRIGGER_HAPPY16 = 0x2cf,
        BTN_TRIGGER_HAPPY17 = 0x2d0,
        BTN_TRIGGER_HAPPY18 = 0x2d1,
        BTN_TRIGGER_HAPPY19 = 0x2d2,
        BTN_TRIGGER_HAPPY20 = 0x2d3,
        BTN_TRIGGER_HAPPY21 = 0x2d4,
        BTN_TRIGGER_HAPPY22 = 0x2d5,
        BTN_TRIGGER_HAPPY23 = 0x2d6,
        BTN_TRIGGER_HAPPY24 = 0x2d7,
        BTN_TRIGGER_HAPPY25 = 0x2d8,
        BTN_TRIGGER_HAPPY26 = 0x2d9,
        BTN_TRIGGER_HAPPY27 = 0x2da,
        BTN_TRIGGER_HAPPY28 = 0x2db,
        BTN_TRIGGER_HAPPY29 = 0x2dc,
        BTN_TRIGGER_HAPPY30 = 0x2dd,
        BTN_TRIGGER_HAPPY31 = 0x2de,
        BTN_TRIGGER_HAPPY32 = 0x2df,
        BTN_TRIGGER_HAPPY33 = 0x2e0,
        BTN_TRIGGER_HAPPY34 = 0x2e1,
        BTN_TRIGGER_HAPPY35 = 0x2e2,
        BTN_TRIGGER_HAPPY36 = 0x2e3,
        BTN_TRIGGER_HAPPY37 = 0x2e4,
        BTN_TRIGGER_HAPPY38 = 0x2e5,
        BTN_TRIGGER_HAPPY39 = 0x2e6,
        BTN_TRIGGER_HAPPY40 = 0x2e7,

        
    }


    internal enum GameControlREL_EventCode
    {
        REL_X = 0x00,
        REL_Y = 0x01,
        REL_Z = 0x02,
        REL_RX = 0x03,
        REL_RY = 0x04,
        REL_RZ = 0x05,
        REL_HWHEEL = 0x06,
        REL_DIAL = 0x07,
        REL_WHEEL = 0x08,
        REL_MISC = 0x09,
        REL_MAX = 0x0f,
        REL_CNT = (REL_MAX+1)
    }

    internal enum GameControlABS_EventCode
    {
        ABS_X = 0x00,
        ABS_Y = 0x01,
        ABS_Z = 0x02,
        ABS_RX = 0x03,
        ABS_RY = 0x04,
        ABS_RZ = 0x05,
        ABS_THROTTLE = 0x06,
        ABS_RUDDER = 0x07,
        ABS_WHEEL = 0x08,
        ABS_GAS = 0x09,
        ABS_BRAKE = 0x0a,
        ABS_HAT0X = 0x10,
        ABS_HAT0Y = 0x11,
        ABS_HAT1X = 0x12,
        ABS_HAT1Y = 0x13,
        ABS_HAT2X = 0x14,
        ABS_HAT2Y = 0x15,
        ABS_HAT3X = 0x16,
        ABS_HAT3Y = 0x17,
        ABS_PRESSURE = 0x18,
        ABS_DISTANCE = 0x19,
        ABS_TILT_X = 0x1a,
        ABS_TILT_Y = 0x1b,
        ABS_TOOL_WIDTH = 0x1c,

        ABS_VOLUME = 0x20,

        ABS_MISC = 0x28,

        ABS_MAX = 0x3f,
        ABS_CNT = (ABS_MAX+1)
    }

    internal enum  force_feedback_Status_effect
    {
        FF_STATUS_STOPPED = 0x00,
        FF_STATUS_PLAYING = 0x01,
        FF_STATUS_MAX = 0x01
    }

    internal enum Force_feedback_effect_types
    {
        FF_RUMBLE = 0x50,
        FF_PERIODIC = 0x51,
        FF_CONSTANT = 0x52,
        FF_SPRING = 0x53,
        FF_FRICTION = 0x54,
        FF_DAMPER = 0x55,
        FF_INERTIA = 0x56,
        FF_RAMP	 = 0x57,

        FF_EFFECT_MIN = FF_RUMBLE,
        FF_EFFECT_MAX = FF_RAMP,
    }

    internal enum Force_feedback_periodic_effect_types
    {
        FF_SQUARE = 0x58,
        FF_TRIANGLE = 0x59,
        FF_SINE	 = 0x5a,
        FF_SAW_UP = 0x5b,
        FF_SAW_DOWN = 0x5c,
        FF_CUSTOM = 0x5d,
        FF_WAVEFORM_MIN = FF_SQUARE,
        FF_WAVEFORM_MAX = FF_CUSTOM,
    }

    internal enum Set_ff_device_properties
    {
        FF_GAIN = 0x60,
        FF_AUTOCENTER = 0x61,

        /*
        * ff->playback(effect_id = FF_GAIN) is the first effect_id to
        * cause a collision with another ff method, in this case ff->set_gain().
        * Therefore the greatest safe value for effect_id is FF_GAIN - 1,
        * and thus the total number of effects should never exceed FF_GAIN.
        */
        FF_MAX_EFFECTS = FF_GAIN,

        FF_MAX = 0x7f,
        FF_CNT = (FF_MAX+1)
    }
}