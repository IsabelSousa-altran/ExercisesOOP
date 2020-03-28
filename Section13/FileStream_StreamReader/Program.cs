using System.IO;
using System;

namespace FileStream_StreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\isantossousa\Documents\Altran\FF\Academia\FicheiroSeccao13\file1.txt";
            
            StreamReader streamReader = null;

            try
            {
                streamReader = File.OpenText(path);
                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An erros occurred");
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                if (streamReader != null) streamReader.Close();

            }

            /*
             * Faz o mesmo que o código acima, contudo o código está atualizado para imprimir todas as linhas e não apenas uma como este
            string path = @"C:\Users\isantossousa\Documents\Altran\FF\Academia\FicheiroSeccao13\file1.txt";
            FileStream fileStream = null;
            StreamReader streamReader = null;
            try
            {
                fileStream = new FileStream(path, FileMode.Open);
                streamReader = new StreamReader(fileStream);
                string line = streamReader.ReadLine();
                Console.WriteLine(line);
            }
            catch (IOException e)
            {
                Console.WriteLine("An erros occurred");
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                if (streamReader != null) streamReader.Close();
                if (fileStream != null) fileStream.Close();

            }
             */
        }
    }
}
