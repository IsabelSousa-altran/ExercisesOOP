using System;
using System.Globalization;

namespace ThisExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter product data:");

            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Product product = new Product(name, price);

            Product product1 = new Product();

            Product product2 = new Product
            {
                Name = "TV",
                Price = 500.00,
                StockQuantity = 20
            };

            Console.WriteLine();
            Console.WriteLine("Product Data: " + product);

            Console.WriteLine();
            Console.Write("Enter the number of products to be added to stock: ");
            int quantity = int.Parse(Console.ReadLine());
            product.AddProducts(quantity);

            Console.WriteLine();
            Console.WriteLine("Updated Data: " + product);

            Console.WriteLine();
            Console.Write("Enter the number of products to be removed from stock: ");
            quantity = int.Parse(Console.ReadLine());
            product.RemoveProducts(quantity);

            Console.WriteLine();
            Console.WriteLine("Updated Data: " + product);
        }
    }
}
