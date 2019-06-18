using Notification.Application.Listeners;
using Notification.Domain.Notifications;

namespace Notification.Domain.Events
{
    public interface IEventRegistry
    {
        void Publish(NotificationCreated notificationCreated);
    }
}