namespace Renting.Domain.Apartments
{
    public class Area
    {
        private decimal _squareMeters;

        private Area(decimal squareMeters)
        {
            _squareMeters = squareMeters;
        }

        public static Area From(decimal squareMeters)
        {
            if (squareMeters <= 0)
            {
                throw new AreaLessThanZeroException(squareMeters);
            }
            return new Area(squareMeters);
        }
    }
}