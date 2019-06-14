namespace Payment.Domain.Transfer
{
    public class Money
    {
        public decimal Amount { get; }

        private Money(decimal amount)
        {
            Amount = amount;
        }

        public static Money From(decimal price)
        {
            return new Money(price);
        }
    }
}