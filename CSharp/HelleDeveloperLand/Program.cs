using System;
using System.Collections.Generic;
using System. Linq;
using System.Text;
using System. Threading.Tasks;

namespace HelloDeveloperLand
{ 
    class Program
    { 
        static void Main(string[] args)
        {
            string gebruikersNaam = Console.ReadLine();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Welkom in Developer Land " + gebruikersNaam + "!");
            Console.WriteLine("Het attractiepark voor ontwikkelaars van overde hele wereld.");
           
            Console.ReadKey();
        }
    }
}