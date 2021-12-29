using System;

namespace dgtk.GameControlSystem.Windows
{
	internal enum RawInputDeviceType : int
    {
        MOUSE = 0,
        KEYBOARD = 1,
        HID = 2
    }

	internal enum RawInputDeviceInfo_Command : uint
	{
		RIDI_DEVICENAME = 0x20000007, 
		RIDI_DEVICEINFO = 0x2000000b,
		RIDI_PREPARSEDDATA = 0x20000005
	}
	
    internal enum HIDResults : int
	{
		HIDP_STATUS_SUCCESS                  = (0x0 << 28) | (0x11 << 16) | 0,
        HIDP_STATUS_NULL                     = (0x8 << 28) | (0x11 << 16) | 1,
        HIDP_STATUS_INVALID_PREPARSED_DATA   = (0xC << 28) | (0x11 << 16) | 1,
        HIDP_STATUS_INVALID_REPORT_TYPE      = (0xC << 28) | (0x11 << 16) | 2,
        HIDP_STATUS_INVALID_REPORT_LENGTH    = (0xC << 28) | (0x11 << 16) | 3,
        HIDP_STATUS_USAGE_NOT_FOUND          = (0xC << 28) | (0x11 << 16) | 4,
        HIDP_STATUS_VALUE_OUT_OF_RANGE       = (0xC << 28) | (0x11 << 16) | 5,
        HIDP_STATUS_BAD_LOG_PHY_VALUES       = (0xC << 28) | (0x11 << 16) | 6,
        HIDP_STATUS_BUFFER_TOO_SMALL         = (0xC << 28) | (0x11 << 16) | 7,
        HIDP_STATUS_INTERNAL_ERROR           = (0xC << 28) | (0x11 << 16) | 8,
        HIDP_STATUS_I8042_TRANS_UNKNOWN      = (0xC << 28) | (0x11 << 16) | 9,
        HIDP_STATUS_INCOMPATIBLE_REPORT_ID   = (0xC << 28) | (0x11 << 16) | 0xA,
        HIDP_STATUS_NOT_VALUE_ARRAY          = (0xC << 28) | (0x11 << 16) | 0xB,
        HIDP_STATUS_IS_VALUE_ARRAY           = (0xC << 28) | (0x11 << 16) | 0xC,
        HIDP_STATUS_DATA_INDEX_NOT_FOUND     = (0xC << 28) | (0x11 << 16) | 0xD,
        HIDP_STATUS_DATA_INDEX_OUT_OF_RANGE  = (0xC << 28) | (0x11 << 16) | 0xE,
        HIDP_STATUS_BUTTON_NOT_PRESSED       = (0xC << 28) | (0x11 << 16) | 0xF,
        HIDP_STATUS_REPORT_DOES_NOT_EXIST    = (0xC << 28) | (0x11 << 16) | 0x10,
        HIDP_STATUS_NOT_IMPLEMENTED          = (0xC << 28) | (0x11 << 16) | 0x20
	}
	
	internal enum HIDUsagePage : ushort
	{
	    Undefined = 0x00,
	    Generic = 0x01,
	    Simulation = 0x02,
	    VR = 0x03,
	    Sport = 0x04,
	    Game = 0x05,
	    Keyboard = 0x07,
	    LED = 0x08,
	    Button = 0x09,
	    Ordinal = 0x0A,
	    Telephony = 0x0B,
	    Consumer = 0x0C,
	    Digitizer = 0x0D,
	    PID = 0x0F,
	    Unicode = 0x10,
	    AlphaNumeric = 0x14,
	    Medical = 0x40,
	    MonitorPage0 = 0x80,
	    MonitorPage1 = 0x81,
	    MonitorPage2 = 0x82,
	    MonitorPage3 = 0x83,
	    PowerPage0 = 0x84,
	    PowerPage1 = 0x85,
	    PowerPage2 = 0x86,
	    PowerPage3 = 0x87,
	    BarCode = 0x8C,
	    Scale = 0x8D,
	    MSR = 0x8E
	}
    

	internal enum HIDUsage : short
	{
	    Pointer = 0x01,
	    Mouse = 0x02,
	    Joystick = 0x04,
	    Gamepad = 0x05,
	    Keyboard = 0x06,
	    Keypad = 0x07,
	    X = 0x30,
	    Y = 0x31,
	    Z = 0x32,
	    RelativeX = 0x33,   
	    RelativeY = 0x34,
	    RelativeZ = 0x35,
	    Slider = 0x36,
	    Dial = 0x37,
	    Wheel = 0x38,
	    HatSwitch = 0x39,
	    SystemControl = 0x80,
	    /*CountedBuffer = 0x3A,
	    ByteCount = 0x3B,
	    MotionWakeup = 0x3C,
	    VX = 0x40,
	    VY = 0x41,
	    VZ = 0x42,
	    VBRX = 0x43,
	    VBRY = 0x44,
	    VBRZ = 0x45,
	    VNO = 0x46,
	    SystemControlPower = 0x81,
	    SystemControlSleep = 0x82,
	    SystemControlWake = 0x83,
	    SystemControlContextMenu = 0x84,
	    SystemControlMainMenu = 0x85,
	    SystemControlApplicationMenu = 0x86,
	    SystemControlHelpMenu = 0x87,
	    SystemControlMenuExit = 0x88,
	    SystemControlMenuSelect = 0x89,
	    SystemControlMenuRight = 0x8A,
	    SystemControlMenuLeft = 0x8B,
	    SystemControlMenuUp = 0x8C,
	    SystemControlMenuDown = 0x8D,
	    KeyboardNoEvent = 0x00,
	    KeyboardRollover = 0x01,
	    KeyboardPostFail = 0x02,
	    KeyboardUndefined = 0x03,
	    KeyboardaA = 0x04,
	    KeyboardzZ = 0x1D,
	    Keyboard1 = 0x1E,
	    Keyboard0 = 0x27,
	    KeyboardLeftControl = 0xE0,
	    KeyboardLeftShift = 0xE1,
	    KeyboardLeftALT = 0xE2,
	    KeyboardLeftGUI = 0xE3,
	    KeyboardRightControl = 0xE4,
	    KeyboardRightShift = 0xE5,
	    KeyboardRightALT = 0xE6,
	    KeyboardRightGUI = 0xE7,
	    KeyboardScrollLock = 0x47,
	    KeyboardNumLock = 0x53,
	    KeyboardCapsLock = 0x39,
	    KeyboardF1 = 0x3A,
	    KeyboardF12 = 0x45,
	    KeyboardReturn = 0x28,
	    KeyboardEscape = 0x29,
	    KeyboardDelete = 0x2A,
	    KeyboardPrintScreen = 0x46,
	    LEDNumLock = 0x01,
	    LEDCapsLock = 0x02,
	    LEDScrollLock = 0x03,
	    LEDCompose = 0x04,
	    LEDKana = 0x05,
	    LEDPower = 0x06,
	    LEDShift = 0x07,
	    LEDDoNotDisturb = 0x08,
	    LEDMute = 0x09,
	    LEDToneEnable = 0x0A,
	    LEDHighCutFilter = 0x0B,
	    LEDLowCutFilter = 0x0C,
	    LEDEqualizerEnable = 0x0D,
	    LEDSoundFieldOn = 0x0E,
	    LEDSurroundFieldOn = 0x0F,
	    LEDRepeat = 0x10,
	    LEDStereo = 0x11,
	    LEDSamplingRateDirect = 0x12,
	    LEDSpinning = 0x13,
	    LEDCAV = 0x14,
	    LEDCLV = 0x15,
	    LEDRecordingFormatDet = 0x16,
	    LEDOffHook = 0x17,
	    LEDRing = 0x18,
	    LEDMessageWaiting = 0x19,
	    LEDDataMode = 0x1A,
	    LEDBatteryOperation = 0x1B,
	    LEDBatteryOK = 0x1C,
	    LEDBatteryLow = 0x1D,
	    LEDSpeaker = 0x1E,
	    LEDHeadset = 0x1F,
	    LEDHold = 0x20,
	    LEDMicrophone = 0x21,
	    LEDCoverage = 0x22,
	    LEDNightMode = 0x23,
	    LEDSendCalls = 0x24,
	    LEDCallPickup = 0x25,
	    LEDConference = 0x26,
	    LEDStandBy = 0x27,
	    LEDCameraOn = 0x28,
	    LEDCameraOff = 0x29,   
	    LEDOnLine = 0x2A,
	    LEDOffLine = 0x2B,
	    LEDBusy = 0x2C,
	    LEDReady = 0x2D,
	    LEDPaperOut = 0x2E,
	    LEDPaperJam = 0x2F,
	    LEDRemote = 0x30,
	    LEDForward = 0x31,
	    LEDReverse = 0x32,
	    LEDStop = 0x33,
	    LEDRewind = 0x34,
	    LEDFastForward = 0x35,
	    LEDPlay = 0x36,
	    LEDPause = 0x37,
	    LEDRecord = 0x38,
	    LEDError = 0x39,
	    LEDSelectedIndicator = 0x3A,
	    LEDInUseIndicator = 0x3B,
	    LEDMultiModeIndicator = 0x3C,
	    LEDIndicatorOn = 0x3D,
	    LEDIndicatorFlash = 0x3E,
	    LEDIndicatorSlowBlink = 0x3F,
	    LEDIndicatorFastBlink = 0x40,
	    LEDIndicatorOff = 0x41,
	    LEDFlashOnTime = 0x42,
	    LEDSlowBlinkOnTime = 0x43,
	    LEDSlowBlinkOffTime = 0x44,
	    LEDFastBlinkOnTime = 0x45,
	    LEDFastBlinkOffTime = 0x46,
	    LEDIndicatorColor = 0x47,
	    LEDRed = 0x48,
	    LEDGreen = 0x49,
	    LEDAmber = 0x4A,
	    LEDGenericIndicator = 0x3B,
	    TelephonyPhone = 0x01,
	    TelephonyAnsweringMachine = 0x02,
	    TelephonyMessageControls = 0x03,
	    TelephonyHandset = 0x04,
	    TelephonyHeadset = 0x05,
	    TelephonyKeypad = 0x06,
	    TelephonyProgrammableButton = 0x07,
	    SimulationRudder = 0xBA,
	    SimulationThrottle = 0xBB*/
	}

	internal enum HIDP_REPORT_TYPE : ushort
	{
		HidP_Input,
		HidP_Output,
		HidP_Feature
	}
    
	#region XInput

	internal enum XInputResult : uint
	{
		SUCCESS = 0, 
		ERROR_DEVICE_NOT_CONNECTED = 1
	}

	internal enum DefinedDeadZones : ushort
	{
		XINPUT_GAMEPAD_LEFT_THUMB_DEADZONE = 7849,
		XINPUT_GAMEPAD_RIGHT_THUMB_DEADZONE = 8689,
		XINPUT_GAMEPAD_TRIGGER_THRESHOLD = 30
	}

	internal enum wButtons : ushort
	{
		XINPUT_GAMEPAD_DPAD_UP = 0x0001,
		XINPUT_GAMEPAD_DPAD_DOWN = 0x0002,
		XINPUT_GAMEPAD_DPAD_LEFT = 0x0004,
		XINPUT_GAMEPAD_DPAD_RIGHT = 0x0008,
		XINPUT_GAMEPAD_START = 0x0010,
		XINPUT_GAMEPAD_BACK = 0x0020,
		XINPUT_GAMEPAD_LEFT_THUMB = 0x0040,
		XINPUT_GAMEPAD_RIGHT_THUMB = 0x0080,
		XINPUT_GAMEPAD_LEFT_SHOULDER = 0x0100,
		XINPUT_GAMEPAD_RIGHT_SHOULDER = 0x0200,
		XINPUT_GAMEPAD_A = 0x1000,
		XINPUT_GAMEPAD_B = 0x2000,
		XINPUT_GAMEPAD_X = 0x4000,
		XINPUT_GAMEPAD_Y = 0x8000
	}

	#endregion
}
	