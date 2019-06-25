using System;
using Discounts.Domain.Customers;
using Discounts.Domain.Discounts;
using Renting.Domain.Discounts;
using Discount = Renting.Domain.Discounts.Discount;

namespace Discounts.Application.Service
{
    public class DiscountService : IDiscountService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly DiscountCalculationService _discountCalculationService;

        public DiscountService(ICustomerRepository customerRepository, DiscountCalculationService discountCalculationService)
        {
            _customerRepository = customerRepository;
            _discountCalculationService = discountCalculationService;
        }

        public Discount CalculateDiscount(string tenantId, string offerId, DateTime from, DateTime to)
        {
            var customerId = CustomerId.From(tenantId);
            var customer = _customerRepository.Get(customerId);
            var discount = _discountCalculationService.Calculate(customer);
            return Discount.From(discount.ToInt());
        }
    }
}