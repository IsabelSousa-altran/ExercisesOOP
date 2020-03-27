using System;
using System.Globalization;

namespace ProposedExercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            Console.Write("Student Name: ");
            student.Name = Console.ReadLine();

            Console.WriteLine("Enter the student's three grades: ");
            student.FirstTrimester = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            student.SecondTrimester = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            student.ThirdTrimester = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Final grade = {student.FinalGrade().ToString("F2", CultureInfo.InvariantCulture)}");

            if (student.ApprovedOrNotApproved())
            {
                Console.WriteLine("APPROVED");
            }
            else 
            {
                Console.WriteLine("NOT APPROVED");
                Console.WriteLine($"{student.MissingPoints().ToString("F2", CultureInfo.InvariantCulture)} points left");
            }

        }
    }
}
