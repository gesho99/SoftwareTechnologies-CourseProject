using RestaurantSystem.Data.Models;
using RestaurantSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace RestaurantSystem.Data
{
    public class RestaurantDbContext : DbContext
    {
        public RestaurantDbContext() : base("name=RestaurantDbContext") { }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Expenses> Expenses { get; set; }

        public DbSet<EmployerReport> EmployerReports { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Dish> Dishes { get; set; }

        public DbSet<Delivery> Deliveries { get; set; }

        public DbSet<Table> Tables { get; set; }

        public DbSet<Supplier> Suppliers { get; set; }

        public DbSet<DayAccountings> DayAccountings { get; set; }

        public DbSet<MonthAccountings> MonthAccountings { get; set; }

        public DbSet<YearAccountings> YearAccountings { get; set; }

        public DbSet<DeliveryProducts2> DeliveryProducts2 { get; set; }

        public DbSet<DishProducts> DishProducts { get; set; }

        public DbSet<DishEmployerReports> DishEmployerReports { get; set; }

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
                .HasRequired<Employee>(emprep => emprep.Employeе)
                .WithMany(emp => emp.Reports)
                .HasForeignKey(emprep => emprep.EmpId)
                .WillCascadeOnDelete(false);

            modelBuilder
                .Entity<Delivery>()
                .HasRequired<Supplier>(d => d.Supplier)
                .WithMany(s => s.Deliveries)
                .HasForeignKey(d => d.SupplierId)
                .WillCascadeOnDelete(false);

            modelBuilder
                .Entity<EmployerReport>()
                .HasRequired<DayAccountings>(empr => empr.DayAccounting)
                .WithMany(dayA => dayA.EmployerReports)
                .HasForeignKey(empr => empr.DayAccountingId)
                .WillCascadeOnDelete(false);

            modelBuilder
                .Entity<DayAccountings>()
                .HasRequired<MonthAccountings>(da => da.MonthAccountings)
                .WithMany(ma => ma.DayAccountings)
                .HasForeignKey(da => da.MonthAccountingId)
                .WillCascadeOnDelete(false);

            modelBuilder
                .Entity<MonthAccountings>()
                .HasRequired<YearAccountings>(ma => ma.YearAccountings)
                .WithMany(ya => ya.MonthAccountings)
                .HasForeignKey(ma => ma.YearAccountingId)
                .WillCascadeOnDelete(false);

            modelBuilder
                .Entity<DishProducts>().HasKey(dp => new { dp.DishId, dp.ProductId });

            modelBuilder
                .Entity<DishProducts>()
                .HasRequired<Dish>(d => d.Dish)
                .WithMany(dp => dp.DishProducts)
                .HasForeignKey(d => d.DishId);

            modelBuilder
               .Entity<DishProducts>()
               .HasRequired<Product>(p => p.Product)
               .WithMany(dp => dp.DishProducts)
               .HasForeignKey(p => p.ProductId);

            modelBuilder
                .Entity<DeliveryProducts2>().HasKey(dp => new { dp.DeliveryId, dp.ProductId });

            modelBuilder
                .Entity<DeliveryProducts2>()
                .HasRequired<Delivery>(d => d.Delivery)
                .WithMany(dp => dp.DeliveryProducts2)
                .HasForeignKey(d => d.DeliveryId);

            modelBuilder
               .Entity<DeliveryProducts2>()
               .HasRequired<Product>(p =>p.Product)
               .WithMany(dp => dp.DeliveryProducts2)
               .HasForeignKey(p => p.ProductId);

            modelBuilder
                .Entity<DishEmployerReports>().HasKey(dp => new { dp.DishId, dp.EmployerReportId });

            modelBuilder
                .Entity<DishEmployerReports>()
                .HasRequired<EmployerReport>(d => d.EmployerReport)
                .WithMany(dp => dp.DishEmployerReports)
                .HasForeignKey(d => d.EmployerReportId);

            modelBuilder
               .Entity<DishEmployerReports>()
               .HasRequired<Dish>(p => p.Dish)
               .WithMany(dp => dp.DishEmployerReports)
               .HasForeignKey(p => p.DishId);
        }
    }
}
