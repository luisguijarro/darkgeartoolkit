using System;
using System.Runtime.InteropServices;

namespace dgtk.GameControlSystem.Windows
{
	[StructLayout( LayoutKind.Sequential )]
    internal struct RAWINPUTDEVICELIST
    {
        internal IntPtr hDevice;
        internal RawInputDeviceType Type;
    }


	[StructLayout(LayoutKind.Explicit)]
    internal struct DeviceInfo 
    { 
        [FieldOffset(0)]
        internal int Size;
        [FieldOffset(4)]
        internal int Type;

        [FieldOffset(8)]
        internal DeviceInfoMouse MouseInfo;
        [FieldOffset(8)]
        internal DeviceInfoKeyboard KeyboardInfo;
        [FieldOffset(8)]
        internal DeviceInfoHID HIDInfo;
    }


	[StructLayout( LayoutKind.Sequential )]
    internal struct DeviceInfoMouse
    {
        internal uint ID;
        internal uint NumberOfButtons;
        internal uint SampleRate;
    }

	[StructLayout( LayoutKind.Sequential )]
    internal struct DeviceInfoKeyboard
    {
        internal uint Type;
        internal uint SubType;
        internal uint KeyboardMode;
        internal uint NumberOfFunctionKeys;
        internal uint NumberOfIndicators;
        internal uint NumberOfKeysTotal;
    }

	[StructLayout( LayoutKind.Sequential )]
    internal struct DeviceInfoHID
    {
        internal uint VendorID;
        internal uint ProductID;
        internal uint VersionNumber;
        internal ushort UsagePage;
        internal ushort Usage;
    }
	
    [StructLayout(LayoutKind.Sequential)]
	internal struct HIDP_CAPS 
	{
		internal HIDUsage  Usage;
		internal HIDUsagePage  UsagePage;
		internal ushort InputReportByteLength;
		internal ushort OutputReportByteLength;
		internal ushort FeatureReportByteLength;
		internal unsafe fixed ushort Reserved[17];
		internal ushort NumberLinkCollectionNodes;
		internal ushort NumberInputButtonCaps;
		internal ushort NumberInputValueCaps;
		internal ushort NumberInputDataIndices;
		internal ushort NumberOutputButtonCaps;
		internal ushort NumberOutputValueCaps;
		internal ushort NumberOutputDataIndices;
		internal ushort NumberFeatureButtonCaps;
		internal ushort NumberFeatureValueCaps;
		internal ushort NumberFeatureDataIndices;
	}

    [StructLayout(LayoutKind.Explicit)]
	internal struct HIDP_VALUE_CAPS 
	{
		[FieldOffset(0)]
		internal HIDUsagePage UsagePage;
        [FieldOffset(2)]
		internal byte ReportID;
        [FieldOffset(3)]
		internal bool IsAlias;
        [FieldOffset(4)]
		internal ushort  BitField;
        [FieldOffset(6)]
		internal ushort  LinkCollection;
        [FieldOffset(8)]
        internal ushort LinkUsage;
        [FieldOffset(10)]
		internal ushort   LinkUsagePage;
        [FieldOffset(12)]
		internal bool IsRange;
        [FieldOffset(13)]
		internal bool IsStringRange;
        [FieldOffset(14)]
		internal bool IsDesignatorRange;
        [FieldOffset(15)]
		internal bool IsAbsolute;
        [FieldOffset(16)]
		internal bool HasNull;
        [FieldOffset(17)]
		internal byte   Reserved;
        [FieldOffset(18)]
		internal ushort  BitSize;
        [FieldOffset(20)]
		internal ushort  ReportCount;
        //[FieldOffset(22)]
		//internal unsafe fixed ushort Reserved2[5];  //2bytes * 5 = 10
        [FieldOffset(32)]
		internal ulong   UnitsExp;
        [FieldOffset(36)]
		internal ulong   Units;
        [FieldOffset(40)]
		internal long    LogicalMin;
        [FieldOffset(44)]
		internal long    LogicalMax;
        [FieldOffset(48)]
		internal long    PhysicalMin;
        [FieldOffset(52)]
		internal long    PhysicalMax;
        [FieldOffset(56)]
		internal Range range;
        [FieldOffset(56)]
        internal NotRange notrange; 
	}

    [StructLayout(LayoutKind.Explicit)]
	internal struct HIDP_BUTTON_CAPS 
	{
        [FieldOffset(0)]
		internal HIDUsagePage UsagePage;
        [FieldOffset(2)]
		internal byte ReportID;
        [FieldOffset(3)]
		internal bool IsAlias;
        [FieldOffset(4)]
		internal ushort  BitField;
        [FieldOffset(6)]
		internal ushort  LinkCollection;
        [FieldOffset(8)]
		internal ushort   LinkUsage;
        [FieldOffset(10)]
		internal ushort   LinkUsagePage;
        [FieldOffset(12)]
		internal bool IsRange;
        [FieldOffset(13)]
		internal bool IsStringRange;
        [FieldOffset(14)]
		internal bool IsDesignatorRange;
        [FieldOffset(15)]
		internal bool IsAbsolute;
        //[FieldOffset(16)]
		//internal unsafe fixed ulong Reserved[10]; //4bytes x 10 = 40
        [FieldOffset(56)]
        internal Range range;
        [FieldOffset(56)]
        internal NotRange notrange; 
	}


	[StructLayout(LayoutKind.Sequential)]
	internal struct Range
	{
		internal short  UsageMin;
		internal short  UsageMax;
		internal short StringMin;
		internal short StringMax;
		internal short DesignatorMin;
		internal short DesignatorMax;
		internal short DataIndexMin;
		internal short DataIndexMax;
	}
	
	[StructLayout(LayoutKind.Sequential)]
    internal struct NotRange
	{
		internal HIDUsage Usage;
		short  Reserved1;
		internal short StringIndex;
		short Reserved2;
		internal short DesignatorIndex;
		short Reserved3;
		internal short DataIndex;
		short Reserved4;
    }
	
}
	