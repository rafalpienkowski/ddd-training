namespace Renting.Domain.Apartments
{
    public class ApartmentId
    {
        private string _id;

        private ApartmentId(string apartmentId)
        {
            _id = apartmentId;
        }

        public static ApartmentId From(string apartmentId)
        {
            return new ApartmentId(apartmentId);
        }
    }
}