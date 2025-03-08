using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LegalPlatform.Infrastructure.Domain.Entity.Security;

namespace LegalPlatform.Core.Features.Articales.Query.Model
{
    public class ArticaleModel
    {
        public Guid Articale_Id { set; get; }
        public string Articale_Content { set; get; }
        public DateTime Articale_UploadedAt { set; get; }
        public Guid Articale_UserId { set; get; }
    }
}
