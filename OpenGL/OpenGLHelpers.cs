using System;
using System.Runtime.InteropServices;

namespace dgtk.OpenGL
{
	public static partial class GL
    {
        #region B:

        public static void glBufferData<T>(BufferTargetARB target, int size, T[] data, BufferUsageARB usage) where T : struct
		{
			GCHandle ptr = GCHandle.Alloc(data, GCHandleType.Pinned);
			internalGL.glBufferData(target, size, (IntPtr)ptr.AddrOfPinnedObject(), usage);
			ptr.Free();
		}

        #endregion

        #region C:
        
        public static void glClearColor(dgtk.Graphics.Color4 color)
        {
            internalGL.glClearColor(color.R, color.G, color.B, color.A);
        }

        #endregion

        #region G:

        public static unsafe uint glGenBuffer()
        {
            uint[] ret = new uint[1];
            fixed (uint* retp = ret)
            {
                internalGL.glGenBuffers(1, retp);
            }		
            return ret[0];
        }

        public static unsafe uint[] glGenBuffers(int n)
        {
            uint[] ret = new uint[n];
            fixed (uint* retp = ret)
            {
                internalGL.glGenBuffers(n, retp);
            }		
            return ret;
        }

		public static unsafe uint glGenFramebuffer()
		{
            uint[] ret = new uint[1];
            fixed (uint* retp = ret)
            {
                internalGL.glGenFramebuffers(1, retp);
            }
            return ret[0];
		}

		public static unsafe uint[] glGenFramebuffers(int n)
		{
            uint[] ret = new uint[n];
            fixed (uint* retp = ret)
            {
                internalGL.glGenFramebuffers(n, retp);
            }
            return ret;
		}

		public static unsafe uint glGenRenderbuffer()
		{
            uint[] ret = new uint[1];
            fixed (uint* retp = ret)
            {
                internalGL.glGenRenderbuffers(1, retp);
            }
            return ret[0];
		}

		public static unsafe uint[] glGenRenderbuffers(int n)
		{
            uint[] ret = new uint[n];
            fixed (uint* retp = ret)
            {
                internalGL.glGenRenderbuffers(n, retp);
            }
            return ret;
		}

        public static unsafe uint glGenTexture()
        {
            uint[] ret = new uint[1];
            fixed (uint* retp = ret)
            {
                internalGL.glGenTextures(1, retp);
            }		
            return ret[0];
        }

        public static unsafe uint[] glGenTextures(int n)
        {
            uint[] ret = new uint[n];
            fixed (uint* retp = ret)
            {
                internalGL.glGenTextures(1, retp);
            }		
            return ret;
        }

        public static unsafe string glGetStringh(StringName name)
		{
			return Marshal.PtrToStringAnsi((IntPtr)internalGL.glGetString(name));
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static unsafe string glGetStringih(StringName name, uint index)
		{
			return Marshal.PtrToStringAnsi((IntPtr)internalGL.glGetStringi(name, index));
		}

        public static unsafe string glGetShaderInfoLog(uint shader)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(512);
            internalGL.glGetShaderInfoLog(shader, 512, null, sb);
            return sb.ToString();
        }

        public static unsafe int glGetShaderiv(uint shader, ShaderParameterName pname)
		{
            int[] ret = new int[1];
            fixed (int* retp = ret)
            {
                internalGL.glGetShaderiv(shader, pname, retp);
            }			
            return ret[0];
		}

        public static unsafe uint glGenVertexArray()
        {
            uint[] ret = new uint[1];
            fixed (uint* retp = ret)
            {
                internalGL.glGenVertexArrays(1, retp);
            }
            return ret[0];
        }

        public static unsafe int[] glGetUniformiv(uint program, int location, int lenght)
        {
            int[] fret = new int[lenght];
            fixed(int* ptr = &fret[0])
            {
                internalGL.glGetUniformiv(program, location, ptr);
            }
            return fret;
        }

        public static unsafe uint[] glGetUniformuiv(uint program, int location, int lenght)
        {
            uint[] fret = new uint[lenght];
            fixed(uint* ptr = &fret[0])
            {
                internalGL.glGetUniformuiv(program, location, ptr);
            }
            return fret;
        }

        public static unsafe float[] glGetUniformfv(uint program, int location, int lenght)
        {
            float[] fret = new float[lenght];
            fixed(float* ptr = &fret[0])
            {
                internalGL.glGetUniformfv(program, location, ptr);
            }
            return fret;
        }

        public static unsafe double[] glGetUniformdv(uint program, int location, int lenght)
        {
            double[] fret = new double[lenght];
            fixed(double* ptr = &fret[0])
            {
                internalGL.glGetUniformdv(program, location, ptr);
            }
            return fret;
        }

        public static unsafe int[] glGetViewport()
        {
            int[] iret = new int[4];
            fixed(int* ptr = &iret[0])
            {
                internalGL.glGetIntegerv(GetPName.GL_VIEWPORT, ptr);
            }
            return iret;
        }

        #endregion

        #region S:

        public static unsafe void glShaderSource(uint shader, string source)
		{
            fixed(int* ptr = new int[]{source.Length})
            {
			    internalGL.glShaderSource(shader, 1, new string[]{source}, ptr);
            }
		}

        public static unsafe void glShaderSource(uint shader, string[] sources)
		{
            int[] ptr_lenght = new int[sources.Length];
            for (int i=0;i<sources.Length;i++)
            {
                ptr_lenght[i] = sources[i].Length;
            }
            fixed(int* ptr = ptr_lenght)
            {
			    internalGL.glShaderSource(shader, sources.Length, sources, ptr);
            }
		}

        #endregion

        #region U:

        public static unsafe void glUniform1iv(int location, int count, int[] value)
        {
            fixed (int* ptr = &value[0])
            {
                internalGL.glUniform1iv(location, count, ptr);
            }
        }

        public static unsafe void glUniform1uiv(int location, int count, uint[] value)
        {
            fixed (uint* ptr = &value[0])
            {
                internalGL.glUniform1uiv(location, count, ptr);
            }
        }

        public static unsafe void glUniform1fv(int location, int count, float[] value)
        {
            fixed (float* ptr = &value[0])
            {
                internalGL.glUniform1fv(location, count, ptr);
            }
        }

        public static unsafe void glUniform2iv(int location, int count, int[] value)
        {
            fixed (int* ptr = &value[0])
            {
                internalGL.glUniform2iv(location, count, ptr);
            }
        }

        public static unsafe void glUniform2uiv(int location, int count, uint[] value)
        {
            fixed (uint* ptr = &value[0])
            {
                internalGL.glUniform2uiv(location, count, ptr);
            }
        }

        public static unsafe void glUniform2fv(int location, int count, float[] value)
        {
            fixed (float* ptr = &value[0])
            {
                internalGL.glUniform2fv(location, count, ptr);
            }
        }

        public static unsafe void glUniform3iv(int location, int count, int[] value)
        {
            fixed (int* ptr = &value[0])
            {
                internalGL.glUniform3iv(location, count, ptr);
            }
        }

        public static unsafe void glUniform3uiv(int location, int count, uint[] value)
        {
            fixed (uint* ptr = &value[0])
            {
                internalGL.glUniform3uiv(location, count, ptr);
            }
        }

        public static unsafe void glUniform3f(int location, dgtk.Math.Vector3 value)
        {
            internalGL.glUniform3f(location, value.X, value.Y, value.Z);
        }

        public static unsafe void glUniform3fv(int location, int count, float[] value)
        {
            fixed (float* ptr = &value[0])
            {
                internalGL.glUniform3fv(location, count, ptr);
            }
        }

        public static unsafe void glUniform4iv(int location, int count, int[] value)
        {
            fixed (int* ptr = &value[0])
            {
                internalGL.glUniform4iv(location, count, ptr);
            }
        }

        public static unsafe void glUniform4uiv(int location, int count, uint[] value)
        {
            fixed (uint* ptr = &value[0])
            {
                internalGL.glUniform4uiv(location, count, ptr);
            }
        }

        public static unsafe void glUniform4f(int location, float[] value)
        {
            internalGL.glUniform4f(location, value[0], value[1], value[2], value[3]);
        }

        public static unsafe void glUniform4f(int location, dgtk.Math.Vector4 value)
        {
            internalGL.glUniform4f(location, value.X, value.Y, value.Z, value.W);
        }

        public static unsafe void glUniform4f(int location, dgtk.Graphics.Color4 value)
        {
            internalGL.glUniform4f(location, value.R, value.G, value.B, value.A);
        }

        public static unsafe void glUniform4fv(int location, int count, float[] value)
        {
            fixed (float* ptr = &value[0])
            {
                internalGL.glUniform4fv(location, count, ptr);
            }
        }

        public static unsafe void glUniformMatrix(int location, Boolean transpose, dgtk.Math.Mat2 mat)
        {
            fixed(float* ptr = &mat.ToFloat()[0])
            {
                internalGL.glUniformMatrix2fv(location, 1, transpose, ptr);
            }            
        }

        public static unsafe void glUniformMatrix(int location, Boolean transpose, dgtk.Math.Mat3 mat)
        {
            fixed(float* ptr = &mat.ToFloat()[0])
            {
                internalGL.glUniformMatrix3fv(location, 1, transpose, ptr);
            }            
        }

        public static unsafe void glUniformMatrix(int location, Boolean transpose, dgtk.Math.Mat4 mat)
        {
            fixed(float* ptr = &mat.ToFloat()[0])
            {
                internalGL.glUniformMatrix4fv(location, 1, transpose, ptr);
            }            
        }

        #endregion
    }
}