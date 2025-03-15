namespace LegalPlatform.Infrastructure.Domain.DTOs.Payment
{
    public class EditPaymentDTO
    {
        public Guid Id { set; get; }
        public decimal Amount { set; get; }
        public Guid From { set; get; }
        public Guid TO { set; get; }
    }
}
