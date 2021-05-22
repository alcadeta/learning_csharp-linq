using System;
using System.Collections.Generic;

namespace FunctionalConcepts
{
    /// <summary>
    /// Compiler infers the type of the variable from the assignment. This is
    /// essential for another feature — anonymous types.
    /// </summary>
    public static class ImplicitlyTypedVariables
    {
        public static void Demonstrate()
        {
            var greeting = "Hi there!";
            var aChar = 'a';
            ShowType(greeting, nameof(greeting));
            ShowType(aChar, nameof(aChar));
            Console.WriteLine();

            SortedDictionary<string, Guid> guids1 = new SortedDictionary<string, Guid>();
            // ---VERSUS---
            var guids2 = new SortedDictionary<string, Guid>();
            ShowType(guids2, nameof(guids2));
        }

        private static void ShowType(object o, string nameOfParameter)
        {
            Console.WriteLine($"Variable name: {nameOfParameter}, implied type: {o.GetType().FullName}");
        }
    }
}