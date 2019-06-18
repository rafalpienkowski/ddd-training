namespace Renting.Domain.Offers
{
    public interface IOfferRepository
    {
        Offer Get(OfferId offerId);
        void Save(Offer offer);
    }
}