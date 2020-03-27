using System;

namespace FirstExercises01
{
    class Program
    {
        static void Main(string[] args)
        {
            Person firstPerson = new Person();
            Person secondPerson = new Person();


            Console.WriteLine("First person data: ");
            Console.Write("Name: ");
            firstPerson.Name = Console.ReadLine();
            Console.Write("Age: ");
            firstPerson.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Second person data: ");
            Console.Write("Name: ");
            secondPerson.Name = Console.ReadLine();
            Console.Write("Age: ");
            secondPerson.Age = int.Parse(Console.ReadLine());

            if (firstPerson.Age > secondPerson.Age)
            {
                Console.WriteLine($"Older Person: {firstPerson.Name} ");
            }
            else
            {
                Console.WriteLine($"Older Person: {secondPerson.Name} ");
            }


        }
    }
}
