using System;
using System.Collections.Generic;

namespace dgtk.OpenAL
{
    public class OAL_Context : IDisposable
    {
        private IntPtr ptr_OpenALContext;
        private IntPtr ptr_OutPutDevice;
		private IntPtr ptr_InPutdevice;
		private string s_actualOutPutDevice;
		private string s_actualInPutDevice;
		private int[] pb_context_attributes;
		private static string defaultOutPutDevice;
		private static string defaultInPutDevice;
		private static List<string> l_OutPutDevices;
		private static List<string> l_InPutDevices;

        public OAL_Context()
        {
            RefreshDevices(); // Obtenemos los dispositivos de audio del sistema.
			this.pb_context_attributes = (int[])null; // No definimos atributos especiales en el contexto.
			this.s_actualOutPutDevice = defaultOutPutDevice; // Establecemos el dispositivo por defecto como el actual.
			this.s_actualInPutDevice = defaultInPutDevice; // Establecemos el dispositivo por defecto como el actual.

			this.UpdateContextDevices();
        }

		private void UpdateContextDevices()
		{
			/*try
			{*/
				this.ptr_OutPutDevice = ALInternalTool.alcOpenDevice(this.s_actualOutPutDevice); // Establecemos el dispositivo de salida elegido
				
				#if DEBUG
				if (this.ptr_OutPutDevice == IntPtr.Zero)
				{
					throw new Exception("alcOpenDevice Fail tu Open Device: "+this.s_actualOutPutDevice);
				}
				#endif
				
				Init_AL_Delegates.InitAlcDelegates(ptr_OutPutDevice);
				Init_AL_Delegates.InitAlDelegates();
				Init_AL_Delegates.InitEFXDelegates();

				this.ptr_OpenALContext = ALC.alcCreateContext(this.ptr_OutPutDevice, this.pb_context_attributes); // Creamos el contexto de salida.
				
				#if DEBUG
				if (this.ptr_OpenALContext == IntPtr.Zero)
				{
					throw new Exception("alcCreateContext Fail tu Create Context to Device: "+this.s_actualOutPutDevice);
				}
				#endif
				
	 			this.ptr_InPutdevice = ALC.alcCaptureOpenDevice(this.s_actualInPutDevice, 22050/*Hz*/, ALC_BufferFormat.AL_FORMAT_MONO16, 4410); // Establecemos el dispositivo de entrada elegido
				
				#if DEBUG
				if (this.ptr_InPutdevice == IntPtr.Zero)
				{
					Console.WriteLine("alcCaptureOpenDevice Fail tu Open Record Device: "+this.s_actualInPutDevice);
				}
				#endif
				
				//this.Recordcontext = ALCMethods.
				ALC.alcMakeContextCurrent(this.ptr_OpenALContext);
			/*}
			catch (Exception exc)
			{
				#if DEBUG
				Console.WriteLine("AL ERROR: "+ALC.alcGetError(this.ptr_OutPutDevice));
				Console.WriteLine("Exception: "+exc.Message);
				#endif
			}*/
		}

        private static void RefreshDevices()
        {
            if (l_OutPutDevices == null)
            {
                l_OutPutDevices = new List<string>();
                l_InPutDevices = new List<string>();
            }

            IntPtr device_temp = ALInternalTool.alcOpenDevice(null);

			Init_AL_Delegates.InitAlcDelegates(device_temp);

			IntPtr context_temp = ALC.alcCreateContext(device_temp, (int[])null);
			
			if (!ALC.alcMakeContextCurrent(context_temp))
			{
				#if DEBUG
				ALC_ERROR error = ALC.alcGetError(device_temp);
				throw new Exception("Fail to Generate Temp Context "+ context_temp.ToString() + " or Device " + device_temp.ToString() + ": "+error.ToString());
				#endif
			}
			
			if (ALC.alcIsExtensionPresent(IntPtr.Zero, "ALC_ENUMERATION_EXT"))
			{
				if (ALC.alcIsExtensionPresent(IntPtr.Zero, "ALC_ENUMERATE_ALL_EXT"))
                {
					l_OutPutDevices = ALC.alcGetStringList(IntPtr.Zero, ALC_GetStringParam.ALC_ALL_DEVICES_SPECIFIER);
					defaultOutPutDevice = ALC.alcGetStringh(IntPtr.Zero, ALC_GetStringParam.ALC_DEFAULT_ALL_DEVICES_SPECIFIER);				
				}
				else
				{
					l_OutPutDevices = ALC.alcGetStringList(IntPtr.Zero, ALC_GetStringParam.ALC_DEVICE_SPECIFIER);
					defaultOutPutDevice = ALC.alcGetStringh(IntPtr.Zero, ALC_GetStringParam.ALC_DEFAULT_DEVICE_SPECIFIER);				
				}

				#if DEBUG
				Console.WriteLine("PlayBackDevices: ");
				for (int i=0;i<l_OutPutDevices.Count;i++)
				{
					if (defaultOutPutDevice == l_OutPutDevices[i])
					{
						Console.WriteLine("    - (Default) "+l_OutPutDevices[i]);
					}
					else
					{
						Console.WriteLine("    - "+l_OutPutDevices[i]);
					}
				}
				#endif				
			}
			
			if (ALC.alcIsExtensionPresent(IntPtr.Zero, "ALC_EXT_CAPTURE"))
			{
				l_InPutDevices = ALC.alcGetStringList(IntPtr.Zero, ALC_GetStringParam.ALC_CAPTURE_DEVICE_SPECIFIER);
				//ALCMethods.alcGetStringListUNI(IntPtr.Zero, ALC_GetStringParam.ALC_CAPTURE_DEVICE_SPECIFIER);
				defaultInPutDevice = ALC.alcGetStringh(IntPtr.Zero, ALC_GetStringParam.ALC_CAPTURE_DEFAULT_DEVICE_SPECIFIER);
				#if DEBUG
				Console.WriteLine("RecordingDevices: ");
				for (int i=0;i<l_InPutDevices.Count;i++)
				{
					if (defaultInPutDevice == l_InPutDevices[i])
					{
						Console.WriteLine("    - (Default) "+l_InPutDevices[i]);
					}
					else
					{
						Console.WriteLine("    - "+l_InPutDevices[i]);
					}
				}
				#endif		
			}
			ALC.alcDestroyContext(context_temp);
			ALC.alcCloseDevice(device_temp);	
        }

		private void DestroyContext()
		{
			ALC.alcDestroyContext(this.ptr_OpenALContext);
			ALC.alcCloseDevice(this.ptr_OutPutDevice);
			ALC.alcCaptureCloseDevice(this.ptr_InPutdevice);
		}

		public bool MakeCurrent()
		{
			return ALC.alcMakeContextCurrent(this.ptr_OpenALContext);
		}

		public string ActualOutPutDevice
		{
			set
			{
				if (l_OutPutDevices.Contains(value))
				{
					this.s_actualOutPutDevice = value;
					UpdateContextDevices();
				}
			}
			get
			{
				return this.s_actualOutPutDevice;
			}
		}

		public string ActualInPutDevice
		{
			set
			{
				if (l_InPutDevices.Contains(value))
				{
					this.s_actualInPutDevice = value;
					UpdateContextDevices();
				}
			}
			get
			{
				return this.s_actualInPutDevice;
			}
		}

        public static List<string> PlayBackDevices 
        { 
            get
            {
                RefreshDevices();
                return l_OutPutDevices;
            }
        }

        public static List<string> RecordingDevices 
        { 
            get
            {
                RefreshDevices();
                return l_InPutDevices;
            }
        }
		
		public static string DefaultPlayBackDevice
		{
			get { return defaultOutPutDevice;}
		}
		
		public static string DefaultRecordingDevice
		{
			get { return defaultInPutDevice;}
		}
        
        public void Dispose()
		{
            this.DestroyContext();
        }
    }

}