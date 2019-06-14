namespace Renting.Domain.Offers
{
    public class OfferId
    {
        public string Id { get; }
        
        private OfferId(string id)
        {
            Id = id;
        }

        public static OfferId From(string offerIdString)
        {
            return new OfferId(offerIdString);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)  
                return false;
            if (GetType() != obj.GetType()) return false; 
  
            var p = (OfferId)obj;  
            return Id == p.Id; 
        }
    }
}