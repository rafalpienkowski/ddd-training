using System;
using System.Collections.Generic;
using Renting.Domain;
using Renting.Domain.Apartments;

namespace Renting.Application.Services
{
    public class ApartmentService
    {
        private readonly IApartmentRepository _apartmentRepository;

        public ApartmentService(IApartmentRepository apartmentRepository)
        {
            _apartmentRepository = apartmentRepository;
        }

        public void Add(CreateApartmentDto createApartmentDto)
        {
            var address = Address.From(createApartmentDto.StreetName, createApartmentDto.PostalCode);
            var ownerId = OwnerId.From(createApartmentDto.OwnerId);
            var rooms = new List<Room>();
            foreach (var (area, type) in createApartmentDto.Rooms)
            {
                var room = Room.From(area, type);
                rooms.Add(room);
            }

            var apartment = ApartmentFactory.Create(address, ownerId, rooms);

            _apartmentRepository.Save(apartment);
        }
    }
}