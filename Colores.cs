using System;
using System.Drawing;

namespace Colores
{
	/// <summary>
	/// Summary description for Colores.
	/// </summary>
	public class Colores
	{
		string nombre;
		Color codigo;

		public Colores(string nombre,Color codigo)
		{
		this.nombre=nombre;
		this.codigo=codigo;
		}
		
		public string Nombre{
			get{return nombre;}
		}
		
		public Color Codigo{
			get{return codigo;}
		}
	}
}
