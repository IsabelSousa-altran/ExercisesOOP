using System;
using System.Collections.Generic;
using AbstractMethods_ResolvedExercise.Entities.Enums;

namespace AbstractMethods_ResolvedExercise.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(Color color, double radius) : base (color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
