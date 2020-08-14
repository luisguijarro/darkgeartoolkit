using System;
using System.Runtime.InteropServices;

namespace dgtk.Math
{
	/// <summary>
	/// Two dimensions Size with Int32 values.
	/// </summary>
	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct Size : IEquatable<Size>
	{
		private int X, Y;
		public Size(int x, int y)
		{
			this.X = x; this.Y = y;
		}
		public static readonly int SizeInBytes = Marshal.SizeOf(new Size());
		
		#region Operadores:
		public static Size operator +(Size izq, Size der)
		{
			izq.X += der.X;
			izq.Y += der.Y;
			return izq;
		}
		public static Size operator -(Size izq, Size der)
		{
			izq.X -= der.X;
			izq.Y -= der.Y;
			return izq;
		}
		public static Size operator -(Size v)
		{
			v.X = -v.X;
			v.Y = -v.Y;
			return v;
		}
		public static Size operator *(Size izq, Size der)
		{
			izq.X *= der.X;
			izq.Y *= der.Y;
			return izq;
		}
		public static bool operator ==(Size izq, Size der)
		{
			if((izq.X == der.X) && (izq.Y == der.Y))
			{
				return true;
			}
			return false;
		}
		public static bool operator !=(Size izq, Size der)
		{
			if((izq.X != der.X) || (izq.Y != der.Y))
			{
				return true;
			}
			return false;
		}
		public override bool Equals(object s)
		{
			return this == (Size)s;
		}
		public bool Equals(Size s)
		{
			return this == s;
		}
		#endregion

		#region Equals and GetHashCode implementation
		public override int GetHashCode()
		{
			int hashCode = 0;
				unchecked {
					hashCode += 1000000007 * X.GetHashCode();
					hashCode += 1000000009 * Y.GetHashCode();
				}
					return hashCode;
		}
		#endregion

		public override string ToString()
		{
			return "(" + this.X + "," + this.Y + ")";
		}

		/// <summary>
		/// Gets the width.
		/// </summary>
		/// <value>The width.</value>
		public int Width
		{
			get { return this.X;}
		}

		/// <summary>
		/// Gets the height.
		/// </summary>
		/// <value>The height.</value>
		public int Height
		{
			get { return this.Y;}
		}
	}
}
