using System.Collections.Generic;
using System.Linq;
using Basics;

namespace Groups
{
    public static class SelectMany
    {
        public static void Demonstrate()
        {
            var calendars = new List<HistoryCalendar>();

            calendars.Add(new HistoryCalendar {
                Decade = "Seventies",
                Years = Enumerable.Range(1970, 10).ToList()});

            calendars.Add(new HistoryCalendar {
                Decade = "Eighties",
                Years = Enumerable.Range(1980, 10).ToList()});

            var query = from calendar in calendars select calendar;
            query.Dump("Calendars");

            // *** HERE: *** //
            var flatYears = calendars.SelectMany(calendar => calendar.Years);
            flatYears.Dump(nameof(flatYears));
        }

        private class HistoryCalendar
        {
            public string Decade { get; set; }
            public List<int> Years { get; set; }
        }
    }
}