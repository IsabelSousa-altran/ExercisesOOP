using System;

namespace Ex3_Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D;
            int difference = 0;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());

            difference = (A * B - C * D);

            Console.WriteLine($"DIFFERENCE = {difference}");

        }
    }
}
