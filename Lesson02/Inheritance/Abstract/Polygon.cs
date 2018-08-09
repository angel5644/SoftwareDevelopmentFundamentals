using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02.Inheritance.Abstract
{
    abstract class Polygon
    {
        public double Length { get; protected set; }
        public double Width { get; protected set; }
        abstract public double GetArea();
    }

    /// <summary>
    /// Polygon class used to give an example of polymorphism
    /// </summary>
    class PolygonPolymor
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing: Polygon");
        }
    }
}
