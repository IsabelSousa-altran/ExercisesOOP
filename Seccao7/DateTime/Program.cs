using System;
using System.Globalization;

namespace DateTimeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now; 
            DateTime d2 = DateTime.UtcNow; 
            DateTime d3 = DateTime.Today; 

            Console.WriteLine(d1); 
            Console.WriteLine(d2); 
            Console.WriteLine(d3);

            DateTime d4 = DateTime.Parse("2000-08-15"); 
            DateTime d5 = DateTime.Parse("2000-08-15 13:05:58"); 
            //DateTime d6 = DateTime.Parse("15/08/2000"); 
            //DateTime d7 = DateTime.Parse("15/08/2000 13:05:58"); 
            
            Console.WriteLine(d4); 
            Console.WriteLine(d5);
            //Console.WriteLine(d6); 
            //Console.WriteLine(d7);

            DateTime d8 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture); 
            DateTime d9 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture); 
            
            Console.WriteLine(d8);
            Console.WriteLine(d9);
        }
    }
}
