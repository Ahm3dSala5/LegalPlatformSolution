using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LegalPlatform.Infrastructure.Domain.Entity.Business;
using Microsoft.AspNetCore.Identity;

namespace LegalPlatform.Infrastructure.Domain.Entity.Security
{
    public class LegalUser : IdentityUser<Guid>
    {
        public string ?Address { set; get; }
        public string? FullName { set; get; } 
        public decimal Balance { set; get; }


        // relationships
        public Lawyer? LawyerProfile { get; set; }
        public Client? ClientProfile { get; set; }
        public ICollection<Comment> Comments { set; get; } = new List<Comment>();
        public ICollection<Payment> Payments { set; get; } = new List<Payment>();
        public ICollection<Articale> Articales { set; get; } = new List<Articale>();
        public ICollection<Appointment> Appointments { set; get; } = new List<Appointment>();
        public ICollection<IdentityUserRole<Guid>> Roles { set; get; } = new List<IdentityUserRole<Guid>>();
        public ICollection<IdentityUserClaim<Guid>> Claims { set; get; } = new List<IdentityUserClaim<Guid>>();
        public ICollection<IdentityUserLogin<Guid>> Logins { set; get; } = new List<IdentityUserLogin<Guid>>();
        public ICollection<IdentityUserToken<Guid>> Tokens { set; get; } = new List<IdentityUserToken<Guid>>();
    }
}
