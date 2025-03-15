using GraduationProjectStore.Core.ResultHandlers;
using MediatR;

namespace LegalPlatform.Core.Features.Payments.Command.Request
{
    public class CancelPaymetCommand : IRequest<Result<string>>
    {

    }
}
