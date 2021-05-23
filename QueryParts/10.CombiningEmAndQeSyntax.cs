using System.Linq;

namespace QueryParts
{
    /// <summary>
    /// Combining LINQ extension methods and query expression syntax.
    /// </summary>
    public static class CombiningEmAndQeSyntax
    {
        public static void Demonstrate()
        {
            var colors = Utilities.Colors;

            var q1 = from color in colors
                where color.StartsWith('B')
                select color;
            q1.Dump();

            // use an extension method on a query variable
            var count = q1.Count();
            count.Dump("`Count` method");

            // use an extension method on a query expression
            var q3 = (from color in colors
                where color.StartsWith('B')
                select color).Count();
            q3.Dump();
        }
    }
}