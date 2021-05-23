using System.Collections.Generic;
using System.Linq;

namespace QueryParts
{
    /// <summary>
    /// LINQ to objects work with types that implement IEnumerable of T
    /// However, arrays are treated specially by the CLR. Provided that the
    /// array is single-dimensional and has zero lower-bound, CLR alters it to
    /// inherit `Array`, which implements IEnumerable of T, ICollection of T,
    /// and IList of T.
    /// </summary>
    public static class ExampleSources
    {
        public static void Demonstrate()
        {
            // array
            var arr = new double[] {4.4, 2.2, 6.6};
            var q1 = from a in arr orderby a select a;
            q1.Dump("array");

            // stack
            var st = new Stack<bool>();
            st.Push(true);
            st.Push(true);
            st.Push(false);
            var q2 = from s in st select s;
            q2.Dump("stack");

            // dictionary
            var dict = new Dictionary<int, string> {{4, "****"}, {2, "eeee"}, {8, "1111"}};
            var q3 = from d in dict select d;
            q3.Dump("dictionary");
            q3.Where(c => c.Key < 5).Dump("dictionary (d.Key < 5)");

            // string
            var str1 = "ABC DEF GHI";
            var q4 = from s in str1 select s;
            q4.Dump("string (letters)");
            var str2 = "Billy, Bhrama, and Brianna went for a bike ride.";
            var q5 = from s in str2 where s != ' ' orderby s select s;
            q5.Dump();
            var q6 = from s in str2 where s == 'B' select s;
            q6.Count().Dump();

        }
    }
}