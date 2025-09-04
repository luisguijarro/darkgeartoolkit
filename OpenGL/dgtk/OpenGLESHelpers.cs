using System;
using System.Runtime.InteropServices;

namespace dgtk.OpenGL
{
	public static partial class GLES
    {
        #region B:

        public static void glBufferData<T>(BufferTargetARB target, int size, T[] data, BufferUsageARB usage) where T : struct
		{
			GCHandle ptr = GCHandle.Alloc(data, GCHandleType.Pinned);
			internalGLES.glBufferData(target, size, (IntPtr)ptr.AddrOfPinnedObject(), usage);
			ptr.Free();
		}

        #endregion

        #region C:
        
        public static void glClearColor(dgtk.Graphics.Color4 color)
        {
            internalGLES.glClearColor(color.R, color.G, color.B, color.A);
        }

        #endregion

        #region D:

		public static unsafe void glDeleteFramebuffer(uint FB)
		{
            uint* ptrFB = &FB;
            internalGLES.glDeleteFramebuffers(1, ptrFB);
		}


        #endregion

        #region G:

        public static unsafe uint glGenBuffer()
        {
            uint[] ret = new uint[1];
            fixed (uint* retp = ret)
            {
                internalGLES.glGenBuffers(1, retp);
            }		
            return ret[0];
        }

        public static unsafe uint[] glGenBuffers(int n)
        {
            uint[] ret = new uint[n];
            fixed (uint* retp = ret)
            {
                internalGLES.glGenBuffers(n, retp);
            }		
            return ret;
        }

		public static unsafe uint glGenFramebuffer()
		{
            uint[] ret = new uint[1];
            fixed (uint* retp = ret)
            {
                internalGLES.glGenFramebuffers(1, retp);
            }
            return ret[0];
		}

		public static unsafe uint[] glGenFramebuffers(int n)
		{
            uint[] ret = new uint[n];
            fixed (uint* retp = ret)
            {
                internalGLES.glGenFramebuffers(n, retp);
            }
            return ret;
		}

		public static unsafe uint glGenRenderbuffer()
		{
            uint[] ret = new uint[1];
            fixed (uint* retp = ret)
            {
                internalGLES.glGenRenderbuffers(1, retp);
            }
            return ret[0];
		}

		public static unsafe uint[] glGenRenderbuffers(int n)
		{
            uint[] ret = new uint[n];
            fixed (uint* retp = ret)
            {
                internalGLES.glGenRenderbuffers(n, retp);
            }
            return ret;
		}

        public static unsafe uint glGenTexture()
        {
            uint[] ret = new uint[1];
            fixed (uint* retp = ret)
            {
                internalGLES.glGenTextures(1, retp);
            }		
            return ret[0];
        }

        public static unsafe uint[] glGenTextures(int n)
        {
            uint[] ret = new uint[n];
            fixed (uint* retp = ret)
            {
                internalGLES.glGenTextures(1, retp);
            }		
            return ret;
        }

        public static unsafe string glGetStringh(StringName name)
		{
			return Marshal.PtrToStringAnsi((IntPtr)internalGLES.glGetString(name));
		}

		///<sumary> Available from OpenGL version 3.0</sumary>
		public static unsafe string glGetStringih(StringName name, uint index)
		{
			return Marshal.PtrToStringAnsi((IntPtr)internalGLES.glGetStringi(name, index));
		}

        public static unsafe string glGetShaderInfoLog(uint shader)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(512);
            internalGLES.glGetShaderInfoLog(shader, 512, null, sb);
            return sb.ToString();
        }

        public static unsafe int glGetShaderiv(uint shader, ShaderParameterName pname)
		{
            int[] ret = new int[1];
            fixed (int* retp = ret)
            {
                internalGLES.glGetShaderiv(shader, pname, retp);
            }			
            return ret[0];
		}

        public static unsafe uint glGenVertexArray()
        {
            uint[] ret = new uint[1];
            fixed (uint* retp = ret)
            {
                internalGLES.glGenVertexArrays(1, retp);
            }
            return ret[0];
        }

        public static unsafe int[] glGetUniformiv(uint program, int location, int lenght)
        {
            int[] fret = new int[lenght];
            fixed(int* ptr = &fret[0])
            {
                internalGLES.glGetUniformiv(program, location, ptr);
            }
            return fret;
        }

        public static unsafe uint[] glGetUniformuiv(uint program, int location, int lenght)
        {
            uint[] fret = new uint[lenght];
            fixed(uint* ptr = &fret[0])
            {
                internalGLES.glGetUniformuiv(program, location, ptr);
            }
            return fret;
        }

        public static unsafe float[] glGetUniformfv(uint program, int location, int lenght)
        {
            float[] fret = new float[lenght];
            fixed(float* ptr = &fret[0])
            {
                internalGLES.glGetUniformfv(program, location, ptr);
            }
            return fret;
        }
        /*
        public static unsafe double[] glGetUniformdv(uint program, int location, int lenght)
        {
            double[] fret = new double[lenght];
            fixed(double* ptr = &fret[0])
            {
                internalGLES.glGetUniformdv(program, location, ptr);
            }
            return fret;
        }
        */
        public static unsafe int[] glGetViewport()
        {
            int[] iret = new int[4];
            fixed(int* ptr = &iret[0])
            {
                internalGLES.glGetIntegerv(GetPName.GL_VIEWPORT, ptr);
            }
            return iret;
        }

        #endregion

        #region S:

        public static unsafe void glShaderSource(uint shader, string source)
		{
            fixed(int* ptr = new int[]{source.Length})
            {
			    internalGLES.glShaderSource(shader, 1, new string[]{source}, ptr);
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
			    internalGLES.glShaderSource(shader, sources.Length, sources, ptr);
            }
		}

        #endregion

        #region U:

        public static unsafe void glUniform1iv(int location, int count, int[] value)
        {
            fixed (int* ptr = &value[0])
            {
                internalGLES.glUniform1iv(location, count, ptr);
            }
        }

        public static unsafe void glUniform1uiv(int location, int count, uint[] value)
        {
            fixed (uint* ptr = &value[0])
            {
                internalGLES.glUniform1uiv(location, count, ptr);
            }
        }

        public static unsafe void glUniform1fv(int location, int count, float[] value)
        {
            fixed (float* ptr = &value[0])
            {
                internalGLES.glUniform1fv(location, count, ptr);
            }
        }

        public static unsafe void glUniform2iv(int location, int count, int[] value)
        {
            fixed (int* ptr = &value[0])
            {
                internalGLES.glUniform2iv(location, count, ptr);
            }
        }

        public static unsafe void glUniform2uiv(int location, int count, uint[] value)
        {
            fixed (uint* ptr = &value[0])
            {
                internalGLES.glUniform2uiv(location, count, ptr);
            }
        }

        public static unsafe void glUniform2fv(int location, int count, float[] value)
        {
            fixed (float* ptr = &value[0])
            {
                internalGLES.glUniform2fv(location, count, ptr);
            }
        }

        public static unsafe void glUniform3iv(int location, int count, int[] value)
        {
            fixed (int* ptr = &value[0])
            {
                internalGLES.glUniform3iv(location, count, ptr);
            }
        }

        public static unsafe void glUniform3uiv(int location, int count, uint[] value)
        {
            fixed (uint* ptr = &value[0])
            {
                internalGLES.glUniform3uiv(location, count, ptr);
            }
        }

        public static unsafe void glUniform3f(int location, dgtk.Math.Vector3 value)
        {
            internalGLES.glUniform3f(location, value.X, value.Y, value.Z);
        }

        public static unsafe void glUniform3fv(int location, int count, float[] value)
        {
            fixed (float* ptr = &value[0])
            {
                internalGLES.glUniform3fv(location, count, ptr);
            }
        }

        public static unsafe void glUniform4iv(int location, int count, int[] value)
        {
            fixed (int* ptr = &value[0])
            {
                internalGLES.glUniform4iv(location, count, ptr);
            }
        }

        public static unsafe void glUniform4uiv(int location, int count, uint[] value)
        {
            fixed (uint* ptr = &value[0])
            {
                internalGLES.glUniform4uiv(location, count, ptr);
            }
        }

        public static unsafe void glUniform4f(int location, float[] value)
        {
            internalGLES.glUniform4f(location, value[0], value[1], value[2], value[3]);
        }

        public static unsafe void glUniform4f(int location, dgtk.Math.Vector4 value)
        {
            internalGLES.glUniform4f(location, value.X, value.Y, value.Z, value.W);
        }

        public static unsafe void glUniform4f(int location, dgtk.Graphics.Color4 value)
        {
            internalGLES.glUniform4f(location, value.R, value.G, value.B, value.A);
        }

        public static unsafe void glUniform4fv(int location, int count, float[] value)
        {
            fixed (float* ptr = &value[0])
            {
                internalGLES.glUniform4fv(location, count, ptr);
            }
        }

        public static unsafe void glUniformMatrix(int location, bool transpose, dgtk.Math.Mat2 mat)
        {
            fixed(float* ptr = &mat.ToFloat()[0])
            {
                internalGLES.glUniformMatrix2fv(location, 1, transpose, ptr);
            }            
        }

        public static unsafe void glUniformMatrix(int location, bool transpose, dgtk.Math.Mat3 mat)
        {
            fixed(float* ptr = &mat.ToFloat()[0])
            {
                internalGLES.glUniformMatrix3fv(location, 1, transpose, ptr);
            }            
        }

        public static unsafe void glUniformMatrix(int location, bool transpose, dgtk.Math.Mat4 mat)
        {
            fixed(float* ptr = &mat.ToFloat()[0])
            {
                internalGLES.glUniformMatrix4fv(location, 1, transpose, ptr);
            }            
        }

        #endregion
    }
}