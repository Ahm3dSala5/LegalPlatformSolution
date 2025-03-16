using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalPlatform.Infrastructure.Domain.DTOs.Comments
{
    public class EditCommentDTO
    {
        public Guid Comment_Id { get; set; }
        public string Commnent_Text { get; set; }
        public Guid UserId { get; set; }
    }
}
