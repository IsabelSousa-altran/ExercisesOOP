using System;
using System.Globalization;

namespace ExampleWithOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangleX, triangleY;

            triangleX = new Triangle();
            triangleY = new Triangle();

            Console.WriteLine("Enter the measures of the first triangle (X):");
            triangleX.sideA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            triangleX.sideB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            triangleX.sideC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Enter the measures of the second triangle (Y):");
            triangleY.sideA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            triangleY.sideB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            triangleY.sideC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (triangleX.sideA + triangleX.sideB + triangleX.sideC) / 2.0;
            double areaX = Math.Sqrt(p * (p - triangleX.sideA) * (p - triangleX.sideB) * (p - triangleX.sideC));

            p = (triangleY.sideA + triangleY.sideB + triangleY.sideC) / 2.0;
            double areaY = Math.Sqrt(p * (p - triangleY.sideA) * (p - triangleY.sideB) * (p - triangleY.sideC));

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
