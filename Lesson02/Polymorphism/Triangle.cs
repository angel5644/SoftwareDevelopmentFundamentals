﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02.Polymorphism
{
    class Triangle : Polygon
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing: Triangle");
        }
    }
}
