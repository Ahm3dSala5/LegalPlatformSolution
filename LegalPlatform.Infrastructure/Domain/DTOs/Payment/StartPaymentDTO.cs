using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalPlatform.Infrastructure.Domain.DTOs.Payment
{
    public class StartPaymentDTO
    {
        public decimal Amount { set; get; }
        public Guid From { set; get; }
        public Guid TO { set; get; }
    }
}
