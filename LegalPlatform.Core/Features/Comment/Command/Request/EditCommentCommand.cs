using GraduationProjectStore.Core.ResultHandlers;
using LegalPlatform.Infrastructure.Domain.DTOs.Comments;
using MediatR;

namespace LegalPlatform.Core.Features.Comments.Command.Request
{
    public class EditCommentCommand : IRequest<Result<string>>
    {
        public EditCommentCommand(EditCommentDTO comment)
        {
            this.Comment = comment;
        }

        public EditCommentDTO Comment { get; }
    }


}
