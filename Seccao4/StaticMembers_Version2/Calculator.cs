using System;
using System.Collections.Generic;
using System.Text;

namespace StaticMembers_Version2
{
    class Calculator
    {
        public double Pi = 3.14;

        public double Circumference(double r) 
        { 
            return 2.0 * Pi * r; 
        }

        public double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * r * r * r;
        }
    }
}
