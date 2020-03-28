using System;
using SpecialTopics.Extensions;

namespace SpecialTopics
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(2020, 03, 28, 8, 10, 45);
            Console.WriteLine(dateTime.ElapsedTime());
        }
    }
}
