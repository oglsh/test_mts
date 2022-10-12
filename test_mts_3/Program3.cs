using System;
using System.Collections.Generic;

namespace test_mts_3
{
    class Program3
    {
        static void Main(string[] args)
        {
            int tailLenght;
            int[] _enumerable =  new[] { 1, 2, 3, 4 };
            IEnumerable<(int item, int? tail)> items = new List<(int item, int? tail)>();

            Console.WriteLine("Введите количество отсчитываемых с конца элементов\n");
            tailLenght = Convert.ToInt32(Console.ReadLine());

            items = _enumerable.EnumerateFromTail(tailLenght);
            foreach(var x in items)
            {
                Console.WriteLine(x);
            }
            
        }

    }
}
