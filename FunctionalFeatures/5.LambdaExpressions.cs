using System;

namespace FunctionalConcepts
{
    /// <summary>
    /// Lambda expressions are used to define inline functions.
    /// </summary>
    public static class LambdaExpressions
    {
        public static void Demonstrate()
        {
            Func<int, int> adderA, adderB, adderC, adderD;

            // Lambda with statement body can consist of any number of statements.
            adderA = (int n) => { n += 2; return n + 1; };
            Console.WriteLine($"\nadderA(5): {adderA(5)}");

            // Lambda with expression body.
            adderB = (int n) => n + 1;
            Console.WriteLine($"\nadderB(10): {adderB(10)}");

            // Parameter type is inferred.
            adderC = (n) => n + 1;
            Console.WriteLine($"\nadderC(15): {adderC(15)}");

            // When there is only one parameter, parentheses can be omitted.
            adderD = n => n + 1;
            Console.WriteLine($"\nadderD(20): {adderD(20)}");
        }
    }
}