namespace Renting.Domain.Apartments
{
    public interface IApartmentRepository
    {
        void Save(Apartment apartment);
        Apartment Get(ApartmentId apartmentId);
    }
}