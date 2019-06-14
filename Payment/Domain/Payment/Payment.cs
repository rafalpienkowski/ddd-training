using Payment.Domain.Events;
using Payment.Domain.Transfer;

namespace Payment.Domain.Payment
{
    public class Payment
    {
        private PaymentId _paymentId;
        private Account _source;
        private Account _destination;
        private Money _money;
        private readonly IEventRegistry _eventRegistry;

        public Payment(Account source, Account destination, Money money, IEventRegistry eventRegistry, PaymentId paymentId)
        {
            _source = source;
            _destination = destination;
            _money = money;
            _eventRegistry = eventRegistry;
            _paymentId = paymentId;
        }


        public void Pay(Title title)
        {
            _source.Withdraw(_money, title);
            _destination.Deposit(_money, title);
            
            var depositPaid = new DepositPaid(_source.AccountOwnerId.ToString(), _destination.AccountOwnerId.ToString(),
                title.ToString(), _paymentId.ToString());
            _eventRegistry.Publish(depositPaid);
        }

        public Money Money => _money;
    }
}