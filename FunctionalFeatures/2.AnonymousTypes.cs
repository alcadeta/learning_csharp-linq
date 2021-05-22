using System;

namespace FunctionalConcepts
{
    /// <summary>
    /// Anonymous types provide a way to encapsulate a set of read-only
    /// properties into a single object without having to explicitly define a
    /// type first. The type of each property is inferred by the compiler.
    /// </summary>
    public static class AnonymousTypes
    {
        public static void Demonstrate()
        {
            var a = new {Color = "Red", Price = 40M};

            Utils.ShowType(a, nameof(a));

            Console.WriteLine($"\na.Color: {a.Color}");
            Console.WriteLine($"a.Price: {a.Price}");
        }
    }
}