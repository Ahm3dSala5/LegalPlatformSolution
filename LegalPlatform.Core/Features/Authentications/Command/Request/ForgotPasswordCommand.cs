using GraduationProjecrStore.Infrastructure.Domain.DTOs.Authentication;
using GraduationProjectStore.Core.ResultHandlers;
using MediatR;

namespace GraduationProjectStore.Core.Feature.Authentications.Command.Request
{
    public class ForgotPasswordCommand : IRequest<Result<string>>
    {
        public ForgotPasswordCommand(string uaername)
        {
            this.UserName = uaername;
        }

        public string UserName { get; }
    }
}
