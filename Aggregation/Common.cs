using System.Collections.Generic;
using System.Linq;
using Filtering;

namespace Aggregation
{
    public static class Common
    {
        public static void Demonstrate()
        {
            var numbers = new List<int> {50, 4, 10, 3, 90, 8, -60, 7, 20, 5};

            var total = numbers.Sum();
            var median = numbers.Average();
            var lowest = numbers.Min();
            var highest = numbers.Max();
            var countOf = numbers.Count();
            var anotherCountOf = numbers.Count(a => a > 20);

            total.Dump("Sum");
            median.Dump("Average");
            lowest.Dump("Min");
            highest.Dump("Max");
            countOf.Dump("Count");
            anotherCountOf.Dump("Count with predicate");
        }
    }
}