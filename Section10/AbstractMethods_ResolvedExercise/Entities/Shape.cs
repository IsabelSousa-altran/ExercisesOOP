using System;
using System.Collections.Generic;
using AbstractMethods_ResolvedExercise.Entities.Enums;

namespace AbstractMethods_ResolvedExercise.Entities
{
    abstract class Shape
    {
        public Color color { get; set; }

        public Shape(Color color)
        {
            this.color = color;
        }

        public abstract double Area();
    }
}
