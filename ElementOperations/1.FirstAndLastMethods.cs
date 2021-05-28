using System.Collections.Generic;
using System.Linq;
using Basics;

namespace ElementOperations
{
    public static class FirstAndLastMethods
    {
        public static void Demonstrate()
        {
            var numbers = new List<int> {50, 4, 10, 3, 90, 8, -60, 7, 20, 5};

            numbers.First().Dump("First");
            numbers.Last().Dump("Last");
            numbers.OrderBy(a => a).First().Dump("Sorted then First");
            numbers.OrderBy(a => a).Last().Dump("Sorted then Last");
        }
    }
}