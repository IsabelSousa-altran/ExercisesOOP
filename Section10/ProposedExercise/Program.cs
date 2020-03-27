using System;
using System.Globalization;
using System.Collections.Generic;
using ProposedExercise.Entities;

namespace ProposedExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int numberProducts = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberProducts; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or improved (c/u/i)? ");
                char typeProduct = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (typeProduct == 'u' || typeProduct == 'U')
                {
                    Console.Write("Manufacture date(MM/DD/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

                    Product productUsed = new UsedProduct(name, price, manufactureDate);
                    products.Add(productUsed);
                }
                else if (typeProduct == 'i' || typeProduct == 'I')
                {
                    Console.Write("Customs Fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Product productImported = new ImportedProducts(name, price, customsFee);
                    products.Add(productImported);
                }
                else
                {
                    Product product = new Product(name, price);
                    products.Add(product);
                }

            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            foreach (Product item in products)
            {
                Console.WriteLine(item.PriceTag());
            }
        }
    }
}
