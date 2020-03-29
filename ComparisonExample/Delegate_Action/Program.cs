using System;
using Delegate_Action.Entities;
using System.Collections.Generic;

namespace Delegate_Action
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            Action<Product> act = UpdatePrice;
            //Expressão lambda
            //Action<Product> act = p => { p.Price += p.Price * 0.1; };

            list.ForEach(act);
            foreach (Product item in list)
            {
                Console.WriteLine(item);
            }
        }

        static void UpdatePrice(Product product)
        {
            product.Price += product.Price * 0.1;
        }
    }
}
