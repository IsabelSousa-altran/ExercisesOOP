using System;
using System.Globalization;

namespace AlternativeSyntax_InitializingValues
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

            //Funciona mesmo que não existam construtores, 
            // mas caso exista um construtor com dois argumentos, este já dará errado. 
            //Nessa caso é necessário ter os dois construtores, um com os dois argumentos e outro com três.
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
