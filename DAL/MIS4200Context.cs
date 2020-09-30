using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using jk760216_MIS4200.Models;

namespace jk760216_MIS4200.DAL
{
    public class MIS4200Context : DbContext
    {
        public MIS4200Context(): base ("name=DefaultConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MIS4200Context,
            jk760216_MIS4200.Migrations.MISContext.Configuration>("DefaultConnection"));
        }
        public DbSet<Order> orders { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<LineItem> lineItems { get; set; }
        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<Patient> Patient { get; set; }
        public DbSet<Appointments> Appointment { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}