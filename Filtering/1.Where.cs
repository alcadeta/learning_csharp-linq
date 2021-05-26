using System.Linq;

namespace Filtering
{
    /// <summary>
    /// The `where` clause filters a sequence based on a predicate function
    /// that's applied to each element in the sequence.
    /// </summary>
    public static class Where
    {
        public static void Demonstrate()
        {
            var colors = CourseLib.ColorSource.GetColors();

            // Use a lambda
            var q1 = from color in colors
                where color.ColorFamily == CourseLib.ColorFamily.Orange
                select color;
            q1.Dump("The orange family");

            // Use a method
            var q2 = from color in colors
                where IsColorTotalLessThan(color, 1.5)
                select new
                {
                    color.ColorName,
                    color.BluePercent,
                    color.GreenPercent,
                    color.RedPercent,
                    TotalPercent = color.BluePercent +
                                   color.GreenPercent +
                                   color.RedPercent
                };
            q2.OrderBy(x => x.TotalPercent).Dump();
        }

        private static bool IsColorTotalLessThan(
            CourseLib.WebColor color, double maxValue
        ) =>
            color.BluePercent + color.GreenPercent + color.RedPercent < maxValue;

    }
}