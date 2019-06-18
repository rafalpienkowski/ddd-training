using System;
using Renting.Domain;
using Renting.Domain.Agreements;
using Renting.Domain.Drafts;
using Renting.Domain.Offers;

namespace Agreement.Application.Services.Agreement
{
    public class DraftNumberGenerator : IDraftNumberGenerator
    {
        public string GetNextAvailable()
        {
            return $"Agreement/{new Random().Next(1, 1000000)}";
        }

        public AgreementNumber GetNextAvailable(TenantId tenantId, OfferId offerId)
        {
            return AgreementNumber.From("123");
        }
    }
}