using Renting.Domain.Agreements;
using Renting.Domain.Drafts;

namespace Renting.Application.Services
{
    public class DraftService
    {
        private readonly IAgreementRepository _agreementRepository;
        private readonly IDraftRepository _draftRepository;

        public DraftService(IAgreementRepository agreementRepository, IDraftRepository draftRepository)
        {
            _agreementRepository = agreementRepository;
            _draftRepository = draftRepository;
        }

        public void Accept(string draftIdString)
        {
            var draftId = DraftId.From(draftIdString);
            var draft = _draftRepository.Get(draftId);
            
            var agreement = draft.Accept();
            
            _agreementRepository.Save(agreement);
        }
    }
}