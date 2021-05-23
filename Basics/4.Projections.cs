using System.Linq;

namespace Basics
{
    /// <summary>
    /// Use `select` to return a sequence of a different type.
    /// </summary>
    public static class Projections
    {
        public static void Demonstrate()
        {
            var colors = CourseLib.ColorSource.GetColors();

            var q1 = from color in colors
                select color.BlueValue;
            q1.Dump("IEnumerable<WebColor> to IEnumerable<int>");

            var q2 = from color in colors
                select color.ColorName;
            q2.Dump("IEnumerable<WebColor> to IEnumerable<string>");

            var q3 = from color in colors
                orderby color.ColorName
                select new SimpleColor
                {
                    ColorCategory = color.ColorFamily.ToString(),
                    Hexadecimal = color.HexValue
                };
            q3.Dump("IEnumerable<WebColor> to IEnumerable<SimpleColor>");
        }

        private class SimpleColor
        {
            public string ColorCategory { get; set; }
            public string Hexadecimal { get; set; }
            public bool IsPrimaryColor { get; set; }
        }
    }
}