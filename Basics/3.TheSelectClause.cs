using System.Linq;

namespace Basics
{
    /// <summary>
    /// Select returns a sequence of a given type (eg. IEnumerable of string,
    /// IEnumerable of Product). In many cases, this is the same type as the
    /// original sequence. Here, it's a list of the same type.
    /// </summary>
    public static class TheSelectClause
    {
        public static void Demonstrate()
        {
            var q = from color in CourseLib.ColorSource.GetColors()
                orderby color.ColorFamily
                select color;

            q.Dump(nameof(q));
        }
    }
}