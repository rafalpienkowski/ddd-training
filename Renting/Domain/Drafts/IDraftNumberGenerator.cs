using Renting.Domain.Agreements;
using Renting.Domain.Offers;

namespace Renting.Domain.Drafts
{
    public interface IDraftNumberGenerator
    {
        AgreementNumber GetNextAvailable(TenantId tenantId, OfferId offerId);
    }
}