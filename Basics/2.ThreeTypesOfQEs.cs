using System.Collections.Generic;
using System.Linq;

namespace Basics
{
    /// <summary>
    /// LINQ query expressions can be categorised into three areas.
    /// </summary>

    public static class ThreeTypesOfQEs
    {
        public static void Demonstrate()
        {
            var colors = Utils.Colors;
            TheFirstType(colors);
            TheSecondType(colors);
        }

        /// <summary>
        /// Takes a sequence, returns a new sequence of the same type.
        /// Element types are the same but the sequence may be sorted, grouped,
        /// filtered, etc.
        /// </summary>
        private static void TheFirstType(List<string> colors)
        {
            var q11 = from c in colors select c;
            q11.Dump(nameof(q11));

            var q12 = from c in colors
                where c.EndsWith('e')
                orderby c
                select c;
            q12.Dump(nameof(q12));
        }

        /// <summary>
        /// Takes a sequence, returns a new sequence containing elements of a
        /// different type. Transforms the items into another type (eg. int to
        /// decimal, Product to string).
        /// </summary>
        private static void TheSecondType(List<string> colors)
        {
            var q21 = from c in colors select c.Length;
            q21.Dump(nameof(q21));
        }

        /// <summary>
        /// Takes a sequence, returns a single value. Reduces a sequence of
        /// items into a single value. For this, you cannot use the query syntax.
        /// </summary>
        private static void TheThirdType(List<string> colors)
        {
            var q31 = colors.Count();
            q31.Dump(nameof(q31));
        }

    }
}