using System;

namespace switch
{
	class switch
	{
		static void Main()
		{
			Console.WriteLine("Vul de dag van de week in om te zien welke les je hebt.");
			string invoer = Console.ReadLine();
			string uitvoer = "";

			switch (invoer)
			{
				case "maandag":
					{
						uitvoer = "C# lessen";
						break;
					}
				case "dinsdag":
					{
						uitvoer = "Project";
						break;
					}
				case "woensdag":
					{
						uitvoer = "Keuzedeel";
						break;
					}
				case "donderdag":
					{
						uitvoer = "HTLM-CSS";
						break;
					}
				case "vrijdag":
					{
						uitvoer = "Python";
						break;
					}
			}
			Console.WriteLine("Op " + invoer + " heb je " + uitvoer + ".");
			Console.ReadKey();
		}
	}
}