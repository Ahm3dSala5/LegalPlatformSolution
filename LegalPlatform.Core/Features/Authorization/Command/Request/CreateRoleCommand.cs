using GraduationProjectStore.Core.ResultHandlers;
using MediatR;

namespace GraduationProjectStore.Core.Feature.Authorization.Command.Request
{
    public class CreateRoleCommand : IRequest<Result<string>>
    {
        public CreateRoleCommand(string rolename)
        {
            this.rolename = rolename;
        }

        public string rolename { get; }
    }
}
