using System;
using UpCasting_Example.Entities;

namespace UpCasting_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(1001, "Alex", 0.0);
            BusinessAccount businessAccount = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            //UPCASTING
            Account account1 = businessAccount;
            Account account2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account account3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            //DOWNCASTING

            BusinessAccount account4 = (BusinessAccount)account2;
            account4.Loan(100.0);

            // Apesar de não dar erro, não é possível criar esta conta, pois o account3 é um savingsAccount
            //BusinessAccount account5 = (BusinessAccount)account3;

            // para testar se a conta é do tipo businessAccount
            if (account3 is BusinessAccount)
            {
                // Para fazer casting é possível também fazer com o operador as
                BusinessAccount account5 = account3 as BusinessAccount;
                //BusinessAccount account5 = (BusinessAccount)account3;
                account5.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if (account3 is SavingsAccount)
            {
                SavingsAccount account5 = (SavingsAccount)account3;
                account5.UpdateBalance();
                Console.WriteLine("Update!");
            }

            
        }
    }
}
