using System;
using System.Collections.Generic;
using System.Linq;
using Filtering;

namespace Aggregation
{
    public static class Custom
    {
        public static void Demonstrate()
        {
            Console.WriteLine("NUMBERS");
            var setA = Enumerable.Range(1, 20).Where(a => a % 3 == 0);

            var multipleOf = setA.Aggregate((a, b) => a * b);

            // set initial seed (accumulator value)
            var multipleOf2 = setA.Aggregate(120, (a, b) => a * b);

            setA.Dump("Set");
            multipleOf.ToString("N0").Dump("Aggregate");
            multipleOf2.ToString("N0").Dump("Aggregate with accumulator");


            Console.WriteLine("\nSTRINGS");
            var foods = new List<string> {
                "apple", "banana", "cherry", "durian", "eggplant", "fig",
                "grape", "honey", "jalapeno", "kale"};

            // reverse list with Aggregate
            var result = foods.Aggregate((a, b) => $"{b}, {a}");

            result.Dump("String Aggregation");
        }
    }
}