namespace Payment.Domain.Transfer
{
    public interface IAccountRepository
    {
        Account Get(AccountOwnerId accountOwnerId);
    }
}