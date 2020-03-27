using System;

namespace CondicionalTernaria
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco = 34.5;
            double desconto;

            if (preco < 20.0)
            {
                desconto = preco * 0.1;
            }
            else
            {
                desconto = preco * 0.05;
            }

            // representa o mesmo que o if else anterior
            // (Condição) ? valor se verdadeiro : valor se falso
            desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;
        }
    }
}
