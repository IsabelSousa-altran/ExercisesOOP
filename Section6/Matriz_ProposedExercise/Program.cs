using System;

namespace Matriz_ProposedExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] matrizSize = Console.ReadLine().Split(' ');

            int lines = int.Parse(matrizSize[0]);
            int rows = int.Parse(matrizSize[1]);

            int[,] matrizNumbers = new int[lines, rows];

            for (int i = 0; i < lines; i++)
            {
                matrizSize = Console.ReadLine().Split(' ');

                for (int j = 0; j < rows; j++)
                {
                    matrizNumbers[i, j] = int.Parse(matrizSize[j]);
                }
            }

            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (matrizNumbers[i,j] == 8)
                    {
                        Console.WriteLine($"Position {i},{j}");
                        if (j > 0)
                        {
                            Console.WriteLine($"Left: {matrizNumbers[i, j - 1]}");
                        }
                        if (i > 0)
                        {
                            Console.WriteLine($"Up: {matrizNumbers[i - 1, j]}");
                        }
                        if (j < rows - 1)
                        {
                            Console.WriteLine($"Right: {matrizNumbers[i, j + 1]}");
                        }
                        if (i < lines - 1)
                        {
                            Console.WriteLine($"Down: {matrizNumbers[i + 1, j]}");
                        }
                    }
                }
            }
        }
    }
}
