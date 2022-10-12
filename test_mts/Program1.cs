using System;
using System.Diagnostics;

namespace test_mts_1
{
    class Program1
    {
        static void Main(string[] args)
        {
            try
            {
                FailProcess();
            }
            catch(Exception ex)
            { Console.WriteLine(ex.Message); }

            Console.WriteLine("Failed to fail process!");
            Console.ReadKey();

        }
        static void FailProcess()
        {
            Console.WriteLine("Not failed:)");
            Environment.Exit(0);
            //Process.GetCurrentProcess().Kill(); // тоже вариант
        }
    }
}
