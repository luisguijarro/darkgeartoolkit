using System;

namespace dgtk.Graphics
{
	/// <summary>
	/// Description of Color4.
	/// </summary>
	public struct Color4 : IEquatable<Color4>
	{
		#region Auto-popierties:

		public float R { get; set; }
		public float G { get; set; }
		public float B { get; set; }
		public float A { get; set; }

		#endregion

		public Color4(uint color)
		{
			A = ((color >> 24) & 0xFF) / 255f;
			R = ((color >> 16) & 0xFF) / 255f;
			G = ((color >> 8) & 0xFF) / 255f;
			B = (color & 0xFF) / 255f;
		}

		public Color4(float[] RGBA_array) : this(RGBA_array[0], RGBA_array[1], RGBA_array[2], RGBA_array[3])
		{

		}

		public Color4(float Red, float Green, float Blue, float alpha) : this()
		{
			R = Red;
			G = Green;
			B = Blue;
			A = alpha;
		}

		public Color4(byte[] RGBA_array) : this(RGBA_array[0], RGBA_array[1], RGBA_array[2], RGBA_array[3])
		{

		}

		public Color4(byte Red, byte Green, byte Blue, byte alpha) : this()
		{
			R = Red / 255f;
			G = Green / 255f;
			B = Blue / 255f;
			A = alpha / 255f;
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

		public float[] ToRgbaFloatArray()
		{
			return new float[] { this.R, this.G, this.B, this.A };
		}

		public static Color4 SuperPink => new Color4(0xFFFF00FF);
		public static Color4 Empty => new Color4(0x00000000);
		public static Color4 AliceBlue = new Color4(0xFFF0F8FF);
		public static Color4 AntiqueWhite = new Color4(0xFFFAEBD7);
		public static Color4 Aqua = new Color4(0xFF00FFFF);
		public static Color4 Aquamarine = new Color4(0xFF7FFFD4);
		public static Color4 Azure = new Color4(0xFFF0FFFF);
		public static Color4 Beige = new Color4(0xFFF5F5DC);
		public static Color4 Bisque = new Color4(0xFFFFE4C4);
		public static Color4 Black = new Color4(0xFF000000);
		public static Color4 BlanchedAlmond = new Color4(0xFFFFEBCD);
		public static Color4 Blue = new Color4(0xFF0000FF);
		public static Color4 BlueViolet = new Color4(0xFF8A2BE2);
		public static Color4 Brown = new Color4(0xFFA52A2A);
		public static Color4 BurlyWood = new Color4(0xFFDEB887);
		public static Color4 CadetBlue = new Color4(0xFF5F9EA0);
		public static Color4 Chartreuse = new Color4(0xFF7FFF00);
		public static Color4 Chocolate = new Color4(0xFFD2691E);
		public static Color4 Coral = new Color4(0xFFFF7F50);
		public static Color4 CornflowerBlue = new Color4(0xFF6495ED);
		public static Color4 Cornsilk = new Color4(0xFFFFF8DC);
		public static Color4 Crimson = new Color4(0xFFDC143C);
		public static Color4 Cyan = new Color4(0xFF00FFFF);
		public static Color4 DarkBlue = new Color4(0xFF00008B);
		public static Color4 DarkCyan = new Color4(0xFF008B8B);
		public static Color4 DarkGoldenrod = new Color4(0xFFB8860B);
		public static Color4 DarkGray = new Color4(0xFFA9A9A9);
		public static Color4 DarkGreen = new Color4(0xFF006400);
		public static Color4 DarkKhaki = new Color4(0xFFBDB76B);
		public static Color4 DarkMagenta = new Color4(0xFF8B008B);
		public static Color4 DarkOliveGreen = new Color4(0xFF556B2F);
		public static Color4 DarkOrange = new Color4(0xFFFF8C00);
		public static Color4 DarkOrchid = new Color4(0xFF9932CC);
		public static Color4 DarkRed = new Color4(0xFF8B0000);
		public static Color4 DarkSalmon = new Color4(0xFFE9967A);
		public static Color4 DarkSeaGreen = new Color4(0xFF8FBC8B);
		public static Color4 DarkSlateBlue = new Color4(0xFF483D8B);
		public static Color4 DarkSlateGray = new Color4(0xFF2F4F4F);
		public static Color4 DarkTurquoise = new Color4(0xFF00CED1);
		public static Color4 DarkViolet = new Color4(0xFF9400D3);
		public static Color4 DeepPink = new Color4(0xFFFF1493);
		public static Color4 DeepSkyBlue = new Color4(0xFF00BFFF);
		public static Color4 DimGray = new Color4(0xFF696969);
		public static Color4 DodgerBlue = new Color4(0xFF1E90FF);
		public static Color4 Firebrick = new Color4(0xFFB22222);
		public static Color4 FloralWhite = new Color4(0xFFFFFAF0);
		public static Color4 ForestGreen = new Color4(0xFF228B22);
		public static Color4 Fuchsia = new Color4(0xFFFF00FF);
		public static Color4 Gainsboro = new Color4(0xFFDCDCDC);
		public static Color4 GhostWhite = new Color4(0xFFF8F8FF);
		public static Color4 Gold = new Color4(0xFFFFD700);
		public static Color4 Goldenrod = new Color4(0xFFDAA520);
		public static Color4 Gray = new Color4(0xFF808080);
		public static Color4 Green = new Color4(0xFF008000);
		public static Color4 GreenYellow = new Color4(0xFFADFF2F);
		public static Color4 Honeydew = new Color4(0xFFF0FFF0);
		public static Color4 HotPink = new Color4(0xFFFF69B4);
		public static Color4 IndianRed = new Color4(0xFFCD5C5C);
		public static Color4 Indigo = new Color4(0xFF4B0082);
		public static Color4 Ivory = new Color4(0xFFFFFFF0);
		public static Color4 Khaki = new Color4(0xFFF0E68C);
		public static Color4 Lavender = new Color4(0xFFE6E6FA);
		public static Color4 LavenderBlush = new Color4(0xFFFFF0F5);
		public static Color4 LawnGreen = new Color4(0xFF7CFC00);
		public static Color4 LemonChiffon = new Color4(0xFFFFFACD);
		public static Color4 LightBlue = new Color4(0xFFADD8E6);
		public static Color4 LightCoral = new Color4(0xFFF08080);
		public static Color4 LightCyan = new Color4(0xFFE0FFFF);
		public static Color4 LightGoldenrodYellow = new Color4(0xFFFAFAD2);
		public static Color4 LightGray = new Color4(0xFFD3D3D3);
		public static Color4 LightGreen = new Color4(0xFF90EE90);
		public static Color4 LightPink = new Color4(0xFFFFB6C1);
		public static Color4 LightSalmon = new Color4(0xFFFFA07A);
		public static Color4 LightSeaGreen = new Color4(0xFF20B2AA);
		public static Color4 LightSkyBlue = new Color4(0xFF87CEFA);
		public static Color4 LightSlateGray = new Color4(0xFF778899);
		public static Color4 LightSteelBlue = new Color4(0xFFB0C4DE);
		public static Color4 LightYellow = new Color4(0xFFFFFFE0);
		public static Color4 Lime = new Color4(0xFF00FF00);
		public static Color4 LimeGreen = new Color4(0xFF32CD32);
		public static Color4 Linen = new Color4(0xFFFAF0E6);
		public static Color4 Magenta = new Color4(0xFFFF00FF);
		public static Color4 Maroon = new Color4(0xFF800000);
		public static Color4 MediumAquamarine = new Color4(0xFF66CDAA);
		public static Color4 MediumBlue = new Color4(0xFF0000CD);
		public static Color4 MediumOrchid = new Color4(0xFFBA55D3);
		public static Color4 MediumPurple = new Color4(0xFF9370DB);
		public static Color4 MediumSeaGreen = new Color4(0xFF3CB371);
		public static Color4 MediumSlateBlue = new Color4(0xFF7B68EE);
		public static Color4 MediumSpringGreen = new Color4(0xFF00FA9A);
		public static Color4 MediumTurquoise = new Color4(0xFF48D1CC);
		public static Color4 MediumVioletRed = new Color4(0xFFC71585);
		public static Color4 MidnightBlue = new Color4(0xFF191970);
		public static Color4 MintCream = new Color4(0xFFF5FFFA);
		public static Color4 MistyRose = new Color4(0xFFFFE4E1);
		public static Color4 Moccasin = new Color4(0xFFFFE4B5);
		public static Color4 NavajoWhite = new Color4(0xFFFFDEAD);
		public static Color4 Navy = new Color4(0xFF000080);
		public static Color4 OldLace = new Color4(0xFFFDF5E6);
		public static Color4 Olive = new Color4(0xFF808000);
		public static Color4 OliveDrab = new Color4(0xFF6B8E23);
		public static Color4 Orange = new Color4(0xFFFFA500);
		public static Color4 OrangeRed = new Color4(0xFFFF4500);
		public static Color4 Orchid = new Color4(0xFFDA70D6);
		public static Color4 PaleGoldenrod = new Color4(0xFFEEE8AA);
		public static Color4 PaleGreen = new Color4(0xFF98FB98);
		public static Color4 PaleTurquoise = new Color4(0xFFAFEEEE);
		public static Color4 PaleVioletRed = new Color4(0xFFDB7093);
		public static Color4 PapayaWhip = new Color4(0xFFFFEFD5);
		public static Color4 PeachPuff = new Color4(0xFFFFDAB9);
		public static Color4 Peru = new Color4(0xFFCD853F);
		public static Color4 Pink = new Color4(0xFFFFC0CB);
		public static Color4 Plum = new Color4(0xFFDDA0DD);
		public static Color4 PowderBlue = new Color4(0xFFB0E0E6);
		public static Color4 Purple = new Color4(0xFF800080);
		public static Color4 Red = new Color4(0xFFFF0000);
		public static Color4 RosyBrown = new Color4(0xFFBC8F8F);
		public static Color4 RoyalBlue = new Color4(0xFF4169E1);
		public static Color4 SaddleBrown = new Color4(0xFF8B4513);
		public static Color4 Salmon = new Color4(0xFFFA8072);
		public static Color4 SandyBrown = new Color4(0xFFF4A460);
		public static Color4 SeaGreen = new Color4(0xFF2E8B57);
		public static Color4 SeaShell = new Color4(0xFFFFF5EE);
		public static Color4 Sienna = new Color4(0xFFA0522D);
		public static Color4 Silver = new Color4(0xFFC0C0C0);
		public static Color4 SkyBlue = new Color4(0xFF87CEEB);
		public static Color4 SlateBlue = new Color4(0xFF6A5ACD);
		public static Color4 SlateGray = new Color4(0xFF708090);
		public static Color4 Snow = new Color4(0xFFFFFAFA);
		public static Color4 SpringGreen = new Color4(0xFF00FF7F);
		public static Color4 SteelBlue = new Color4(0xFF4682B4);
		public static Color4 Tan = new Color4(0xFFD2B48C);
		public static Color4 Teal = new Color4(0xFF008080);
		public static Color4 Thistle = new Color4(0xFFD8BFD8);
		public static Color4 Tomato = new Color4(0xFFFF6347);
		public static Color4 Turquoise = new Color4(0xFF40E0D0);
		public static Color4 Violet = new Color4(0xFFEE82EE);
		public static Color4 Wheat = new Color4(0xFFF5DEB3);
		public static Color4 White = new Color4(0xFFFFFFFF);
		public static Color4 WhiteSmoke = new Color4(0xFFF5F5F5);
		public static Color4 Yellow = new Color4(0xFFFFFF00);
		public static Color4 YellowGreen = new Color4(0xFF9ACD32);
		public static Color4 Transparent = new Color4(0x00FFFFFF);
	}
}
