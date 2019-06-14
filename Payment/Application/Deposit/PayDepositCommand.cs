namespace Payment.Application.Deposit
{
    public class PayDepositCommand
    {
        public PayDepositCommand(string agreementId, string tenantId)
        {
            AgreementId = agreementId;
            TenantId = tenantId;
        }

        public string AgreementId { get; }
        public string TenantId { get; }
    }
}