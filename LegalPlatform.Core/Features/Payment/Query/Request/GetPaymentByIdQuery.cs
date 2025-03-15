using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraduationProjectStore.Core.ResultHandlers;
using LegalPlatform.Core.Features.Payments.Query.Model;
using MediatR;

namespace LegalPlatform.Core.Features.Payments.Query.Request
{
    public class GetPaymentByIdQuery : IRequest<Result<PaymentModel>>
    {
        public GetPaymentByIdQuery(Guid id)
        {
            this.Id = id;
        }

        public Guid Id { get; }
    }
}
