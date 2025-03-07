using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LegalPlatform.Infrastructure.Domain.Entity.Business;
using LegalPlatform.Infrastructure.Repository;

namespace LegalPlatform.Service.Abstraction.Business
{
    public interface ICommentService : IMainRepository<Comment>
    {

    }
}
