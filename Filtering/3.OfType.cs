using System.Linq;

namespace Filtering
{
    public static class OfType
    {
        public static void Demonstrate()
        {
            var q = from card in CourseLib.CardSource.GetCards()
                    select card;

            var monstersOnly = from c in q.OfType<CourseLib.Cards.Cyborg>()
                               select new {c.Name, c.ListPrice, c.TypeName};

            q.Dump(nameof(q));
            monstersOnly.Dump(nameof(monstersOnly));
        }
    }
}