using System;
using System.Runtime.InteropServices;

namespace dgtk.Math
{
	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct Vector2
	{
		public float X, Y;
		public Vector2(float x, float y)
		{
			this.X = x; this.Y = y;
		}
		public float Longitud
		{
			get { return (float)System.Math.Sqrt(this.X * this.X + this.Y * this.Y); }
		}
		public Vector2 Normalizar()
		{
			float s = 1f / this.Longitud;
			this.X *= s;
			this.Y *= s;
			return this;
		}
		public Vector2 PerpendicularR
		{
			get { return new Vector2(this.Y, -this.X); }
		}
		public Vector2 PerpendicularL
		{
			get { return new Vector2(-this.Y, this.X); }
		}
		public static readonly int SizeInBytes = Marshal.SizeOf(new Vector2());
		
		#region Operadores:
		public static Vector2 operator +(Vector2 izq, Vector2 der)
		{
			izq.X += der.X;
			izq.Y += der.Y;
			return izq;
		}
		public static Vector2 operator -(Vector2 izq, Vector2 der)
		{
			izq.X -= der.X;
			izq.Y -= der.Y;
			return izq;
		}
		public static Vector2 operator -(Vector2 v)
		{
			v.X = -v.X;
			v.Y = -v.Y;
			return v;
		}
		public static Vector2 operator *(Vector2 izq, Vector2 der)
		{
			izq.X *= der.X;
			izq.Y *= der.Y;
			return izq;
		}
		public static bool operator ==(Vector2 izq, Vector2 der)
		{
			if((izq.X == der.X) && (izq.Y == der.Y))
			{
				return true;
			}
			return false;
		}
		public static bool operator !=(Vector2 izq, Vector2 der)
		{
			if((izq.X != der.X) || (izq.Y != der.Y))
			{
				return true;
			}
			return false;
		}
		public override bool Equals(object v)
		{
			return this == (Vector2)v;
		}
		public bool Equals(Vector2 v)
		{
			return this == v;
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
	}
}

