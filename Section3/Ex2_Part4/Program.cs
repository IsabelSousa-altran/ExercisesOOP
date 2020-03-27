using System;

namespace Ex2_Part4
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityNumbers;
            quantityNumbers = int.Parse(Console.ReadLine());
            int countIn = 0;
            int countOut = 0;

            for (int i = 0; i < quantityNumbers; i++)
            {
                int numbers = int.Parse(Console.ReadLine());

                if (numbers >= 10 && numbers <= 20)
                {
                    countIn++;
                }
                else
                {
                    countOut++;
                }
            }

            Console.WriteLine($"{countIn} in");
            Console.WriteLine($"{countOut} out");
        }
    }
}
