using GraduationProjectStore.Core.ResultHandlers;
using LegalPlatform.Core.Features.Articales.Query.Model;
using MediatR;

namespace LegalPlatform.Core.Features.Articales.Query.Request
{
    public class GetAllArticalesQuery : IRequest<Result<ICollection<ArticaleModel>>>
    {

    }

}
