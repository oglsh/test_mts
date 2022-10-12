using System;
using System.IO;

namespace test_mts_5
{
    class Program5
    {
        static void Main(string[] args)
        {
            TransformToElephant();
            Console.WriteLine("Муха");

        }
        static void TransformToElephant()
        {
            Console.WriteLine("Слон");
            AnotherCode();
            Environment.Exit(0);
        }

        static void AnotherCode()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
