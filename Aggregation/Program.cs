using System;
using System.Collections.Generic;
using System.Linq;
using Filtering;

namespace Aggregation
{
    /// <summary>
    /// Aggregate, given a sequence (a,b,c,d,e) perform an operation on each
    /// successive pair
    ///
    /// var result = operation(a, b);
    /// result = operation(result, c);
    /// result = operation(result, d);
    /// result = operation(result, e);
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Common.Demonstrate();
            Custom.Demonstrate();
        }
    }
}