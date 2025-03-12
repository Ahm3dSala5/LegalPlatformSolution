namespace LegalPlatform.Infrastructure.Domain.DTOs.Comments
{
    public class WriteCommentDTO
    {
        public string Content { get; set; }
        public Guid ArticleId { get; set; }
        public Guid UserId { get; set; }
    }
}
