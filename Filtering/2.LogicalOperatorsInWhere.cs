using System.Linq;
using CourseLib;

namespace Filtering
{
    public static class LogicalOperatorsInWhere
    {
        public static void Demonstrate()
        {
            var colors = ColorSource.GetColors();

            var q1 = from color in colors
                where color.ColorFamily == ColorFamily.Orange
                      && color.ColorName.Contains("o")
                select new {color.ColorName, color.ColorFamily};
            q1.Dump("&&");

            var q2 = from color in colors
                where color.ColorFamily == ColorFamily.Blue
                      || color.ColorFamily == ColorFamily.Yellow
                select new {color.ColorName, color.ColorFamily};
            q2.Dump("||");
        }
    }
}