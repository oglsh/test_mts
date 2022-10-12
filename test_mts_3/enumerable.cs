using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_mts_3
{
    static class enumerable
    {


        public static IEnumerable<(T item, int? tail)> EnumerateFromTail<T>(this IEnumerable<T> enumerable, int? tailLength)
        {
            if (tailLength == null || tailLength <= 0)
                return new List<(T item, int? tail)>();

            IList<(T item, int? tail)> items = new List<(T item, int? tail)>();
            var count = enumerable.Count();
            if (tailLength >= count)
            {
                foreach (var x in enumerable)
                {
                    items.Add((x, --count));
                }
            }
            else
            {
                var i = 0;
                var re = count - tailLength;
                foreach (var x in enumerable)
                {
                    items.Add((x, i >= re ? --tailLength : null));
                    i++;
                }
            }
            return items;


        }
    }
}
