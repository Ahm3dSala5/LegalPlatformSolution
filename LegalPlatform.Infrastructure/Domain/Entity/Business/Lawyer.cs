using System.ComponentModel.DataAnnotations;
using LegalPlatform.Infrastructure.Domain.Entity.Base;

namespace LegalPlatform.Infrastructure.Domain.Entity.Business
{
    public sealed class Lawyer : Consumer<Guid>
    {
        [Required, MaxLength(50)]
        public string LicenseNumber { get; set; } // Unique lawyer license number

        [Required, MaxLength(255)]
        public string Specialty { get; set; } // E.g., Criminal Law, Corporate Law, Family Law

        [MaxLength(500)]
        public string Experience { get; set; } // Years of experience, certifications, etc.

        [MaxLength(255)]
        public string LawFirm { get; set; } // Name of the law firm (if applicable)

        [MaxLength(255)]
        public string OfficeAddress { get; set; }

    }
}
