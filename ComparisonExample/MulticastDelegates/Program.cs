using System;
using MulticastDelegates.Services;

namespace MulticastDelegates
{
    delegate void BinaryNumericOperations(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperations op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;

            op.Invoke(a, b);

        }
    }
}
