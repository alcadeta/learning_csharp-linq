using System.Collections.Generic;
using System.Linq;
using Basics;

namespace QuantifyData
{
    /// <summary>
    /// Similar to `Any` but takes in a value rather than a predicate.
    /// </summary>
    public static class Contains
    {
        public static void Demonstrate()
        {
            var numbers = new List<int> {24, 18, 16, 76, 14, 24, -10};
            numbers.Contains(14).Dump("Contains 14");

            var colors = CourseLib.ColorSource.GetColors();
            var colorRef1 = new CourseLib.WebColor
            {
                ColorName = "DirtBrown",
                ColorFamily = CourseLib.ColorFamily.Brown
            };
            var colorRef2 = colors.ElementAt(101);

            colors.Contains(colorRef1).Dump("Contains DirtBrown");
            colors.Contains(colorRef2).Dump("Contains Other");
        }
    }
}