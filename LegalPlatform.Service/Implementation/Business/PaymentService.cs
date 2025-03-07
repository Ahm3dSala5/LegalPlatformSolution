using LegalPlatform.Infrastructure.Domain.Entity.Business;
using LegalPlatform.Infrastructure.Persistence.Context;
using LegalPlatform.Infrastructure.Repository;
using LegalPlatform.Service.Abstraction.Business;

namespace LegalPlatform.Service.Implementation.Business
{
    public class PaymentService : MainRepository<Payment>, IPaymentService
    {
        public PaymentService(LegalPlatformContext context) : base(context)
        {
        }
    }
}
