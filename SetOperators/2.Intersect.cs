using System.Collections.Generic;
using System.Linq;
using Basics;

namespace SetOperators
{
    public static class Intersect
    {
        public static void Demonstrate()
        {
            var numbersA = new List<int> {0, 2, 4, 5, 6, 8, 9, 8};
            var numbersB = new List<int> {1, 3, 5, 7, 8, 9};

            var q = numbersA.Intersect(numbersB);
            q.Dump("Intersect — items that occur in both sequences");
        }
    }
}