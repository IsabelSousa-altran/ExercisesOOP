using System;

namespace Ex7_Part4
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityLines;
            quantityLines = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quantityLines; i++)
            {
                Console.Write($"{i} ");
                Console.Write($"{i * i} ");
                Console.Write($"{i * i * i} ");
                Console.WriteLine();

            }
        }
    }
}
