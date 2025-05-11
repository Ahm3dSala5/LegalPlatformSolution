using Graduation_Project_Store.API.Bases;
using LegalPlatform.Core.Features.Comments.Command.Request;
using LegalPlatform.Core.Features.Comments.Query.Request;
using LegalPlatform.Infrastructure.Domain.DTOs.Comments;
using Microsoft.AspNetCore.Mvc;

namespace LegalPlatform.API.Controllers
{
    [ApiController]
    [Route("api/Comment")]
    public class CommentController : Base
    {
        [HttpPost("Write")]
        public async Task<IActionResult> Write([FromBody] WriteCommentDTO comment)
        {
            var writeCommand = await Mediator.Send(new WriteCommentCommand(comment));
            return HandledResult(writeCommand);
        }

        [HttpGet("Get/{Id}")]
        public async Task<IActionResult> Get([FromHeader] Guid Id)
        {
            var GetQuery = await Mediator.Send(new GetCommentByIdQuery(Id));
            return HandledResult(GetQuery);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var GetQuery = await Mediator.Send(new GetAllCommentQuery());
            return HandledResult(GetQuery);
        }

        [HttpPut("Edit")]
        public async Task<IActionResult> Edit([FromBody] EditCommentDTO comment)
        {
            var editCommand = await Mediator.Send(new EditCommentCommand(comment));
            return HandledResult(editCommand);
        }

        [HttpDelete("Delete/{Id}")]
        public async Task<IActionResult> Delete([FromHeader] Guid Id)
        {
            var deleteCommand = await Mediator.Send(new DeleteCommentCommand(Id));
            return HandledResult(deleteCommand);
        }
    }
}
