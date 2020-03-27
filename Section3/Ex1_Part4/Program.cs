using System;

namespace Ex1_Part4
{
    class Program
    {
        static void Main(string[] args)
        {
            int odd;
            odd = int.Parse(Console.ReadLine());

            for (int i = 1; i <= odd; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
