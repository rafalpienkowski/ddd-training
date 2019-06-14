using Payment.Domain.Events;
using Payment.Domain.Payment;
using Payment.Domain.Transfer;

namespace Payment.Application.Service
{
    public class PaymentService
    {
        private readonly IBalanceService _balanceService;
        private readonly IEventRegistry _eventRegistry;

        public PaymentService(IBalanceService balanceService, IEventRegistry eventRegistry)
        {
            _balanceService = balanceService;
            _eventRegistry = eventRegistry;
        }

        public void PayDeposit(AccountOwnerId accountId, Title title, Domain.Payment.Payment payment, PaymentId paymentId)
        {
            if (_balanceService.HasFounds(accountId, payment.Money))
            {
                payment.Pay(title);
                return;
            }
            
            _eventRegistry.Publish(new InsufficientFundsNoticed(accountId.ToString(), paymentId.ToString()));
        }
    }
}