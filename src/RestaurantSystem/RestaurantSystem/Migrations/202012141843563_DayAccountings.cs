namespace RestaurantSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DayAccountings : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ProductDeliveries", newName: "DeliveryProducts");
            RenameTable(name: "dbo.DishProducts", newName: "ProductDishes");
            DropPrimaryKey("dbo.DeliveryProducts");
            DropPrimaryKey("dbo.ProductDishes");
            CreateTable(
                "dbo.DayAccountings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DayExpense = c.Double(nullable: false),
                        DayIncome = c.Double(nullable: false),
                        DayProfit = c.Double(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DishProducts2",
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
                "dbo.Suppliers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PhoneNumber = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.Id);
            
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
            
            AddColumn("dbo.Deliveries", "SupplierId", c => c.Int(nullable: false));
            AddColumn("dbo.Deliveries", "DeliveryDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Deliveries", "DeliveryQuantity", c => c.Int(nullable: false));
            AddColumn("dbo.Deliveries", "Approved", c => c.Boolean(nullable: false));
            AddColumn("dbo.EmployerReports", "DayAccountingId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.DeliveryProducts", new[] { "Delivery_Id", "Product_Id" });
            AddPrimaryKey("dbo.ProductDishes", new[] { "Product_Id", "Dish_Id" });
            CreateIndex("dbo.EmployerReports", "DayAccountingId");
            CreateIndex("dbo.Deliveries", "SupplierId");
            AddForeignKey("dbo.EmployerReports", "DayAccountingId", "dbo.DayAccountings", "Id");
            AddForeignKey("dbo.Deliveries", "SupplierId", "dbo.Suppliers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DishEmployerReports", "EmployerReport_Id", "dbo.EmployerReports");
            DropForeignKey("dbo.DishEmployerReports", "Dish_Id", "dbo.Dishes");
            DropForeignKey("dbo.DishProducts2", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Deliveries", "SupplierId", "dbo.Suppliers");
            DropForeignKey("dbo.DishProducts2", "DishId", "dbo.Dishes");
            DropForeignKey("dbo.EmployerReports", "DayAccountingId", "dbo.DayAccountings");
            DropIndex("dbo.DishEmployerReports", new[] { "EmployerReport_Id" });
            DropIndex("dbo.DishEmployerReports", new[] { "Dish_Id" });
            DropIndex("dbo.Deliveries", new[] { "SupplierId" });
            DropIndex("dbo.DishProducts2", new[] { "ProductId" });
            DropIndex("dbo.DishProducts2", new[] { "DishId" });
            DropIndex("dbo.EmployerReports", new[] { "DayAccountingId" });
            DropPrimaryKey("dbo.ProductDishes");
            DropPrimaryKey("dbo.DeliveryProducts");
            DropColumn("dbo.EmployerReports", "DayAccountingId");
            DropColumn("dbo.Deliveries", "Approved");
            DropColumn("dbo.Deliveries", "DeliveryQuantity");
            DropColumn("dbo.Deliveries", "DeliveryDate");
            DropColumn("dbo.Deliveries", "SupplierId");
            DropTable("dbo.DishEmployerReports");
            DropTable("dbo.Suppliers");
            DropTable("dbo.DishProducts2");
            DropTable("dbo.DayAccountings");
            AddPrimaryKey("dbo.ProductDishes", new[] { "Dish_Id", "Product_Id" });
            AddPrimaryKey("dbo.DeliveryProducts", new[] { "Product_Id", "Delivery_Id" });
            RenameTable(name: "dbo.ProductDishes", newName: "DishProducts");
            RenameTable(name: "dbo.DeliveryProducts", newName: "ProductDeliveries");
        }
    }
}
