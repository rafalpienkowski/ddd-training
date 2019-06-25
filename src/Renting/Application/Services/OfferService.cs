using System;
using Renting.Domain;
using Renting.Domain.Apartments;
using Renting.Domain.Discounts;
using Renting.Domain.Drafts;
using Renting.Domain.Offers;

namespace Renting.Application.Services
{
    public class OfferService
    {
        private readonly IOfferRepository _offerRepository;
        private readonly IDraftRepository _draftRepository;
        private readonly IApartmentRepository _apartmentRepository;
        private readonly IDiscountService _discountService;

        public OfferService(IOfferRepository offerRepository, IDraftRepository draftRepository, IApartmentRepository apartmentRepository, IDiscountService discountService)
        {
            _offerRepository = offerRepository;
            _draftRepository = draftRepository;
            _apartmentRepository = apartmentRepository;
            _discountService = discountService;
        }

        public DraftId Choose(string offerIdString, string tenantIdString, DateTime from, DateTime to)
        {
            var offerId = OfferId.From(offerIdString);
            var offer = _offerRepository.Get(offerId);
            var tenantId = TenantId.From(tenantIdString);
            var period = Period.From(from, to);

            var discount = _discountService.CalculateDiscount(tenantIdString, offerIdString, from, to);
            var draftFactory = new DraftFactory(discount, new DefaultDraftNumberGenerator());
            var draft = offer.Choose(tenantId, period, draftFactory);
            
            _draftRepository.Save(draft);

            return draft.Id;
        }

        public OfferId Create(DateTime from, DateTime to, string apartmentIdString, decimal priceDecimal, string ownerIdString, decimal depositDecimal)
        {
            var apartmentId = ApartmentId.From(apartmentIdString);
            var apartment = _apartmentRepository.Get(apartmentId);
            var period = Period.From(from, to);
            var pricePerDay = Price.From(priceDecimal);
            var ownerId = OwnerId.From(ownerIdString);
            var deposit = Price.From(depositDecimal);

            var offer = OfferFactory.Create(apartment, ownerId, period, pricePerDay,deposit);

            _offerRepository.Save(offer);

            return offer.Id;
        }
    }
}