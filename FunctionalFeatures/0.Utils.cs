using System;

namespace FunctionalConcepts
{
    public static class Utils {
        public static void ShowType(object o, string nameOfParameter)
        {
            Console.WriteLine($"\nVariable name: {nameOfParameter}");
            Console.WriteLine($"Implied type: {o.GetType().FullName}");
        }
    }
}