using System.Linq;
using Basics;

namespace Partition
{
    /// <summary>
    /// Take: Get a consecutive subset of the sequence
    /// Skip: Skip a consecutive subset of the sequence, take the rest
    /// </summary>
    public class SkipAndTake
    {
        public static void Demonstrate()
        {
            var numbers = Enumerable.Range(1, 50).ToArray();

            numbers.Take(5).Dump("Take 5");

            numbers.Skip(46).Dump("Skip 46");
            numbers.Skip(numbers.Count() - 12).Dump("Skip based on count");

            numbers.Skip(11).Take(12).Dump("Skip 11, Take 12");
            numbers.Skip(2).Take(10).Dump("Skip 2, Take 10");
        }
    }
}