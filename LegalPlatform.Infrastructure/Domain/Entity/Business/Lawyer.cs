﻿using System.ComponentModel.DataAnnotations;
using LegalPlatform.Infrastructure.Domain.Entity.Base;
using LegalPlatform.Infrastructure.Domain.Entity.Security;

namespace LegalPlatform.Infrastructure.Domain.Entity.Business
{
    public sealed class Lawyer : Consumer<Guid>
    {
        public string LicenseNumber { get; set; } // Unique lawyer license number

        public string Specialty { get; set; } // E.g., Criminal Law, Corporate Law, Family Law

        public string Experience { get; set; } // Years of experience, certifications, etc.

        public string LawFirm { get; set; } // Name of the law firm (if applicable)

        public string OfficeAddress { get; set; }

        public decimal Balance { set; get; }

        public Guid UserId { set; get; }
        public LegalUser User { get; set; } // Navigation property to the associated LegalUser

        public ICollection<Appointment> Appointments { set; get; } = new List<Appointment>();
    }
}
