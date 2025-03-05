using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace LegalPlatform.Infrastructure.Domain.Entity.Security
{
    public class LegalUser : IdentityUser<Guid>
    {
        public string Address { set; get; }
    }
}
