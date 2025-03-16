using LegalPlatform.Core.Features.Payments.Query.Model;
using LegalPlatform.Infrastructure.Domain.Entity.Business;

namespace LegalPlatform.Core.Mapping.Payments
{
    public partial class PaymentProfile 
    {
        public void GetPaymentQueryMapping()
        {
            CreateMap<PaymentModel, Payment>().
                ForMember(x => x.Id, x => x.MapFrom(x => x.Payment_Id)).
                ForMember(x => x.PaymentDate, x => x.MapFrom(x => x.Payment_Date)).
                ForMember(x => x.Amount, x => x.MapFrom(x => x.Payment_Amount)).
                ForMember(x => x.Sender, x => x.MapFrom(x => x.Payment_Sender)).
                ForMember(x => x.Reciever, x => x.MapFrom(x => x.Payment_Reciver)).ReverseMap();
        }
    }
}
