using System;

namespace Renting.Domain.Discounts
{
    public interface IDiscountService
    {
        //TODO dodanie dto do komunikacji
        Discount CalculateDiscount(string tenantId, string offerId, DateTime from, DateTime to);
    }
}