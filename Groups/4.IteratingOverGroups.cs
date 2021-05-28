using System;
using System.Linq;

namespace Groups
{
    public static class IteratingOverGroups
    {
        public static void Demonstrate()
        {
            var colors = CourseLib.ColorSource.GetColors();

            var grouped = colors.GroupBy(
                c => c.ColorFamily,
                c => new {c.ColorName, c.HexValue},
                (key, value) => new {Family = key, Colors = value});

            foreach (var group in grouped)
            {
                Console.WriteLine(group.Family);
                foreach (var color in group.Colors)
                {
                    Console.WriteLine($"    {color.ColorName}");
                }
                Console.WriteLine();
            }
        }
    }
}