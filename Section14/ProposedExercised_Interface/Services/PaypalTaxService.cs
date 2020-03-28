using System;
using System.Collections.Generic;
using ProposedExercised_Interface.Entities;

namespace ProposedExercised_Interface.Services
{
    class PaypalTaxService : ITaxService
    {
        private const double FeePercentage = 0.02;
        private const double MonthlyInterest = 0.01;

        public double Interest(double amount, int months)
        {
            return amount * MonthlyInterest * months;
        }

        public double Tax(double amount)
        {
            return amount * FeePercentage;
        }
    }
}
