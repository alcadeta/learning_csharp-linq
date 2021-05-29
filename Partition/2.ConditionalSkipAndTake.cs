using System.Collections.Generic;
using System.Linq;
using Basics;

namespace Partition
{
    /// <summary>
    /// TakeWhile: Returns elements from a sequence as long as the specified
    ///            condition is true, and then skips the remaining items.
    /// SkipWhile: Bypasses elements in a sequence as long as the specified
    ///            condition is true, and then returns the remaining items.
    /// </summary>
    public static class ConditionalSkipAndTake
    {
        public static void Demonstrate()
        {
            var numbers = new List<int> {
                21, 32, 43, 54, 65, 201, 301, 401, 76, 87, 98};

            numbers.TakeWhile(n => n < 100).Dump("Take while lesser than 100");
            numbers.SkipWhile(n => n < 100).Dump("Skip while lesser than 100");
        }
    }
}