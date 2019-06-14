namespace Renting.Domain
{
    public class Price
    {
        private readonly decimal _amount;

        private Price(decimal amount)
        {
            _amount = amount;
        }

        public static Price From(decimal price)
        {
            return new Price(price);
        }

        public decimal ToDecimal()
        {
            return _amount;
        }
    }
}