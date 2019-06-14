namespace Payment.Domain.Payment
{
    public interface IPaymentRepository
    {
        Payment Get(PaymentId paymentId);
    }
}