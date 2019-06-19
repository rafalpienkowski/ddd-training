using System;
using Autofac.Extras.Moq;
using FluentAssertions;
using Renting.Application.Services;
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
                
                var sut = mock.Create<OfferService>();
                var from = DateTime.Now.AddDays(-15);
                var to = DateTime.Now.AddDays(15);
                var apartmentId = Guid.NewGuid().ToString();
                var price = 13.24m;
                var owner = Guid.NewGuid().ToString();
                var deposit = 100.50m;
                
                var offerId = sut.Create(from, to, apartmentId, price, owner, deposit);

                var offer = offerRepository.Get(offerId);
                
                offer.Should().NotBeNull();
                offer.Id.Should().BeEquivalentTo(offerId);
            }
        }
    }
}