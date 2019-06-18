namespace Payment.Domain.Payment
{
    public class DepositPaid
    {
        public string TenantId { get; }
        public string OwnerId { get; }
        public string AgreementId { get; }
        public string PaymentId { get; }

        public DepositPaid(string tenantId, string ownerId, string agreementId, string paymentId)
        {
            TenantId = tenantId;
            OwnerId = ownerId;
            AgreementId = agreementId;
            PaymentId = paymentId;
        }
    }
}