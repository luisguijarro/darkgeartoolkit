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


        public static void alBufferData( uint idbuffer, AL_FORMAT format, short[] data, int size, int freq )
		{
			GCHandle ptr = GCHandle.Alloc(data, GCHandleType.Pinned);
			alBufferData(idbuffer, format, ptr.AddrOfPinnedObject(), size, freq);
			ptr.Free();
		}

        public static void alBufferData( uint idbuffer, AL_FORMAT format, int[] data, int size, int freq )
		{
			GCHandle ptr = GCHandle.Alloc(data, GCHandleType.Pinned);
			alBufferData(idbuffer, format, ptr.AddrOfPinnedObject(), size, freq);
			ptr.Free();
		}

        public static void alBufferData( uint idbuffer, AL_FORMAT format, float[] data, int size, int freq )
		{
			GCHandle ptr = GCHandle.Alloc(data, GCHandleType.Pinned);
			alBufferData(idbuffer, format, ptr.AddrOfPinnedObject(), size, freq);
			ptr.Free();
		}

        public static void alBufferData( uint idbuffer, AL_FORMAT format, double[] data, int size, int freq )
		{
			GCHandle ptr = GCHandle.Alloc(data, GCHandleType.Pinned);
			alBufferData(idbuffer, format, ptr.AddrOfPinnedObject(), size, freq);
			ptr.Free();
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

		public static unsafe uint alGenSource()
		{
			UInt32* p_ret = stackalloc UInt32[1];
			alGenSources(1, p_ret);
			return p_ret[0];
		}

        public static unsafe uint[] alGenSources(Int32 n)
		{
			UInt32[] ret = new UInt32[n];
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
			float* value = stackalloc float[1];
			alGetSourcef(sid, param, value);
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

		public static unsafe uint alGenBuffer()
		{
			uint* ret = stackalloc uint[1];
			alGenBuffers(1, ret);
			return ret[0];
		}

        public static unsafe uint[] alGenBuffers(int n)
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

	public static partial class EFX
	{
		public static unsafe uint alGenEffect()
		{
			uint[] ret = new uint[1];
            fixed (uint* retp = ret)
            {
                alGenEffects( 1, retp );
			}
			return ret[0];
		}

		public static unsafe uint[] alGenEffects(int n)
		{
			uint[] ret = new uint[n];
            fixed (uint* retp = ret)
            {
                alGenEffects( n, retp );
			}
			return ret;
		}

        public static unsafe void alDeleteEffect(uint effect )
		{
			fixed (uint* ptr = new uint[]{effect})
			{
				alDeleteEffects(1, ptr);
			}
		}

        public static unsafe void alDeleteEffects(uint[] effects )
		{
			fixed (uint* ptr = effects)
			{
				alDeleteEffects(effects.Length, ptr);
			}
		}

		public static unsafe void alEffectiv( uint eid, AL_EffectParam param, int[] values )
		{
			fixed(int* ptr = values)
			{
				alEffectiv( eid, param, ptr); 
			}
		}

		public static unsafe void alEffectfv( uint eid, AL_EffectParam param, float[] values )
		{
			fixed(float* ptr = values)
			{
				alEffectfv( eid, param, ptr); 
			}
		}

		public static unsafe int alGetEffecti( uint eid, AL_EffectParam pname)
		{
			int* ptr = stackalloc int[1];
			alGetEffecti( eid, pname, ptr);
			return ptr[0];
		}

		public static unsafe int[] alGetEffrctiv( uint eid, AL_EffectParam pname)
		{
			int[] ret = new int[3];
			fixed (int* ptr = ret)
			{
				alGetEffecti( eid, pname, ptr);
			}
			return ret;
		}

		public static unsafe float alGetEffectf( uint eid, AL_EffectParam pname)
		{
			float* ptr = stackalloc float[1];
			alGetEffectf( eid, pname, ptr);
			return ptr[0];
		}

		public static unsafe float[] alGetEffectfv( uint eid, AL_EffectParam pname)
		{
			float[] ret = new float[3];
			fixed (float* ptr = ret)
			{
				alGetEffectfv( eid, pname, ptr);
			}
			return ret;
		}

		public static unsafe uint alGenFilter()
		{
			uint[] ret = new uint[1];
            fixed (uint* retp = ret)
            {
                alGenFilters(1, retp);
			}
			return ret[0];
		}

		public static unsafe uint[] alGenFilters( int n)
		{
			uint[] ret = new uint[n];
            fixed (uint* retp = ret)
            {
                alGenFilters(n, retp);
			}
			return ret;
		}

		public static unsafe void alDeleteFilter( uint filter )
		{
			fixed (uint* ptr = new uint[]{filter})
			{
				alDeleteEffects(1, ptr);
			}
		}

		public static unsafe void alDeleteFilters( int n, uint[] filters )
		{
			fixed (uint* ptr = filters)
			{
				alDeleteEffects(filters.Length, ptr);
			}
		}

		public static unsafe void alFilteriv( uint fid, AL_FilterParam param, int[] values )
		{
			fixed (int* ptr = values)
			{
				alFilteriv(fid, param, ptr);
			}
		}

		public static unsafe void alFilterfv( uint fid, AL_FilterPassParam param, float[] values )
		{
			fixed (float* ptr = values)
			{
				alFilterfv(fid, param, ptr);
			}
		}

		public static unsafe int alGetFilteri( uint fid, AL_FilterParam pname)
		{
			int* ret = stackalloc int[1];
			alGetFilteri( fid, pname, ret );
			return ret[0];
		}

        public static unsafe int[] alGetFilteriv( uint fid, AL_FilterParam pname)
		{
			int[] ret = new int[3];
			fixed (int* ptr = ret)
			{
				alGetFilteriv( fid, pname, ptr );
			}
			return ret;
		}

        public static unsafe float alGetFilterf( uint fid, AL_FilterPassParam pname)
		{
			float* ret = stackalloc float[1];
			alGetFilterf( fid, pname, ret );
			return ret[0];
		}

        public static unsafe float[] alGetFilterfv( uint fid, AL_FilterPassParam pname)
		{
			float[] ret = new float[3];
			fixed (float* ptr = ret)
			{
				alGetFilterfv( fid, pname, ptr );
			}
			return ret;
		}

		public static unsafe uint alGenAuxiliaryEffectSlot()
		{
			uint* ret = stackalloc uint[1];
			alGenAuxiliaryEffectSlots( 1, ret );			
			return ret[0];
		}

		public static unsafe uint[] alGenAuxiliaryEffectSlots( int n )
		{
			uint[] ret = new uint[n];
			fixed(uint* ptr = ret)
			{
				alGenAuxiliaryEffectSlots( n, ptr );
			}
			return ret;
		}

        public static unsafe void alDeleteAuxiliaryEffectSlot(uint slot )
		{
			fixed(uint* ptr = new uint[]{slot})
			{
				alDdeleteAuxiliaryEffectSlots( 1, ptr );
			}
		}

        public static unsafe void alDdeleteAuxiliaryEffectSlots(uint[] slots )
		{
			fixed(uint* ptr = slots)
			{
				alDdeleteAuxiliaryEffectSlots( slots.Length, ptr );
			}
		}

		public static unsafe void alAuxiliaryEffectSlotiv( uint asid, AL_AuxiliaryEffectSlot param, int[] values )
		{
			fixed(int* ptr = values)
			{
				alAuxiliaryEffectSlotiv( asid, param, ptr ); 
			}
		}

		public static unsafe void alAuxiliaryEffectSlotfv( uint asid, AL_AuxiliaryEffectSlot param, float[] values )
		{
			fixed(float* ptr = values)
			{
				alAuxiliaryEffectSlotfv( asid, param, ptr ); 
			}
		}

        public static unsafe int alGetAuxiliaryEffectSloti( uint asid, AL_AuxiliaryEffectSlot pname)
		{
			int* ret = stackalloc int[1];
			alGetAuxiliaryEffectSloti(asid, pname, ret);
			return ret[0];
		}

        public static unsafe int[] alGetAuxiliaryEffectSlotiv( uint asid, AL_AuxiliaryEffectSlot pname)
		{
			int[] ret = new int[3];
			fixed(int* ptr = ret)
			{
				alGetAuxiliaryEffectSlotiv( asid, pname, ptr);
			}
			return ret;
		}

        public static unsafe float alGetAuxiliaryEffectSlotf( uint asid, AL_AuxiliaryEffectSlot pname)
		{
			float* ret = stackalloc float[1];
			alGetAuxiliaryEffectSlotf( asid, pname, ret );
			return ret[0];
		}

        public static unsafe float[] alGetAuxiliaryEffectSlotfv( uint asid, AL_AuxiliaryEffectSlot pname)
		{
			float[] ret = new float[3];
			fixed(float* ptr = ret)
			{
				alGetAuxiliaryEffectSlotf( asid, pname, ptr );
			}
			return ret;
		}
	}
}