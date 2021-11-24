using System;
namespace HelloDeveloperLand
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vul aantal tosties:");
            int tosties = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Vul aantal Uitsmijters:");
            int uitsmijters = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Koffie:");
            int koffie = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Melk:");
            int melk = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Frisdrank:");
            int frisdrank = Convert.ToInt32(Console.ReadLine());

            double prijs = (tosties * 6.50) + (uitsmijters * 7.95) + (koffie * 2.25) + (melk * 2) + (frisdrank * 2.50);
            Console.WriteLine(prijs);

        }
    }
}