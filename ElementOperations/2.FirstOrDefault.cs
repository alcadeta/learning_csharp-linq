using System.Collections.Generic;
using System.Linq;
using Basics;

namespace ElementOperations
{
    public static class FirstOrDefault
    {
        public static void Demonstrate()
        {
            var numbers = new List<int> {50, 4, 10, 3, 90, 8, -60, 7, 20, 5};
            var emptyNumbers = new List<int>();
            var emptyStrings = new List<string>();
            var emptyBools = new List<bool>();

            numbers.FirstOrDefault().Dump("Valid sequence");
            emptyNumbers.FirstOrDefault().Dump("Empty int sequence");
            emptyStrings.FirstOrDefault().Dump("Empty string sequence");
            emptyBools.FirstOrDefault().Dump("Empty bool sequence");
        }
    }
}