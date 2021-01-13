namespace RestaurantSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AllMigrationsTillNow : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DayAccountings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MonthAccountingId = c.Int(nullable: false),
                        DayExpense = c.Double(nullable: false),
                        DayIncome = c.Double(nullable: false),
                        DayProfit = c.Double(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MonthAccountings", t => t.MonthAccountingId)
                .Index(t => t.MonthAccountingId);
            
            CreateTable(
                "dbo.EmployerReports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmpId = c.Int(nullable: false),
                        DayAccountingId = c.Int(nullable: false),
                        Bill = c.Double(nullable: false),
                        ReportDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DayAccountings", t => t.DayAccountingId)
                .ForeignKey("dbo.Employees", t => t.EmpId)
                .Index(t => t.EmpId)
                .Index(t => t.DayAccountingId);
            
            CreateTable(
                "dbo.Dishes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DishName = c.String(nullable: false, maxLength: 30),
                        DishCategory = c.String(maxLength: 30),
                        DishPrice = c.Double(nullable: false),
                        DishWeight = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DishProducts",
                c => new
                    {
                        DishId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.DishId, t.ProductId })
                .ForeignKey("dbo.Dishes", t => t.DishId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.DishId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        Quantity = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        DeliveryPrice = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Deliveries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SupplierId = c.Int(nullable: false),
                        DeliveryPrice = c.Double(nullable: false),
                        DeliveryDate = c.DateTime(nullable: false),
                        DeliveryQuantity = c.Int(nullable: false),
                        Approved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Suppliers", t => t.SupplierId)
                .Index(t => t.SupplierId);
            
            CreateTable(
                "dbo.DeliveryProducts2",
                c => new
                    {
                        DeliveryId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.DeliveryId, t.ProductId })
                .ForeignKey("dbo.Deliveries", t => t.DeliveryId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.DeliveryId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PhoneNumber = c.String(nullable: false, maxLength: 10),
                        AvailableDays = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmpId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        JobPosition = c.String(),
                        Salary = c.Int(nullable: false),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.EmpId);
            
            CreateTable(
                "dbo.MonthAccountings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        YearAccountingId = c.Int(nullable: false),
                        MonthExpense = c.Double(nullable: false),
                        MonthIncome = c.Double(nullable: false),
                        MonthProfit = c.Double(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.YearAccountings", t => t.YearAccountingId)
                .Index(t => t.YearAccountingId);
            
            CreateTable(
                "dbo.YearAccountings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        YearExpense = c.Double(nullable: false),
                        YearIncome = c.Double(nullable: false),
                        YearProfit = c.Double(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Expenses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 15),
                        Value = c.Double(nullable: false),
                        ExpenseDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeеId = c.Int(nullable: false),
                        RoleId = c.Int(nullable: false),
                        Username = c.String(nullable: false, maxLength: 15),
                        Password = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeеId, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.RoleId)
                .Index(t => t.EmployeеId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Tables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DeliveryProducts",
                c => new
                    {
                        Delivery_Id = c.Int(nullable: false),
                        Product_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Delivery_Id, t.Product_Id })
                .ForeignKey("dbo.Deliveries", t => t.Delivery_Id, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.Product_Id, cascadeDelete: true)
                .Index(t => t.Delivery_Id)
                .Index(t => t.Product_Id);
            
            CreateTable(
                "dbo.DishEmployerReports",
                c => new
                    {
                        Dish_Id = c.Int(nullable: false),
                        EmployerReport_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Dish_Id, t.EmployerReport_Id })
                .ForeignKey("dbo.Dishes", t => t.Dish_Id, cascadeDelete: true)
                .ForeignKey("dbo.EmployerReports", t => t.EmployerReport_Id, cascadeDelete: true)
                .Index(t => t.Dish_Id)
                .Index(t => t.EmployerReport_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.Users", "EmployeеId", "dbo.Employees");
            DropForeignKey("dbo.DayAccountings", "MonthAccountingId", "dbo.MonthAccountings");
            DropForeignKey("dbo.MonthAccountings", "YearAccountingId", "dbo.YearAccountings");
            DropForeignKey("dbo.EmployerReports", "EmpId", "dbo.Employees");
            DropForeignKey("dbo.DishEmployerReports", "EmployerReport_Id", "dbo.EmployerReports");
            DropForeignKey("dbo.DishEmployerReports", "Dish_Id", "dbo.Dishes");
            DropForeignKey("dbo.DishProducts", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Deliveries", "SupplierId", "dbo.Suppliers");
            DropForeignKey("dbo.DeliveryProducts", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.DeliveryProducts", "Delivery_Id", "dbo.Deliveries");
            DropForeignKey("dbo.DeliveryProducts2", "ProductId", "dbo.Products");
            DropForeignKey("dbo.DeliveryProducts2", "DeliveryId", "dbo.Deliveries");
            DropForeignKey("dbo.DishProducts", "DishId", "dbo.Dishes");
            DropForeignKey("dbo.EmployerReports", "DayAccountingId", "dbo.DayAccountings");
            DropIndex("dbo.DishEmployerReports", new[] { "EmployerReport_Id" });
            DropIndex("dbo.DishEmployerReports", new[] { "Dish_Id" });
            DropIndex("dbo.DeliveryProducts", new[] { "Product_Id" });
            DropIndex("dbo.DeliveryProducts", new[] { "Delivery_Id" });
            DropIndex("dbo.Users", new[] { "RoleId" });
            DropIndex("dbo.Users", new[] { "EmployeеId" });
            DropIndex("dbo.MonthAccountings", new[] { "YearAccountingId" });
            DropIndex("dbo.DeliveryProducts2", new[] { "ProductId" });
            DropIndex("dbo.DeliveryProducts2", new[] { "DeliveryId" });
            DropIndex("dbo.Deliveries", new[] { "SupplierId" });
            DropIndex("dbo.DishProducts", new[] { "ProductId" });
            DropIndex("dbo.DishProducts", new[] { "DishId" });
            DropIndex("dbo.EmployerReports", new[] { "DayAccountingId" });
            DropIndex("dbo.EmployerReports", new[] { "EmpId" });
            DropIndex("dbo.DayAccountings", new[] { "MonthAccountingId" });
            DropTable("dbo.DishEmployerReports");
            DropTable("dbo.DeliveryProducts");
            DropTable("dbo.Tables");
            DropTable("dbo.Users");
            DropTable("dbo.Roles");
            DropTable("dbo.Expenses");
            DropTable("dbo.YearAccountings");
            DropTable("dbo.MonthAccountings");
            DropTable("dbo.Employees");
            DropTable("dbo.Suppliers");
            DropTable("dbo.DeliveryProducts2");
            DropTable("dbo.Deliveries");
            DropTable("dbo.Products");
            DropTable("dbo.DishProducts");
            DropTable("dbo.Dishes");
            DropTable("dbo.EmployerReports");
            DropTable("dbo.DayAccountings");
        }
    }
}
