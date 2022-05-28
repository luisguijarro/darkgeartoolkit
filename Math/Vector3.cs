using System;
using System.Runtime.InteropServices;

namespace dgtk.Math
{
	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct Vector3
	{
		internal float f_X, f_Y, f_Z;
		public Vector3(float x, float y, float z)
		{
			this.f_X = x; this.f_Y = y; this.f_Z = z;
		}
		public float Length
		{
			get { return (float)System.Math.Sqrt(this.f_X * this.f_X + this.f_Y * this.f_Y + this.f_Z * this.f_Z); }
		}
		public Vector3 Normalize()
		{
			float s = 1f / this.Length;
			this.f_X *= s;
			this.f_Y *= s;
			this.f_Z *= s;
			return this;
		}
		
		public float[] ToArray()
		{
			return new float[]{this.f_X, this.f_Y, this.f_Z};
		}
				
		public static readonly int SizeInBytes = Marshal.SizeOf(new Vector3());

		#region Operadores:
		public static Vector3 operator +(Vector3 izq, Vector3 der)
		{
			izq.f_X += der.f_X;
			izq.f_Y += der.f_Y;
			izq.f_Z += der.f_Z;
			return izq;
		}
		public static Vector3 operator -(Vector3 izq, Vector3 der)
		{
			izq.f_X -= der.f_X;
			izq.f_Y -= der.f_Y;
			izq.f_Z -= der.f_Z;
			return izq;
		}
		public static Vector3 operator -(Vector3 v)
		{
			v.f_X = -v.f_X;
			v.f_Y = -v.f_Y;
			v.f_Z = -v.f_Z;
			return v;
		}
		public static Vector3 operator *(Vector3 izq, Vector3 der)
		{
			izq.f_X *= der.f_X;
			izq.f_Y *= der.f_Y;
			izq.f_Z *= der.f_Z;
			return izq;
		}
		public static Vector3 operator *(Vector3 v, Mat3 m)
		{
			return new Vector3(
				(v.f_X * m.Row0.f_X) + (v.f_Y * m.Row1.f_X) + (v.f_Z * m.Row2.f_X),
				(v.f_X * m.Row0.f_Y) + (v.f_Y * m.Row1.f_Y) + (v.f_Z * m.Row2.f_Y),
				(v.f_X * m.Row0.f_Z) + (v.f_Y * m.Row1.f_Z) + (v.f_Z * m.Row2.f_Z));
		}
		public static Vector3 operator *(Mat3 m, Vector3 v)
		{
			return new Vector3(
				(m.Row0.f_X * v.f_X) + (m.Row0.f_Y * v.f_Y) + (m.Row0.f_Z * v.f_Z),
				(m.Row1.f_X * v.f_X) + (m.Row1.f_Y * v.f_Y) + (m.Row1.f_Z * v.f_Z),
				(m.Row2.f_X * v.f_X) + (m.Row2.f_Y * v.f_Y) + (m.Row2.f_Z * v.f_Z)
			);
		}
		public static bool operator ==(Vector3 izq, Vector3 der)
		{
			if ((izq.f_X == der.f_X) && (izq.f_Y == der.f_Y) && (izq.f_Z == der.f_Z))
			{
				return true;
			}
			return false;
		}
		public static bool operator !=(Vector3 izq, Vector3 der)
		{
			if ((izq.f_X != der.f_X) || (izq.f_Y != der.f_Y) || (izq.f_Z != der.f_Z))
			{
				return true;
			}
			return false;
		}		
		public override bool Equals(object o)
		{
			return this == (Vector3)o;
		}
		
		#endregion
		#region Equals and GetHashCode implementation
		public override int GetHashCode()
		{
			int hashCode = 0;
				unchecked {
					hashCode += 1000000007 * f_X.GetHashCode();
					hashCode += 1000000009 * f_Y.GetHashCode();
					hashCode += 1000000021 * f_Z.GetHashCode();
				}
					return hashCode;
		}
		#endregion
		
		public float X
		{
			get { return this.f_X;}
			set { this.f_X = value;}
		}
		public float Y
		{
			get { return this.f_Y;}
			set { this.f_Y = value;}
		}
		public float Z
		{
			get { return this.f_Z;}
			set { this.f_Z = value;}
		}
		public override string ToString()
		{
			return "(" + this.f_X + "," + this.f_Y + "," + this.f_Z + ")";
		}
	}
}

