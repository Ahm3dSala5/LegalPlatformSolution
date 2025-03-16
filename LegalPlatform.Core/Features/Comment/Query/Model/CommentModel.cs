using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalPlatform.Core.Features.Comments.Query.Model
{
    public class CommentModel 
    {
        public Guid Comment_Id { get; set; }
        public DateTime Comment_AddedAt { get; set; }
        public string Comment_Text { get; set; }
        public Guid Comment_UserId { get; set; }
        public Guid Comment_ArticleId { get; set; }
    }
}
