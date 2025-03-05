using GraduationProjectStore.Core.ResultHandlers;
using MediatR;

namespace GraduationProjectStore.Core.Feature.Authentications.Command.Request
{
    public class ConfirmRegisterationCommand : IRequest<Result<object>>
    {
        public ConfirmRegisterationCommand(string username, string code)
        {
            this.username = username;
            Code = code;
        }

        public string username { get; }
        public string Code { get; }
    }
}
