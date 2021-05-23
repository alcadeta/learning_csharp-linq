using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace QueryParts
{
    public static class Utilities
    {
        public static List<string> Colors = new List<string>
        {
            "Green", "Blush", "Yellow", "Red", "Orange",
            "Burgundy", "Purple", "White", "Black", "Blue", "Bronze"
        };

        public static void Dump(this object dumpee, string header = null)
        {
            if (header != null) Console.WriteLine(header + ":");
            Console.WriteLine(JsonConvert.SerializeObject(dumpee) + "\n");
        }
    }
}