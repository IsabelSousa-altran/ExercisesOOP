using System;
using System.IO;
using ProposedExercise_Archives.Entities;
using System.Globalization;

namespace ProposedExercise_Archives
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\isantossousa\Documents\Altran\FF\Academia\OOPCourseTeorics\Seccao13\ItemsVendidos.csv";

            try
            {

                string[] lines = File.ReadAllLines(sourcePath);

                string sourceFolderPath = Path.GetDirectoryName(sourcePath);

                string targetFolderPath = sourceFolderPath + @"\out";
                string targetFilePath = targetFolderPath + @"\summary.csv";

                //vai criar um segundo ficheiro que vai conter a mesma coisa que o primeiro mas com todas as letras maiusculas
                using (StreamWriter streamWriter = File.AppendText(targetFilePath))
                {
                    foreach (string line in lines)
                    {
                        string[] fields = line.Split(',');
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);

                        Product prod = new Product(name, price, quantity);

                        streamWriter.WriteLine(prod.Name + "," + prod.TotalPrice().ToString("F2", CultureInfo.InvariantCulture));
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
