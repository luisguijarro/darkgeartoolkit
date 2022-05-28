using System;
using System.Runtime.InteropServices;

namespace dgtk.Math
{
	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct Vector2
	{
		private float f_x, f_y;
		public Vector2(float f_x, float f_y)
		{
			this.f_x = f_x; this.f_y = f_y;
		}
		public float Length
		{
			get { return (float)System.Math.Sqrt(this.f_x * this.f_x + this.f_y * this.f_y); }
		}
		public Vector2 Normalize()
		{
			float s = 1f / this.Length;
			this.f_x *= s;
			this.f_y *= s;
			return this;
		}
		public Vector2 PerpendicularR
		{
			get { return new Vector2(this.f_y, -this.f_x); }
		}
		public Vector2 PerpendicularL
		{
			get { return new Vector2(-this.f_y, this.f_x); }
		}
		public static readonly int SizeInBytes = Marshal.SizeOf(new Vector2());
		
		public float[] ToArray()
		{
			return new float[]{this.f_x, this.f_y};
		}
				
		#region Operadores:
		public static Vector2 operator +(Vector2 izq, Vector2 der)
		{
			izq.f_x += der.f_x;
			izq.f_y += der.f_y;
			return izq;
		}
		public static Vector2 operator -(Vector2 izq, Vector2 der)
		{
			izq.f_x -= der.f_x;
			izq.f_y -= der.f_y;
			return izq;
		}
		public static Vector2 operator -(Vector2 v)
		{
			v.f_x = -v.f_x;
			v.f_y = -v.f_y;
			return v;
		}
		public static Vector2 operator *(Vector2 izq, Vector2 der)
		{
			izq.f_x *= der.f_x;
			izq.f_y *= der.f_y;
			return izq;
		}
		public static bool operator ==(Vector2 izq, Vector2 der)
		{
			if((izq.f_x == der.f_x) && (izq.f_y == der.f_y))
			{
				return true;
			}
			return false;
		}
		public static bool operator !=(Vector2 izq, Vector2 der)
		{
			if((izq.f_x != der.f_x) || (izq.f_y != der.f_y))
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
					hashCode += 1000000007 * f_x.GetHashCode();
					hashCode += 1000000009 * f_y.GetHashCode();
				}
					return hashCode;
		}
		#endregion
		public override string ToString()
		{
			return "(" + this.f_x + "," + this.f_y + ")";
		}

		public float X
		{
			set { this.f_x = value; }
			get { return this.f_x; }
		}
		public float Y
		{
			set { this.f_y = value; }
			get { return this.f_y; }
		}
	}
}

