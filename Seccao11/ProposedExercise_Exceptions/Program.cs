using System;
using ProposedExercise_Exceptions.Entities.Exceptions;
using ProposedExercise_Exceptions.Entities;
using System.Globalization;

namespace ProposedExercise_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
			
			Console.WriteLine("Enter account data");
			Console.Write("Number: ");
			int number = int.Parse(Console.ReadLine());
			Console.Write("Holder: ");
			string name = Console.ReadLine();
			Console.Write("Initial balance: ");
			double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			Console.Write("Withdraw Limit: ");
			double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			Account account = new Account(number, name, balance, withdrawLimit);

			Console.WriteLine();
			Console.Write("Enter amount for withdraw: ");
			double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			try
			{
				account.Withdraw(withdraw);

				Console.WriteLine("New balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
			}
			catch (DomainException e )
			{

				Console.WriteLine("Withdraw error: " + e.Message);
			}
        }
    }
}
