using System;
using DelegatesExample.Services;

namespace DelegatesExample
{
    delegate double BinaryNumericOperations(double n1, double n2);
    // não é possivel colocar o método square pois não coincide com o delegate criado anteriormente
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperations op = CalculationService.Sum;

           // double result = op(a, b);
            double result = op.Invoke(a, b);
            Console.WriteLine(result);
        }
    }
}
