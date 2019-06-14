using Discounts.Application.Service;
using Discounts.Domain.Customers;

namespace Discounts.Domain.Discounts
{
    public class DiscountCalculationService
    {
        public Discount Calculate(Customer customer)
        {
            if (customer.ApartmentsHired % 10 == 0)
            {
                return Discount.From(10);
            }
            
            return Discount.From(0);
        }
    }
}