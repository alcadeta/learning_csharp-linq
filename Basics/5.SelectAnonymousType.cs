using System.Linq;

namespace Basics
{
    /// <summary>
    /// Project into an anonymous type.
    /// </summary>
    public static class SelectAnonymousType
    {
        public static void Demonstrate()
        {
            var q = from color in CourseLib.ColorSource.GetColors()
                orderby color.ColorName
                select new {Name = color.ColorName, Family = color.ColorFamily};
            q.Dump("Sequence of anonymous type");
        }
    }
}