using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace QueryParts
{
    public static class Sources
    {
        public static void Demonstrate()
        {
            // IEnumerable sources
            var a1 = Assembly.Load("System.Collections");

            var q1 = a1.GetExportedTypes()
                .SelectMany(t => t.GetInterfaces(), (t, i) => new {t, i})
                .Where(ti => ti.i.IsGenericType
                             && ti.t.IsClass
                             && ti.i.GetGenericTypeDefinition() == typeof(IEnumerable<>))
                .OrderBy(ti => ti.t.Name)
                .Select(ti => ti.t.Name);

            Console.WriteLine("1. IEnumerable sources:");
            foreach (var str in q1) Console.WriteLine(str);


            // IQueryableSources
            var a2 = Assembly.Load("System.Linq.Queryable");

            var q2 = a2.GetExportedTypes()
                .SelectMany(t => t.GetInterfaces(), (t, i) => new {t, i})
                .Where(ti => ti.i.IsGenericType
                             && ti.t.IsClass
                             && ti.i.GetGenericTypeDefinition() == typeof(IQueryable<>))
                .OrderBy(ti => ti.t.Name)
                .Select(ti => ti.t.Name);

            Console.WriteLine("\n2. IQueryable sources:");
            foreach (var str in q2) Console.WriteLine(str);
        }
    }
}