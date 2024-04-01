using System;
using System.Runtime.InteropServices;

namespace dgtk.Math
{
	/// <summary>
	/// Two dimensions Size with Int32 values.
	/// </summary>
	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct Size3f : IEquatable<Size3f>
	{
		private float X, Y, Z;
		public Size3f(float width, float height, float depth)
		{
			this.X = width; this.Y = height; this.Z = depth;
		}
		public static readonly int SizeInBytes = Marshal.SizeOf(new Size());
		
		#region Operadores:
		public static Size3f operator +(Size3f izq, Size3f der)
		{
			izq.X += der.X;
			izq.Y += der.Y;
			izq.Z += der.Z;
			return izq;
		}
		public static Size3f operator -(Size3f izq, Size3f der)
		{
			izq.X -= der.X;
			izq.Y -= der.Y;
			izq.Z -= der.Z;
			return izq;
		}
		public static Size3f operator -(Size3f v)
		{
			v.X = -v.X;
			v.Y = -v.Y;
			v.Z = -v.Z;
			return v;
		}
		public static Size3f operator *(Size3f izq, Size3f der)
		{
			izq.X *= der.X;
			izq.Y *= der.Y;
			izq.Z *= der.Z;
			return izq;
		}
		public static bool operator ==(Size3f izq, Size3f der)
		{
			if((izq.X == der.X) && (izq.Y == der.Y) && (izq.Z == der.Z))
			{
				return true;
			}
			return false;
		}
		public static bool operator !=(Size3f izq, Size3f der)
		{
			if((izq.X != der.X) || (izq.Y != der.Y) || (izq.Y != der.Y))
			{
				return true;
			}
			return false;
		}
		public override bool Equals(object s)
		{
			return this == (Size3f)s;
		}
		public bool Equals(Size3f s)
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
					hashCode += 1000000011 * Z.GetHashCode();
				}
					return hashCode;
		}
		#endregion

		public override string ToString()
		{
			return "(" + this.X + "," + this.Y + "," + this.Z + ")";
		}

		/// <summary>
		/// Gets the width.
		/// </summary>
		/// <value>The width.</value>
		public float Width
		{
			get { return this.X;}
		}

		/// <summary>
		/// Gets the height.
		/// </summary>
		/// <value>The height.</value>
		public float Height
		{
			get { return this.Y;}
		}

		/// <summary>
		/// Gets the height.
		/// </summary>
		/// <value>The height.</value>
		public float Depth
		{
			get { return this.Z;}
		}
	}
}
