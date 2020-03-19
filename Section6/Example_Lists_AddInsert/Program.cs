using System;
using System.Collections.Generic;

namespace Example_Lists_AddInsert
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Add("Pierre");
            list.Add("John");

            list.Insert(2, "Marco");

            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("List count: " + list.Count);

            // Encontrar o nome que inicia com a letra A
            // string s1 = list.Find(x => a[0] == 'A'); - Expressão lambda
            string s1 = list.Find(Test);
            Console.WriteLine("First 'A': " + s1);

            // Encontrar o nome que termina com a letra A
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);

            // Encontrar a posição do nome em que a primeira letra começa por A
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1);

            // Encontrar a posição do nome em que a ultima letra começa por A
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + pos2);

            // Filtrar a primeira lista  e colocar na segunda lista todos os nomes que tenham tamanho 5
            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("-------------------------------");
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            // Remove o nome que está na posição 3 da lista
            list.RemoveAt(3);
            Console.WriteLine("---------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            // Remove o Alex da lista
            list.Remove("Alex");
            Console.WriteLine("---------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            // Remove todos os nomes que começam por M
            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("----------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            // Elimina dois elementos a partir da posição 1
            list.RemoveRange(1, 2);
            Console.WriteLine("----------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
        }

        static bool Test(string s)
        {
            return s[0] == 'A';
        }
    }
}
