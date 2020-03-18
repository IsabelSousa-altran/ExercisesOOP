using System;
using System.Globalization;

namespace ProposedExercised01_Section5
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account;

            Console.Write("Enter the account number: ");
            int accountNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the account older: ");
            string name = Console.ReadLine();

            Console.Write("Will there be an initial deposit? (Y/N) ");
            char answer = char.Parse(Console.ReadLine());

            if (answer == 'Y' || answer == 'y')
            {
                Console.Write("Enter the initial deposit amount: ");
                double initialDeposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                account = new Account(accountNumber, name, initialDeposit);
            }
            else
            {
                account = new Account(accountNumber, name);
            }

            Console.WriteLine();
            Console.WriteLine("Account Data: ");
            Console.WriteLine(account);

            Console.WriteLine();
            Console.Write("Enter a deposit amount: ");
            double deposit = double.Parse(Console.ReadLine());
            account.AddDeposit(deposit);

            Console.WriteLine("Account details updated: ");
            Console.WriteLine(account);

            Console.WriteLine();
            Console.Write("Enter a value to withdraw: ");
            double withdraw = double.Parse(Console.ReadLine());
            account.Withdraw(withdraw);

            Console.WriteLine("Account details updated: ");
            Console.WriteLine(account);

        }
    }
}
