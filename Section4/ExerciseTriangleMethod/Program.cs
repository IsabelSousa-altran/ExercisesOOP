using System;
using System.Globalization;

namespace ExerciseTriangleMethod
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

            double areaX = triangleX.Area();
            double areaY = triangleY.Area();

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
