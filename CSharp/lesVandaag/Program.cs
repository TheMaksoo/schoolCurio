
DateTime now  = DateTime.Now;
string day = now.DayOfWeek.ToString();
string invoer = day;
string uitvoer = "";
string dag = "";

switch (invoer)
{
	case "Monday":
		{
			dag = "maandag";
			uitvoer = "C# lessen";
			break;
		}
	case "Tuesday":
		{
			dag = "dinsdag";
			uitvoer = "Project";
			break;
		}
	case "Wednesday":
		{
			dag = "woensdag";
			uitvoer = "Keuzedeel";
			break;
		}
	case "Thursday":
		{
			dag = "donderdag";
			uitvoer = "HTLM-CSS";
			break;
		}
	case "Friday":
		{
			dag = "vrijdag";
			uitvoer = "Python";
			break;
		}
}
Console.WriteLine("Op " + dag + " heb je " + uitvoer + ".");
Console.ReadKey();