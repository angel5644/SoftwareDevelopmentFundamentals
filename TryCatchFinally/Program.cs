using System;
using System.Collections.Generic;
using System.IO;

namespace TryCatchFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            TryCatchFinallyTest();
        }

        private static void TryCatchFinallyTest()
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
            finally
            {
                if (sr != null)
                {
                    Console.WriteLine("Closing file...");
                    sr.Close();
                }
            }
        }
    }
}
