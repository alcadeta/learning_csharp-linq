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

            var q1 = from t in a1.GetExportedTypes()
                from i in t.GetInterfaces()
                where i.IsGenericType && t.IsClass && i.GetGenericTypeDefinition() == typeof(IEnumerable<>)
                orderby t.Name
                select t.Name;

            Console.WriteLine("IEnumerable sources:");
            q1.Dump();


            // IQueryableSources
            var a2 = Assembly.Load("System.Linq.Queryable");

            var q2 = from t in a2.GetExportedTypes()
                from i in t.GetInterfaces()
                where i.IsGenericType
                      && t.IsClass
                      && i.GetGenericTypeDefinition() == typeof(IQueryable<>)
                orderby t.Name
                select t.Name;

            q2.Dump();
        }
    }
}