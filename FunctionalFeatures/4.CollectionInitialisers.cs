using System.Collections.Generic;

namespace FunctionalConcepts
{
    /// <summary>
    /// Collection initialisers are similar to object initialisers, in that they
    /// allow us to initialise a collection at the same line that we define it,
    /// but they are used on collections such as arrays, lists, and dictionaries
    /// rather than objects.
    /// </summary>
    public class CollectionInitialisers
    {
        public static void Demonstrate()
        {
            var a = new List<int> {1, 2, 5, 4};
            var b = new double[] {1.2, 2.3, 3.4};
            var c = new Dictionary<string, int> {{"yellow", 33}, {"blue", 22}};
            var w = new Website {Tags = {"Flowers", "Tools", "Trees"}};
        }
    }

    internal class Website { public List<string> Tags { get; set; } }
}