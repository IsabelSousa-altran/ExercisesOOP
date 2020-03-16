using System;
using System.Globalization;

namespace Ex6_Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C;
            double triangle = 0;
            double circle = 0;
            double trapeze = 0;
            double square = 0;
            double rectangle = 0;

            string[] values = Console.ReadLine().Split(' ');

            A = double.Parse(values[0],CultureInfo.InvariantCulture);
            B = double.Parse(values[1], CultureInfo.InvariantCulture);
            C = double.Parse(values[2], CultureInfo.InvariantCulture);

            triangle = (A * C) / 2;
            circle = 3.14159 * Math.Pow(C, 2);
            trapeze = ((A + B) * C) / 2;
            square = B * B;
            rectangle = A * B;

            Console.WriteLine($"TRIANGLE: {triangle.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"CIRCLE: {circle.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"TRAPEZE: {trapeze.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"SQUARE: {square.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"RECTANGLE: {rectangle.ToString("F3", CultureInfo.InvariantCulture)}");

        }
    }
}
