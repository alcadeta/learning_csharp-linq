using System;
using Newtonsoft.Json;

namespace Generate
{
    public static class Utils
    {
        public static void Dump(this object dumpee, string header = null)
        {
            if (header != null) Console.Write(header + ": ");
            Console.Write(JsonConvert.SerializeObject(dumpee) + "\n\n");
        }
    }
}