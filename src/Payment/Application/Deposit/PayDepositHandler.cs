using Payment.Application.Service;
using Payment.Domain.Payment;
using Payment.Domain.Transfer;

namespace Payment.Application.Deposit
{
    public class PayDepositHandler
    {
        private readonly IPaymentRepository _paymentRepository;
        private readonly PaymentService _paymentService;

        public PayDepositHandler(IPaymentRepository paymentRepository, PaymentService paymentService)
        {
            _paymentRepository = paymentRepository;
            _paymentService = paymentService;
        }

        public void Handle(PayDepositCommand payDepositCommand)
        {
            var paymentId = PaymentId.From(payDepositCommand.AgreementId);
            var payment = _paymentRepository.Get(paymentId);
            var accountId = AccountOwnerId.From(payDepositCommand.TenantId);
            var title = Title.From("Deposit payment");
            
            _paymentService.PayDeposit(accountId, title, payment, paymentId);
        }
    }
}