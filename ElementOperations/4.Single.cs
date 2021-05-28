using System.Linq;
using Basics;

namespace ElementOperations
{
    public static class Single
    {
        public static void Demonstrate()
        {
            var colors = CourseLib.ColorSource.GetColors();

            colors
                .Single(c => c.ColorName == "SteelBlue")
                .Dump("Single");

            colors
                .SingleOrDefault(c => c.ColorName == "DirtBrown")
                .Dump("SingleOrDefault");
        }
    }
}