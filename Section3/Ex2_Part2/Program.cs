using System;

namespace Ex2_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            int evenOrOdd;

            evenOrOdd = int.Parse(Console.ReadLine());

            if (evenOrOdd % 2 == 0)
            {
                Console.WriteLine($"Even");
            }
            else
            {
                Console.WriteLine($"ODD");
            }
        }
    }
}
