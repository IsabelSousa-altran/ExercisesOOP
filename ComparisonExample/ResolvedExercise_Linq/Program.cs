using System;
using System.Collections.Generic;
using ResolvedExercise_Linq.Entities;
using System.IO;
using System.Linq;
using System.Globalization;

namespace ResolvedExercise_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter full file path: ");
            string path = Console.ReadLine();

            List<Product> listProducts = new List<Product>();

            using (StreamReader streamReader = File.OpenText(path))
            {
                while (!streamReader.EndOfStream)
                {
                    string[] fields = streamReader.ReadLine().Split(',');
                    string name = fields[0];
                    double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                    listProducts.Add(new Product(name, price));
                }
            }

            var avg = listProducts.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine($"Average price = {avg.ToString("F2", CultureInfo.InvariantCulture)}");

            var names = listProducts.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(P => P.Name);
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
