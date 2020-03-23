using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses_Example.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        // Para aproveitar o método da classe principal e depois ainda retirar mais 2.
        public override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.0;

        }

        // Para escrever por cima da classe principal, neste caso não utiliza nada do método withdraw
        //public override void Withdraw(double amount)
        //{
        //    Balance -= amount;
        //}
    }
}
