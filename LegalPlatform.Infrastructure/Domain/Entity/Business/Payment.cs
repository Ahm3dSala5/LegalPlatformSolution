using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LegalPlatform.Infrastructure.Domain.Entity.Base;

namespace LegalPlatform.Infrastructure.Domain.Entity.Business
{
    internal sealed class Payment : BaseEntity<Guid>
    {
        public DateTime PayAt { set; get; }
        public decimal Amount { set; get; }
    }
}
