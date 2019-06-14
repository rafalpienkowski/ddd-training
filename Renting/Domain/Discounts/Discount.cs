namespace Renting.Domain.Discounts
{
    public class Discount
    {
        private int _percentage;

        private Discount(int percentage)
        {
            _percentage = percentage;
        }

        public static Discount From(int percentage)
        {
            return new Discount(percentage);
        }

        public decimal ToDecimal()
        {
            return _percentage/100;
        }
    }
}