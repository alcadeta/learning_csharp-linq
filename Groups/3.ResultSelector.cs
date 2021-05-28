using System.Linq;
using Basics;

namespace Groups
{
    public static class ResultSelector
    {
        public static void Demonstrate()
        {
            var colors = CourseLib.ColorSource.GetColors();

            // *** EXTENSION METHOD SYNTAX *** //
            var groupedByFamily = colors.GroupBy(
                c => c.ColorFamily,  // keySelector
                c => new {c.ColorName, c.HexValue},  // elementSelector
                (key, val) => new {Family = key, Colors = val});  // resultSelector
            groupedByFamily.Dump("EMS");

            // *** QUERY EXPRESSION SYNTAX *** //
            var q = from color in colors
                    let colorShort = new {color.ColorName, color.HexValue, color.ColorFamily}
                    group colorShort by color.ColorFamily // key selector
                    into familyGroup // variable used in result selector
                    select new {Family = familyGroup.Key, Colors = familyGroup}; // result selector
            q.Dump("QES");
        }
    }
}