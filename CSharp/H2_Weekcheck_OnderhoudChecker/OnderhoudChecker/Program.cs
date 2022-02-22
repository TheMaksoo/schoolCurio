
var attracties = new List<Attractie>();

attracties.Add(new Attractie
{
    Naam = "Debug Hero",
    Soort = "Achtbaan",
    BezoekersPerJaar = 11000,
    LaatsteOnderhoud = 320
});
attracties.Add(new Attractie
{
    Naam = "Bugs of Horror",
    Soort = "Achtbaan",
    BezoekersPerJaar = 9900,
    LaatsteOnderhoud = 430
});
attracties.Add(new Attractie
{
    Naam = "Fun Splash",
    Soort = "water",
    BezoekersPerJaar = 20000,
    LaatsteOnderhoud = 100
});
attracties.Add(new Attractie
{
    Naam = "Turbo Turn 2000",
    Soort = "water",
    BezoekersPerJaar = 8500,
    LaatsteOnderhoud = 260
});
attracties.Add(new Attractie
{
    Naam = "Magic Programmer",
    Soort = "Darkride",
    BezoekersPerJaar = 12500,
    LaatsteOnderhoud = 85
});
attracties.Add(new Attractie
{
    Naam = "Kids Park",
    Soort = "Anders",
    BezoekersPerJaar = 2100,
    LaatsteOnderhoud = 600
});

bool running = true;
bool add = false;
Console.WriteLine("Wil je een nieuwe attractie toevoegen? ja/nee");
string awnser = Console.ReadLine();
awnser.ToLower();

if (awnser == "ja") 
{
    add = true;
}
while (running == true)
{ 
    if (add == false)
    {
        foreach (var a in attracties)
        {
            if (a.LaatsteOnderhoud >= 500)
            {
                Console.WriteLine($"{a.Naam}, {a.Soort}, Het laatste onderhoud is meer dan 500 dagen.");
                Console.ReadLine();
                Console.Clear();
                continue;
            }

            if (a.BezoekersPerJaar >= 10000 && a.LaatsteOnderhoud >= 300)
            {
                Console.WriteLine($"{a.Naam}, {a.Soort}, Er zijn meer dan 10.000 bezoekers per jaar en het laatste onderhoud is meed dan 300 dagen geleden.");
                Console.ReadLine();
                Console.Clear();
                continue;

            }

            if (a.Soort == "water" && a.LaatsteOnderhoud >= 200)
            {
                Console.WriteLine($"{a.Naam}, {a.Soort}, Het betreft een water-attractie en het laatste onderhoud is meer dan 200 dagen gelen.");
                Console.ReadLine();
                Console.Clear();
                continue;
            }
        }
        return;
    }
    else
    {
        Console.WriteLine("Naam nieuwe attractie.");
        string addnaam = Console.ReadLine();
        Console.WriteLine("Soort nieuwe attractie.");
        string addsoort = Console.ReadLine();
        Console.WriteLine("Bezoekers per jaar nieuwe attractie.");
        int addvisitor  = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Laatste onderhoud nieuwe attractie.");
        int addo = Convert.ToInt32(Console.ReadLine());

        attracties.Add(new Attractie
        {
            Naam = addnaam,
            Soort = addsoort,
            BezoekersPerJaar = addvisitor,
            LaatsteOnderhoud = addo
        });
        add = false;
    }
}