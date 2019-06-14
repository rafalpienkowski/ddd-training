using System;

namespace Renting.Domain.Apartments
{
    //TODO Exceptiony blisko obektów domenowych???
    public class AreaLessThanZeroException : Exception
    {
        public AreaLessThanZeroException(decimal squareMeters) : base($"Given area: {squareMeters} must be grater than 0!")
        {
        }
    }
}