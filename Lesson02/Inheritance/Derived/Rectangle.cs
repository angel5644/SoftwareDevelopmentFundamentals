using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02.Inheritance.Derived
{
    class Rectangle : Polygon
    {
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }
        public double GetArea()
        {
            return Width * Length;
        }
    }
}
