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
        public string Address { set; get; }

        public decimal Balance { set; get; }

        public Lawyer? LawyerProfile { get; set; }
        public Client? ClientProfile { get; set; }
        public ICollection<Payment> Payments { set; get; } = new List<Payment>();
        public ICollection<Articale> Articales { set; get; } = new List<Articale>();
        public ICollection<Comment> Comments { set; get; } = new List<Comment>();
        public ICollection<Appointment> Appointments { set; get; } = new List<Appointment>();
    }
}
