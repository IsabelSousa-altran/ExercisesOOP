using System;
using System.Globalization;

namespace Ex2_Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius;
            double area = 0;

            radius = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            //area1 = Math.PI * Math.Pow(radius, 2);

            area = 3.14159 * radius * radius;

            Console.WriteLine($"A = {area.ToString("F4",CultureInfo.InvariantCulture)}");
       
        }
    }
}
