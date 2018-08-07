using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingExceptions_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Divide(0,0);
            }
            catch (ArithmeticException aex)
            {
                Console.WriteLine("ArithmeticException. Message: {0}", aex.Message);
            }
            catch (InvalidCastException icex)
            {
                Console.WriteLine("InvalidCastException. Message: {0}", icex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception. Message: {0}", ex.Message);
            }
        }

        private static int Divide(int x, int y)
        {
            return x / y;
        }
    }
}
