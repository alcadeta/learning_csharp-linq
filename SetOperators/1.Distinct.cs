using System.Collections.Generic;
using System.Linq;
using Basics;

namespace SetOperators
{
    public static class Distinct
    {
        public static void Demonstrate()
        {
            var numbers = new List<int> {1, 2, 2, 1, 3, 5, 5, 6};
            var distinctNumbers = numbers.Distinct();

            numbers.Dump(nameof(numbers));
            distinctNumbers.Dump(nameof(distinctNumbers));

            var distinctColors = CourseLib.ColorSource.GetColors()
                .Select(x => x.HexValue).Distinct();
            distinctColors.Dump(nameof(distinctColors));
        }
    }
}