using LegalPlatform.Infrastructure.Domain.DTOs.Comments;
using LegalPlatform.Infrastructure.Domain.Entity.Business;
using LegalPlatform.Infrastructure.Persistence.Context;
using LegalPlatform.Infrastructure.Repository;
using LegalPlatform.Service.Abstraction.Business;
using Microsoft.Extensions.Configuration;

namespace LegalPlatform.Service.Implementation.Business
{
    public class CommentService : MainRepository<Comment>, ICommentService
    {
        private readonly LegalPlatformContext _legalPlatformContext;
        public CommentService(LegalPlatformContext context, IConfiguration config) : base(context, config)
        {
            this._legalPlatformContext = context;
        }

        public async ValueTask<string> EditCommentAsync(EditCommentDTO comment)
        {
            var _comment = await _legalPlatformContext.Comments.FindAsync(comment.Comment_Id);   
            if(_comment == null)
                return "NotFound";

            if(_comment.UserId != comment.UserId)
                return "Unauhorized";

            _legalPlatformContext.Entry(_comment).CurrentValues.SetValues(comment);
            var editingResult = await _legalPlatformContext.SaveChangesAsync();
            return editingResult > 0 ? "Successfully" : "Invalid";
        }
    }
}
