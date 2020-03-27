using System;
using System.Globalization;

namespace Ex4_Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            double employeeNumber, WorkedHours, valuePerHour, salary;

            employeeNumber = double.Parse(Console.ReadLine());
            WorkedHours = double.Parse(Console.ReadLine());
            valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salary = WorkedHours * valuePerHour;

            Console.WriteLine($"Number = {employeeNumber}");
            Console.WriteLine($"Salary = U$ {salary.ToString("F2", CultureInfo.InvariantCulture)}");


        }
    }
}
