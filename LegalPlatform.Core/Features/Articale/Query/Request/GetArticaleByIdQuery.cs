using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraduationProjectStore.Core.ResultHandlers;
using LegalPlatform.Core.Features.Articales.Query.Model;
using MediatR;

namespace LegalPlatform.Core.Features.Articales.Query.Request
{
    public class GetArticaleByIdQuery : IRequest<Result<ArticaleModel>>
    {
        public GetArticaleByIdQuery(Guid id)
        {
            this.Id = id;
        }

        public Guid Id { get; }
    }
}
