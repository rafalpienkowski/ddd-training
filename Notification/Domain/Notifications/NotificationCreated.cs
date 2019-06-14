namespace Notification.Domain.Notifications
{
    public class NotificationCreated
    {
        public string RecipientId { get; }
        public string Subject { get; }
        public string Content { get; }

        public NotificationCreated(string recipientId, string subject, string content)
        {
            RecipientId = recipientId;
            Subject = subject;
            Content = content;
        }
    }
}