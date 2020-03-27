using System;
using System.Collections.Generic;
using System.Text;

namespace Override__Virtual_Base.Entities
{
    //Sealed não permite que outras classes herdem desta classe
    sealed class SavingsAccount : Account
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
        // sealed - só é possivel selar métodos override e isto impede que sejam subescritos novamente
        public sealed override void Withdraw(double amount)
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
