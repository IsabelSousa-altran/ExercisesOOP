using System;
using System.Globalization;

namespace ProposedExercise_StaticMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the dollar quote? ");
            CurrencyConverter.DollarQuote = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("How many dollars will you buy? ");
            CurrencyConverter.DollarQuantity = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Amount to be paid in reais = {CurrencyConverter.PaiedInReais().ToString("F2", CultureInfo.InvariantCulture)} ");
        }
    }
}
