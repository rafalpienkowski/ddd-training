using Payment.Domain.Transfer;
using Renting.Domain.Drafts;

namespace Payment.Application.Listeners.Drafs
{
    //TODO czy to dobry namespace?
    //TODO gdzie to subskrynować?
    public class DraftAcceptedListener
    {
        private readonly IAccountRepository _accountRepository;
        private readonly MoneyTransferService  _transferMoneyService = new MoneyTransferService();

        public DraftAcceptedListener(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public void Handle(DraftAccepted draftAccepted)
        {
            var sourceAccountOwnerId = AccountOwnerId.From(draftAccepted.TenantId);
            var destinationAccountOwnerId = AccountOwnerId.From(draftAccepted.OwnerId);
            var sourceAccount = _accountRepository.Get(sourceAccountOwnerId);
            var destinationAccount = _accountRepository.Get(destinationAccountOwnerId);
            var money = Money.From(draftAccepted.Price);
            var title = Title.ToTransferTitle(draftAccepted.AgreementNumber);

            _transferMoneyService.Transfer(sourceAccount, destinationAccount, money, title);
        }
    }
}