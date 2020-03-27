using System;
using ResolvedExercise_InheritagePolimorfism.Entities;
using System.Collections.Generic;
using System.Globalization;
namespace ResolvedExercise_InheritagePolimorfism
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("Enter the number of employees:");
            int numberEmployees = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberEmployees; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsourced (Y/n)? ");
                char answerOutsourced = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valueHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (answerOutsourced == 'y' || answerOutsourced == 'Y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Employee employeeOutsourced = new OutSourceEmployee(name, hours, valueHour, additionalCharge);

                    employees.Add(employeeOutsourced);
                }
                else
                {
                    Employee employee = new Employee(name, hours, valueHour);
                    employees.Add(employee);
                }
            }

            Console.WriteLine("PAYMENTS:");
            foreach (Employee item in employees)
            {
                Console.WriteLine($"{item.Name} - $ {item.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
