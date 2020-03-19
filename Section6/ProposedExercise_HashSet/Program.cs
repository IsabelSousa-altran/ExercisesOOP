using System;
using System.Collections.Generic;

namespace ProposedExercise_HashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> CourseA = new HashSet<int>();
            HashSet<int> CourseB = new HashSet<int>();
            HashSet<int> CourseC = new HashSet<int>();

            Console.Write("How many students does Course A have? ");
            int numberCourseA = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the students codes of the course A: ");
            for (int i = 0; i < numberCourseA; i++)
            {
                int studentNumber = int.Parse(Console.ReadLine());
                CourseA.Add(studentNumber);
            }

            Console.Write("How many students does Course B have? ");
            int numberCourseB = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the students codes of the course B: ");
            for (int i = 0; i < numberCourseB; i++)
            {
                int studentNumber = int.Parse(Console.ReadLine());
                CourseB.Add(studentNumber);
            }

            Console.Write("How many students does Course C have? ");
            int numberCourseC = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the students codes of the course C: ");
            for (int i = 0; i < numberCourseC; i++)
            {
                int studentNumber = int.Parse(Console.ReadLine());
                CourseC.Add(studentNumber);
            }

            CourseA.UnionWith(CourseB);
            CourseA.UnionWith(CourseC);

            int count = 0;
            foreach (int students in CourseA)
            {
                count++;
            }
            Console.WriteLine($"Total Students: {count}");
        }
    }
}
