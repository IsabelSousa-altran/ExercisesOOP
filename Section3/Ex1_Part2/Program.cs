using System;

namespace Ex1_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            int negativeOrPositive;

            negativeOrPositive = int.Parse(Console.ReadLine());

            if (negativeOrPositive >= 0)
            {
                Console.WriteLine($"NOT NEGATIVE");
            }
            else
            {
                Console.WriteLine($"NEGATIVE");
            }
        }
    }
}
