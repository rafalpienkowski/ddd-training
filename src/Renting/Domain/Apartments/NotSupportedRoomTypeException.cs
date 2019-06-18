using System;

namespace Renting.Domain.Apartments
{
    public class NotSupportedRoomTypeException : Exception
    {
        public NotSupportedRoomTypeException(string roomType) : base($"{roomType} is not supported")
        {
        }
    }
}