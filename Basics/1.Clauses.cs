using System.Linq;

namespace Basics
{
    /// <summary>
    /// A query expression must start with a `from` clause, and it must end with
    /// either a `select` or `group` clause. Additionally, it may or may not
    /// have `where`, `orderby`, `join`, `let`, and `from` clauses.
    /// </summary>
    public static class Clauses
    {
        public static void Demonstrate()
        {
            var colors = Utils.Colors;

            var q1 = from c in colors select c; // OR:
            var q2 = colors.Select(c => c);
            q1.Dump("q1");
            q2.Dump("q2");
        }
    }
}