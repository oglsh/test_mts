using System;
using System.Collections.Generic;

namespace test_mts_4
{
    class Program4
    {
        static void Main(string[] args)
        {
            IEnumerable<int> items = new List<int>() { 2, 4, 10 ,3, 8, 11, 16, 14, 52, 32, 64, 5 };
            //IEnumerable<int> re = new List<int>();
            items = Sort._Sort(items, 15, 64);
           foreach(var x in items)
           {
                Console.WriteLine(x);
           }
        }
    }
}
