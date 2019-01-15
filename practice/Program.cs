using System;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");

            string userInput = Console.ReadLine();

           string convertedInput = String.Format("{0:0.00}", userInput);

            double finalResult = Convert.ToDouble(convertedInput);

            Console.WriteLine(finalResult);

            Console.Read();

        }
    }
}
