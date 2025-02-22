using LegalPlatform.Infrastructure.Domain.Entity.Base;

namespace LegalPlatform.Infrastructure.Domain.Entity.Business
{
    internal sealed class Document : BaseEntity<Guid>
    {
        public string Name { set; get; }
        public byte[] Content { set; get; }
        public string ContentType { set; get; }
        public DateTime UploadedAt { set; get; }
    }
}
