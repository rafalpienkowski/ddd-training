namespace Discounts.Domain.Customers
{
    public class Customer
    {
        private CustomerId _customerId;
        private int _apartmentsHired;

        public Customer(CustomerId customerId, int apartmentsHired)
        {
            _customerId = customerId;
            _apartmentsHired = apartmentsHired;
        }

        public int ApartmentsHired => _apartmentsHired;
    }
}