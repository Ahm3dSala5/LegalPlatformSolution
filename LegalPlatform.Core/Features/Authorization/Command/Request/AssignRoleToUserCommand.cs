using GraduationProjectStore.Core.ResultHandlers;
using MediatR;

namespace GraduationProjectStore.Core.Feature.Authorization.Command.Request
{
    public class AssignRoleToUserCommand : IRequest<Result<string>>
    {
        public AssignRoleToUserCommand(string roleName ,string username)
        {
            RoleName = roleName;
            Username = username;
        }

        public string RoleName { get; }
        public string Username { get; }
    }
}
