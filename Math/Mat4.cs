using System;
using System.Runtime.InteropServices;

namespace dgtk.Math
{
	/// <summary>
	/// Matrix 4x4 dimensions.
	/// </summary>
	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public struct Mat4 : IEquatable<Mat4>
	{
		public float[] FloatMatrix;
		internal Vector4 v_Row0;
		internal Vector4 v_Row1;
		internal Vector4 v_Row2;
		internal Vector4 v_Row3;
		public static readonly Mat4 Identity = new Mat4(new Vector4(1, 0, 0, 0), new Vector4(0, 1, 0, 0), new Vector4(0, 0, 1, 0), new Vector4(0, 0, 0, 1));
		public Mat4(Vector4 Row0, Vector4 Row1, Vector4 Row2, Vector4 Row3)
		{
			this.v_Row0 = Row0;
			this.v_Row1 = Row1;
			this.v_Row2 = Row2;
			this.v_Row3 = Row3;
			this.FloatMatrix = new float[] //El Float[] se ordena por columnas, no por lineas.
			{
				v_Row0.X, v_Row1.X, v_Row2.X, v_Row3.X, 
				v_Row0.Y, v_Row1.Y, v_Row2.Y, v_Row3.Y, 
				v_Row0.Z, v_Row1.Z, v_Row2.Z, v_Row3.Z, 
				v_Row0.W, v_Row1.W, v_Row2.W, v_Row3.W
			};
		}
		/*public Mat4(Vector4 Column0, Vector4 Column1, Vector4 Column2, Vector4 Column3)
		{
			this.v_Row0 = new Vector4(Column0.X, Column1.X, Column2.X, Column3.X);
			this.v_Row1 = new Vector4(Column0.Y, Column1.Y, Column2.Y, Column3.Y);
			this.v_Row2 = new Vector4(Column0.Z, Column1.Z, Column2.Z, Column3.Z);
			this.v_Row3 = new Vector4(Column0.W, Column1.W, Column2.W, Column3.W);
		}*/
		public Mat4(float[] values)
		{
			this.v_Row0 = new Vector4(values[00], values[04], values[08], values[12]);
			this.v_Row1 = new Vector4(values[01], values[05], values[09], values[13]);
			this.v_Row2 = new Vector4(values[02], values[06], values[10], values[14]);
			this.v_Row3 = new Vector4(values[03], values[07], values[11], values[15]);
			this.FloatMatrix = new float[]
			{
				v_Row0.X, v_Row1.X, v_Row2.X, v_Row3.X, 
				v_Row0.Y, v_Row1.Y, v_Row2.Y, v_Row3.Y, 
				v_Row0.Z, v_Row1.Z, v_Row2.Z, v_Row3.Z, 
				v_Row0.W, v_Row1.W, v_Row2.W, v_Row3.W
			};
		}
		public Mat4 Traspose()
		{
			this = new Mat4(this.Column0, this.Column1, this.Column2, this.Column3);
			return this;
		}
		public Mat4 TrasposeCopy()
		{
			Mat4 mret = new Mat4(this.Column0, this.Column1, this.Column2, this.Column3);
			return mret;
		}
		
		#region Operadores
		public static Mat4 operator +(Mat4 izq, Mat4 der)
		{
			Mat4 ret = new Mat4();
			ret.v_Row0 = izq.Row0 + der.Row0;
			ret.v_Row1 = izq.Row1 + der.Row1;
			ret.v_Row2 = izq.Row2 + der.Row2;
			ret.v_Row3 = izq.Row3 + der.Row3;
			return ret;
		}
		public static Mat4 operator -(Mat4 izq, Mat4 der)
		{
			Mat4 ret = new Mat4();
			ret.v_Row0 = izq.Row0 - der.Row0;
			ret.v_Row1 = izq.Row1 - der.Row1;
			ret.v_Row2 = izq.Row2 - der.Row2;
			ret.v_Row3 = izq.Row3 - der.Row3;
			return ret;
		}
		
		public static Mat4 operator *(Mat4 izq, Mat4 der)
		{
			Mat4 ret = new Mat4();
			ret.v_Row0.X = ((izq.Row0.X * der.Row0.X) + (izq.Row0.Y * der.Row1.X) + (izq.Row0.Z * der.Row2.X) + (izq.Row0.W * der.Row3.X));
			ret.v_Row0.Y = ((izq.Row0.X * der.Row0.Y) + (izq.Row0.Y * der.Row1.Y) + (izq.Row0.Z * der.Row2.Y) + (izq.Row0.W * der.Row3.Y));
			ret.v_Row0.Z = ((izq.Row0.X * der.Row0.Z) + (izq.Row0.Y * der.Row1.Z) + (izq.Row0.Z * der.Row2.Z) + (izq.Row0.W * der.Row3.Z));
			ret.v_Row0.W = ((izq.Row0.X * der.Row0.W) + (izq.Row0.Y * der.Row1.W) + (izq.Row0.Z * der.Row2.W) + (izq.Row0.W * der.Row3.W));
			ret.v_Row1.X = ((izq.Row1.X * der.Row0.X) + (izq.Row1.Y * der.Row1.X) + (izq.Row1.Z * der.Row2.X) + (izq.Row1.W * der.Row3.X));
			ret.v_Row1.Y = ((izq.Row1.X * der.Row0.Y) + (izq.Row1.Y * der.Row1.Y) + (izq.Row1.Z * der.Row2.Y) + (izq.Row1.W * der.Row3.Y));
			ret.v_Row1.Z = ((izq.Row1.X * der.Row0.Z) + (izq.Row1.Y * der.Row1.Z) + (izq.Row1.Z * der.Row2.Z) + (izq.Row1.W * der.Row3.Z));
			ret.v_Row1.W = ((izq.Row1.X * der.Row0.W) + (izq.Row1.Y * der.Row1.W) + (izq.Row1.Z * der.Row2.W) + (izq.Row1.W * der.Row3.W));
			ret.v_Row2.X = ((izq.Row2.X * der.Row0.X) + (izq.Row2.Y * der.Row1.X) + (izq.Row2.Z * der.Row2.X) + (izq.Row2.W * der.Row3.X));
			ret.v_Row2.Y = ((izq.Row2.X * der.Row0.Y) + (izq.Row2.Y * der.Row1.Y) + (izq.Row2.Z * der.Row2.Y) + (izq.Row2.W * der.Row3.Y));
			ret.v_Row2.Z = ((izq.Row2.X * der.Row0.Z) + (izq.Row2.Y * der.Row1.Z) + (izq.Row2.Z * der.Row2.Z) + (izq.Row2.W * der.Row3.Z));
			ret.v_Row2.W = ((izq.Row2.X * der.Row0.W) + (izq.Row2.Y * der.Row1.W) + (izq.Row2.Z * der.Row2.W) + (izq.Row2.W * der.Row3.W));			
			ret.v_Row3.X = ((izq.Row3.X * der.Row0.X) + (izq.Row3.Y * der.Row1.X) + (izq.Row3.Z * der.Row2.X) + (izq.Row3.W * der.Row3.X));
			ret.v_Row3.Y = ((izq.Row3.X * der.Row0.Y) + (izq.Row3.Y * der.Row1.Y) + (izq.Row3.Z * der.Row2.Y) + (izq.Row3.W * der.Row3.Y));
			ret.v_Row3.Z = ((izq.Row3.X * der.Row0.Z) + (izq.Row3.Y * der.Row1.Z) + (izq.Row3.Z * der.Row2.Z) + (izq.Row3.W * der.Row3.Z));
			ret.v_Row3.W = ((izq.Row3.X * der.Row0.W) + (izq.Row3.Y * der.Row1.W) + (izq.Row3.Z * der.Row2.W) + (izq.Row3.W * der.Row3.W));
			return ret;
		}
		
		
		public static bool operator ==(Mat4 izq, Mat4 der)
		{
			return izq.Equals(der);
		}
		
		public static bool operator !=(Mat4 izq, Mat4 der)
		{
			return !izq.Equals(der);
		}
		
		public bool Equals(Mat4 m)
		{
			if((this.Row0 == m.Row0) && (this.Row1 == m.Row1) && (this.Row2 == m.Row2) && (this.Row3 == m.Row3))
			{
				return true;
			}
			return false;
		}
		public override bool Equals(object obj)
		{
			if(!(obj is Mat4))
			{
				return false;
			}
			return this.Equals((Mat4)obj);
		}
		#endregion
		
		#region Equals and GetHashCode implementation
		public override int GetHashCode()
		{
			int hashCode = 0;
			unchecked {
				hashCode += 1000000007 * v_Row0.GetHashCode();
				hashCode += 1000000009 * v_Row1.GetHashCode();
				hashCode += 1000000021 * v_Row2.GetHashCode();
				hashCode += 1000000033 * v_Row3.GetHashCode();
			}
			return hashCode;
		}
		#endregion
		
		#region PROPIEDADES:

		public Vector4 Row0
		{
			get { return this.v_Row0;}
			set 
			{ 
				this.v_Row0 = value;
				this.FloatMatrix = this.ToFloat();
			}
		}

		public Vector4 Row1
		{
			get { return this.v_Row1;}
			set 
			{ 
				this.v_Row1 = value;
				this.FloatMatrix = this.ToFloat();
			}
		}

		public Vector4 Row2
		{
			get { return this.v_Row2;}
			set 
			{ 
				this.v_Row2 = value;
				this.FloatMatrix = this.ToFloat();
			}
		}

		public Vector4 Row3
		{
			get { return this.v_Row3;}
			set 
			{ 
				this.v_Row3 = value;
				this.FloatMatrix = this.ToFloat();
			}
		}

		public Vector4 Column0
		{
			get { return  new Vector4(v_Row0.X, v_Row1.X, v_Row2.X, v_Row3.X);}
			set 
			{ 
				this.v_Row0.X = value.X; this.v_Row1.X = value.Y; this.v_Row2.X = value.Z; this.v_Row3.X = value.W; 
				this.FloatMatrix = this.ToFloat();
			}
		}

		public Vector4 Column1
		{
			get { return  new Vector4(v_Row0.Y, v_Row1.Y, v_Row2.Y, v_Row3.Y);}
			set 
			{ 
				this.v_Row0.Y = value.X; this.v_Row1.Y = value.Y; this.v_Row2.Y = value.Z; this.v_Row3.Y = value.W; 
				this.FloatMatrix = this.ToFloat();
			}
		}

		public Vector4 Column2
		{
			get { return  new Vector4(v_Row0.Z, v_Row1.Z, v_Row2.Z, v_Row3.Z);}
			set 
			{ 
				this.v_Row0.Z = value.X; this.v_Row1.Z = value.Y; this.v_Row2.Z = value.Z; this.v_Row3.Z = value.W; 
				this.FloatMatrix = this.ToFloat();
			}
		}

		public Vector4 Column3
		{
			get { return  new Vector4(v_Row0.W, v_Row1.W, v_Row2.W, v_Row3.W);}
			set 
			{ 
				this.v_Row0.W = value.X; this.v_Row1.W = value.Y; this.v_Row2.W = value.Z; this.v_Row3.W = value.W; 
				this.FloatMatrix = this.ToFloat();
			}
		}

		public Single[] ToFloat()
		{
			return new float[]
			{
				v_Row0.X, v_Row1.X, v_Row2.X, v_Row3.X, 
				v_Row0.Y, v_Row1.Y, v_Row2.Y, v_Row3.Y, 
				v_Row0.Z, v_Row1.Z, v_Row2.Z, v_Row3.Z, 
				v_Row0.W, v_Row1.W, v_Row2.W, v_Row3.W
			};
		}

		#endregion
	}
}
