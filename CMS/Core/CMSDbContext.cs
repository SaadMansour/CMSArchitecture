using CMS.Models;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Core
{
    public class CMSDbContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Encounter> Encounters { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<User_Role> UserRoles { get; set; }

        /// <summary>
        /// Constructor argument
        /// </summary>
        /// <param name="options"></param>
        public CMSDbContext(DbContextOptions<CMSDbContext> options)
        : base(options)
        { }

        //Using Fluent API Configuration.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //One-one relationship between patient and contact. Patient is the principal entity.
            //TODO check if it is built by convention
            //modelBuilder.Entity<Patient>()
            //    .HasOne(p => p.Contact)
            //    .WithOne(c => c.Patient)
            //    .HasForeignKey<Contact>(i => i.PatientId);
        }
    }
}
