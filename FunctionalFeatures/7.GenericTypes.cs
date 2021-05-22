using System;
using System.Collections.Generic;
using System.Linq;

namespace FunctionalConcepts
{
    /// <summary>
    /// Generics introduces the concept of type parameters to .NET, which make
    /// it possible to design classes and methods that defer the specification
    /// of one or more types until the class or method is declared and
    /// instantiated by client code.
    /// </summary>
    public static class GenericTypes
    {
        public static void Demonstrate()
        {
            var saleAmounts = new List<decimal> {21.30M, 92.35M, 14M};
            Console.Write("Sales:");
            foreach (var saleAmount in saleAmounts)
                Console.Write(" " + saleAmount);

            var sumA = saleAmounts.Sum();
            Console.WriteLine($"\nSum: {sumA}\n");

            IEnumerable<int> numbers = new List<int> {1, 3, 5, 7, 9};
            Console.WriteLine("Numbers:");
            foreach (var number in numbers)
                Console.Write(" " + number);

            var sumB = numbers.Sum();
            Console.WriteLine($"\nSum: {sumB}");
        }
    }
}