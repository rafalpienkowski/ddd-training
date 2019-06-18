namespace Renting.Domain.Agreements
{
    public class AgreementNumber
    {
        private readonly string _number;

        private AgreementNumber(string number)
        {
            _number = number;
        }

        public static AgreementNumber From(string number)
        {
            return new AgreementNumber(number);
        }

        public override string ToString()
        {
            return _number;
        }
    }
}