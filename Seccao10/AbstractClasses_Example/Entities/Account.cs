using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses_Example.Entities
{
    abstract class Account
    {
        public int Number { get; private set; }
        public string Holder { get; set; }
        public double Balance { get; protected set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        // Virtual - vai permitir que nas outras classes seja possivel criar um override deste método
        public virtual void Withdraw(double amount)
        {
            Balance -= amount + 5.0;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
