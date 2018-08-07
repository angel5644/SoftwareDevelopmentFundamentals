using System;
using System.Collections.Generic;
using System.IO;

namespace SoftwareDevelopmentFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            ExceptionTest();
        }

        private static void ExceptionTest()
        {
            StreamReader sr = null;

            try
            {
                sr = File.OpenText(@"C:\Users\VictorAngelLeonGonza\Desktop\data.txt");
                Console.WriteLine(sr.ReadToEnd());
            }
            catch (FileNotFoundException fnfex)
            {
                Console.WriteLine(fnfex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
