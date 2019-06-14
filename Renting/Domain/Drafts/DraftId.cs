namespace Renting.Domain.Drafts
{
    public class DraftId
    {
        public string Id { get; }

        private DraftId(string id)
        {
            Id = id;
        }

        public static DraftId From(string draftId)
        {
            return new DraftId(draftId);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)  
                return false;
            if (GetType() != obj.GetType()) return false; 
  
            var p = (DraftId)obj;  
            return Id == p.Id; 
        }
    }
}