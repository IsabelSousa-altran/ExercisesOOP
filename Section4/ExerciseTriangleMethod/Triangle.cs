using System;

namespace ExerciseTriangleMethod
{
    class Triangle
    {
        public double sideA;
        public double sideB;
        public double sideC;

        public double Area()
        {
            double p = (sideA + sideB + sideC) / 2.0; 
            return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        }
    }
}
