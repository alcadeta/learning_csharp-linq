using System;
using System.Collections.Generic;
using System.Linq;

namespace Filtering
{
    public static class Challenge
    {
        public static void MySolution()
        {
            var hexValues = "ABCDEF";
            for (var i = 0; i <= 9; i++) hexValues += i;

            var q = from c in CourseLib.ColorSource.GetColors()
                    where c.ColorName.Contains("-")
                          || !c.HexValue.All(h => hexValues.Contains(h))
                    orderby !c.HexValue.All(h => hexValues.Contains(h))
                    select new {c.ColorName, c.HexValue};

            q.Dump("My Result");
        }

        public static void TutorsSolution()
        {
            var q = from color in CourseLib.ColorSource.GetColors()
                    where color.ColorName.Contains("-") || IsValidHex(color.HexValue) == false
                    orderby IsValidHex(color.HexValue) == false
                    select new {color.ColorName, color.HexValue};

            q.Dump("Tutor's Result");

            bool IsValidHex(string candidate)
                => int.TryParse(candidate, System.Globalization.NumberStyles.HexNumber, null, out _);
        }
    }
}