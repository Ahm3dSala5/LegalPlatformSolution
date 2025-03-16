using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalPlatform.Core.Features.Payments.Query.Model
{
    public class PaymentModel
    {
        public Guid Payment_Id { set; get; }
        public Guid Payment_Sender { set; get; }
        public Guid  Payment_Reciver { set; get; }
        public decimal Payment_Amount {  set; get; }
        public DateTime Payment_Date { set; get; }
    }
}
