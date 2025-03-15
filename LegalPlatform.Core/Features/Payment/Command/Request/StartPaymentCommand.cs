using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraduationProjectStore.Core.ResultHandlers;
using MediatR;

namespace LegalPlatform.Core.Features.Payments.Command.Request
{
    public class StartPaymentCommand : IRequest<Result<string>>
    {

    }
}
