using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakte_klasse_Geometrische_Figur
{
	internal class Kreis : Geometrische_Figur
	{
		public double Radius { get; set; }
		public Kreis (double r) : base("")
		{
			Radius = r;
		}
		public override double Flächenberechner()
		{
			return Math.PI*Math.Pow(2, Radius);
		}
		public override double Umfangberechnen()
		{
			return 2 * Math.PI * Radius;
		}

	}
}
