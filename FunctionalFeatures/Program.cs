using System;

namespace FunctionalConcepts
{
    /// <summary>
    /// These features were added to C# to bring functional programming concepts
    /// into the C#. They were released at the same time as LINQ and many of
    /// them are enablers for LINQ — they make it easier to write LINQ code.
    /// </summary>
    static class Program
    {
        // Some of the demonstrate methods below do nothing. Navigate to their
        // definition to see what they're about.
        static void Main(string[] args)
        {
            // ImplicitlyTypedVariables.Demonstrate();
            // AnonymousTypes.Demonstrate();
            // ObjectInitialisers.Demonstrate();
            // CollectionInitialisers.Demonstrate();
            // LambdaExpressions.Demonstrate();
            // ExtensionMethods.Demonstrate();
            GenericTypes.Demonstrate();
        }
    }
}