using System;
using System.Globalization;

namespace Ex3_Part4
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityNumbers;
            quantityNumbers = int.Parse(Console.ReadLine());
            double mean = 0;

            for (int i = 0; i < quantityNumbers; i++)
            {
                string[] numbers = Console.ReadLine().Split(' ');

                double value1 = double.Parse(numbers[0]);
                double value2 = double.Parse(numbers[1]);
                double value3 = double.Parse(numbers[2]);

                mean = (value1 + value2 + value3) / 3;
                Console.WriteLine(mean.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
