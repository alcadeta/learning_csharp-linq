using System;
using System.Collections.Generic;

namespace FunctionalConcepts
{
    public static class ExtensionMethods
    {
        public static void Demonstrate()
        {
            var colors = new List<string> {"purple", "yellow", "orange"};
            colors.ShowItems();

            var numbers = new[] {2, 4, 6, 8};
            numbers.ShowItems();
        }
    }

    static class CollectionExtensions
    {
        private static readonly Random _Ran = new Random();

        public static void ShowItems<T>(this IEnumerable<T> collection)
        {
            Console.WriteLine();
            foreach (T item in collection)
                Console.WriteLine(item);
        }
    }
}