using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace QueryParts
{
    public static class TheEnumerableStaticMethods
    {
        public static void Demonstrate()
        {
            var colors = new List<string>
            {
                "Green", "Blush", "Yellow", "Red", "Orange",
                "Burgundy", "Purple", "White", "Black", "Blue", "Bronze"
            };
            colors.Dump("ORIGINAL LIST");

            var bColors = Enumerable.Where(colors, c => c.StartsWith('B'));
            bColors.Dump("Colors starting with 'B'");

            var lastColor = Enumerable.Last(colors);
            lastColor.Dump("The last color");
        }
    }
}