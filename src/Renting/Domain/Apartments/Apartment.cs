using System.Collections.Generic;

namespace Renting.Domain.Apartments
{
    public class Apartment
    {
        public ApartmentId Id { get; }
        private Address _address;
        private OwnerId _ownerId;
        private IEnumerable<Room> _rooms;

        public Apartment(Address address, OwnerId ownerId, IEnumerable<Room> rooms)
        {
            _address = address;
            _ownerId = ownerId;
            _rooms = rooms;
        }
    }
}