using GraduationProjectStore.Core.ResultHandlers;
using MediatR;

namespace GraduationProjectStore.Core.Feature.Authorization.Command.Request
{
    public class RemoveUserFromRoleCommand : IRequest<Result<string>>
    {
        public RemoveUserFromRoleCommand(string rolename,string username)
        {
            Rolename = rolename;
            Username = username;
        }

        public string Rolename { get; }
        public string Username { get; }
    }
}
