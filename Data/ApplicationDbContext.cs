using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Promises.Models;

namespace Promises.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Alias> Alias { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Connection> Connection { get; set; }
        public DbSet<Education> Education { get; set; }
        public DbSet<EmailAddress> EmailAddress { get; set; }
        public DbSet<Employment> Employment { get; set; }
        public DbSet<ExternalProfile> ExternalProfile { get; set; }
        public DbSet<MailingAddress> MailingAddress { get; set; }
        public DbSet<PhoneNumber> PhoneNumber { get; set; }
        public DbSet<Profile> Profile { get; set; }
        public DbSet<Promise> Promise { get; set; }
        public DbSet<School> School { get; set; }
        public DbSet<Skill> Skill { get; set; }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
