using System;
using System.Collections.Generic;
using System.Linq;

namespace QueryParts
{
    /// <summary>
    /// Chaining function calls.
    /// </summary>
    public static class Pipelines
    {
        public static void Demonstrate()
        {
            var colors = new List<string>
            {
                "Green", "Blush", "Yellow", "Red", "Orange", "Burgundy", "Purple",
                "White", "Black", "Blue", "Bronze", "Bronze"
            };

            // Pipeline example
            var pipe1 = colors.Where(c => c.Length > 5); // `Where` returns IEnumerable<T>
            var pipe2 = pipe1.OrderBy(p => p); // `OrderBy` returns IOrderedEnumerable<T>
            pipe2.Dump("ordered and filtered");

            var pipe3 = pipe2.Distinct(); // `Distinct` returns IEnumerable<T>
            pipe3.Dump("... and duplicates are removed");

            // ...OR:
            var q = colors.Where(c => c.Length > 5).OrderBy(c => c).Distinct();
            q.Dump("the same, but done in a single line");
        }
    }
}