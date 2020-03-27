using System.Globalization;

namespace ProposedExercised01_Section5
{
    class Account
    {
        private int numberAccount { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }

        public Account(int numberAccount, string name)
        {
            this.numberAccount = numberAccount;
            Name = name;
        }

        public Account(int numberAccount, string name, double balance) : this(numberAccount, name)
        {
            Balance = balance;
        }

        public double AddDeposit(double deposit)
        {
            return Balance += deposit;
        }

        public double Withdraw(double withdraw)
        {
            return Balance -= withdraw + 5.00;
        }

        public override string ToString()
        {
            return "Account "
                + numberAccount 
                + ", Older: "
                + Name
                + ", Balance: $ "
                + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
