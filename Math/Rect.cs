using System;

namespace dgtk.Math
{
	/// <summary>
	/// Description of Rect.
	/// </summary>
	
	[Serializable]
	//[StructLayout(LayoutKind.Sequential)]
	public struct Rect : IEquatable<Rect>
	{
		private int i_x, i_y, i_width, i_height;
		public Rect(int x, int y, int width, int height)
		{
			this.i_x = x;
			this.i_y = y;
			this.i_width = width;
			this.i_height = height;
		}
		
		#region Operadores:
		public static Rect operator +(Rect izq, Rect der)
		{
			izq.i_width += der.i_width;
			izq.i_height += der.i_height;
			return izq;
		}
		public static Rect operator -(Rect izq, Rect der)
		{
			izq.i_width -= der.i_width;
			izq.i_height -= der.i_height;
			return izq;
		}
		public static Rect operator -(Rect v)
		{
			v.i_width = -v.i_width;
			v.i_height = -v.i_height;
			return v;
		}
		public static Rect operator *(Rect izq, Rect der)
		{
			izq.i_width *= der.i_width;
			izq.i_height *= der.i_height;
			return izq;
		}
		public static bool operator ==(Rect izq, Rect der)
		{
			if((izq.i_x == der.i_x) && (izq.i_y == der.i_y) && (izq.i_width == der.i_width) && (izq.i_height == der.i_height))
			{
				return true;
			}
			return false;
		}
		public static bool operator !=(Rect izq, Rect der)
		{
			if((izq.i_x != der.i_x) || (izq.i_y != der.i_y) || (izq.i_width != der.i_width) || (izq.i_height != der.i_height))
			{
				return true;
			}
			return false;
		}
		public override bool Equals(object s)
		{
			return this == (Rect)s;
		}
		public bool Equals(Rect s)
		{
			return this == s;
		}
		#endregion

		
		#region Equals and GetHashCode implementation
		public override int GetHashCode()
		{
			int hashCode = 0;
				unchecked {
					hashCode += 1000000007 * i_x.GetHashCode();
					hashCode += 1000000009 * i_y.GetHashCode();
					hashCode += 1000000009 * i_width.GetHashCode();
					hashCode += 1000000009 * i_height.GetHashCode();
				}
					return hashCode;
		}
		#endregion

		
		/// <summary>
		/// Gets the width.
		/// </summary>
		/// <value>The width.</value>
		public int PositionX
		{
			set { this.i_x = value;}
			get { return this.i_x;}
		}

		/// <summary>
		/// Gets the height.
		/// </summary>
		/// <value>The height.</value>
		public int PositionY
		{
			set { this.i_y = value;}
			get { return this.i_y;}
		}
				
		/// <summary>
		/// Gets the Position end.
		/// </summary>
		/// <value>The width.</value>
		public int PositionX2
		{
			set { this.i_width = value - this.i_x;}
			get { return this.i_x+this.i_width;}
		}

		/// <summary>
		/// Gets the Position end.
		/// </summary>
		/// <value>The height.</value>
		public int PositionY2
		{
			set { this.i_height = value - this.i_y;}
			get { return this.i_y+this.i_height;}
		}
				
		/// <summary>
		/// Gets the width.
		/// </summary>
		/// <value>The width.</value>
		public int Width
		{
			set { this.i_width = value; }
			get { return this.i_width;}
		}

		/// <summary>
		/// Gets the height.
		/// </summary>
		/// <value>The height.</value>
		public int Height
		{
			set { this.i_height = value; }
			get { return this.i_height;}
		}
	}
}
