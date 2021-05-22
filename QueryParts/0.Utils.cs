using System;
using Newtonsoft.Json;

namespace QueryParts
{
    public static class Utils
    {
        public static string ToPrettyString(this object value)
        {
            return JsonConvert.SerializeObject(value, Formatting.Indented);
        }

        public static T Dump<T>(this T value)
        {
            Console.WriteLine(value.ToPrettyString());
            return value;
        }
    }
}