using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionTable_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The discount for {0} is {1}%.", 5, DiscountFromQuantity(5));
            Console.WriteLine("The discount for {0} is {1}%.", 25, DiscountFromQuantity(25));
            Console.WriteLine("The discount for {0} is {1}%.", 51, DiscountFromQuantity(51));
            Console.WriteLine("The discount for {0} is {1}%.", 200,DiscountFromQuantity(200));
        }

        private static int DiscountFromQuantity(int quantity)
        {
            if (quantity < 10)
            {
                return 5;
            }
            else
            {
                if (quantity < 50)
                {
                    return 10;
                }
                else
                {
                    if (quantity < 100)
                    {
                        return 15;
                    }
                    else
                    {
                        return 20;
                    }
                }
            }
        }
    }
}
