using System.Collections.Generic;
using System.Linq;
using Renting.Domain.Offers;

namespace Renting.Persistence.InMemory
{
    public class InMemoryOfferRepository : IOfferRepository
    {
        private static readonly List<Offer> Offers = new List<Offer>();
        
        public Offer Get(OfferId offerId)
        {
            return Offers.SingleOrDefault(o => o.Id.Equals(offerId));
        }

        public void Save(Offer offer)
        {
            Offers.Add(offer);
        }
    }
}