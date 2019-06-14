using System.Collections.Generic;
using System.Linq;
using Renting.Domain.Agreements;

namespace Renting.Persistence.InMemory
{
    public class InMemoryAgreementRepository : IAgreementRepository
    {
        private readonly List<Agreement> _agreements = new List<Agreement>();
        
        public void Save(Agreement agreement)
        {
            _agreements.Add(agreement);
        }

        public Agreement Get(AgreementId agreementId)
        {
            return _agreements.SingleOrDefault();
        }
    }
}