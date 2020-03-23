using System;
using System.Globalization;
using System.Collections.Generic;
using ProposedExercise_AbstractMethods.Entities;

namespace ProposedExercise_AbstractMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> listTaxPayers = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");

                Console.Write("Individual or company (i/c)? ");
                char type = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                String name = Console.ReadLine();
                Console.Write("Anual income: ");

                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (type == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    TaxPayer individual = new Individual(name, income, healthExpenditures);
                    listTaxPayers.Add(individual);
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());

                    TaxPayer company = new Company(name, income, numberOfEmployees);
                    listTaxPayers.Add(company);
                }
            }

            double sum = 0.0;
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach (TaxPayer item in listTaxPayers)
            {
                double tax = item.Tax();
                Console.WriteLine(item.Name + ": $ " + tax.ToString("F2", CultureInfo.InvariantCulture));
                sum += tax;
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
