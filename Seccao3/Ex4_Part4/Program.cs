using System;
using System.Globalization;

namespace Ex4_Part4
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityNumbers;
            quantityNumbers = int.Parse(Console.ReadLine());
            double divison = 0;

            for (int i = 0; i < quantityNumbers; i++)
            {
                string[] numbers = Console.ReadLine().Split(' ');

                double value1 = double.Parse(numbers[0]);
                double value2 = double.Parse(numbers[1]);

                if (value2 != 0)
                {
                    divison = value1 / value2;
                    Console.WriteLine(divison.ToString("F1", CultureInfo.InvariantCulture));
                }
                else
                {
                    Console.WriteLine("Division Impossible");
                }
                
            }
        }
    }
}
