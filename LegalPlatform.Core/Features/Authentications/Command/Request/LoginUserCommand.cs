using GraduationProjecrStore.Infrastructure.Domain.DTOs.Authentication;
using GraduationProjectStore.Core.ResultHandlers;
using MediatR;

namespace GraduationProjectStore.Core.Feature.Authentications.Command.Request
{
    public class LoginUserCommand : IRequest<Result<object>>
    {
        public LoginUserCommand(LoginDTO loginDTO)
        {
            this.LoginDTO = loginDTO;
        }
        public LoginDTO LoginDTO { get; }
    }
}
