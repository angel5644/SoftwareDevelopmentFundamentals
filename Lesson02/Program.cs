using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(10.0, 20.0);
            double area = rect.GetArea();

            Console.WriteLine("Area of rectangle: {0}", area);
        }
    }
}
