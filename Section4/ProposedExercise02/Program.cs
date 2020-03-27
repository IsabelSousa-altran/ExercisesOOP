using System;
using System.Globalization;

namespace ProposedExercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            Console.Write("Name: ");
            employee.Name = Console.ReadLine();
            Console.Write("Gross Salary: ");
            employee.GrossSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Tax: ");
            employee.Tax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine($"Employee: {employee}");

            Console.WriteLine();
            Console.Write("Enter the percentage to increase the salary: ");
            double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            employee.IncreaseSalary(percentage);

            Console.WriteLine();
            Console.WriteLine($"Updated Data: {employee}");


        }
    }
}
