


using Abstrakte_klasse_Geometrische_Figur;

while (true)
{
	try
	{
		Console.WriteLine();
		Console.WriteLine($"_____________Wahl_____________\n");
		Console.WriteLine($"\nWählen Sie bitte\n");

		Console.WriteLine($"\n Kreis Berechnen		(1)");
		Console.WriteLine($"\n Dreieck Berechnen		(2)");
		Console.WriteLine($"\n Programm beende		(0)");
        Console.WriteLine();
        Console.WriteLine($"______________________________\n");
		int wahl = Convert.ToInt32(Console.ReadLine());
		if (wahl == 0)
			break;
		switch (wahl)
		{
			case 1:
				Console.WriteLine($"_____________Kreis_____________\n");
				double r = 0;
				EingabeKreis(ref r);
				if (r <= 0) continue;
				Geometrische_Figur kreis = new Kreis(r);
				Console.WriteLine($"\nFläche der Kreis mit Radius{r} = {kreis.Flächenberechner()} ");
				Console.WriteLine($"\nUmfang der Kreis mit Radius{r} = {kreis.Umfangberechnen()} ");
				break;
			case 2:
				Console.WriteLine($"_____________Dreieck_____________\n");
				double a = 0, b = 0, c = 0, h = 0;
				EingabeDreieck(ref a, ref b, ref c, ref h);
				Geometrische_Figur dreieck = new Dreieck(a, b, c, h);
				Console.WriteLine($"\nFläche der Kreis mit Radius{a},{b},{c} und Höhe {h} ={dreieck.Flächenberechner()}");
				Console.WriteLine($"\nUmfang der Kreis mit Radius{a},{b},{c} und Höhe {h} = {dreieck.Umfangberechnen()} ");
				break;




		}


	}
	catch (Exception e)
	{
		Console.WriteLine(e.Message);
	}
	Console.ReadKey();
}
static void EingabeKreis(ref double radius)
{
	try
	{
		Console.WriteLine("Geben Sie den Radius ein :");
		radius = Convert.ToInt32(Console.ReadLine());
	}
	catch(Exception e)
	{
		Console.WriteLine(e.Message);
	}

}

static void EingabeDreieck(ref double a, ref double b, ref double c, ref double h)
{
	try
	{
		Console.WriteLine($"Geben Sie Seite A ein :");
		a = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine($"Geben Sie Seite B ein :");
		b = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine($"Geben Sie Seite C ein :");
		c = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine($"Geben Sie die Höhe ein :");
		h = Convert.ToInt32(Console.ReadLine());

	}
	catch(Exception e)
	{
		Console.WriteLine(e.Message);
	}
}
