using Payment.Domain.Events;
using Payment.Domain.Payment;
using Payment.Domain.Transfer;
using Renting.Domain.Agreements;

namespace Payment.Application.Service
{
    public class BalanceService : IBalanceService
    {
        private readonly IEventRegistry _eventRegistry;
        private readonly IAccountRepository _accountRepository;

        public BalanceService(IEventRegistry eventRegistry, IAccountRepository accountRepository)
        {
            _eventRegistry = eventRegistry;
            _accountRepository = accountRepository;
        }

        public bool HasFounds(AccountOwnerId accountOwnerId, Money money)
        {
            var account = _accountRepository.Get(accountOwnerId);
            return account.HasFounds(money);
        }
    }
}