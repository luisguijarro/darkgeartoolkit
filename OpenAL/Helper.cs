using System;
using System.Security;
using System.Runtime.InteropServices;

namespace dgtk.OpenAL
{
    public static partial class ALC
    {
        public static String alcGetStringh(IntPtr device, ALC_GetStringParam param)
		{
			IntPtr ptr = alcGetString(device, param);			
			if (ptr != IntPtr.Zero)
			{
				return Marshal.PtrToStringAnsi(ptr);
			}
			return null;
        }
    }

    public static partial class AL
    {
        public static unsafe void alGenBuffers(Int32 n, out UInt32[] buffers)
		{
			UInt32* p_buffers = stackalloc UInt32[n];
            alGenBuffers(n, p_buffers);
            buffers = new UInt32[n];
            for (int i=0;i<n;i++)
            {
            	buffers[i] = p_buffers[i];
            }
		}
		
		public static void alGenBuffer(out UInt32 buffer)
		{
			UInt32[] ret = new uint[1];
			alGenBuffers(1, out ret);
			buffer = ret[0];
		}

        public static unsafe void alDeleteBuffer(UInt32 buffer)
		{
			UInt32[] arraybuffer = new uint[]{buffer};
			fixed(uint* ptr = arraybuffer)
			{
				alDeleteBuffers(1, ptr);
			}
		}

        public static void alBufferData(UInt32 idbuffer, AL_FORMAT format, byte[] data, Int32 size, Int32 freq)
		{
			GCHandle ptr = GCHandle.Alloc(data, GCHandleType.Pinned);
			alBufferData(idbuffer, format, ptr.AddrOfPinnedObject(), size, freq);
			ptr.Free();
		}

        public static unsafe void alGenSources(Int32 n, out UInt32[] idsources)
		{
			UInt32* p_ret = stackalloc UInt32[n];
			alGenSources(n, p_ret);
			idsources = new UInt32[n];
			for (int i=0;i<n;i++)
			{
				idsources[i] = p_ret[i];
			}
		}
		
		public static unsafe void alGenSource(out UInt32 idsource)
		{
			UInt32* p_ret = stackalloc UInt32[1];
			//UInt32[] ret;// = new UInt32[1];
			alGenSources(1, p_ret);
			idsource = p_ret[0];
		}

        public static unsafe void alDeleteSource(ref UInt32 idsource)
		{
			UInt32[] del = new UInt32[]{idsource};
			fixed(uint* ptr = del)
			{
				alDeleteSources(1, ptr);
			}
		}

        public static void alSourceb(UInt32 idsource, AL_SourcebParam param, Boolean value)
		{
			alSourcei(idsource, (AL_SourceiParam)param, value ? 1 : 0);
		}

        public static unsafe dgtk.Math.Vector3 alGetSource3fv(UInt32 idsource, AL_Source3Param param)
		{
			float* fx = stackalloc float[1];
			float* fy = stackalloc float[1];
			float* fz = stackalloc float[1];			
			alGetSource3f(idsource, param, fx, fy, fz);
			return new dgtk.Math.Vector3(fx[0], fy[0], fz[0]);
		}

        public static unsafe int alGetSourcei(UInt32 idsource, AL_GetSourceiParam pname)
		{
			int* p_ret = stackalloc int[1];
			//UInt32[] ret;// = new UInt32[1];
			alGetSourcei(idsource, pname, p_ret);
			return p_ret[0];
		}
						
		public static unsafe AL_SourceState alGetSourceState(UInt32 idsource)
		{
			int* ret = stackalloc int [1];
			alGetSourcei(idsource, AL_GetSourceiParam.AL_SOURCE_STATE, ret);
			return (AL_SourceState)ret[0];
		}
		
		public static unsafe Boolean alGetSourceb(UInt32 idsource, AL_SourcebParam param)
		{
			int* ret = stackalloc int[1];
			alGetSourcei(idsource, (AL_GetSourceiParam)param, ret);			
			return ret[0]==1;
		}

        public static String alGetStringh(AL_GetStringParam param)
		{
			IntPtr ptr = alGetString(param);
			string ret = "";
			if (ptr != IntPtr.Zero)
			{
				ret = Marshal.PtrToStringAnsi(ptr);
			}
			return ret;
		}

        public static string alGetErrorString(AL_ERROR param)
        {
            return alGetStringh((AL_GetStringParam)param);
        }
    }
}