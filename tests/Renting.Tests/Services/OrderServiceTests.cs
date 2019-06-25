using System;
using Autofac.Extras.Moq;
using Discounts.Application.Service;
using Discounts.Domain.Customers;
using Discounts.Domain.Discounts;
using FluentAssertions;
using Microsoft.VisualStudio.TestPlatform.Common.DataCollection;
using Moq;
using Renting.Application.Services;
using Renting.Domain.Discounts;
using Renting.Domain.Drafts;
using Renting.Domain.Offers;
using Renting.Persistence.InMemory;
using Xunit;

namespace Renting.Tests.Services
{
    public class OrderServiceTests
    {
        [Fact]
        public void Create_Should_Save_Offer()
        {
            using (var mock = AutoMock.GetLoose())
            {
                var offerRepository = new InMemoryOfferRepository();
                mock.Provide<IOfferRepository>(offerRepository);
                
                var offerId = CreateSampleOffer(mock);
                var offer = offerRepository.Get(offerId);
                
                offer.Should().NotBeNull();
                offer.Id.Should().BeEquivalentTo(offerId);
            }
        }

        private OfferId CreateSampleOffer(AutoMock mock)
        {
            var sut = mock.Create<OfferService>();
            var from = DateTime.Now.AddDays(-15);
            var to = DateTime.Now.AddDays(15);
            var apartmentId = Guid.NewGuid().ToString();
            var price = 13.24m;
            var owner = Guid.NewGuid().ToString();
            var deposit = 100.50m;
            
            return sut.Create(from, to, apartmentId, price, owner, deposit);
        }


        [Fact]
        public void Choose_Should_Return_Draft()
        {
            using (var mock = AutoMock.GetLoose())
            {
                var tenantIdString = Guid.NewGuid().ToString();
                var offerRepository = new InMemoryOfferRepository();
                mock.Provide<IOfferRepository>(offerRepository);
                var draftRepository = new InMemoryDraftRepository();
                mock.Provide<IDraftRepository>(draftRepository);
                mock.Mock<ICustomerRepository>().Setup(_ => _.Get(It.IsAny<CustomerId>())).Returns(new Customer(CustomerId.From(tenantIdString),1));
                var discountCalculationService = new DiscountCalculationService();
                var discountService = new DiscountService(mock.Create<ICustomerRepository>(), discountCalculationService);
                mock.Provide<IDiscountService>(discountService);
                var sut = mock.Create<OfferService>();
                var offerId = CreateSampleOffer(mock);
                
                var draftId = sut.Choose(offerId.ToString(), tenantIdString, DateTime.Now.AddDays(-10), DateTime.Now.AddDays(10));
                
                var draft = draftRepository.Get(draftId);
                draft.Should().NotBeNull();
                draft.Id.Should().BeEquivalentTo(draftId);
            }
        }
    }
}