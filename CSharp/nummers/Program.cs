using System;
namespace Numbers 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // make arrays of numbers.
            int[] numbers = {10, 12, 13, 15};
            int[] numbers2 = { -12, -10, -5, 0, 1, 6, 8, 10 };
            double[] brokenNumbers = { 16.45, 18.98, 897.78, 12.11, 78976.78 };

            // get and print numbers from lists.
            Console.WriteLine("Het tweede nummer uit de Array nummers is " + numbers[1] + ".");
            Console.WriteLine("Het nummer " + brokenNumbers[0] + " is het eerste nummer uit de Array gebrokenGetallen.");
            Console.WriteLine(numbers2[3] + " is het vierde nummer uit de Array nummersTwee.");

            Console.ReadKey();
        }
    }
}
