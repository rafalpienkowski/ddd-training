using Renting.Domain.Drafts;

namespace Renting.Domain.Events
{
    public interface IEventRegistry
    {
        void Publish(DraftAccepted draftAccepted);
    }
}