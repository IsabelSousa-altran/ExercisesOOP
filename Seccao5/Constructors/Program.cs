using System;
using System.Globalization;

namespace Constructors
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
            Console.Write("Quantity in stock: "); 
            int stockQuantity = int.Parse(Console.ReadLine());

            Product product = new Product(name, price, stockQuantity);

            Console.WriteLine(); 
            Console.WriteLine("Product Data: " + product);

            Console.WriteLine(); 
            Console.Write("Enter the number of products to be added to stock: "); 
            int quantity = int.Parse(Console.ReadLine()); product.AddProducts(quantity);

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
