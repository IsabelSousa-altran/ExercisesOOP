using System;
using AbstractMethods_ResolvedExercise.Entities;
using AbstractMethods_ResolvedExercise.Entities.Enums;
using System.Collections.Generic;
using System.Globalization;

namespace AbstractMethods_ResolvedExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> listShapes = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int numberShapes = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberShapes; i++)
            {
                Console.WriteLine($"Shape #{i} data: ");

                Console.Write("Rectangle or circle (r/c)? ");
                char shape = Char.Parse(Console.ReadLine());

                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (shape == 'r' || shape == 'R')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Shape rectangle = new Rectangle(color, width, height);
                    listShapes.Add(rectangle);
                }
                else 
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Shape Circle = new Circle(color, radius);
                    listShapes.Add(Circle);
                }
            }

            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS: ");
            foreach (Shape item in listShapes)
            {
                Console.WriteLine(item.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
            
        }
    }
}
