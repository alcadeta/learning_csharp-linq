using System;
using System.Linq;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Clauses.Demonstrate();
            // ThreeTypesOfQEs.Demonstrate();
            // TheSelectClause.Demonstrate();
            // Projections.Demonstrate();
            // SelectAnonymousType.Demonstrate();
            // ExpressionsWithSelect.Demonstrate();
            IndexIntoAnotherSeq.Demonstrate();


            // Code Challenge — My Solution:
            var q = from color in CourseLib.ColorSource.GetColors()
                orderby color.GreenValue descending
                select $"{color.ColorName}, " +
                       $"rgb ({color.RedValue:D3}, {color.GreenValue:D3}, {color.BlueValue:D3})";
            // q.Dump("My solution");
        }
    }
}