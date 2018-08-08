using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test: 20 - Result: 2
            int number = 2147483647;
            Console.WriteLine("The number of significant digits for {0} is {1}.", number, SignificantDigits(number));
        }

        private static int SignificantDigits(int n)
        {
            if (n <= 9)
            {
                return 1;
            }
            else
            {
                return SignificantDigits(n / 10) + 1;
            }
        }
    }
}
