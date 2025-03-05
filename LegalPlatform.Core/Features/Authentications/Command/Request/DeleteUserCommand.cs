using GraduationProjectStore.Core.ResultHandlers;
using MediatR;

namespace GraduationProjectStore.Core.Feature.Authentications.Command.Request
{
    public class DeleteUserCommand : IRequest<Result<string>>
    {
        public DeleteUserCommand(string username)
        {
            Username = username;
        }

        public string Username { get; }
    }
}