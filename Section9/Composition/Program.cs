using System;
using Composition.Entities;
using Composition.Entities.Enums;
using System.Globalization;

namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string department = Console.ReadLine();
            Department newDepartment = new Department(department);

            Console.WriteLine("Enter worker data: ");

            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            string level = Console.ReadLine();
            WorkerLevel workerLevel = Enum.Parse<WorkerLevel>(level);
            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Worker worker = new Worker
                (
                    name, 
                    workerLevel, 
                    baseSalary,
                    newDepartment
                );

            Console.Write("How many contracts to this worker? ");
            int numberContracts = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberContracts; i++)
            {
                Console.WriteLine($"Enter #{i} contract data: ");
                Console.Write("Date (MM/DD/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valueHour = double.Parse(Console.ReadLine());
                Console.Write("Duration (hours): ");
                int numberHours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract
                    (
                        date,
                        valueHour,
                        numberHours
                    );
                worker.AddContract(contract);
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthYear = Console.ReadLine();
            int month = int.Parse(monthYear.Substring(0, 2));
            int year = int.Parse(monthYear.Substring(3));

            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Department: {worker.Department.Name}");
            Console.WriteLine($"Income for {monthYear}: {worker.Income(year, month).ToString("F2",CultureInfo.InvariantCulture)}");




        }
    }
}
