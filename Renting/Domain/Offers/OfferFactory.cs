using System;
using Renting.Domain.Apartments;

namespace Renting.Domain.Offers
{
    public class OfferFactory
    {
        public static Offer Create(Apartment apartment, OwnerId ownerId, Period period, Price pricePerDay, Price deposit)
        {
            var offerId = OfferId.From(Guid.NewGuid().ToString());
            return new Offer(period, ownerId, apartment, pricePerDay, offerId, deposit);
        }
    }
}