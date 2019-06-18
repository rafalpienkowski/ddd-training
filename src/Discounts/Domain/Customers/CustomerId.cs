namespace Discounts.Domain.Customers
{
    public class CustomerId
    {
        private string _customerId;

        private CustomerId(string customerId)
        {
            _customerId = customerId;
        }

        public static CustomerId From(string customerId)
        {
            return new CustomerId(customerId);
        }
    }
}