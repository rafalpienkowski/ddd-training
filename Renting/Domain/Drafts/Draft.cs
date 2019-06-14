using Renting.Domain.Agreements;
using Renting.Domain.Apartments;
using Renting.Domain.Events;

namespace Renting.Domain.Drafts
{
    public class Draft
    {
        public DraftId Id { get; }
        private OwnerId _ownerId;
        private TenantId _tenantId;
        private Apartment _apartment;
        private Period _period;
        private Price _pricePerDay;
        private AgreementNumber _agreementNumber;
        private Price _deposit;
        private readonly IEventRegistry _eventRegistry;
        
        private Price TotalPrice
        {
            get
            {
                var totalPrice = _period.Days * _pricePerDay.ToDecimal();
                return Price.From(totalPrice);
            }
        }

        public Draft(OwnerId ownerId, TenantId tenantId, Apartment apartment, Period period, Price pricePerDay, AgreementNumber agreementNumber, Price deposit)
        {
            _ownerId = ownerId;
            _tenantId = tenantId;
            _apartment = apartment;
            _period = period;
            _pricePerDay = pricePerDay;
            _agreementNumber = agreementNumber;
            _deposit = deposit;
        }
        
        public Agreement Accept()
        {
            var draftAcceptedEvent = new DraftAccepted(_agreementNumber.ToString(), _ownerId.ToString(), _tenantId.ToString(), TotalPrice.ToDecimal());
            var agreement = new Agreement(_ownerId, _tenantId, _apartment, _period, _pricePerDay, _agreementNumber, _deposit);

            _eventRegistry.Publish(draftAcceptedEvent);
            
            return agreement;
        }
    }
}