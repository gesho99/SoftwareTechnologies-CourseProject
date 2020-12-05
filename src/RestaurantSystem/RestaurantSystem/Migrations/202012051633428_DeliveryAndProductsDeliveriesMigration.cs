namespace RestaurantSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeliveryAndProductsDeliveriesMigration : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.DishProducts");
            CreateTable(
                "dbo.Deliveries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DeliveryPrice = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductDeliveries",
                c => new
                    {
                        Product_Id = c.Int(nullable: false),
                        Delivery_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Product_Id, t.Delivery_Id })
                .ForeignKey("dbo.Products", t => t.Product_Id, cascadeDelete: true)
                .ForeignKey("dbo.Deliveries", t => t.Delivery_Id, cascadeDelete: true)
                .Index(t => t.Product_Id)
                .Index(t => t.Delivery_Id);
            
            AddPrimaryKey("dbo.DishProducts", new[] { "Dish_Id", "Product_Id" });
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductDeliveries", "Delivery_Id", "dbo.Deliveries");
            DropForeignKey("dbo.ProductDeliveries", "Product_Id", "dbo.Products");
            DropIndex("dbo.ProductDeliveries", new[] { "Delivery_Id" });
            DropIndex("dbo.ProductDeliveries", new[] { "Product_Id" });
            DropPrimaryKey("dbo.DishProducts");
            DropTable("dbo.ProductDeliveries");
            DropTable("dbo.Deliveries");
            AddPrimaryKey("dbo.DishProducts", new[] { "Product_Id", "Dish_Id" });
        }
    }
}
