using System;
using System.Collections.Generic;
using InheritanceVSInterface_FinalExercise.Model.Enum;

namespace InheritanceVSInterface_FinalExercise.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
