using LegalPlatform.Infrastructure.Domain.DTOs.Comments;
using LegalPlatform.Infrastructure.Domain.Entity.Business;
using LegalPlatform.Infrastructure.Repository;

namespace LegalPlatform.Service.Abstraction.Business
{
    public interface ICommentService : IMainRepository<Comment>
    {
        ValueTask<string> EditCommentAsync(EditCommentDTO comment);
    }
}
