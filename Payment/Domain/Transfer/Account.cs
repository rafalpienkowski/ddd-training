namespace Payment.Domain.Transfer
{
    public class Account
    {
        private Money _founds;
        private AccountOwnerId _accountOwnerId;

        public Account(AccountOwnerId accountOwnerId)
        {
            _accountOwnerId = accountOwnerId;
        }

        public Money Withdraw(Money money, Title title)
        {
            if (money.Amount > _founds.Amount)
            {
                throw new OutOfFoundsException(this, money);
            }
            
            return Money.From(money.Amount);
        }

        public bool HasFounds(Money money)
        {
            return _founds.Amount > money.Amount;
        }

        public void Deposit(Money money, Title title)
        {
            _founds = Money.From(_founds.Amount + money.Amount);
        }
        
        public AccountOwnerId AccountOwnerId => _accountOwnerId;
    }
}