using AutoMapper;

namespace LegalPlatform.Core.Mapping.Comments
{
    public partial class CommentProfile : Profile
    {
        public CommentProfile()
        {
            GetCommentQueryMapping();
            WriteCommentCommandMapping();
            UpdateCommentCommandMapping();
        }  
    }
}
