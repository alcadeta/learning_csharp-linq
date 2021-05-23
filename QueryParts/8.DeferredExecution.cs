using System;
using System.Collections.Generic;
using System.Linq;

namespace QueryParts
{
    /// <summary>
    /// The execution of the query is distinct from the creation of the query.
    /// No data is retrieved by just creating a query.
    /// </summary>
    public static class DeferredExecution
    {
        public static void Demonstrate()
        {
            Console.WriteLine("\nBASIC EXAMPLE\n");
            var numbers = new List<int> {5, 4, 3, 2, 1, 9, 8, 7, 6};

            var q1 = from n in numbers
                orderby n
                select n;
            Console.WriteLine("Query has been defined.\n");

            var numArray = q1.ToArray();
            Console.WriteLine("Query has been run.\n");

            var numList = q1.ToList();
            Console.WriteLine("Query has been run.\n");

            foreach (var item in q1)
                Console.WriteLine(item);
            Console.WriteLine("\nQuery has been run.\n");


            Console.WriteLine("\nUPDATING VALUE/SEQUENCE AFTER DEFINITION AND BEFORE EXECUTION\n");

            var colors = Utilities.Colors;
            var searchLetter = 'B';
            Console.WriteLine("The search letter has been set to 'B'.\n");

            var q2 = from c in colors
                where c.StartsWith(searchLetter)
                select c;
            Console.WriteLine("Query has been defined.\n");

            searchLetter = 'C';
            q2.Dump("Run colors query after searchLetter changes to 'C'");

            colors.Add("Coral");
            q2.Dump("Run it again after `Coral` is added to colors");


            Console.WriteLine("\nEXTENSION METHOD SYNTAX EXAMPLES\n");

            var q3 = colors.Where(c => c.StartsWith('C'));
            Console.WriteLine("The query has been defined");
            q3.Dump("First run");

            colors.Remove("Coral");
            Console.WriteLine("\"Coral\" is removed from the sequence\n");
            q3.Dump("Second run");

            q3 = q3.OrderBy(c => c);
            Console.WriteLine("The query has been modified");
            q3.Dump("Third run");
        }
    }
}