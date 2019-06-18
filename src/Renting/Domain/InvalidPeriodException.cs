using System;

namespace Renting.Domain
{
    public class InvalidPeriodException : Exception
    {
        public InvalidPeriodException(DateTime from, DateTime to) : base($"{from} {to}")
        {
        }
    }
}