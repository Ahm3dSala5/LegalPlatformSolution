using AutoMapper;

namespace LegalPlatform.Core.Mapping.Payments
{
    public partial class PaymentProfile : Profile
    {
        public PaymentProfile()
        {
            GetPaymentQueryMapping();
        }
    }
}
