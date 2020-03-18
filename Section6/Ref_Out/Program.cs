using System;

namespace Ref_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            // ref - faz o parâmtro ser uma referência para a variável original
         /* int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a); */

            // Out - Semelhante ao REF mas não exige que a variável seja iniciada
            int a = 10;
            int triple;
            Calculator.Triple(a, out triple);
            Console.WriteLine(triple);


        }
    }
}
