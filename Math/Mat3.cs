using System;

namespace dgtk.Math
{
	/// <summary>
	/// Matrix 3x3 dimensions.
	/// </summary>
	public struct Mat3 : IEquatable<Mat3>
	{
		internal Vector3 v_Row0;
		internal Vector3 v_Row1;
		internal Vector3 v_Row2;
		public static readonly Mat3 Identity = new Mat3(new Vector3(1, 0, 0), new Vector3(0, 1, 0), new Vector3(0, 0, 1));
		public Mat3(Vector3 Row0, Vector3 Row1, Vector3 Row2)
		{
			this.v_Row0 = Row0;
			this.v_Row1 = Row1;
			this.v_Row2 = Row2;
		}
		public Mat3 Traspose()
		{
			this = new Mat3(this.Columna0, this.Columna1, this.Columna2);
			return this;
		}
		public Mat3 TrasposeCopy()
		{
			Mat3 mret = new Mat3(this.Columna0, this.Columna1, this.Columna2);
			return mret;
		}
		#region Operadores
		public static Mat3 operator *(Mat3 izq, Mat3 der)
		{
			Mat3 ret = new Mat3();
			ret.v_Row0.X = ((izq.Row0.X * der.Row0.X) + (izq.Row0.Y * der.Row1.X) + (izq.Row0.Z * der.Row2.X));
			ret.v_Row0.Y = ((izq.Row0.X * der.Row0.Y) + (izq.Row0.Y * der.Row1.Y) + (izq.Row0.Z * der.Row2.Y));
			ret.v_Row0.Z = ((izq.Row0.X * der.Row0.Z) + (izq.Row0.Y * der.Row1.Z) + (izq.Row0.Z * der.Row2.Z));
			ret.v_Row1.X = ((izq.Row1.X * der.Row0.X) + (izq.Row1.Y * der.Row1.X) + (izq.Row1.Z * der.Row2.X));
			ret.v_Row1.Y = ((izq.Row1.X * der.Row0.Y) + (izq.Row1.Y * der.Row1.Y) + (izq.Row1.Z * der.Row2.Y));
			ret.v_Row1.Z = ((izq.Row1.X * der.Row0.Z) + (izq.Row1.Y * der.Row1.Z) + (izq.Row1.Z * der.Row2.Z));
			ret.v_Row2.X = ((izq.Row2.X * der.Row0.X) + (izq.Row2.Y * der.Row1.X) + (izq.Row2.Z * der.Row2.X));
			ret.v_Row2.Y = ((izq.Row2.X * der.Row0.Y) + (izq.Row2.Y * der.Row1.Y) + (izq.Row2.Z * der.Row2.Y));
			ret.v_Row2.Z = ((izq.Row2.X * der.Row0.Z) + (izq.Row2.Y * der.Row1.Z) + (izq.Row2.Z * der.Row2.Z));
			return ret;
		}
		public static bool operator ==(Mat3 izq, Mat3 der)
		{
			return izq.Equals(der);
		}
		public static bool operator !=(Mat3 izq, Mat3 der)
		{
			if((izq.Row0 == der.Row0) && (izq.Row1 == der.Row1) && (izq.Row2 == der.Row2))
			{
				return false;
			}
			return true;
		}
		
		public bool Equals(Mat3 m)
		{
			if((this.Row0 == m.Row0) && (this.Row1 == m.Row1) && (this.Row2 == m.Row2))
			{
				return true;
			}
			return false;
		}
		public override bool Equals(object obj)
		{
			if(!(obj is Mat3))
			{
				return false;
			}
			return this.Equals((Mat3)obj);
		}
		#endregion
		
		#region Equals and GetHashCode implementation
		public override int GetHashCode()
		{
			int hashCode = 0;
			unchecked 
			{
				hashCode += 1000000007 * v_Row0.GetHashCode();
				hashCode += 1000000009 * v_Row1.GetHashCode();
				hashCode += 1000000021 * v_Row2.GetHashCode();
			}
			return hashCode;
		}

		#endregion

		public Single[] ToFloat()
		{
			return new float[]
			{
				v_Row0.X, v_Row1.X, v_Row2.X,  
				v_Row0.Y, v_Row1.Y, v_Row2.Y,  
				v_Row0.Z, v_Row1.Z, v_Row2.Z
			};
		}		
		
		#region PROPIEDADES:
		public Vector3 Row0
		{
			get { return this.v_Row0;}
			set { this.v_Row0 = value;}
		}
		public Vector3 Row1
		{
			get { return this.v_Row1;}
			set { this.v_Row1 = value;}
		}
		public Vector3 Row2
		{
			get { return this.v_Row2;}
			set { this.v_Row2 = value;}
		}
		public Vector3 Columna0
		{
			get { return  new Vector3(Row0.X, Row1.X, Row2.X);}
			set 
			{ 
				this.v_Row0.X = value.X;
				this.v_Row1.X = value.Y;
				this.v_Row2.X = value.Z;
			}
		}
		public Vector3 Columna1
		{
			get { return  new Vector3(Row0.Y, Row1.Y, Row2.Y);}
			set 
			{ 
				this.v_Row0.Y = value.X;
				this.v_Row1.Y = value.Y;
				this.v_Row2.Y = value.Z;
			}
		}
		public Vector3 Columna2
		{
			get { return  new Vector3(Row0.Z, Row1.Z, Row2.Z);}
			set 
			{ 
				this.v_Row0.Z = value.X;
				this.v_Row1.Z = value.Y;
				this.v_Row2.Z = value.Z;
			}
		}
		#endregion
		
	}

}

