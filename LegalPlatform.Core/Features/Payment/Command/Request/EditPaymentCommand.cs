using GraduationProjectStore.Core.ResultHandlers;
using LegalPlatform.Infrastructure.Domain.DTOs.Payment;
using MediatR;

namespace LegalPlatform.Core.Features.Payments.Command.Request
{
    public class EditPaymentCommand : IRequest<Result<string>>
    {
        public EditPaymentCommand(EditPaymentDTO payment)
        {
            this.Payment = payment;
        }

        public EditPaymentDTO Payment { get; }
    }
}
