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
            Console.Write("Name: ");
            product.StockQuantity = int.Parse(Console.ReadLine());

            Console.WriteLine($"Product Data: {product}");
        }
    }
}
