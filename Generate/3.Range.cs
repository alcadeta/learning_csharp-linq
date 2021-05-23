using System.Linq;

namespace Generate
{
    /// <summary>
    /// The `Range` method generates a sequence of integral numbers within a
    /// specified range.
    /// </summary>

    public static class Range
    {
        public static void Demonstrate()
        {
            var numbers = Enumerable.Range(1000, 30);
            numbers.Dump("numbers");

            // transform
            var odds = Enumerable.Range(1000, 30).Where(e => e % 2 == 1);
            odds.Dump("odds");
        }
    }
}