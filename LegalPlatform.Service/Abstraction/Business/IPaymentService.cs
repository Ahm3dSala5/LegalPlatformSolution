using LegalPlatform.Infrastructure.Domain.DTOs.Payment;
using LegalPlatform.Infrastructure.Domain.Entity.Business;
using LegalPlatform.Infrastructure.Repository;

namespace LegalPlatform.Service.Abstraction.Business
{
    public interface IPaymentService : IMainRepository<Payment>
    {
        ValueTask<string> StartPaymentAsync(StartPaymentDTO payment);
        ValueTask<string> EditPaymentAsync(EditPaymentDTO payment);
    }
}
