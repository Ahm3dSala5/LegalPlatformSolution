using GraduationProjectStore.Core.ResultHandlers;
using LegalPlatform.Infrastructure.Domain.Entity.Security;
using MediatR;
namespace GraduationProjectStore.Core.Feature.Authentications.Query.Request
{
    public class GetUserByUsernameQuery: IRequest<Result<LegalUser>>
    {
        public string Username { get; set; }

        public GetUserByUsernameQuery(string username)
        {
            this.Username = username;
        }
    }
}
