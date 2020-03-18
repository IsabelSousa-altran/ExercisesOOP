using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            // ? - nullable
            double? x = null;
            double? y = 10;

            // Se alguma das variáveis for nula altera esse valor para o estipulado
            double a = x ?? 5;
            double b = y ?? 5;

            
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
