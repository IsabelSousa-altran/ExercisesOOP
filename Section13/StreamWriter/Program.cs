using System;
using System.IO;

namespace StreamWriter_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\isantossousa\Documents\Altran\FF\Academia\FicheiroSeccao13\file1.txt";
            string targetPath = @"C:\Users\isantossousa\Documents\Altran\FF\Academia\FicheiroSeccao13\file2.txt";

            try
            {
                // lê todas as linhas do ficheiro
                string[] lines = File.ReadAllLines(sourcePath);

                //vai criar um segundo ficheiro que vai conter a mesma coisa que o primeiro mas com todas as letras maiusculas
                using (StreamWriter streamWriter = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        streamWriter.WriteLine(line.ToUpper());
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
