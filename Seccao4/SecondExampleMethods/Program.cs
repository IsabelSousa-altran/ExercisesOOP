using System;

namespace SecondExampleMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();

            Console.WriteLine("First employee data: ");
            Console.Write("Name: ");
            product.Name = Console.ReadLine();
            Console.Write("Price: ");
            product.Price = double.Parse(Console.ReadLine());
            Console.Write("Quantity in stock: ");
            product.StockQuantity = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"Product Data: {product}");

            Console.WriteLine();
            Console.Write("Enter the number of products to be added: ");
            int quantity = int.Parse(Console.ReadLine());
            product.AddProduct(quantity);

            Console.WriteLine();
            Console.WriteLine($"Updated Data: {product}");

            Console.WriteLine();
            Console.Write("Enter the number of products to be removed: ");
            quantity = int.Parse(Console.ReadLine());
            product.RemoveProduct(quantity);

            Console.WriteLine();
            Console.WriteLine($"Updated Data: {product}");
        }
    }
}
