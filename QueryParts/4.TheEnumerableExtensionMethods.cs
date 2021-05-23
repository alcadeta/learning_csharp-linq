using System.Collections.Generic;
using System.Linq;

namespace QueryParts
{
    /// <summary>
    /// The extension method syntax simplifies the syntax and makes it easier
    /// to understand your intent.
    /// </summary>
    public static class TheEnumerableExtensionMethods
    {
        public static void Demonstrate()
        {
            var colors = new List<string>
            {
                "Green", "Blush", "Yellow", "Red", "Orange",
                "Burgundy", "Purple", "White", "Black", "Blue", "Bronze"
            };
            colors.Dump("ORIGINAL LIST");

            // Enumerable.Where(colors, c => c.StartsWith('B')).Dump();
            colors.Where(c => c.StartsWith('B')).Dump();

            // Enumerable.Last(colors).Dump();
            colors.Last().Dump();

            // Pipeline
            colors.Where(c => c.StartsWith('B')).Last().Dump();
        }
    }
}