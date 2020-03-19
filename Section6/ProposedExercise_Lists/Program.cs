using System;
using System.Collections.Generic;
using System.Globalization;

namespace ProposedExercise_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int numberEmployees = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for (int i = 1; i <= numberEmployees; i++)
            {
                Console.WriteLine($"Employee #{i}:");

                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                employees.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int idIncreaseSalary = int.Parse(Console.ReadLine());

            Employee employee = employees.Find(X => X.Id == idIncreaseSalary);

            if (employee != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.CurrentCulture);
                employee.IncreasedSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees: ");
            foreach (Employee employee1 in employees)
            {
                Console.WriteLine(employee1);
            }
        }
    }
}
