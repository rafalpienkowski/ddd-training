namespace Payment.Domain.Payment
{
    public class PaymentId
    {
        private string _id;

        private PaymentId(string id)
        {
            _id = id;
        }

        public static PaymentId From(string paymentId)
        {
            return new PaymentId(paymentId);
        }

        public override string ToString()
        {
            return _id;
        }
    }
}