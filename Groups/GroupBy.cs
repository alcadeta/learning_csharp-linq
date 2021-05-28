using System.Linq;
using Basics;

namespace Groups
{
    public static class GroupBy
    {
        public static void Demonstrate()
        {
            var colors = CourseLib.ColorSource.GetColors();

            // *** Extension Method *** //
            var groupRes = colors.GroupBy(c => c.ColorFamily);
            groupRes.Dump("EM");
            groupRes.ElementAt(2).Dump();


            // *** Query Expression *** //
            var q = from color in colors
                    group color by color.ColorFamily;
            q.Dump("QE");

            // other
            var numbers = Enumerable.Range(1, 90);
            var groupedResult = from number in numbers
                                group number by number % 10;
            groupedResult.Dump();
        }
    }
}