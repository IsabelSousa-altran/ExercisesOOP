using System;
using System.IO;
using System.Collections.Generic;

namespace Directory_DirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\isantossousa\Documents\Altran\FF\Academia\FicheiroSeccao13";

            try
            {
                // vai retornar uma coleção contendo os strings correspondentes às pastas
                IEnumerable <string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS: ");
                foreach (string item in folders)
                {
                    Console.WriteLine(item);
                }

                // Todos os ficheiros
                Console.WriteLine();
                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES: ");
                foreach (string item in files)
                {
                    Console.WriteLine(item);
                }

                // criar nova pasta
                // As duas formas estão corretas
                Directory.CreateDirectory(path + "\\newfolder");
                Directory.CreateDirectory(@"C:\Users\isantossousa\Documents\Altran\FF\Academia\FicheiroSeccao13\newfolderTest");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
