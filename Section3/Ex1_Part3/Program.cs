using System;

namespace Ex1_Part3
{
    class Program
    {
        static void Main(string[] args)
        {
            int password;

            password = int.Parse(Console.ReadLine());

            while (password != 2002)
            {
                Console.WriteLine("Wrong Password"); 
                password = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Correct Password");
        }
    }
}
