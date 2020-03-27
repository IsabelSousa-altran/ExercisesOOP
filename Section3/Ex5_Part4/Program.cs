using System;

namespace Ex5_Part4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());
            int factorial = 1;


            for (int i = 1; i <= N; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine(factorial);
        }
    }
}
