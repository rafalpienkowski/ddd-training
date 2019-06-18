namespace Renting.Domain
{
    public class OwnerId
    {
        private readonly string _id;

        private OwnerId(string id)
        {
            _id = id;
        }

        public static OwnerId From(string id)
        {
            return new OwnerId(id);
        }

        public override string ToString()
        {
            return _id;
        }
    }
}