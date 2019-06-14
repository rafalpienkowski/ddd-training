namespace Payment.Domain.Transfer
{
    public class Title
    {
        private string _name;

        private Title(string name)
        {
            _name = name;
        }

        public static Title ToTransferTitle(string agreementNumber)
        {
            return new Title($"Rent for {agreementNumber}");
        }

        public static Title From(string title)
        {
            return new Title(title);
        }

        public override string ToString()
        {
            return _name;
        }
    }
}