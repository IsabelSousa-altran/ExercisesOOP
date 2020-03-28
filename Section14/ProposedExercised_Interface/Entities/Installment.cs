using System;
using System.Globalization;
using System.Text;

namespace ProposedExercised_Interface.Entities
{
    class Installment
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }

        public override string ToString()
        {
            return DueDate.ToString("MM/dd/yyyy")
                + " - "
                + Amount.ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
