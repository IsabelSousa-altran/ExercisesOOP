using System;
using System.Linq;
using System.Collections.Generic;
using LINQ_SQL.Entities;

namespace LINQ_SQL
{
    class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T item in collection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Category category1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category category2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category category3 = new Category() { Id = 3, Name = "Electronics", Tier = 1 };

            List<Product> products = new List<Product>()
            {
                new Product(){Id = 1, Name = "Computer", Price = 1100.0, Category = category2},
                new Product(){Id = 2, Name = "Hammer", Price = 90.0, Category = category1},
                new Product(){Id = 3, Name = "TV", Price = 1700.0, Category = category3},
                new Product(){Id = 4, Name = "Notebook", Price = 1300.0, Category = category2},
                new Product(){Id = 5, Name = "Saw", Price = 80.0, Category = category1},
                new Product(){Id = 6, Name = "Tablet", Price = 700.0, Category = category2},
                new Product(){Id = 7, Name = "Camera", Price = 700.0, Category = category3},
                new Product(){Id = 8, Name = "Printer", Price = 350.0, Category = category3},
                new Product(){Id = 9, Name = "Macbook", Price = 1800.0, Category = category2},
                new Product(){Id = 10, Name = "Sound Bar", Price = 700.0, Category = category3},
                new Product(){Id = 11, Name = "Level", Price = 70.0, Category = category1}
            };


            // var query1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);
            var query1 =
                from p in products
                where p.Category.Tier == 1 && p.Price < 900.0
                select p; 
            Print("TIER 1 AND PRICE < 900: ", query1);

            // var query2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            var query2 =
                from p in products
                where p.Category.Name == "Tools"
                select p.Name;
            Print("NAMES OF PRODUCTS FROM TOOLS: ", query2);

            // var query3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            var query3 =
                from p in products
                where p.Name[0] == 'C'
                select new
                {
                    p.Name,
                    p.Price,
                    CategoryName = p.Category.Name
                };
            Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT: ", query3);

            // var query4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            var query4 =
                from p in products
                where p.Category.Tier == 1
                orderby p.Name
                orderby p.Price
                select p;
           Print("TIER 1 ORDER BY PRICE THEN BY NAME: ", query4);

            // var query5 = query4.Skip(2).Take(4);
            var query5 = 
                (from p in query4
                 select p).Skip(2).Take(4);

            Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4: ", query5);

            // var query6 = products.First();
            // Neste caso e nos seguintes seria mais prático colocar o 'products diretamente'
            var query6 = (from p in query4
                          select p).First();
            Console.WriteLine("First test1: " + query6);

            //var query7 = products.Where(p => p.Price > 3000.0).First();
            // Se não existir um produto sob as condições pedidas se usarmos a query anterior é demostrada uma exceção.
            // Em vez de Firt(), utiliza-se FirstOrDefault() e retorna nulo
            // var query7 = products.Where(p => p.Price > 3000.0).FirstOrDefault();
            var query7 =
                (from p in products
                 where p.Price > 3000.0
                 select p).FirstOrDefault();
            Console.WriteLine("First test2: " + query7);
            Console.WriteLine();


            //var query17 = products.GroupBy(p => p.Category);
            var query17 =
                from p in products
                group p by p.Category;

            foreach (IGrouping<Category, Product> group in query17)
            {
                Console.WriteLine("Category " + group.Key.Name + ":");
                foreach (Product product in group)
                {
                    Console.WriteLine(product);
                }
                Console.WriteLine();
            }
        }
    }
}
