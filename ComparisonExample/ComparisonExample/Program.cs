using System;
using ComparisonExample.Entities;
using System.Collections.Generic;

namespace ComparisonExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> listProducts = new List<Product>();

            listProducts.Add(new Product("TV", 900.00));
            listProducts.Add(new Product("Notebook", 1200.00));
            listProducts.Add(new Product("Tablet", 450.00));

            listProducts.Sort(CompareProducts);

            foreach (Product item in listProducts)
            {
                Console.WriteLine(item);
            }

            //Delegate
            static int CompareProducts(Product product1, Product product2)
            {
                return product1.Name.ToUpper().CompareTo(product2.Name.ToUpper());
            }
        }
    }
}
