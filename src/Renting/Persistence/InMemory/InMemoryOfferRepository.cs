using System.Collections.Generic;
using System.Linq;
using Renting.Domain.Offers;

namespace Renting.Persistence.InMemory
{
    public class InMemoryOfferRepository : IOfferRepository
    {
        private readonly List<Offer> _offers = new List<Offer>();
        
        public Offer Get(OfferId offerId)
        {
            return _offers.SingleOrDefault(o => o.Id.Equals(offerId));
        }

        public void Save(Offer offer)
        {
            _offers.Add(offer);
        }
    }
}