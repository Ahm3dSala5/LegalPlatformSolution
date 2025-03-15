using GraduationProjectStore.Core.ResultHandlers;
using LegalPlatform.Core.Features.Payments.Query.Model;
using MediatR;

namespace LegalPlatform.Core.Features.Payments.Query.Request
{
    public class GetAllPaymentQuery : IRequest<Result<ICollection<PaymentModel>>>
    {

    }
}
