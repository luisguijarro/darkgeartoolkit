
namespace dgtk.OpenGL
{
	public static partial class GL
    {
        #region G:

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
    }
}