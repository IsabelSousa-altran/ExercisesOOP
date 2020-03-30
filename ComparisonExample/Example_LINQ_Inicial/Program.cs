﻿using System;
using System.Linq;

namespace Example_LINQ_Inicial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Specify the data source
            int[] numbers = new int[] { 2, 3, 4, 5 };

            // Define the query expression
            // IEnumerable<int> result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);
            var result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            // Execute the query
            foreach (int item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
