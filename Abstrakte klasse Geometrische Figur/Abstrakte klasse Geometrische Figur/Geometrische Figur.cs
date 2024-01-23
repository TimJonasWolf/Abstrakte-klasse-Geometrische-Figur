using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakte_klasse_Geometrische_Figur
{
	internal abstract class Geometrische_Figur
	{
		public string Name { get; set; }
		public Geometrische_Figur(string name) 
		{
			Name = name;
		}
		public abstract double Flächenberechner();
		public abstract double Umfangberechnen();


	}
}
