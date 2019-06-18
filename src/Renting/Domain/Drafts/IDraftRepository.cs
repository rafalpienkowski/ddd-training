namespace Renting.Domain.Drafts
{
    public interface IDraftRepository
    {
        Draft Get(DraftId draftId);
        void Save(Draft draft);
    }
}