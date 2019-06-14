namespace Renting.Domain.Agreements
{
    public interface IAgreementRepository
    {
        void Save(Agreement agreement);

        Agreement Get(AgreementId agreementId);
    }
}