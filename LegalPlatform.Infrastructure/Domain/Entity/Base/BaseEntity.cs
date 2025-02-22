using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalPlatform.Infrastructure.Domain.Entity.Base
{
    internal abstract class BaseEntity <TKey>
    {
        public int Id { set; get; }
    }
}
