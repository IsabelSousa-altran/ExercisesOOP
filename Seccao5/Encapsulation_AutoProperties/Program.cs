using System;

namespace Encapsulation_AutoProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("Tv", 500.00, 10);

            product.Name = "T";

            Console.WriteLine(product.Name);
            Console.WriteLine(product.Price);
        }
    }
}
