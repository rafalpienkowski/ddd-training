using Renting.Domain.Apartments;
using Renting.Domain.Discounts;
using Renting.Domain.Offers;

namespace Renting.Domain.Drafts
{
    public class DraftFactory
    {
        private readonly IDraftNumberGenerator _draftNumberGenerator;
        private readonly Discount _discount;

        public DraftFactory(Discount discount, IDraftNumberGenerator draftNumberGenerator)
        {
            _discount = discount;
            _draftNumberGenerator = draftNumberGenerator;
        }

        public Draft Create(OwnerId ownerId, TenantId tenantId, Apartment apartment, Period period, Price pricePerDay, OfferId offerId, Price deposit)
        {
            var draftNumber = _draftNumberGenerator.GetNextAvailable(tenantId, offerId);
            var discountedPrice = Price.From(pricePerDay.ToDecimal() * _discount.ToDecimal());
            return new Draft(ownerId, tenantId, apartment, period, discountedPrice, draftNumber, deposit);
        }
    }
}