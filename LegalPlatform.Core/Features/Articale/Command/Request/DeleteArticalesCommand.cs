using GraduationProjectStore.Core.ResultHandlers;
using MediatR;

namespace LegalPlatform.Core.Features.Articales.Command.Request
{
    public class DeleteArticalesCommand : IRequest<Result<string>>
    {
        public DeleteArticalesCommand(Guid id)
        {
            this.Id = id;
        }
        public Guid Id { get; }
    }
}
