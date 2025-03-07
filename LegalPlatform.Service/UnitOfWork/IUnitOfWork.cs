using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LegalPlatform.Service.Abstraction.Business;

namespace LegalPlatform.Service.UnitOfWorks
{
    public interface IUnitOfWork : IDisposable
    {
        ICommentService CommentService { get; }
        IArticaleService ArticaleService { get; }
        IPaymentService paymentService { get; }
        IAppointmentService AppointmentService { get; }
        Task<int> SaveChamgesAsync();
    }

}
