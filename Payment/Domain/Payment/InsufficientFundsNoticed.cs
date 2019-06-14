namespace Payment.Domain.Payment
{
    public class InsufficientFundsNoticed
    {
        public string AccountId { get; }
        public string PaymentId { get; }

        public InsufficientFundsNoticed(string accountId, string paymentId)
        {
            AccountId = accountId;
            PaymentId = paymentId;
        }
    }
}