using System.Collections.Generic;
using System.Linq;

namespace Generate
{
    /// <summary>
    /// Repeat returns a sequence of repeated items as IEnumerable.
    /// </summary>
    public static class Repeat
    {
        public static void Demonstrate()
        {
            // the statement-based way
            var manyThrees = new List<int>(120);
            for (var i = 0; i < 120; i++)
                manyThrees.Add(3);
            manyThrees.Dump("manyThrees");

            // the expression-based way
            var manyFives = Enumerable.Repeat<int>(5, 200);
            manyFives.Dump("manyFives");
        }
    }
}