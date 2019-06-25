using System;

namespace Renting.Domain.Discounts
{
    public interface IDiscountService
    {
        Discount CalculateDiscount(string tenantId, string offerId, DateTime from, DateTime to);
    }
}