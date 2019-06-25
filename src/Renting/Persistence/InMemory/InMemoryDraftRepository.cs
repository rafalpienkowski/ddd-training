using System.Collections.Generic;
using System.Linq;
using Renting.Domain.Drafts;

namespace Renting.Persistence.InMemory
{
    public class InMemoryDraftRepository : IDraftRepository
    {
        private static readonly List<Draft> Drafts = new List<Draft>();

        public Draft Get(DraftId draftId)
        {
            return Drafts.SingleOrDefault(d => d.Id.Equals(draftId));
        }

        public void Save(Draft draft)
        {
            Drafts.Add(draft);
        }
    }
}