using System;

namespace Matriz_ExerciseExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrizSize = int.Parse(Console.ReadLine());

            int[,] matriz = new int[matrizSize,matrizSize];

            for (int i = 0; i < matrizSize; i++)
            {
                string[] numbersMatriz = Console.ReadLine().Split(' ');

                for (int j = 0; j < matrizSize; j++)
                {
                    matriz[i, j] = int.Parse(numbersMatriz[j]); 
                }
            }

            Console.WriteLine("Main Diagonal: ");
            for (int i = 0; i < matrizSize; i++)
            {
                    Console.Write(matriz[i, i] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < matrizSize; i++)
            {
                for (int j = 0; j < matrizSize; j++)
                {
                    if (matriz[i,j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine($"Nugative Numbers = {count}");
        }
    }
}
