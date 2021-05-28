using System.Linq;
using Basics;

namespace Groups
{
    public static class CombiningSequences
    {
        public static void Demonstrate()
        {
            var setA = Enumerable.Range(2, 3);
            var setB = Enumerable.Range(5, 3);

            // *** QUERY EXPRESSION SYNTAX *** //
            var group1 = from a in setA
                         from b in setB
                         group a by b
                         into groupA
                         select groupA;
            group1.Dump(nameof(group1));

            var query2 = from a in setA
                         from b in setB
                         select new {a, b};
            query2.Dump(nameof(query2));

            // *** EXTENSION METHOD SYNTAX *** //
            var query1 = setA.Select(a => setB.Select(b => $"A: {a}, B: {b}"));
            query1.Dump(nameof(query1));
        }
    }
}