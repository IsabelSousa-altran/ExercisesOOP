using System;
using System.IO;

namespace File_FileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            // coloca-se o '@' para não ser necessário colocar as barras no diretório
            string sourcePath = @"C:\Users\isantossousa\Documents\Altran\FF\Academia\FicheiroSeccao13\file1.txt";
            string targetPath = @"C:\Users\isantossousa\Documents\Altran\FF\Academia\FicheiroSeccao13\file2.txt";

            try
            {
                // Vai ao ficheiro e copia todas as linhas para um segundo ficheiro
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);

                //Lê todas as linhas que estão no primeiro ficheiro
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e )
            {
                Console.WriteLine("An error accurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
