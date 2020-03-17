using System;
using System.Globalization;

namespace FirstExercises02
{
    class Program
    {
        static void Main(string[] args)
        {
            double salaryMean = 0;

            Employee firstEmployee = new Employee();

            Console.WriteLine("First employee data: ");
            Console.Write("Name: ");
            firstEmployee.Name = Console.ReadLine();
            Console.Write("Salary: ");
            firstEmployee.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Employee secondEmployee = new Employee();

            Console.WriteLine("Second employee data: ");
            Console.Write("Name: ");
            secondEmployee.Name = Console.ReadLine();
            Console.Write("Salary: ");
            secondEmployee.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salaryMean = (firstEmployee.Salary + secondEmployee.Salary) / 2.0;

            Console.WriteLine($"Average Salary: {salaryMean.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
