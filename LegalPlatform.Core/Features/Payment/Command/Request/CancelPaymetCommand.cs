using GraduationProjectStore.Core.ResultHandlers;
using MediatR;

namespace LegalPlatform.Core.Features.Payments.Command.Request
{
    public class CancelPaymetCommand : IRequest<Result<string>>
    {
        public CancelPaymetCommand(Guid id)
        {
            this.Id = id;
        }

        public Guid Id { get; }
    }
}
