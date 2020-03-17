using System;
using System.Collections.Generic;
using System.Text;

namespace ProposedExercise01
{
    class Rectangle
    {
        public double Width;
        public double Height;

        public double Area()
        {
            return Width * Height;
        }

        public double Perimeter()
        {
            return (Width * 2) + (Height * 2);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Width, 2) + Math.Pow(Height, 2));
        }
    }
}
