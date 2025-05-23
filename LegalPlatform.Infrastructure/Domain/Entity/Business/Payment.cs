﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LegalPlatform.Infrastructure.Domain.Entity.Base;
using LegalPlatform.Infrastructure.Domain.Entity.Security;

namespace LegalPlatform.Infrastructure.Domain.Entity.Business
{
    public sealed class Payment : BaseEntity<Guid>
    {
        public DateTime PaymentDate { set; get; }
        public decimal Amount { set; get; }
        public Guid Sender { set; get; }
        public Guid Reciever { set; get; }
        public LegalUser User { set; get; }
        public Guid UserId { set; get; }
    }
}
