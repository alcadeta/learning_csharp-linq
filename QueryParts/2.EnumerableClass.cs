using System;
using System.Linq;

namespace QueryParts
{
    public static class EnumerableClass
    {
        public static void Demonstrate()
        {
            var q = typeof(System.Linq.Enumerable).GetMethods()
                .OrderBy(method => method.Name)
                .GroupBy(method => method.Name)
                .Select(g => $"Key: {g.Key}, Overloads: {g.Count()}");

            foreach (var str in q)
                Console.WriteLine(str);
        }
    }
}