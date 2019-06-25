using Renting.Domain.Agreements;
using Renting.Domain.Offers;

namespace Renting.Domain.Drafts
{
    internal class DefaultDraftNumberGenerator : IDraftNumberGenerator
    {
        public AgreementNumber GetNextAvailable(TenantId tenantId, OfferId offerId)
        {
            return AgreementNumber.From($"{offerId}-{tenantId}");
        }
    }
}