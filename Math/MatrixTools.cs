using System;

namespace dgtk.Math
{
	/// <summary>
	/// Description of MatrixTools.
	/// </summary>
	public static class MatrixTools
	{
		/// <summary>
		/// Metodo que devuelve una matriz de Perspectivoa de proyección Ortogonal.
		/// </summary>
		/// <param name="width">Ancho de la proyección</param>
		/// <param name="height">Alto de la proyección</param>
		/// <param name="zNear">Distancia más proxima que es mostrada.</param>
		/// <param name="zFar">Distancia más lejana que es mostrada.</param>
		/// <returns>Retorna una Matriz de Perspectiva de proyección Ortogonal.</returns>
		public static Mat4 MakeOrthoPerspectiveMatrix(float width, float height, float zNear, float zFar)
		{
			return MakeOrthoPerspectiveMatrix(-(width/2f), (width/2f), -(height/2f), (height/2f), zNear, zFar);
		}
		
		/// <summary>
		/// Metodo que devuelve una matriz de Perspectivoa de proyección Ortogonal.
		/// </summary>
		/// <param name="left">Borde izquiero de la proyección.</param>
		/// <param name="right">Borde derecho de la proyección.</param>
		/// <param name="bottom">Borde inferior de la proyección.</param>
		/// <param name="top">Borde superior d ela proyección.</param>
		/// <param name="zNear">Distancia más proxima que es mostrada.</param>
		/// <param name="zFar">Distancia más lejana que es mostrada.</param>
		/// <returns></returns>
		public static Mat4 MakeOrthoPerspectiveMatrix(float left, float right, float bottom, float top, float zNear, float zFar)
		{
			Mat4 ret = Mat4.Identity;

			ret.v_Row0 = new Vector4(2f/(right-left), 0, 0, -(right+left)/(right-left));
			ret.v_Row1 = new Vector4(0, 2f/(top-bottom), 0, -(top+bottom)/(top-bottom));
			ret.v_Row2 = new Vector4(0, 0, -2/(zFar-zNear), -(zFar+zNear)/(zFar-zNear));

            return ret;
		}
		
		/// <summary>
		/// Metodo que devuelve una Matriz de Perspectiva.
		/// </summary>
		/// <param name="fovy">(Field of View) Campo de visión.</param>
		/// <param name="aspect">(Aspect Ratio) Relación de Aspecto. Proporción entre ancho by alto de la visión.</param>
		/// <param name="zNear">Distancia más proxima que es mostrada.</param>
		/// <param name="zFar">Distancia más lejana que es mostrada.</param>
		/// <returns></returns>
		public static Mat4 MakePerspectiveMatrix(float fovy, float aspect, float zNear, float zFar)
		{
			Mat4 ret = Mat4.Identity;
			if (fovy <= 0 || fovy > System.Math.PI) { throw new ArgumentOutOfRangeException("fovy is not valid: "+fovy); }
			if (aspect <= 0) { throw new ArgumentOutOfRangeException("aspect must by greater than 0: "+aspect); }
			if (zNear <= 0) { throw new ArgumentOutOfRangeException("zNear must by greater than 0: "+zNear); }
			if (zFar <= 0) { throw new ArgumentOutOfRangeException("zFar must by greater than 0: "+zFar); }
            
            float yMax = zNear * (float)System.Math.Tan(0.5f * fovy);
            float yMin = -yMax;
            float xMin = yMin * aspect;
            float xMax = yMax * aspect;
            
            float x = (2.0f * zNear) / (xMax - xMin);
            float y = (2.0f * zNear) / (yMax - yMin);
            float a = (xMax + xMin) / (xMax - xMin);
            float b = (yMax + yMin) / (yMax - yMin);
            float c = -(zFar + zNear) / (zFar - zNear);
            float d = -(2.0f * zFar * zNear) / (zFar - zNear);
            
            ret.Row0 = new Vector4(x, 0, 0, 0);
            ret.Row1 = new Vector4(0, y, 0, 0);
            ret.Row2 = new Vector4(a, b, c, -1);
            ret.Row3 = new Vector4(0, 0, d, 0);
            
            return ret;
		}
		
		/// <summary>
		/// Metodo que devuelve una Matriz de traslació o desplazamiento.
		/// </summary>
		/// <param name="traslation">Vector3 que representa la cantidad de distancia a recorrer en cada eje.</param>
		/// <returns>Matriz de trasformación que represeta una traslación en el espacio.</returns>
		public static Mat4 MakeTraslationMatrix(Vector3 traslation)
		{
			Mat4 ret = Mat4.Identity;
			ret.Column3 = new Vector4(traslation.X, traslation.Y, traslation.Z, 1f);
			return ret;
		}
		
		/// <summary>
		/// Metodo que devuelve una Matriz de transformaciónd e rotación en el EjeX.
		/// </summary>
		/// <param name="angle_in_radians">Angulo de rotación medido en radianes.</param>
		/// <returns>Matriz de Tradformación de Rotación en torno a eje X.</returns>
		public static Mat4 MakeRotationMatrixX(float angle_in_radians)
		{
			Mat4 ret;
			float cos = (float)System.Math.Cos(angle_in_radians);
            float sin = (float)System.Math.Sin(angle_in_radians);

            ret = Mat4.Identity;
            ret.Row1 = new Vector4(0, cos, sin, 0);
            ret.Row2 = new Vector4(0, -sin, cos, 0);
            
            return ret;
		}
		
		/// <summary>
		/// Metodo que devuelve una Matriz de transformaciónd e rotación en el EjeY.
		/// </summary>
		/// <param name="angle_in_radians">Angulo de rotación medido en radianes.</param>
		/// <returns>Matriz de Tradformación de Rotación en torno a eje Y.</returns>
		public static Mat4 MakeRotationMatrixY(float angle_in_radians)
		{
			Mat4 ret;
			float cos = (float)System.Math.Cos(angle_in_radians);
            float sin = (float)System.Math.Sin(angle_in_radians);

            ret = Mat4.Identity;
            ret.Row0 = new Vector4(cos, 0, -sin, 0);
            ret.Row2 = new Vector4(sin, 0, cos, 0);
            
            return ret;
		}
		
		/// <summary>
		/// Metodo que devuelve una Matriz de transformaciónd e rotación en el EjeZ.
		/// </summary>
		/// <param name="angle_in_radians">Angulo de rotación medido en radianes.</param>
		/// <returns>Matriz de Tradformación de Rotación en torno a eje Z.</returns>
		public static Mat4 MakeRotationMatrixZ(float angle_in_radians)
		{
			Mat4 ret;
			float cos = (float)System.Math.Cos(angle_in_radians);
            float sin = (float)System.Math.Sin(angle_in_radians);

            ret = Mat4.Identity;
            ret.Row0 = new Vector4(cos, sin, 0, 0);
            ret.Row1 = new Vector4(-sin, cos, 0, 0);
            
            return ret;
		}
		
		/// <summary>
		/// Metodo que devuelve una Matriz de Escalado de proporción única.
		/// </summary>
		/// <param name="scale">Proporción de escalado.</param>
		/// <returns>Matriz de Escalado.</returns>
		public static Mat4 MakeScaleMatrix(float scale)
		{
			return MakeScaleMatrix(scale, scale, scale);
		}
		
		/// <summary>
		/// Metodo que devuelve una MAtriz de Escalado de diferentes proporciones.
		/// </summary>
		/// <param name="v_scale">Vector3 que representa las proporciones de escalado por eje.</param>
		/// <returns>Matriz de Escalado.</returns>
		public static Mat4 MakeScaleMatrix(Vector3 v_scale)
		{
			return MakeScaleMatrix(v_scale.X, v_scale.Y, v_scale.Z);
		}
		
		/// <summary>
		/// Metodo que devuelve una MAtriz de Escalado de diferentes proporciones.
		/// </summary>
		/// <param name="scale_x">Proporción de escalado en el Eje X.</param>
		/// <param name="scale_y">Proporción de escalado en el Eje Y.</param>
		/// <param name="scale_z">Proporción de escalado en el Eje Z.</param>
		/// <returns>Matriz de Escalado.</returns>
		public static Mat4 MakeScaleMatrix(float scale_x, float scale_y, float scale_z)
		{
			Mat4 ret = Mat4.Identity;
			ret.Row0 = new Vector4(scale_x, 0, 0, 0);
			ret.Row1 = new Vector4(0, scale_y, 0, 0);
			ret.Row2 = new Vector4(0, 0, scale_z, 0);
			return ret;
		}
		
		/// <summary>
		/// Metodo que devuelve una matriz de transformación en torno a un punto en el espacio.
		/// </summary>
		/// <param name="m4">Matriz de trasformación previa al giro.</param>
		/// <param name="center">Vector3 con las coordenadas sobre las que se va a realizar el giro.</param>
		/// <returns>Matriz de transformación de un giro en torno a un punto en el espacio.</returns>
		public static Mat4 TransformationAroundPoint(Mat4 m4, Vector3 center)
		{
			Mat4 precam = MakeTraslationMatrix(-center);
			Mat4 poscam = MakeTraslationMatrix(center);
			return precam * m4 * poscam;
		}

		/// <summary>
		/// Metodo que devuelve una matriz de transformación de un giro en torno a un punto en el espacio Bidimensional.
		/// </summary>
		/// <param name="degrees">Grados de giro en torno al centro.</param>
		/// <param name="center">Vector3 con las coordenadas sobre las que se va a realizar el giro.</param>
		/// <returns>Matriz de transformación de un giro en torno a un punto en el espacio bidimensional.</returns>
		public static Mat4 TwistAroundPoint2D(float degrees, Vector2 center)
		{
			Vector3 v_center = new Vector3(center.X, center.Y, 0);
			Mat4 m4 = MakeRotationMatrixZ(Tools.DegreesToRadians(degrees));
			Mat4 precam = MakeTraslationMatrix(-v_center);
			Mat4 poscam = MakeTraslationMatrix(v_center);
			return precam * m4 * poscam;
		}
		
		/// <summary>
		/// Metodo que devuelve una matriz de transformación de un giro en torno a un punto en el espacio Bidimensional.
		/// </summary>
		/// <param name="degrees">Grados de giro en torno al centro.</param>
		/// <param name="center">Vector3 con las coordenadas sobre las que se va a realizar el giro.</param>
		/// <returns>Matriz de transformación de un giro en torno a un punto en el espacio bidimensional.</returns>
		public static Vector2 TwistVector2AroundPoint2D(Vector2 point2d, float degrees, Vector2 center)
		{			
			//Mat4 ret;
			Vector3 v_center = new Vector3(center.X, center.Y, 0);
			Vector4 vtemp = new Vector4(point2d.X, point2d.Y, 0, 0);
			Mat4 m4 = MakeRotationMatrixZ(Tools.DegreesToRadians(degrees));
			Mat4 precam = MakeTraslationMatrix(-v_center);
			Mat4 poscam = MakeTraslationMatrix(v_center);
			
			Vector4 v3f = vtemp * (precam * m4 * poscam);
			return new Vector2(v3f.X, v3f.Y);
		}

		/// <summary>
		/// Metodo que devuelve una matriz de transformación de un giro en torno a un punto en el espacio Tridimensional.
		/// </summary>
		/// <param name="degreesX">Grados de giro en torno al centro en el eje X.</param>
		/// <param name="degreesY">Grados de giro en torno al centro en el eje Y.</param>
		/// <param name="degreesZ">Grados de giro en torno al centro en el eje Z.</param>
		/// <param name="center">Vector3 con las coordenadas sobre las que se va a realizar el giro.</param>
		/// <returns>Matriz de transformación de un giro en torno a un punto en el espacio Tridimensional.</returns>
		public static Mat4 TwistAroundPoint3D(float degreesX, float degreesY, float degreesZ, Vector3 center)
		{
			Mat4 m4x = MakeRotationMatrixX(Tools.DegreesToRadians(degreesX));
			Mat4 m4y = MakeRotationMatrixY(Tools.DegreesToRadians(degreesY));
			Mat4 m4z = MakeRotationMatrixZ(Tools.DegreesToRadians(degreesZ));
			Mat4 precam = MakeTraslationMatrix(-center);
			Mat4 poscam = MakeTraslationMatrix(center);
			return precam * m4x * m4y * m4z * poscam;
		}

		/// <summary>
		/// Metodo que trasforma un array de matrices de 4 dimensiones en un array de valores flotantes.
		/// </summary>
		/// <param name="m4s">Array de matrices a pasar a array de valores flotantes.</param>
		/// <returns>Array contenedos de todos los valores floatd e las matrices dadas.</returns>
		public static float[] Mat4ArrayToFloat(Mat4[] m4s)
		{
			Vector4[] RowsMatriz = new Vector4[m4s.Length];
			float[] ret = new float[RowsMatriz.Length*4];
			int contador = 0;
			for (int a = 0;a<m4s.Length;a++)
			{
				RowsMatriz[contador] = m4s[a].Column0;
				RowsMatriz[contador+1] = m4s[a].Column1;
				RowsMatriz[contador+2] = m4s[a].Column2;
				RowsMatriz[contador+3] = m4s[a].Column3;
				contador += 4;
			}
			contador = 0;
			for (int b=0;b<RowsMatriz.Length;b++)
			{
				ret[contador] = RowsMatriz[b].X;
				ret[contador+1] = RowsMatriz[b].Y;
				ret[contador+2] = RowsMatriz[b].Z;
				ret[contador+3] = RowsMatriz[b].W;
			}
			return ret;
		}
	}
}
