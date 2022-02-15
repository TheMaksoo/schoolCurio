using System;

namespace AttractieChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                
                Console.WriteLine("\nWelkom bij attactie checker V82.423.51\n Kies uit de volgende attracties.\n1. Debug Hero\n2.Bugs of Horror\n3.Speedy XL\n4.Turbo Turn 2000'\n5. Stoppen");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    questions(out int age, out int weight, out int length);

                    if (age > 12 || length > 120)
                    {
                        Console.WriteLine("Je mag in Debug Hero!");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Je mag helaas niet in Debug hero.");
                    }

                }

                if (choice == "2")
                {
                    questions(out int age, out int weight, out int length);

                    if (age > 16 && weight < 95)
                    {
                        Console.WriteLine("Je mag in Bugs of Horror!");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Je mag helaas niet in Bugs of Horror.");
                    }

                }

                if (choice == "3")
                {
                    questions(out int age, out int weight, out int length);

                    if (length > 90 && weight < 120)
                    {
                        Console.WriteLine("Je mag in Speedy XL!");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Je mag helaas niet in Speedy XL.");
                    }

                }

                if (choice == "4")
                {
                    questions(out int age, out int weight, out int length);

                    if ((age > 12 && weight < 120) ||(length > 100 && weight < 120))
                    {
                        Console.WriteLine("Je mag in Turbo Turn 2000!");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Je mag helaas niet in Turbo Turn 2000.");
                    }

                }
                
                if (choice == "5")
                {
                    running = false;
                }

                static void questions(out int age, out int weight, out int length)
                {
                    Console.WriteLine("Leeftijd?");
                    age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Gewicht?");
                    weight = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Lengte?");
                    length = Convert.ToInt32(Console.ReadLine());
                    
                }

            }
        }
    }
}