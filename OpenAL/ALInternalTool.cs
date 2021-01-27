using System;
using System.Runtime.InteropServices;

namespace dgtk.OpenAL
{
    internal static class ALInternalTool
    {
        private static OperatingSystem OS;
        internal static Delegate AlcGetMethodAddress(IntPtr device, String MethodName, Type type_origen)
        {
            if (OS == OperatingSystem.None) { OS = GetOS(); } // Prevenir
            IntPtr ptr_ret = IntPtr.Zero;
            switch(OS)
            {
                case OperatingSystem.Windows:
                    ptr_ret = Win_alcGetProcAddress(device, MethodName);
                    break;
                case OperatingSystem.Linux:
                    ptr_ret = Lnx_alcGetProcAddress(device, MethodName);
                    break;
                case OperatingSystem.MacOS:
                    throw new Exception("MacOS Support not Implmented.");
                default:
                    throw new Exception("Platform not supported.");
            }

            if (ptr_ret != IntPtr.Zero)
			{
				try
				{
					return Marshal.GetDelegateForFunctionPointer(ptr_ret, type_origen);
				}
				catch
				{
					#if DEBUG
					Console.WriteLine(type_origen.ToString());
					#endif
					return null;
				}
			}
			else
			{
				return null;
			}
        }

        internal static Delegate AlGetMethodAddress(String MethodName, Type type_origen)
        {
            if (OS == OperatingSystem.None) { OS = GetOS(); } // Prevenir
            IntPtr ptr_ret = IntPtr.Zero;
            switch(OS)
            {
                case OperatingSystem.Windows:
                    ptr_ret = Win_alGetProcAddress(MethodName);
                    break;
                case OperatingSystem.Linux:
                    ptr_ret = Lnx_alGetProcAddress(MethodName);
                    break;
                case OperatingSystem.MacOS:
                    throw new Exception("MacOS Support not Implmented.");
                    //ptr_ret = Mac_alGetProcAddress(MethodName);
                default:
                    throw new Exception("Platform not supported.");
            }
            

            if (ptr_ret != IntPtr.Zero)
			{
				try
				{
					return Marshal.GetDelegateForFunctionPointer(ptr_ret, type_origen);
				}
				catch
				{
					#if DEBUG
					Console.WriteLine(type_origen.ToString());
					#endif
					return null;
				}
			}
			else
			{
				return null;
			}
        }

        internal static OperatingSystem GetOS()
		{
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                return OperatingSystem.Linux;
            } 
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                return OperatingSystem.MacOS;
            } 
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return OperatingSystem.Windows;
            }
            else
            {
                return OperatingSystem.NotSuported;
            }
        }

        public static IntPtr alcOpenDevice(string device)
        {
            if (OS == OperatingSystem.None) { OS = GetOS(); } // Prevenir
            switch(OS)
            {
                case OperatingSystem.Windows:
                    return Win_alcOpenDevice(device);
                case OperatingSystem.Linux:
                    return Lnx_alcOpenDevice(device);
                case OperatingSystem.MacOS:
                    throw new Exception("MacOS Support not Implmented.");
                    //return Mac_alcOpenDevice(MethodName);
                default:
                    throw new Exception("Platform not supported.");
            }
        }

		internal enum OperatingSystem
		{
			None = 0, Windows, Linux, MacOS, NotSuported
		}

		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alcGetProcAddress", ExactSpelling = true)]
        public static extern IntPtr Win_alcGetProcAddress( IntPtr device, string funcname );

		[DllImport("libopenal.so.1", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alcGetProcAddress", ExactSpelling = true)]
        public static extern IntPtr Lnx_alcGetProcAddress( IntPtr device, string funcname );

		[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alcGetProcAddress", ExactSpelling = true)]
        public static extern IntPtr Mac_alcGetProcAddress( IntPtr device, string funcname );



		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alGetProcAddress", ExactSpelling = true)]
        public static extern IntPtr Win_alGetProcAddress( string funcname );

		[DllImport("libopenal.so.1", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alGetProcAddress", ExactSpelling = true)]
        public static extern IntPtr Lnx_alGetProcAddress( string funcname );

		[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alGetProcAddress", ExactSpelling = true)]
        public static extern IntPtr Mac_alGetProcAddress( string funcname );



		[DllImport("openal32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alcOpenDevice", ExactSpelling = true)]
        public static extern IntPtr Win_alcOpenDevice( string device );

		[DllImport("libopenal.so.1", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alcOpenDevice", ExactSpelling = true)]
        public static extern IntPtr Lnx_alcOpenDevice( string device );

		[DllImport("/System/Library/Frameworks/OpenAL.framework/OpenAL", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "alcOpenDevice", ExactSpelling = true)]
        public static extern IntPtr Mac_alcOpenDevice( string device );
    }
}