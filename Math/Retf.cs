using System;

namespace dgtk.Math
{
	/// <summary>
	/// Description of Rect.
	/// </summary>
	
	[Serializable]
	//[StructLayout(LayoutKind.Sequential)]
	public struct Rectf : IEquatable<Rectf>
	{
		private float i_x, i_y, i_width, i_height;
		public Rectf(float x, float y, float width, float height)
		{
			this.i_x = x;
			this.i_y = y;
			this.i_width = width;
			this.i_height = height;
		}
		
		#region Operadores:
		public static Rectf operator +(Rectf izq, Rectf der)
		{
			izq.i_width += der.i_width;
			izq.i_height += der.i_height;
			return izq;
		}
		public static Rectf operator -(Rectf izq, Rectf der)
		{
			izq.i_width -= der.i_width;
			izq.i_height -= der.i_height;
			return izq;
		}
		public static Rectf operator -(Rectf v)
		{
			v.i_width = -v.i_width;
			v.i_height = -v.i_height;
			return v;
		}
		public static Rectf operator *(Rectf izq, Rectf der)
		{
			izq.i_width *= der.i_width;
			izq.i_height *= der.i_height;
			return izq;
		}
		public static bool operator ==(Rectf izq, Rectf der)
		{
			if((izq.i_x == der.i_x) && (izq.i_y == der.i_y) && (izq.i_width == der.i_width) && (izq.i_height == der.i_height))
			{
				return true;
			}
			return false;
		}
		public static bool operator !=(Rectf izq, Rectf der)
		{
			if((izq.i_x != der.i_x) || (izq.i_y != der.i_y) || (izq.i_width != der.i_width) || (izq.i_height != der.i_height))
			{
				return true;
			}
			return false;
		}
		public override bool Equals(object s)
		{
			return this == (Rectf)s;
		}
		public bool Equals(Rectf s)
		{
			return this == s;
		}
		#endregion

		
		#region Equals and GetHashCode implementation
		public override int GetHashCode()
		{
			int hashCode = 0;
				unchecked 
				{
					hashCode += 1000000007 * i_x.GetHashCode();
					hashCode += 1000000009 * i_y.GetHashCode();
					hashCode += 1000000009 * i_width.GetHashCode();
					hashCode += 1000000009 * i_height.GetHashCode();
				}
				return hashCode;
		}
		#endregion

		
		/// <summary>
		/// Gets/Sets the Position initial.
		/// </summary>
		/// <value>The X edge coord of a top-left point that determine de position of this rectangle. This value cause change in PositionX2 property.</value>
		public float PositionX
		{
			set { this.i_x = value; this.PositionX2 = this.i_x + this.i_width;}
			get { return this.i_x;}
		}

		/// <summary>
		/// Gets/Sets the Position initial.
		/// </summary>
		/// <value>The Y edge coord of a top-left point that determine de position of this rectangle. This value cause change in PositionY2 property.</value>
		public float PositionY
		{
			set { this.i_y = value; this.PositionY2 = this.i_y + this.i_height;}
			get { return this.i_y;}
		}
		
		/// <summary>
		/// Gets the Position end.
		/// </summary>
		/// <value>The X edge Coord os a Bottom-Right point of this rectangle. A change in this value cause change of Width Property of this rectangle.</value>
		public float PositionX2
		{
			set { this.i_width = value - this.i_x;}
			get { return this.i_x+this.i_width;}
		}

		/// <summary>
		/// Gets the Position end.
		/// </summary>
		/// <value>The Y edge Coord os a Bottom-Right point of this rectangle. A change in this value cause change of Height Property of this rectangle.</value>
		public float PositionY2
		{
			set { this.i_height = value - this.i_y;}
			get { return this.i_y+this.i_height;}
		}
		
		/// <summary>
		/// Gets/Sets the width.
		/// </summary>
		/// <value>The width of this rectangle. A change in dis property cause a change of the value of PositionX2 property.</value>
		public float Width
		{
			set { this.i_width = value; }
			get { return this.i_width;}
		}

		/// <summary>
		/// Gets/Sets the height.
		/// </summary>
		/// <value>The height of this rectangle. A change in dis property cause a change of the value of PositionY2 property.</value>
		public float Height
		{
			set { this.i_height = value; }
			get { return this.i_height;}
		}
	}
}
