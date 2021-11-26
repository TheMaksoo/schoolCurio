
DateTime now  = DateTime.Now;
string day = now.DayOfWeek.ToString();
string invoer = day;
string uitvoer = "";

switch (invoer)
{
	case "Monday":
		{
			uitvoer = "C# lessen";
			break;
		}
	case "Tuesday":
		{
			uitvoer = "Project";
			break;
		}
	case "Wednesday":
		{
			uitvoer = "Keuzedeel";
			break;
		}
	case "Thursday":
		{
			uitvoer = "HTLM-CSS";
			break;
		}
	case "Friday":
		{
			uitvoer = "Python";
			break;
		}
}
Console.WriteLine("Op " + invoer + " heb je " + uitvoer + ".");
Console.ReadKey();