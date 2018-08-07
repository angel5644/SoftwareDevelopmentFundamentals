using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowchart_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            Console.WriteLine("The factorial of {0} is {1}", n, Factorial(n));
        }

        private static int Factorial(int n)
        {
            int fact = 1;

            while (n > 1)
            {
                fact = fact * n;
                n--;
            }

            return fact;
        }
    }
}
