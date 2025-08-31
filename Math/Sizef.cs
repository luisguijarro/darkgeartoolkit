using System;
using System.Runtime.InteropServices;

namespace dgtk.Math
{
	/// <summary>
	/// Two dimensions Sizef with Int32 values.
	/// </summary>
	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct Sizef : IEquatable<Sizef>
	{
		private float X, Y;
		public Sizef(float width, float height)
		{
			this.X = width; this.Y = height;
		}
		public static readonly float SizefInBytes = Marshal.SizeOf(new Sizef());
		
		#region Operadores:
		public static Sizef operator +(Sizef izq, Sizef der)
		{
			izq.X += der.X;
			izq.Y += der.Y;
			return izq;
		}
		public static Sizef operator -(Sizef izq, Sizef der)
		{
			izq.X -= der.X;
			izq.Y -= der.Y;
			return izq;
		}
		public static Sizef operator -(Sizef v)
		{
			v.X = -v.X;
			v.Y = -v.Y;
			return v;
		}
		public static Sizef operator *(Sizef izq, Sizef der)
		{
			izq.X *= der.X;
			izq.Y *= der.Y;
			return izq;
		}
		public static bool operator ==(Sizef izq, Sizef der)
		{
			if((izq.X == der.X) && (izq.Y == der.Y))
			{
				return true;
			}
			return false;
		}
		public static bool operator !=(Sizef izq, Sizef der)
		{
			if((izq.X != der.X) || (izq.Y != der.Y))
			{
				return true;
			}
			return false;
		}
		public override bool Equals(object s)
		{
			return this == (Sizef)s;
		}
		public bool Equals(Sizef s)
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
	}
}
