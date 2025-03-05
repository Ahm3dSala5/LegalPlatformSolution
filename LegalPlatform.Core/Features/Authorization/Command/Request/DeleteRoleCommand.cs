using GraduationProjectStore.Core.ResultHandlers;
using MediatR;

namespace GraduationProjectStore.Core.Feature.Authorization.Command.Request
{
    public class DeleteRoleCommand : IRequest<Result<string>>
    {
        public DeleteRoleCommand(string rolename)
        {
            this.rolename = rolename;
        }

        public string rolename { get; }
    }
}
