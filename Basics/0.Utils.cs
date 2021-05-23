using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Basics
{
    public static class Utils
    {
        public static readonly List<string> Colors = new()
        {
            "Green", "Blush", "Yellow", "Red", "Orange", "Burgundy", "Purple",
            "White", "Black", "Blue", "Bronze"
        };

        public static void Dump(this object dumpee, string header = null)
        {
            if (header != null) Console.Write(header + ": ");
            Console.Write(JsonConvert.SerializeObject(dumpee) + "\n\n");
        }
	}
}