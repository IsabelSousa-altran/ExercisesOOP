using System;

namespace Ex2_Part3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] coordinates;
            int x, y;

            coordinates = Console.ReadLine().Split(' ');

            x = int.Parse(coordinates[0]);
            y = int.Parse(coordinates[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("First");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("Fourth");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Third");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Second");
                }

                coordinates = Console.ReadLine().Split(' ');

                x = int.Parse(coordinates[0]);
                y = int.Parse(coordinates[1]);
            }

            Console.WriteLine();
        }
    }
}
