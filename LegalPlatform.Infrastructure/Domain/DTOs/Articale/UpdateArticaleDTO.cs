namespace LegalPlatform.Infrastructure.Domain.DTOs.Articale
{
    public class UpdateArticaleDTO
    {
        public Guid Articale_Id { set; get; }
        public string Articale_Content { set; get; }
        public Guid Articale_UserId { set; get; }
    }
}
