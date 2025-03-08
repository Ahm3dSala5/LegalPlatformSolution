using GraduationProjectStore.Core.ResultHandlers;
using LegalPlatform.Infrastructure.Domain.DTOs.Articale;
using MediatR;

namespace LegalPlatform.Core.Features.Articales.Command.Request
{
    public class UpdateArticalesCommand : IRequest<Result<string>>
    {
        public UpdateArticalesCommand(UpdateArticaleDTO articale)
        {
            this.Articale = articale;
        }
        public UpdateArticaleDTO Articale { get; }
    }
}
