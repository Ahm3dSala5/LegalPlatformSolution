﻿using System;
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
        }

    }
}
