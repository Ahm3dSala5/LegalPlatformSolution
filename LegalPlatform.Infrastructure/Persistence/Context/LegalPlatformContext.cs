using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using LegalPlatform.Infrastructure.Domain.Entity.Business;
using LegalPlatform.Infrastructure.Domain.Entity.Security;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
[assembly: InternalsVisibleTo("LegalPlatform.API")]
namespace LegalPlatform.Infrastructure.Persistence.Context
{
    internal class LegalPlatformContext : IdentityDbContext<LegalUser,LegalRole,Guid>
    {
        public LegalPlatformContext(DbContextOptions<LegalPlatformContext> options) : base(options)
        {

        }

        public DbSet<Chat> Chats { set; get; }
        public DbSet<Client> Clients { set; get; }
        public DbSet<Lawyer> Lawyers { set; get; }
        public DbSet<Review> Reviews { set; get; }  
        public DbSet<LegalUser> Users { set; get; }
        public DbSet<Payment> Payments { set; get; }
        public DbSet<Document> Documents { set; get; }  
        public DbSet<Appointment> Appointments { set; get; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}
