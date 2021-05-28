using System.Collections.Generic;
using System.Linq;
using Basics;

namespace ElementOperations
{
    public static class ElementAt
    {
        public static void Demonstrate()
        {
            var fiveCount = new List<int> {0, 5, 10, 15, 20, 25, 30};

            fiveCount.ElementAt(3).Dump("Element at 3");
            fiveCount.ElementAtOrDefault(10).Dump("Element at 10");
        }
    }
}