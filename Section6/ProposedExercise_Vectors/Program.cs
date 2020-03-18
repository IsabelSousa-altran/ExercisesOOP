using System;

namespace ProposedExercise_Vectors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many rooms will be rented? ");
            int studentsNumber = int.Parse(Console.ReadLine());

            Student[] students = new Student[10];

            for (int i = 1; i <= studentsNumber; i++)
            {
                Console.WriteLine($"Rent #{i}: ");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int roomNumber = int.Parse(Console.ReadLine());

                Console.WriteLine();

                students[roomNumber] = new Student(name, email);
                
            }

            Console.WriteLine();
            Console.WriteLine("Busy rooms: ");
            for (int i = 0; i < 10; i++)
            {
                if (students[i] != null)
                {
                    Console.WriteLine($"{i}: {students[i]}");
                }
                
            }
            
           
        }
    }
}
