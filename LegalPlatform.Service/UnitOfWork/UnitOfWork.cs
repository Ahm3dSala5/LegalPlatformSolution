using LegalPlatform.Infrastructure.Persistence.Context;
using LegalPlatform.Service.Abstraction.Business;
using LegalPlatform.Service.Implementation.Business;
using Microsoft.Extensions.Configuration;

namespace LegalPlatform.Service.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly LegalPlatformContext _context;
        private readonly IConfiguration _config;
        public UnitOfWork(LegalPlatformContext context, IConfiguration config)
        {
            this._context = context;
            this.CommentService = new CommentService(_context, config);
            this.AppointmentService = new AppointmentService(_context, config);
            this.ArticaleService = new ArticaleService(_context, config);
            this.paymentService = new PaymentService(_context, config);
            this._config = config;
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
