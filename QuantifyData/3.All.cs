using System;
using System.Collections.Generic;
using System.Linq;
using Basics;

namespace QuantifyData
{
    public static class All
    {
        public static void Demonstrate()
        {
            var colors = CourseLib.ColorSource.GetColors();

            var numbers = new List<int> {24, 18, 16, 76, 14, 24, -10};

            var areEven = numbers.All(n => n % 2 == 0);
            areEven.Dump("All are even numbers");

            var hasTwoDigits = numbers.All(n => Math.Abs(n) is > 9 and < 100);
            hasTwoDigits.Dump("All have two digits");
        }
    }
}