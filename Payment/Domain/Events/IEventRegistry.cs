using Payment.Domain.Payment;

namespace Payment.Domain.Events
{
    public interface IEventRegistry
    {
        void Publish(DepositPaid depositPaid);

        void Publish(InsufficientFundsNoticed insufficientFunds);
    }
}