using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02.Inheritance.Sealed
{
    sealed class Rectangle : Polygon
    {
        sealed public override double GetArea()
        {
            return base.Length * base.Width;
        }
    }
}
