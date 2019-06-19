using Renting.Domain.Apartments;
using Renting.Domain.Drafts;

namespace Renting.Domain.Offers
{
    public class Offer
    {
        public OfferId Id;
        private Period _period;
        private OwnerId _ownerId;
        private Apartment _apartment;
        private Price _pricePerDay;
        private Price _deposit;

        public Offer(Period period, OwnerId ownerId, Apartment apartment, Price pricePerDay, OfferId offerId, Price deposit)
        {
            Id = offerId;
            _period = period;
            _ownerId = ownerId;
            _apartment = apartment;
            _pricePerDay = pricePerDay;
            _deposit = deposit;
        }

        public Draft Choose(TenantId tenantId, Period period, DraftFactory draftFactory)
        {
            return draftFactory.Create(_ownerId, tenantId, _apartment, period, _pricePerDay, Id, _deposit);
        }
    }
}