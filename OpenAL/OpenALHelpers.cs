using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace dgtk.OpenAL
{
    public static partial class ALC
    {
        public static string alcGetStringh(IntPtr device, ALC_GetStringParam param)
		{
			IntPtr ptr = alcGetString(device, param);			
			if (ptr != IntPtr.Zero)
			{
				return Marshal.PtrToStringAnsi(ptr);
			}
			return null;
        }

		public static unsafe List<string> alcGetStringList(IntPtr device, ALC_GetStringParam param)
		{
			List<string> retList = new List<string>();
			bool b_end = false;
			int position = 0;
			IntPtr string_ptr = alcGetString(device, param);
			if (string_ptr != IntPtr.Zero)
			{
				sbyte* charti = (sbyte*)((void*)string_ptr);
				while (!b_end)
				{
					sbyte* t_charti = (charti+position);
					String s_charti = new string(t_charti);
				
					position+=System.Text.Encoding.Default.GetByteCount(s_charti.ToCharArray());
					retList.Add(s_charti);
					if ((char)charti[position] == '\0')
					{
						position++;
						if ((char)charti[position] == '\0')
						{
							b_end = true;
						}						
					}
				}
			}
			return retList;
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

		public static uint alGenBuffer()
		{
			UInt32[] ret = new uint[1];
			alGenBuffers(1, out ret);
			return ret[0];
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

		#region Source

		public static unsafe uint[] alGenSources(Int32 n)
		{
			uint[] ret = new uint[n];
			fixed(uint* ptr = ret)
			{
				alGenSources(n, ptr);
			}
			return ret;
		}

        public static unsafe void alDeleteSources(uint[] sources )
		{
			fixed(uint* ptr = sources)
			{
				alDeleteSources(sources.Length, ptr);
			}
		}

        public static unsafe void alSourcefv( uint sid, AL_Source3Param param, float[] values )
		{
			fixed(float* ptr = values)
			{
				alSourcefv(sid, param, ptr);
			}
		}

        public static unsafe void alSourceiv( uint sid, AL_Source3Param param, int[] values )
		{
			fixed(int* ptr = values)
			{
				alSourceiv(sid, param, ptr);
			}
		}

		public static unsafe float alGetSourcef( uint sid, AL_SourcefParam param)
		{
			float[] value = new float[1];
			fixed(float* ptr = value)
			{
				alGetSourcef(sid, param, ptr);
			}
			return value[0];
		}
		

        public static unsafe float[] alGetSource3f( uint sid, AL_Source3Param param)
		{
			float* fx = stackalloc float[1];
			float* fy = stackalloc float[1];
			float* fz = stackalloc float[1];	
			alGetSource3f(sid, param, fx, fy, fz);
			//}
			return new float[]{fx[0], fy[0], fz[0]};
		}

        public static unsafe float[] alGetSourcefv( uint sid, AL_Source3Param param)
		{
			float[] values = new float[3];
			fixed(float* ptr = values)
			{
				alGetSourcefv(sid, param, ptr);
			}
			return values;
		}

        public static unsafe int alGetSourcei( uint sid,  AL_GetSourceiParam param)
		{
			int[] ret = new int[1];
			fixed(int* ptr = ret)
			{
				alGetSourcei(sid, param, ptr);
			}
			return ret[0];
		}

        public static unsafe int[] alGetSource3i( uint sid, AL_Source3Param param)
		{			
			int* ix = stackalloc int[1];
			int* iy = stackalloc int[1];
			int* iz = stackalloc int[1];
			alGetSource3i(sid, param, ix, iy, iz);
			return new int[]{ix[0], iy[0], iz[0]};
		}

        public static unsafe int[] alGetSourceiv( uint sid,  AL_Source3Param param)
		{
			int[] values= new int[3];
			fixed (int* ptr = values)
			{
				alGetSourceiv(sid, param, ptr);
			}
			return values;
		}

		public static unsafe void alSourcePlayv(uint[] sids )
		{
			fixed(uint* ptr = sids)
			{
				alSourcePlayv(sids.Length, ptr);
			}
		}

        public static unsafe void alSourceStopv(uint[] sids )
		{
			fixed(uint* ptr = sids)
			{
				alSourceStopv(sids.Length, ptr);
			}
		}

        public static unsafe void alSourceRewindv(uint[] sids )
		{
			fixed(uint* ptr = sids)
			{
				alSourceRewindv(sids.Length, ptr);
			}
		}

        public static unsafe void alSourcePausev(uint[] sids )
		{
			fixed(uint* ptr = sids)
			{
				alSourcePausev(sids.Length, ptr);
			}
		}

        public static unsafe void alSourceQueueBuffers( uint sid, uint[] bids )
		{
			fixed(uint* ptr = bids)
			{
				alSourceQueueBuffers( sid, bids.Length, ptr);
			}
		}

        public static unsafe void alSourceUnqueueBuffers( uint sid, uint[] bids )
		{
			fixed(uint* ptr = bids)
			{
				alSourceUnqueueBuffers( sid, bids.Length, ptr);
			}
		}

        public static unsafe dgtk.Math.Vector3 alGetSource3fv(UInt32 idsource, AL_Source3Param param)
		{
			float* fx = stackalloc float[1];
			float* fy = stackalloc float[1];
			float* fz = stackalloc float[1];			
			alGetSource3f(idsource, param, fx, fy, fz);
			return new dgtk.Math.Vector3(fx[0], fy[0], fz[0]);
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

		#endregion


		#region Listener

        public static unsafe float alGetListenerf( AL_ListenerifParam param)
		{
			float[] ret = new float[1];
			fixed(float* ptr = ret)
			{
				alGetListenerf( param, ptr);
			}
			return ret[0];
		}

        public static unsafe float[] alGetListener3f( AL_Listener3vParam param)
		{
			float* fx = stackalloc float[1];
			float* fy = stackalloc float[1];
			float* fz = stackalloc float[1];
			alGetListener3f(param, fx, fy, fz);
			return new float[]{fx[0], fy[0], fz[0]};
		}

        public static unsafe float[] alGetListenerfv( AL_Listener3vParam param)
		{
			float[] ret;
			if(param == AL_Listener3vParam.AL_ORIENTATION)
			{
				ret = new float[6];
			}
			else
			{
				ret = new float[3];
			}
			fixed(float* ptr = ret)
			{
				alGetListenerfv(param, ptr);
			}
			return ret;
		}

        public static unsafe int alGetListeneri( AL_ListenerifParam param)
		{
			int* ret = stackalloc int[1];
			alGetListeneri(param, ret);
			return ret[0];
		}

        public static unsafe int[] alGetListener3i( AL_Listener3vParam param)
		{
			int* ix = stackalloc int[1];
			int* iy = stackalloc int[1];
			int* iz = stackalloc int[1];
			alGetListener3i(param, ix, iy, iz);
			return new int[]{ix[0], iy[0], iz[0]};
		}

        public static unsafe int[] alGetListeneriv( AL_Listener3vParam param)
		{
			int[] ret;
			if(param == AL_Listener3vParam.AL_ORIENTATION)
			{
				ret = new int[6];
			}
			else
			{
				ret = new int[3];
			}
			fixed(int* ptr = ret)
			{
				alGetListeneriv(param, ptr);
			}
			return ret;
		}

		#endregion


		#region Buffers

        public static unsafe uint[] alGenBuffers( int n)
		{
			uint[] ret = new uint[n];
			fixed(uint* ptr = ret)
			{
				alGenBuffers(n, ptr);
			}
			return ret;
		}

        public static unsafe void alDeleteBuffers(uint[] buffers )
		{
			fixed(uint* ptr = buffers)
			{
				alDeleteBuffers( buffers.Length, ptr );
			}
		}

        public static void alBufferData( uint bid, AL_FORMAT format, short[] data, int size, int freq )
		{
			IntPtr data_ptr = Marshal.AllocHGlobal(data.Length);
            Marshal.Copy(data, 0, data_ptr, data.Length);
			alBufferData( bid, format, data_ptr, size, freq );
			Marshal.FreeHGlobal(data_ptr);
		}

        public static void alBufferData( uint bid, AL_FORMAT format, int[] data, int size, int freq )
		{
			IntPtr data_ptr = Marshal.AllocHGlobal(data.Length);
            Marshal.Copy(data, 0, data_ptr, data.Length);
			alBufferData( bid, format, data_ptr, size, freq );
			Marshal.FreeHGlobal(data_ptr);
		}

        public static void alBufferData( uint bid, AL_FORMAT format, float[] data, int size, int freq )
		{
			IntPtr data_ptr = Marshal.AllocHGlobal(data.Length);
            Marshal.Copy(data, 0, data_ptr, data.Length);
			alBufferData( bid, format, data_ptr, size, freq );
			Marshal.FreeHGlobal(data_ptr);
		}

        public static void alBufferData( uint bid, AL_FORMAT format, double[] data, int size, int freq )
		{
			IntPtr data_ptr = Marshal.AllocHGlobal(data.Length);
            Marshal.Copy(data, 0, data_ptr, data.Length);
			alBufferData( bid, format, data_ptr, size, freq );
			Marshal.FreeHGlobal(data_ptr);
		}

        public static unsafe void alBufferfv( uint bid, AL_BufferParam param, float[] values )
		{
			fixed(float* ptr = values)
			{
				alBufferfv(bid, param, ptr);
			}
		}

        public static unsafe void alBufferiv( uint bid, AL_BufferParam param, int[] values )
		{
			fixed(int* ptr = values)
			{
				alBufferiv(bid, param, ptr);
			}
		}

		//public static unsafe float[] alGetBufferfv( uint bid, AL_BufferParam param, [Out] float* values )
		
		// public static unsafe extern void alGetBufferiv( uint bid, AL_BufferParam param, [Out] int* values );


		#endregion

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