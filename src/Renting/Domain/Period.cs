using System;

namespace Renting.Domain
{
    public class Period
    {
        private readonly DateTime _from;
        private readonly DateTime _to;

        private Period(DateTime from, DateTime to)
        {
            _from = from;
            _to = to;
        }

        public static Period From(DateTime from, DateTime to)
        {
            if (to > from)
            {
                throw new InvalidPeriodException(from, to);
            }
            
            return new Period(from, to);
        }

        public int Days
        {
            get
            {
                var span = _to.Subtract(_from);
                return (int)span.TotalDays;
            }
        }
    }
}