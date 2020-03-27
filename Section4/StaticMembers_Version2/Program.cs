using System;
using System.Globalization;

namespace StaticMembers_Version2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.Write("Enter the radius value: "); 
            double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circ = calculator.Circumference(radius); 
            double volume = calculator.Volume(radius);

            Console.WriteLine("Circumference: " + circ.ToString("F2", CultureInfo.InvariantCulture)); 
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture)); 
            Console.WriteLine("Valor de PI: " + calculator.Pi.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
