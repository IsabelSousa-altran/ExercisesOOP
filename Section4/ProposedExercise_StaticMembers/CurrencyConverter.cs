using System;
using System.Collections.Generic;
using System.Text;

namespace ProposedExercise_StaticMembers
{
    class CurrencyConverter
    {
        public static double DollarQuote;
        public static double DollarQuantity;
        public static double Iof = 6.0;

        public static double PaiedInReais()
        {
            double result = DollarQuote * DollarQuantity;
            return result + result * Iof / 100.0;
        }
    }
}
