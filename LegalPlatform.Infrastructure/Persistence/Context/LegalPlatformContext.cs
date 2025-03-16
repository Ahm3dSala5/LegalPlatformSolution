using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using LegalPlatform.Infrastructure.Domain.Entity.Business;
using LegalPlatform.Infrastructure.Domain.Entity.Security;
using LegalPlatform.Infrastructure.Persistence.DataSeed;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
[assembly: InternalsVisibleTo("LegalPlatform.API")]
namespace LegalPlatform.Infrastructure.Persistence.Context
{
    public class LegalPlatformContext : IdentityDbContext<LegalUser,LegalRole,Guid>
    {
        public LegalPlatformContext(DbContextOptions<LegalPlatformContext> options) : base(options)
        {

        }

        public DbSet<LegalUser> Users { set; get; }
        public DbSet<Payment> Payments { set; get; }
        public DbSet<Articale> Articale { set; get; }  
        public DbSet<Appointment> Appointments { set; get; }
        public DbSet<Comment> Comments { set; get; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            var (users, payments, articles, comments, appointments) = DataSeeder.Seeder();

            builder.Entity<LegalUser>().HasData(users);
            builder.Entity<Payment>().HasData(payments);
            builder.Entity<Articale>().HasData(articles);
            builder.Entity<Comment>().HasData(comments);
            builder.Entity<Appointment>().HasData(appointments);
        }

    }
}
