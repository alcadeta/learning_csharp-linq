using System;
using System.Linq;
using Basics;

namespace Groups
{
    public static class Challenge
    {
        public static void MySolution()
        {
            var colors = CourseLib.ColorSource.GetColors();

            var group1 = colors.GroupBy(
                color => color.RedPercent.ToString("00.00"),
                (key, value) => new {Key = key, Value = value});
            group1.Dump();

            var group2 = colors.GroupBy(
                color => new {color.BlueValue, color.GreenValue},
                (key, value) => new {Key = key, Value = value});
            group2.Dump();
        }

        public static void TutorsSolution()
        {
            var colors = CourseLib.ColorSource.GetColors();

            var group1 = from color in colors
                         group color by Math.Round(color.RedPercent, 2)
                         into colorGroup
                         select new {colorGroup.Key, Value = colorGroup};
            group1.Dump();

            var group2 = from color in colors
                         group color by new {color.BlueValue, color.GreenValue}
                         into colorGroup
                         select new {colorGroup.Key, Value = colorGroup};
            group2.Dump();
        }
    }
}