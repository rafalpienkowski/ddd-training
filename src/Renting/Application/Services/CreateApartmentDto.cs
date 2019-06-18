using System;
using System.Collections.Generic;

namespace Renting.Application.Services
{
    //TODO Czy informacje o DTO przy application services?
    public class CreateApartmentDto
    {
        public CreateApartmentDto(string streetName, string postalCode, string ownerId, List<Tuple<decimal, string>> rooms)
        {
            StreetName = streetName;
            PostalCode = postalCode;
            OwnerId = ownerId;
            Rooms = rooms;
        }

        public string StreetName { get; }
        public string PostalCode { get; }
        public string OwnerId { get; }
        public List<Tuple<decimal, string>> Rooms { get; }
    }
}