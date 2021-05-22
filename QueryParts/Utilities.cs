using System;
using Newtonsoft.Json;

namespace QueryParts
{
    public static class Utilities
    {
        public static void Dump(this object dumpee, string header = null)
        {
            if (header != null) Console.WriteLine(header + ":");
            Console.WriteLine(JsonConvert.SerializeObject(dumpee) + "\n");
        }
    }
}