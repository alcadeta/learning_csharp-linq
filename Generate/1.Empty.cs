using System;
using System.Collections.Generic;
using System.Linq;

namespace Generate
{
    /// <summary>
    /// The `Empty` method returns a zero length Array of T. This is useful for
    /// a starting value, or as an empty parameter for a method.
    ///
    /// The `DefaultIfEmpty` method returns an enumerable with a single value
    /// (default for the given type) if the given sequence has no items.
    /// Otherwise, it returns the given sequence.
    /// </summary>
    public static class Empty
    {
        public static void Demonstrate()
        {
            // Empty
            var datesArray = Enumerable.Empty<DateTime>();
            datesArray.GetType().Name.Dump("datesArray type");
            datesArray.Count().Dump("datesArray count");
            datesArray.Dump("datesArray content");

            var datesList = Enumerable.Empty<DateTime>().ToList();
            datesList.GetType().Name.Dump("datesList type");
            datesList.Count.Dump("datesList count");
            datesList.Dump("datesList content");

            // DefaultIfEmpty
            var numbers1 = new List<int> {1, 3, 5, 7, 9};
            var numbers2 = Enumerable.Empty<int>().ToList();
            var intList1 = Enumerable.DefaultIfEmpty<int>(numbers1);
            var intList2 = Enumerable.DefaultIfEmpty<int>(numbers2);
            intList1.Dump("intList1 content");
            intList2.Dump("intList2 content");

            var strList = Enumerable.DefaultIfEmpty(Enumerable.Empty<string>().ToList());
            strList.Dump("strList content");
        }
    }
}