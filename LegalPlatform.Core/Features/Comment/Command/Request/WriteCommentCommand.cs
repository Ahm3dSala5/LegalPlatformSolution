using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraduationProjectStore.Core.ResultHandlers;
using LegalPlatform.Infrastructure.Domain.DTOs.Comments;
using MediatR;

namespace LegalPlatform.Core.Features.Comments.Command.Request
{
    public class WriteCommentCommand : IRequest<Result<string>>
    {
        public WriteCommentCommand(WriteCommentDTO comment)
        {
            Comment = comment;
        }
        public WriteCommentDTO Comment { get; }
    }
}
