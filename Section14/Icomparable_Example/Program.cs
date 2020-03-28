using System;
using System.IO;
using System.Collections.Generic;
using Icomparable_Example.Entities;

namespace Icomparable_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\isantossousa\Documents\Altran\FF\Academia\OOPCourseTeorics\Section14\in.txt";

            try
            {
                using (StreamReader streamReader = File.OpenText(path)) 
                {
                    List<Employee> list = new List<Employee>();
                    while (!streamReader.EndOfStream)
                    {
                        list.Add(new Employee(streamReader.ReadLine()));
                    }
                    list.Sort();
                    foreach (Employee item in list)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
