using System;
using System.Globalization;
using ProposedExercised_Interface.Entities;
using ProposedExercised_Interface.Services;

namespace ProposedExercised_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number:");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (MM/dd/yyyy):");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, contractValue);

            ContractService contractService = new ContractService(new PaypalTaxService());
            contractService.ProcessContract(contract, months);

            Console.WriteLine("Installments:");
            foreach (Installment item in contract.Installments)
            {
                Console.WriteLine(item);
            }
        }
    }
}
