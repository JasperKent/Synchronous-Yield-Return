using System;
using System.Collections.Generic;
using System.Linq;

namespace YieldReturn
{
    public enum DayOfWeek { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday}

    public static class DayEnumeration
    {
        public static IEnumerable<DayOfWeek> All => Enum.GetValues(typeof(DayOfWeek)).Cast<DayOfWeek>();

        public static IEnumerable<DayOfWeek> Weekdays
        {
            get
            {
                yield return DayOfWeek.Monday;
                yield return DayOfWeek.Tuesday;
                yield return DayOfWeek.Wednesday;
                yield return DayOfWeek.Thursday;
                yield return DayOfWeek.Friday;
            }
        }

        public static IEnumerable<DayOfWeek> Weekend
        {
            get
            {
                yield return DayOfWeek.Saturday;
                yield return DayOfWeek.Sunday;
            }
        }
    }
}
