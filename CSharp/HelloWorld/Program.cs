using System;

namespace MiljonairsQuiz
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            
            while (running)
            { 
                string question = "Jouw antwoord?";
                Console.WriteLine("Welkom bij de Miljonairs Quiz!");
                Console.WriteLine("Vraag 1");
                Console.WriteLine("Wat is C#\n" + "a. Spaans bedrijf\n" + "b. Programmeertaal\n" + "c. Computer\n" + "d. Website op het internet\n");
                Console.WriteLine(question);
                string answer;
                answer = Console.ReadLine();

                if (answer != "b")
                {
                    wrongAwnser();
                    continue;
                }
           
                
                Console.WriteLine("Vraag 2");
                Console.WriteLine("Hoe vergelijk je een programmeertaal\n" + "a. Loop\n" + "b. Funcite\n" + "c. If-statement\n" + "d. Methode\n");
                Console.WriteLine(question);
                answer = Console.ReadLine();

                if (answer != "c")
                {
                    wrongAwnser();
                    continue;
                }
           

                Console.WriteLine("Vraag 3");
                Console.WriteLine("Hoe herhaal je in een programmeertaal\n" + "a. Loop\n" + "b. Funcite\n" + "c. Herhaal\n" + "d. Return\n");
                Console.WriteLine(question);
                answer = Console.ReadLine();

                if (answer != "a")
                {
                    wrongAwnser();
                    continue;
                }
            

                Console.WriteLine("Vraag 4");
                Console.WriteLine("Wie was een hoofdachitect bij de ontwikkeling van C#\n" + "a. Bill Gates\n" + "b. Tim Lutt\n" + "c. Anders Heijsberg\n" + "d. Steve Jobs\n");
                Console.WriteLine(question);
                answer = Console.ReadLine();

                if (answer != "c")
                {
                    wrongAwnser();
                    continue;
                }
           

                Console.WriteLine("Vraag 5");
                Console.WriteLine("Wat kun je niet met C# maken\n" + "a. Mobiele apps\n" + "b. Desktoapplicaties\n" + "c. Webapplicaties\n" + "d. Frietje met mayo om op te eten\n");
                Console.WriteLine(question);
                answer = Console.ReadLine();

                if (answer != "d")
                {
                    wrongAwnser();
                    continue;
                }

                Console.WriteLine("Goed gedaan! Je hebt alle vragen goed beantwoord :)");
                Console.WriteLine("Wil je afsluiten?");
                string close = Console.ReadLine();
                if (close == "ja")
                {
                    running = false;
                }
            }
            
            static async void wrongAwnser()
            {
                Console.WriteLine("Dat is helaas niet het goede antwoord!");
                Console.WriteLine();
                Console.WriteLine("De Quiz begint nu opnieuw...");
                Thread.Sleep(500);
                
            }
            
        }
    }



}
