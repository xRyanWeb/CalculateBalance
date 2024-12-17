using System;

namespace App
{
    class App
    {
        static void Main(string[] args)
        {
            for (int? i = 0; i < 1; i++)
            {

                Console.WriteLine("Enter Current Balance 1: ");
                double price1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Current Balance 2: ");
                double price2 = Convert.ToDouble(Console.ReadLine());

                double calculation = (double)(double)(price1 - price2);

                Console.Write($"Your Final Balance is: ${Double.Round(calculation, 2, MidpointRounding.AwayFromZero)}");
                Console.ReadLine();

            }

        }
    }
}