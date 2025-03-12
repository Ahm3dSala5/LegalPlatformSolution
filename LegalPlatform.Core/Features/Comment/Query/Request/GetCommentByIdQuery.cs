using GraduationProjectStore.Core.ResultHandlers;
using LegalPlatform.Core.Features.Comments.Query.Model;
using MediatR;

namespace LegalPlatform.Core.Features.Comments.Query.Request
{
    public class GetCommentByIdQuery : IRequest<Result<CommentModel>>
    {
        public GetCommentByIdQuery(Guid commentId)
        {
            CommentId = commentId;
        }
        public Guid CommentId { get; }
    }
}
