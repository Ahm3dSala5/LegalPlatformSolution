using GraduationProjecrStore.Infrastructure.Domain.DTOs.Authentication;
using GraduationProjectStore.Core.ResultHandlers;
using MediatR;

namespace GraduationProjectStore.Core.Feature.Authentications.Command.Request
{
    public class ConfirmForgotpasswordCommand : IRequest<Result<object>>
    {
        public ConfirmForgotpasswordCommand(ConfirmForgotPasswordDTO confirmForgetPasswordDTO)
        {
           this.ConfirmForgetPasswordDTO = confirmForgetPasswordDTO;
        }
        public ConfirmForgotPasswordDTO ConfirmForgetPasswordDTO { get; }
    }
}
