using System.Collections.Generic;
using System.Linq;
using Basics;

namespace QuantifyData
{
    public static class Any
    {
        public static void Demonstrate()
        {
            var strColors = new List<string> {
                "Green", "Blush", "Yellow", "Red", "Orange", "Burgandy",
                "Purple", "White", "Black", "Blue", "Bronze"};
            var emptyList = new List<double>();

            // COUNT vs ANY for determining whether a sequence is empty
            strColors.Count().Dump("colors Count");
            strColors.Any().Dump("colors Any");
            emptyList.Count().Dump("emptyList Count");
            emptyList.Any().Dump("emptyList Any");

            // One issue with the aggregate `Count` method is that it iterates
            // over the entire sequence.
            if (strColors.Count() > 0)
                "Items in colors!".Dump();
            else
                "Colors empty.".Dump();

            // Any, on the other hand, stops iteration as soon as it finds an
            // item that satisfies it.
            if (strColors.Any())
                "Items in colors!".Dump();
            else
                "Colors empty.".Dump();


            // ANY (second overload) takes a predicate as a parameter and
            // determines whether an element in the sequence satisfies it
            var colors = CourseLib.ColorSource.GetColors();

            bool hasMatchingItem = colors.Any(c => c.ColorName.StartsWith('C'));
            hasMatchingItem.Dump("'C' found");

            var q1 = from c in colors
                    where c.ColorName.StartsWith('C')
                    select c.ColorName;
            q1.Dump("Query #1");

            bool hasMaxBlue = colors.Any(c => c.BlueValue >= 255);
            hasMaxBlue.Dump("Max Blue");
        }
    }
}