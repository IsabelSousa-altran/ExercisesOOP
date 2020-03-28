using System;
using System.Collections.Generic;
using System.Text;

namespace ProposedExercised_Interface.Services
{
    interface ITaxService
    {
        double Tax(double amount);
        double Interest(double amount, int months);
    }
}
