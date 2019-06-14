namespace Payment.Domain.Transfer
{
    public class MoneyTransferService
    {
        internal void Transfer(Account source, Account destination, Money money, Title title)
        {
            source.Withdraw(money, title);
            destination.Deposit(money, title);
        }
    }

    public class MoneyCollected
    {
        public string AccountOwnerOwnerId { get; }
        public string Reason { get; }
        public decimal Amount { get; }

        public MoneyCollected(string accountOwnerId, string reason, decimal amount)
        {
            AccountOwnerOwnerId = accountOwnerId;
            Reason = reason;
            Amount = amount;
        }
    }

    public class MoneyPaid
    {
        public string AccountOwnerId { get; }
        public string Reason { get; }
        public decimal Amount { get; }

        public MoneyPaid(string accountOwnerId, string reason, decimal amount)
        {
            AccountOwnerId = accountOwnerId;
            Reason = reason;
            Amount = amount;
        }
    }
}