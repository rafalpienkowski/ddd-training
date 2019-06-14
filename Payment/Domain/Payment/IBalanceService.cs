using Payment.Domain.Transfer;

namespace Payment.Domain.Payment
{
    public interface IBalanceService
    {
        bool HasFounds(AccountOwnerId agreementId, Money money);
    }
}