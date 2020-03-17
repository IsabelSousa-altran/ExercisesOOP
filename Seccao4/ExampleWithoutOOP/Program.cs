using System;
using System.Globalization;

namespace ExampleWithoutOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideA, sideB, sideC, anotherSideA, anotherSideB, anotherSideC;

            Console.WriteLine("Enter the measures of the first triangle (X):"); 
            sideA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
            sideB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
            sideC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Enter the measures of the second triangle (Y):"); 
            anotherSideA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
            anotherSideB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
            anotherSideC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (sideA + sideB + sideC) / 2.0; 
            double areaX = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));

            p = (anotherSideA + anotherSideB + anotherSideC) / 2.0; 
            double areaY = Math.Sqrt(p * (p - anotherSideA) * (p - anotherSideB) * (p - anotherSideC));

            Console.WriteLine("Area x = " + areaX.ToString("F4", CultureInfo.InvariantCulture)); 
            Console.WriteLine("Area y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY) 
            { 
                Console.WriteLine("Bigger area: X"); 
            } 
            else 
            { 
                Console.WriteLine("Bigger área: Y"); 
            }
        }
    }
}