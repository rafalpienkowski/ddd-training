using System.Collections.Generic;

namespace Renting.Domain.Apartments
{
    public class ApartmentFactory
    {
        public static Apartment Create(Address address, OwnerId ownerId, IEnumerable<Room> rooms)
        {
            return new Apartment(address, ownerId, rooms);
        }
    }
}