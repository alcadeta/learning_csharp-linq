using System.Collections.Generic;
using System.Linq;
using Basics;

namespace SetOperators
{
    public static class Union
    {
        public static void Demonstrate()
        {
            var numbersA = new List<int> {0, 2, 4, 5, 6, 8, 9, 8}; // 8 items
            var numbersB = new List<int> {1, 3, 5, 7, 8, 9}; // 6 items

            var q = numbersA.Union(numbersB); // 10 members (A + B - duplicates)
            q.Dump("Union");
        }
    }
}