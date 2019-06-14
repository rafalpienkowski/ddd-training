namespace Payment.Domain.Transfer
{
    public class AccountOwnerId
    {
        private AccountOwnerId(string id)
        {
            _id = id;
        }

        private readonly string _id;

        public static AccountOwnerId From(string accountOwnerId)
        {
            return new AccountOwnerId(accountOwnerId);
        }

        public override string ToString()
        {
            return _id;
        }
    }
}