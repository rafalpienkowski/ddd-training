using Payment.Application.Listeners.Drafs;
using Renting.Domain.Drafts;
using Renting.Domain.Events;

namespace EventBus.Persistence.InMemory
{
    public class InMemoryEventBus : IEventRegistry
    {

        private DraftAcceptedListener _draftAcceptedEventListener;
        
        public void Subscribe(DraftAcceptedListener draftAcceptedEventListener)
        {
            _draftAcceptedEventListener = draftAcceptedEventListener;
        }

        public void Publish(DraftAccepted draftAccepted)
        {
            _draftAcceptedEventListener?.Handle(draftAccepted);
        }

    }
}