using GraduationProjecrStore.Infrastructure.Domain.DTOs.Authentication;
using GraduationProjectStore.Core.ResultHandlers;
using MediatR;

namespace GraduationProjectStore.Core.Feature.Authentications.Command.Request
{
    public class ChangePasswordCommand : IRequest<Result<string>>
    {
        public ChangePasswordCommand(ChangePassowrdDTO chmagePassword)
        {
            this.ChmagePassword = chmagePassword;
        }
        public ChangePassowrdDTO ChmagePassword { get; }
    }
}
