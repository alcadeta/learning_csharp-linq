using System;
using System.Collections.Generic;
using System.Linq;

namespace FunctionalConcepts
{
    /// <summary>
    /// Extension methods are a way to "add" methods to existing types without
    /// creating a new derived type, recompiling, or otherwise modifying the
    /// original type.
    /// </summary>
    public static class ExtensionMethods
    {
        public static void Demonstrate()
        {
            var colors = new List<string> {"purple", "yellow", "orange"};
            colors.ShowItems();

            if (!colors.IsEmpty())
                Console.WriteLine("\nThe collection has items.");

            Console.WriteLine("\n" + colors.GetRandomElement());

            var shuffledColors = colors.Shuffle();
            shuffledColors.ShowItems();
        }
    }

    static class CollectionExtensions
    {
        private static readonly Random _Ran = new();

        public static void ShowItems<T>(this IEnumerable<T> collection)
        {
            Console.WriteLine();
            foreach (T item in collection)
                Console.WriteLine(item);
        }

        public static bool IsEmpty<T>(this ICollection<T> candidateCollection) =>
            candidateCollection == null || !candidateCollection.Any();

        public static T GetRandomElement<T>(this ICollection<T> array) =>
            array.ElementAt(_Ran.Next(array.Count));

        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> candidate) =>
            candidate.OrderBy(x => _Ran.NextDouble());
    }
}