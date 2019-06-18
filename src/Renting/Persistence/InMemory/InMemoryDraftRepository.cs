using System.Collections.Generic;
using System.Linq;
using Renting.Domain.Drafts;

namespace Renting.Persistence.InMemory
{
    public class InMemoryDraftRepository : IDraftRepository
    {
        private readonly List<Draft> _drafts = new List<Draft>();

        public Draft Get(DraftId draftId)
        {
            return _drafts.SingleOrDefault(d => d.Id.Equals(draftId));
        }

        public void Save(Draft draft)
        {
            _drafts.Add(draft);
        }
    }
}