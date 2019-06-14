using Notification.Domain.Events;
using Notification.Domain.Notifications;
using Payment.Domain.Payment;

namespace Notification.Application.Listeners
{
    public class DepositPaidListener
    {
        private readonly IEventRegistry _eventRegistry;

        public DepositPaidListener(IEventRegistry eventRegistry)
        {
            _eventRegistry = eventRegistry;
        }

        public void Handle(DepositPaid depositPaid)
        {
            var tenantNotificationCreated =
                new NotificationCreated(depositPaid.TenantId, depositPaid.PaymentId, depositPaid.AgreementId);
            _eventRegistry.Publish(tenantNotificationCreated);

            var ownerNotificationCreated =
                new NotificationCreated(depositPaid.OwnerId, depositPaid.PaymentId, depositPaid.AgreementId);
            _eventRegistry.Publish(ownerNotificationCreated);
        }
    }
}