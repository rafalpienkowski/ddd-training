namespace Renting.Domain.Agreements
{
    public class AgreementId
    {
        private string _id;

        private AgreementId(string id)
        {
            _id = id;
        }

        public static AgreementId From(string agreementId)
        {
            return new AgreementId(agreementId);
        }
    }
}