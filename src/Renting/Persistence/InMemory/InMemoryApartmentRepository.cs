using System.Collections.Generic;
using System.Linq;
using Renting.Domain.Apartments;

namespace Renting.Persistence.InMemory
{
    public class InMemoryApartmentRepository : IApartmentRepository
    {
        private readonly List<Apartment> _apartments = new List<Apartment>();
        
        public void Save(Apartment apartment)
        {
            _apartments.Add(apartment);
        }

        public Apartment Get(ApartmentId apartmentId)
        {
            return _apartments.SingleOrDefault(a => a.Id.Equals(apartmentId));
        }
    }
}