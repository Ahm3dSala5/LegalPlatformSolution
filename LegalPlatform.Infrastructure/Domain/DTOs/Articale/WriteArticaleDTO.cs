using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LegalPlatform.Infrastructure.Domain.Entity.Security;

namespace LegalPlatform.Infrastructure.Domain.DTOs.Articale
{
    public class WriteArticaleDTO
    {
        public string Articale_Content { set; get; }
        public Guid Articale_UserId { set; get; }
    }
}
