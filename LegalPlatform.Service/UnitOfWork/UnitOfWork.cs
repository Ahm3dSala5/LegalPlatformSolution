using LegalPlatform.Infrastructure.Persistence.Context;
using LegalPlatform.Service.Abstraction.Business;
using LegalPlatform.Service.Implementation.Business;

namespace LegalPlatform.Service.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly LegalPlatformContext _context;
        public UnitOfWork(LegalPlatformContext context)
        {
            this._context = context;
            this.CommentService = new CommentService(_context);
            this.AppointmentService = new AppointmentService(_context);
            this.ArticaleService = new ArticaleService(_context);
            this.paymentService = new PaymentService(_context);
        }

        public ICommentService CommentService { get; private set; }

        public IArticaleService ArticaleService { get; private set; }

        public IPaymentService paymentService { get; private set; }

        public IAppointmentService AppointmentService { get; private set; }

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task<int> SaveChamgesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
