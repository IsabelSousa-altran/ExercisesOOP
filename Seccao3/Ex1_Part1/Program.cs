using System;

namespace Ex1_Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1, value2;
            int valuesSum = 0;

            value1 = int.Parse(Console.ReadLine());
            value2 = int.Parse(Console.ReadLine());

            valuesSum = value1 + value2;

            Console.WriteLine($"SUM = {valuesSum}");

        }
    }
}
