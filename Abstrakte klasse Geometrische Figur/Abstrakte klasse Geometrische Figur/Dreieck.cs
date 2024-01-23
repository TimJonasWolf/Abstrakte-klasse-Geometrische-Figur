using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakte_klasse_Geometrische_Figur
{
	internal class Dreieck : Geometrische_Figur
	{
		public double SeiteA { get; set; }
		public double SeiteB { get; set; }
		public double Grundseite { get; set; }
		public double höhe { get; set; }
		public Dreieck(double a, double b, double c, double h) : base("")
		{
			SeiteA = a;
			SeiteB = b;
			Grundseite = c;
			höhe = h;
		}
		public override double Flächenberechner()
		{
			return Grundseite * höhe / 2;
		}
		public override double Umfangberechnen()
		{
			return SeiteA + SeiteB + Grundseite;



		}
	}
}
