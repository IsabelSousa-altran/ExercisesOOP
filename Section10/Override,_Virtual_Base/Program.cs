using System;
using Override__Virtual_Base.Entities;

namespace Override__Virtual_Base
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account(1001, "Alex", 500.0);
            Account account2 = new SavingsAccount(1002, "Anna", 500.0, 10.0);

            account1.Withdraw(10.0);
            account2.Withdraw(10.0);

            Console.WriteLine(account1.Balance);
            Console.WriteLine(account2.Balance);

        }
    }
}
