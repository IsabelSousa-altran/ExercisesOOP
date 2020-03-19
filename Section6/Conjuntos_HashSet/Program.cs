using System;
using System.Collections.Generic;

namespace Conjuntos_HashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();

            A.Add(3);
            A.Add(5);
            A.Add(8);
            A.Add(9);

            B.Add(3);
            B.Add(4);
            B.Add(5);
            B.Add(7);

            // Não faz repetição de valores, nas listas é possível respetir nos conjuntos não
            // B.Add(4); 

            // Conjunto não tem posição, por isso para mostrar todos os 
            // valores no conjunto é obrigatório usar o foreach
            foreach (int x in B)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("Digite um valor inteiro: ");
            int N = int.Parse(Console.ReadLine());

            if (B.Contains(N))
            {
                Console.WriteLine($"{N} pertence ao conjunto B");
            }
            else
            {
                Console.WriteLine($"{N} não pertence ao conjunto B");
            }

            // Diferença entre conjuntos - Remove do conjunto A todos os iguais ao conjunto B
            A.ExceptWith(B);
            foreach (int x in A)
            {
                Console.WriteLine(x);
            }

            B.Remove(7);


        }
    }
}
