using GraduationProjectStore.Core.ResultHandlers;
using LegalPlatform.Infrastructure.Domain.Entity.Security;
using MediatR;

namespace GraduationProjectStore.Core.Feature.Authentications.Query.Request
{
    public class GetAllUserQuery :IRequest<Result<ICollection<LegalUser>>>
    {

    }
}
