using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraduationProjectStore.Core.ResultHandlers;
using LegalPlatform.Infrastructure.Domain.DTOs.Articale;
using MediatR;

namespace LegalPlatform.Core.Features.Articales.Command.Request
{
    public class WriteArticalesCommand : IRequest<Result<string>>
    {
        public WriteArticalesCommand(WriteArticaleDTO articale)
        {
            this.Articale = articale;
        }

        public WriteArticaleDTO Articale { get; }
    }
}
