using System;
using System.Runtime.InteropServices;

namespace dgtk.GameControlSystem.Windows
{
    internal class Imports
    {
        
		[DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
	    internal static extern uint GetRawInputDeviceList([In, Out] RAWINPUTDEVICELIST[] RawInputDeviceList, ref uint NumDevices, uint Size);
	    
		[DllImport("user32.dll", SetLastError=true)]
		internal static extern uint GetRawInputDeviceInfo(IntPtr hDevice, RawInputDeviceInfo_Command uiCommand, out DeviceInfo pData, ref uint pcbSize);
		
		[DllImport("user32.dll", SetLastError=true)]
		internal static extern uint GetRawInputDeviceInfo(IntPtr hDevice, RawInputDeviceInfo_Command uiCommand, ref IntPtr pData, ref uint pcbSize);
		
        [DllImport("user32.dll", SetLastError=true)]
		internal static extern int GetRawInputDeviceInfo(IntPtr hDevice, RawInputDeviceInfo_Command uiCommand, IntPtr pData, ref int pcbSize);

		[DllImport("user32.dll", SetLastError=true)]
		internal static extern int GetRawInputDeviceInfo(IntPtr hDevice, RawInputDeviceInfo_Command uiCommand_preparsedData, [In, Out] byte[] PreparsedData, [In, Out] ref int pcbSize);
	    
		[DllImport("user32.dll", SetLastError=true, CharSet = CharSet.Auto)]
		internal static extern unsafe int GetRawInputDeviceInfo(IntPtr hDevice, RawInputDeviceInfo_Command uiCommand_preparsedData, [In,Out] IntPtr PreparsedData, [In,Out] ref uint pcbSize);
	    
        [DllImport("hid.dll", SetLastError=true)]
		internal static extern HIDResults HidP_GetCaps(byte[] preparsedDataPointer, ref HIDP_CAPS Capabilities);
		
		[DllImport("hid.dll", SetLastError=true)]
		internal static extern HIDResults HidP_GetValueCaps([In] HIDP_REPORT_TYPE ReportType, [Out] HIDP_VALUE_CAPS[] ValueCaps, [In, Out] ref ushort ValueCapsLength, [In] byte[] preparsed_data);
		
		[DllImport("hid.dll", SetLastError=true)]
		internal static extern HIDResults HidP_GetButtonCaps([In] HIDP_REPORT_TYPE ReportType, [Out] HIDP_BUTTON_CAPS[] ButtonCaps,[In, Out] ref ushort ButtonCapsLength, [In] byte[] preparsed_data);
		
		[DllImport("hid.dll", SetLastError=true)]
		internal static extern HIDResults HidP_GetUsageValue([In] HIDP_REPORT_TYPE ReportType, [In] HIDUsagePage UsagePage, [In] ushort LinkCollection, [In] HIDUsage Usage, ref long UsageValue,  [In] byte[] preparsed_data, [In] IntPtr Report, [In] int ReportLength);
		
		[DllImport("hid.dll", SetLastError=true)]
		internal static unsafe extern HIDResults HidP_GetUsages([In] HIDP_REPORT_TYPE ReportType,[In] HIDUsagePage UsagePage, [In] ushort LinkCollection, [Out] short* UsageList,
		                                                 [In,Out] ref int UsageLength, [In] byte[] preparsed_data, [Out] IntPtr Report, [In] int ReportLength);
		 [DllImport("hid.dll", SetLastError=true)]
		static extern Boolean HidD_FreePreparsedData(IntPtr PreparsedData);

		[DllImport("hid.dll", CharSet = CharSet.Auto, SetLastError = true)]
		internal static extern bool HidD_GetPhysicalDescriptor([In] IntPtr HidDeviceObject, [Out] IntPtr Buffer, [In] uint BufferLength);

		[DllImport("hid.dll", CharSet = CharSet.Auto, SetLastError = true)]
		internal static extern bool HidD_GetProductString([In] IntPtr HidDeviceObject, [Out] IntPtr Buffer, [In] int BufferLength);
    }
}