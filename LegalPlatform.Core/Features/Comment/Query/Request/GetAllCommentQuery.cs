using GraduationProjectStore.Core.ResultHandlers;
using LegalPlatform.Core.Features.Comments.Query.Model;
using MediatR;

namespace LegalPlatform.Core.Features.Comments.Query.Request
{
    public class GetAllCommentQuery : IRequest<Result<ICollection<CommentModel>>>
    {

    }
}
