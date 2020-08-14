using System;

namespace dgtk.Math
{
	/// <summary>
	/// Two dimensions Point with Int32 values.
	/// </summary>
	public struct Point : IEquatable<Point>
	{
		private int i_X, i_Y;
		public Point(int x, int y)
		{
			this.i_X = x;
			this.i_Y = y;
		}
		
		
		#region Operadores:
		public static Point operator +(Point izq, Point der)
		{
			izq.i_X += der.i_X;
			izq.i_Y += der.i_Y;
			return izq;
		}
		public static Point operator -(Point izq, Point der)
		{
			izq.i_X -= der.i_X;
			izq.i_Y -= der.i_Y;
			return izq;
		}
		public static Point operator -(Point v)
		{
			v.i_X = -v.i_X;
			v.i_Y = -v.i_Y;
			return v;
		}
		public static Point operator *(Point izq, Point der)
		{
			izq.i_X *= der.i_X;
			izq.i_Y *= der.i_Y;
			return izq;
		}
		public static bool operator ==(Point izq, Point der)
		{
			if((izq.i_X == der.i_X) && (izq.i_Y == der.i_Y))
			{
				return true;
			}
			return false;
		}
		public static bool operator !=(Point izq, Point der)
		{
			if((izq.i_X != der.i_X || (izq.i_Y != der.i_Y)))
			{
				return true;
			}
			return false;
		}
		public override bool Equals(object s)
		{
			return this == (Point)s;
		}
		public bool Equals(Point s)
		{
			return this == s;
		}
		#endregion

		
		#region GetHashCode implementation		
		public override int GetHashCode()
		{
			// combine the hash codes of all members here (e.g. with XOR operator ^)
			int hascode = 0;
			hascode += i_X.GetHashCode();
			hascode += i_Y.GetHashCode();
			return hascode;
		}
		#endregion
		
		public int X
		{
			set { this.i_X = value;}
			get { return this.i_X;}
		}
		
		public int Y
		{
			set { this.i_Y = value;}
			get { return this.i_Y;}
		}
	}
}
