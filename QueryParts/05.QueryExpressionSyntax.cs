using System.Collections.Generic;
using System.Linq;

namespace QueryParts
{
    /// <summary>
    /// Query expression syntax simplifies our LINQ queries even more by
    /// allowing us to use a SQL-like syntax. T
    /// </summary>
    public static class QueryExpressionSyntax
    {
        public static void Demonstrate()
        {
            var colors = Utilities.Colors;
            var numbers = new List<int> {2, 4, 6, 8, 100, 200, 300, 1, 3, 5, 7, 400};

            var q1 = from n in numbers
                select n;
            q1.Dump("Simple pass through query");

            var q2 = from n in numbers
                orderby n descending
                select n;
            q2.Dump("Add `orderby` clause");

            var q3 = from n in numbers
                orderby n
                where n % 100 == 0
                select n;
            q3.Dump("Add `where` clause");

            var q4 = from n in numbers
                orderby n
                where n % 100 == 0
                select n + 50;
            q4.Dump("Transform data on `select`");

            var q5 = from c in colors
                where c.Length > 5
                orderby c
                select c;
            q5.Dump("More expressions");
        }
    }
}