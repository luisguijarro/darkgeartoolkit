using System;

namespace dgtk.Math
{
	/// <summary>
	/// Description of Tools.
	/// </summary>
	public static class Tools
	{
		/// <summary>
		/// Metodo que devuelve el número de radianes correspondiente a un numero dado de grados.
		/// </summary>
		/// <param name="degrees">Grados representados en Valor Flotante de doble precisión</param>
		/// <returns>Radianes representados en Valor Flotante de doble precisión</returns>
		public static double DegreesToRadians(double degrees)
		{
			return degrees * (System.Math.PI/180D);
		}
		
		/// <summary>
		/// Metodo que devuelve el número de radianes correspondiente a un numero dado de grados.
		/// </summary>
		/// <param name="degrees">Grados representados en Valor Flotante de precisión simple</param>
		/// <returns>Radianes representados en Valor Flotante de precisión simple</returns>
		public static float DegreesToRadians(float degrees)
		{
			return (float)(degrees * (System.Math.PI/180D));
		}

		/// <summary>
		/// Propiedad que representa el valor del número aureo.
		/// </summary>
		/// <remarks>Número aureo</remarks>
		/// <returns>Retorna un valor float que representa el numero aureo</returns>
		public static float NumeroAureo
		{
			get { return (float)((1+System.Math.Sqrt(5))/2);}
		}

		/// <summary>
		/// Metodo que devuelve la distancia entre dos puntos dentro de un espacio bidimensional.
		/// </summary>
		/// <remarks>devuelve la distancia entre dos puntos</remarks>
		/// <param>X0, Y0: Coordenadas X Y del primer punto</param>
		/// <param>X1, Y1: Coordenadas X Y del segundo punto</param>
		/// <returns>Retorna un valor float que representa la distancia entre los dos puntos</returns>
		public static float Distancia2Puntos2D(float X0, float Y0, float X1, float Y1)
		{
			return (float)(System.Math.Sqrt( System.Math.Pow((X1-X0), 2) + System.Math.Pow((Y1-Y0), 2)));
		}

		/// <summary>
		/// Metodo que devuelve la distancia entre dos puntos dentro de un espacio tridimensional.
		/// </summary>
		/// <remarks>devuelve la distancia entre dos puntos</remarks>
		/// <param>X0, Y0 y Z0: Coordenadas X Y Z del primer punto</param>
		/// <param>X1, Y1 y Z1: Coordenadas X Y Z del segundo punto</param>
		/// <returns>Retorna un valor float que representa la distancia entre los dos puntos</returns>
		public static float Distancia2Puntos3D(float X0, float Y0, float Z0, float X1, float Y1, float Z1)
		{
			return (float)(System.Math.Sqrt( System.Math.Pow((X1-X0), 2) + System.Math.Pow((Y1-Y0), 2) + System.Math.Pow((Z1-Z0), 2)));
		}
	}
}
