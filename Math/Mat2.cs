using System;

namespace dgtk.Math
{
	/// <summary>
	/// Matrix 3x3 dimensions.
	/// </summary>
	public struct Mat2 : IEquatable<Mat3>
	{
		internal Vector2 v_Row0;
		internal Vector2 v_Row1;
		public static readonly Mat2 Identity = new Mat2(new Vector3(1, 0, 0), new Vector3(0, 1, 0), new Vector3(0, 0, 1));
		public Mat2(Vector2 Row0, Vector2 Row1)
		{
			this.v_Row0 = Row0;
			this.v_Row1 = Row1;
		}
		public Mat2 Traspose()
		{
			this = new Mat2(this.Columna0, this.Columna1, this.Columna2);
			return this;
		}
		public Mat2 TrasposeCopy()
		{
			Mat2 mret = new Mat2(this.Columna0, this.Columna1, this.Columna2);
			return mret;
		}
		#region Operadores
		public static Mat2 operator *(Mat2 izq, Mat2 der)
		{
			Mat2 ret = new Mat2();
			ret.v_Row0.X = ((izq.Row0.X * der.Row0.X) + (izq.Row0.Y * der.Row1.X));
			ret.v_Row0.Y = ((izq.Row0.X * der.Row0.Y) + (izq.Row0.Y * der.Row1.Y));
			ret.v_Row1.X = ((izq.Row1.X * der.Row0.X) + (izq.Row1.Y * der.Row1.X));
			ret.v_Row1.Y = ((izq.Row1.X * der.Row0.Y) + (izq.Row1.Y * der.Row1.Y));
			return ret;
		}
		public static bool operator ==(Mat2 izq, Mat2 der)
		{
			return izq.Equals(der);
		}
		public static bool operator !=(Mat2 izq, Mat2 der)
		{
			if((izq.Row0 == der.Row0) && (izq.Row1 == der.Row1))
			{
				return false;
			}
			return true;
		}
		
		public bool Equals(Mat2 m)
		{
			if((this.Row0 == m.Row0) && (this.Row1 == m.Row1))
			{
				return true;
			}
			return false;
		}
		public override bool Equals(object obj)
		{
			if(!(obj is Mat2))
			{
				return false;
			}
			return this.Equals((Mat2)obj);
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
				}
				return hashCode;
		}

		#endregion

		public Single[] ToFloat()
		{
			return new float[]
			{
				v_Row0.X, v_Row1.X,   
				v_Row0.Y, v_Row1.Y
			};
		}		
		
		#region PROPIEDADES:
		public Vector2 Row0
		{
			get { return this.v_Row0;}
			set { this.v_Row0 = value;}
		}
		public Vector2 Row1
		{
			get { return this.v_Row1;}
			set { this.v_Row1 = value;}
		}
		public Vector2 Columna0
		{
			get { return  new Vector2(Row0.X, Row1.X);}
			set 
			{ 
				this.v_Row0.X = value.X;
				this.v_Row1.X = value.Y;
			}
		}
		public Vector2 Columna1
		{
			get { return  new Vector2(Row0.Y, Row1.Y);}
			set 
			{ 
				this.v_Row0.Y = value.X;
				this.v_Row1.Y = value.Y;
			}
		}
		#endregion
		
	}

}

