namespace Discounts.Domain.Customers
{
    public interface ICustomerRepository
    {
        Customer Get(CustomerId customerId);
    }
}