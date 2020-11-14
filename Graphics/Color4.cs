using System;

namespace dgtk.Graphics
{
	/// <summary>
	/// Description of Color4.
	/// </summary>
	public struct Color4 : IEquatable<Color4>
	{
		#region Auto-popierties:
        
		public float R {get; set;}
		public float G {get; set;}
		public float B {get; set;}
		public float A {get; set;}

		#endregion

		public Color4(float Red, float Green, float Blue, float alpha) : this()
		{
			R = Red;
			G = Green;
			B = Blue;
			A = alpha;
		}
		
		public Color4(byte Red, byte Green, byte Blue, byte alpha) : this()
		{
			R = Red/255f;
			G = Green/255f;
			B = Blue/255f;
			A = alpha/255f;
		}
		
		public Color4 Color4A(float Alpha)
		{
			return new Color4(R, G, B, Alpha);
		}
		
		#region Equals and GetHashCode implementation
		
		public override bool Equals(object obj)
		{
			if (obj is Color4)
				return Equals((Color4)obj); // use Equals method below
			else
				return false;
		}
		
		public bool Equals(Color4 other)
		{
			// add comparisions for all members here
			return this.GetHashCode() == other.GetHashCode();
		}
		
		public override int GetHashCode()
		{
			// combine the hash codes of all members here (e.g. with XOR operator ^)
			return this.ToArgb();
		}
		
		public static bool operator ==(Color4 left, Color4 right)
		{
			return left.Equals(right);
		}
		
		public static bool operator !=(Color4 left, Color4 right)
		{
			return !left.Equals(right);
		}

		#endregion
	
		public int ToArgb()
        {
            uint argb = (uint)(A * 255) << 24 | (uint)(R * 255) << 16 | (uint)(G * 255) << 8 | (uint)(B * 255);
            return unchecked((int)argb);
        }
		
		public static Color4 Transparent
		{
			get {return new Color4(0f, 0f, 0f, 0f);}
		}
		public static Color4 Red
		{
			get {return new Color4(1f, 0f, 0f, 1f);}
		}
		public static Color4 Green
		{
			get {return new Color4(0f, 1f, 0f, 1f);}
		}
		public static Color4 Blue
		{
			get {return new Color4(0f, 0f, 1f, 1f);}
		}
		public static Color4 Black
		{
			get {return new Color4(0f, 0f, 0f, 1f);}
		}
		public static Color4 White
		{
			get {return new Color4(1f, 1f, 1f, 1f);}
		}
		public static Color4 Gray
		{
			get {return new Color4(0.5f,0.5f,0.5f,1f);}
		}
		public static Color4 Pink
		{
			get {return new Color4(1f, 0f, 1f, 1f);}
		}
	}
}
