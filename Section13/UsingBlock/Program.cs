using System;
using System.IO;

namespace UsingBlock
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\isantossousa\Documents\Altran\FF\Academia\FicheiroSeccao13\file1.txt";

            try
            {
                
                // Tudo o que colocar neste bloco, vai ser executado. Quando o bloco terminar, o recurso é fechado 
                using (StreamReader streamReader = File.OpenText(path))
                {
                    while (!streamReader.EndOfStream)
                    {
                        string line = streamReader.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }


            /*
             * Realiza a emsma coisa que o código de cima
             string path = @"C:\Users\isantossousa\Documents\Altran\FF\Academia\FicheiroSeccao13\filex.txt";

            try
            {
                using (FileStream fileStream = new FileStream(path, FileMode.Open))
                {
                    // Tudo o que colocar neste bloco, vai ser executado. Quando o bloco terminar, o recurso é fechado 
                    using (StreamReader streamReader = new StreamReader(fileStream))
                    {
                        while (!streamReader.EndOfStream)
                        {
                            string line = streamReader.ReadLine();
                            Console.WriteLine(line);
                        }
                    }

                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
             */
        }
    }
}
