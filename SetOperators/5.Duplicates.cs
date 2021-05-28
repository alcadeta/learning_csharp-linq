using System.Linq;
using Basics;

namespace SetOperators
{
    public static class Duplicates
    {
        public static void Demonstrate()
        {
            var q1 = CourseLib.ColorSource.GetColors()
                .GroupBy(color => color.HexValue,
                         color => new {color.ColorName, color.HexValue})
                .Where(hex => hex.Count() > 1);
            q1.Dump();
        }
    }
}