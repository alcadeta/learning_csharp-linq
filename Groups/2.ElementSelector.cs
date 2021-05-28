using System.Linq;
using Basics;

namespace Groups
{
    public static class ElementSelector
    {
        public static void Demonstrate()
        {
            var colors = CourseLib.ColorSource.GetColors();

            // *** EXTENSION METHOD *** //
            var groupedByColorFamily = colors.GroupBy(
                x => x.ColorFamily,
                y => new {y.ColorName, y.HexValue});
            groupedByColorFamily.Dump();

            // *** QUERY EXPRESSION *** //
            var grouped2 = from color in colors
                           let colorShort = new {color.ColorName,
                                                 color.HexValue,
                                                 color.ColorFamily}
                           group colorShort by colorShort.ColorFamily;
            grouped2.Dump();
        }
    }
}