using RestaurantSystem.Data.Models;
using RestaurantSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace RestaurantSystem.Data
{
    class RestaurantDbContext : DbContext
    {

        public DbSet<Product> Products { get; set; }

        public DbSet<Employer> Employers { get; set; }

        public DbSet<Expenses> Expenses { get; set; }

        public DbSet<EmployerReport> EmployerReports { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<RestaurantMenu> RestaurantMenu { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<User>()
                .HasRequired<Role>(r => r.Role)
                .WithMany(u => u.Users)
                .HasForeignKey(r => r.RoleId)
                .WillCascadeOnDelete(false);

            modelBuilder
                .Entity<EmployerReport>()
                .HasRequired<Employer>(emp => emp.Employer)
                .WithMany(rep => rep.Reports)
                .HasForeignKey(emp => emp.EmployerId)
                .WillCascadeOnDelete(false);

        }
    }
}
