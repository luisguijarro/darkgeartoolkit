
using System;
using System.Runtime.InteropServices;

namespace dgtk.Math
{
	/// <summary>
	/// Description of Vector4.
	/// </summary>
	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct Vector4 : IEquatable<Vector4>
	{
		internal float f_X, f_Y, f_Z, f_W;
		public Vector4(float x, float y, float z, float w)
		{
			this.f_X = x;
			this.f_Y = y;
			this.f_Z = z;
			this.f_W = w;
		}
		public Vector4(Vector3 v, float w) : this(v.X, v.Y, v.Z, w)
		{

		}
		public float Length
		{
			get { return (float)System.Math.Sqrt(this.X * this.X + this.Y * this.Y + this.Z * this.Z + this.W * this.W); }
		}
		public Vector4 Normalize()
		{
			float s = 1f / this.Length;
			X *= s;
			Y *= s;
			Z *= s;
			W *= s;
			return this;
		}
		public static readonly int SizeInBytes = Marshal.SizeOf(new Vector4());

		public float[] ToArray()
		{
			return new float[]{this.f_X, this.f_Y, this.f_Z, this.f_W};
		}
				
		#region Operadores:
		public static Vector4 operator +(Vector4 izq, Vector4 der)
		{
			izq.X += der.X;
			izq.Y += der.Y;
			izq.Z += der.Z;
			izq.W += der.W;
			return izq;
		}
		public static Vector4 operator -(Vector4 izq, Vector4 der)
		{
			izq.X -= der.X;
			izq.Y -= der.Y;
			izq.Z -= der.Z;
			izq.W -= der.W;
			return izq;
		}
		public static Vector4 operator -(Vector4 v)
		{
			v.X = -v.X;
			v.Y = -v.Y;
			v.Z = -v.Z;
			v.W = -v.W;
			return v;
		}
		public static Vector4 operator *(Vector4 izq, Vector4 der)
		{
			izq.X *= der.X;
			izq.Y *= der.Y;
			izq.Z *= der.Z;
			izq.W *= der.W;
			return izq;
		}
		#region Equals and GetHashCode implementation
		public override int GetHashCode()
		{
			int hashCode = 0;
				unchecked {
					hashCode += 1000000007 * f_X.GetHashCode();
					hashCode += 1000000009 * f_Y.GetHashCode();
					hashCode += 1000000021 * f_Z.GetHashCode();
					hashCode += 1000000033 * f_W.GetHashCode();
				}
					return hashCode;
		}

		#endregion
		
		public static Vector4 operator *(Vector4 v, Mat4 m)
		{
			return new Vector4(
				(v.X * m.Row0.X) + (v.Y * m.Row1.X) + (v.Z * m.Row2.X) + (v.W * m.Row3.X),
				(v.X * m.Row0.Y) + (v.Y * m.Row1.Y) + (v.Z * m.Row2.Y) + (v.W * m.Row3.Y),
				(v.X * m.Row0.Z) + (v.Y * m.Row1.Z) + (v.Z * m.Row2.Z) + (v.W * m.Row3.Z),
				(v.X * m.Row0.Z) + (v.Y * m.Row1.Z) + (v.Z * m.Row2.Z) + (v.W * m.Row3.W));
		}
		public static Vector4 operator *(Mat4 m, Vector4 v)
		{
			return new Vector4(
				(m.Row0.X * v.X) + (m.Row0.Y * v.Y) + (m.Row0.Z * v.Z) + (m.Row0.W * v.W),
				(m.Row1.X * v.X) + (m.Row1.Y * v.Y) + (m.Row1.Z * v.Z) + (m.Row1.W * v.W),
				(m.Row2.X * v.X) + (m.Row2.Y * v.Y) + (m.Row2.Z * v.Z) + (m.Row2.W * v.W),
				(m.Row3.X * v.X) + (m.Row3.Y * v.Y) + (m.Row3.Z * v.Z) + (m.Row3.W * v.W)
			);
		}
		public static bool operator ==(Vector4 izq, Vector4 der)
		{
			if ((izq.X == der.X) && (izq.Y == der.Y) && (izq.Z == der.Z)&& (izq.W == der.W))
			{
				return true;
			}
			return false;
		}
		public static bool operator !=(Vector4 izq, Vector4 der)
		{
			if ((izq.X != der.X) || (izq.Y != der.Y) || (izq.Z != der.Z)  || (izq.W != der.W))
			{
				return true;
			}
			return false;
		}
					
		public override bool Equals(object v)
		{
			return this == (Vector4)v;
		}
		
		public bool Equals(Vector4 v)
		{
			return this == v;
		}

		#endregion

		#region PROPIEDADES
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
		public float W
		{
			get { return this.f_W;}
			set { this.f_W = value;}
		}
		public Vector3 xyz
		{
			get { return new Vector3(this.f_X, this.f_Y, this.f_Z); }
		}
		#endregion
	}
}
