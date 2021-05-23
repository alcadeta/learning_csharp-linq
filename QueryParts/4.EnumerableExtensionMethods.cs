using System.Collections.Generic;
using System.Linq;

namespace QueryParts
{
    /// <summary>
    /// The extension method syntax simplifies the syntax and makes it easier
    /// to understand your intent.
    /// </summary>
    public static class EnumerableExtensionMethods
    {
        public static void Demonstrate()
        {
            var colors = Utilities.Colors;
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