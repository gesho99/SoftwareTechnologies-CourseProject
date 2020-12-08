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

        public DbSet<Dish> Dishes { get; set; }

        public DbSet<Delivery> Deliveries { get; set; }

        public DbSet<Table> Tables { get; set; }

        public DbSet<DishProducts2> DishProducts2 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<User>()
                .HasRequired<Role>(u => u.Role)
                .WithMany(r => r.Users)
                .HasForeignKey(u => u.RoleId)
                .WillCascadeOnDelete(false);

            modelBuilder
                .Entity<EmployerReport>()
                .HasRequired<Employer>(emprep => emprep.Employer)
                .WithMany(emp => emp.Reports)
                .HasForeignKey(emprep => emprep.EmployerId)
                .WillCascadeOnDelete(false);

            modelBuilder
                .Entity<DishProducts2>().HasKey(dp => new { dp.DishId, dp.ProductId });


            modelBuilder
                .Entity<DishProducts2>()
                .HasRequired<Dish>(dp => dp.Dish)
                .WithMany(d => d.DishProducts2)
                .HasForeignKey(dp => dp.DishId);

            modelBuilder
                .Entity<DishProducts2>()
                .HasRequired<Product>(dp => dp.Product)
                .WithMany(d => d.DishProducts2)
                .HasForeignKey(dp => dp.ProductId);
        }
    }
}
