using Renting.Domain.Apartments;

namespace Renting.Domain.Agreements
{
    public class Agreement
    {
        private AgreementId _id;
        private AgreementNumber _number;
        private OwnerId _ownerId;
        private TenantId _tenantId;
        private Apartment _apartment;
        private Period _period;
        private Price _price;
        private Price _deposit;

        public Agreement(OwnerId ownerId, TenantId tenantId, Apartment apartment, Period period, Price price, AgreementNumber number, Price deposit)
        {
            _ownerId = ownerId;
            _tenantId = tenantId;
            _apartment = apartment;
            _period = period;
            _price = price;
            _number = number;
            _deposit = deposit;
        }
    }
}