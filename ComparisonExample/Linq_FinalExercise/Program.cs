using System;
using System.IO;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using Linq_FinalExercise.Entities;

namespace Linq_FinalExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> listEmployees = new List<Employee>();

            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            using (StreamReader streamReader = File.OpenText(path))
            {
                while (!streamReader.EndOfStream)
                {
                    string[] fields = streamReader.ReadLine().Split(',');
                    string name = fields[0];
                    string email = fields[1];
                    double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                    listEmployees.Add(new Employee(name, email, salary));
                }
            }

            Console.Write("Enter salary: ");
            double newSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            var query = listEmployees.Where(p => p.Salary > newSalary).OrderBy(p => p.Email).Select(p => p.Email);
            Console.WriteLine($"Email of people whose salary is more than {newSalary.ToString("F2", CultureInfo.InvariantCulture)}: ");
            foreach (string item in query)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            
            var sum = listEmployees.Where(p => p.Name[0] == 'M').Sum(p => p.Salary);
            Console.WriteLine($"Sum of salary of peoplo whose name starts with 'M': {sum.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
