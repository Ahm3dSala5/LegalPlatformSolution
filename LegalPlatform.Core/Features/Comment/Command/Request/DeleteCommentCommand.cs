using GraduationProjectStore.Core.ResultHandlers;
using MediatR;

namespace LegalPlatform.Core.Features.Comments.Command.Request
{
    public class DeleteCommentCommand : IRequest<Result<string>>
    {
        public DeleteCommentCommand(Guid commentId)
        {
            this.CommentId = commentId;
        }
        public Guid CommentId { get; }
    }


}
