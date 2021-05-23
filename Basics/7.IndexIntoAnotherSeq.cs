using System.Collections.Generic;
using System.Linq;

namespace Basics
{
    public static class IndexIntoAnotherSeq
    {
        public static void Demonstrate()
        {
            var preferredOrder = new List<int> {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
            var foods = new List<string>
            {
                "apple", "banana", "cherry", "durian", "eggplant", "fig",
                "grape", "honey", "jalapeno", "kale"
            };

            var q = from position in preferredOrder
                select new {Position = position, Word = foods.ElementAt(position)};
            q.Dump();
        }
    }
}