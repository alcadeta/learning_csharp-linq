using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace QueryParts
{
    public static class EnumerableStaticMethods
    {
        public static void Demonstrate()
        {
            var colors = Utilities.Colors;
            colors.Dump("ORIGINAL LIST");

            var bColors = Enumerable.Where(colors, c => c.StartsWith('B'));
            bColors.Dump("Colors starting with 'B'");

            var lastColor = Enumerable.Last(colors);
            lastColor.Dump("The last color");
        }
    }
}