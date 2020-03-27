using System;

namespace Ex3_Part3
{
    class Program
    {
        static void Main(string[] args)
        {
            int code;
            int countAlcohol = 0;
            int countGasoline = 0;
            int countDiesel = 0;

            code = int.Parse(Console.ReadLine());

            while (code != 4)
            {
                if (code == 1)
                {
                    countAlcohol++;
                }
                else if (code == 2)
                {
                    countGasoline++;
                }
                else if (code == 3)
                {
                    countDiesel++;
                }
                

                code = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"THANK YOU");
            Console.WriteLine($"Alcohol: {countAlcohol}");
            Console.WriteLine($"Gasoline: {countGasoline}");
            Console.WriteLine($"Diesel: {countDiesel}");
        }
    }
}
