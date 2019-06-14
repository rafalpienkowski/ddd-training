namespace Renting.Domain.Drafts
{
    //TODO Czy na to też factory method/class?
    public class DraftAccepted
    {
        public string AgreementNumber { get; }
        public string OwnerId { get; }
        public string TenantId { get; }
        public decimal Price { get; }

        public DraftAccepted(string agreementNumber, string ownerId, string tenantId, decimal price)
        {
            AgreementNumber = agreementNumber;
            OwnerId = ownerId;
            TenantId = tenantId;
            Price = price;
        }
    }
}