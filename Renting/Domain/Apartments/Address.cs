namespace Renting.Domain.Apartments
{
    public class Address
    {
        private string _streetName;
        private string _postalCode;

        private Address(string streetName, string postalCode)
        {
            _streetName = streetName;
            _postalCode = postalCode;
        }
        
        public static Address From(string streetName, string postalCode)
        {
            return new Address(streetName, postalCode);
        }
    }
}