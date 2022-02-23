using AbboChecker;
var abonnements = AbonnementenLijst.HaalAbonnementenOp();

bool isRunning = true;



while(isRunning)
{
    Console.Clear();
    Console.WriteLine("1. Toon de gemiddelde leeftijd van alle abonnementhouders.");
    Console.WriteLine("2. Toon alle abonnementen van het type 'Regulier' die nog niet zijn betaald.");
    Console.WriteLine("3. Toon het aantal abonnementen van de mederwerkers van het type 'Abbo XL' die nog niet zijn betaald vermeld ook de gemmiddelde leeftijd van deze mederwerkers.");
    Console.WriteLine("4. Verleng alle automatische abonnementen die zijn verlopen (>360dgn) en verhoog de prijs met X%.");
    Console.WriteLine("5. Verleng alle automatische abonnementen die van een 65+'er of de medewerker zijn en geef X% korting, dit geld ook voor nog niet verlopem abonnementen.");
    string Answer = Console.ReadLine();


    // Average age.
    if (Answer == "1")
    {
        int average = Convert.ToInt32(abonnements.Average(a => a.Leeftijd));
        Console.WriteLine("Gemmiddelde leeftijd: " + average);
    }

    // list abbo not paid.
    if (Answer == "2")
    {
        string notPaid;
        notPaid = "onbetaalde regulieren abbonnementen.\n";
        foreach (var abbo in abonnements)
        {
            if (abbo.IsBetaald == false && abbo.Type == "Regulier" )
            {
                notPaid += ($"{abbo.Nummer}\n");
            }
            
        }
        Console.WriteLine(notPaid);
    }

    // abbo xl age
    if (Answer == "3")
    {
        
        string abboXL = "Onbetaalde Abbo XL abonnomenten.\n";
        int i = 0;
        int averagehealth = 0;

        foreach (var abbo in abonnements)
        {
            if (!abbo.IsBetaald && abbo.Type == "Abbo XL" && abbo.IsMedewerker == true)
            {
                i++;
                averagehealth += abbo.Leeftijd;
                abboXL += ($"{abbo.Nummer}\n");
            }
        }
        averagehealth = averagehealth / i;
        Console.WriteLine(abboXL);
        Console.WriteLine($"Gemmidelde leeftijd: {averagehealth} over {i} abonnomenten.");

    }

    // expensive shizzle
    if (Answer == "4")
    {
        Console.WriteLine("met hoeveel % wilt u de prijs verhogen?");
        uint percentage = Convert.ToUInt16(Console.ReadLine());

        
        foreach (var abbo in abonnements)
        {
            if(abbo.HeeftAutomatischVerlengen == true && abbo.AantalDagenOud > 360)
            {
                abbo.AantalDagenOud = 0;
                double newprice = (abbo.Prijs / 100 ) * (100 + percentage);
                Console.WriteLine($"Abonnement {abbo.Nummer} verlengd (van {abbo.Prijs} naar {Math.Round(newprice, 2)})");
                abbo.Prijs = Math.Round(newprice, 2);
            }

        }
    }

    // korting
    if (Answer == "5")
    {
        Console.WriteLine("met hoeveel % wilt u de prijs verhogen?");
        uint percentage = Convert.ToUInt16(Console.ReadLine());


        foreach (var abbo in abonnements)
        {
            if (abbo.HeeftAutomatischVerlengen == true )
            {
                if ( abbo.Leeftijd > 65 || abbo.IsMedewerker == true)
                { 
                    abbo.AantalDagenOud = 0;
                    double newprice = abbo.Prijs - ((abbo.Prijs / 100) * percentage);
                    Console.WriteLine($"Abonnement {abbo.Nummer} verlengd (van {abbo.Prijs} naar {Math.Round(newprice, 2)})");
                    abbo.Prijs = Math.Round(newprice, 2);
                }
            }
        }
    }

    // SCRHIJF HIER JE EIGEN CODE


    Console.WriteLine("Wilt u afsluiten? Ja / Nee");
    string closeAnswer = Console.ReadLine();
    if (closeAnswer == "Ja" || closeAnswer == "ja")
    {
        isRunning = false;
    }

}

