namespace RestaurantSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DishProducts2Migration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DishProducts2",
                c => new
                    {
                        DishId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Dish_Id = c.Int(),
                        Product_Id = c.Int(),
                    })
                .PrimaryKey(t => new { t.DishId, t.ProductId })
                .ForeignKey("dbo.Dishes", t => t.DishId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Dishes", t => t.Dish_Id)
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .Index(t => t.DishId)
                .Index(t => t.ProductId)
                .Index(t => t.Dish_Id)
                .Index(t => t.Product_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DishProducts2", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.DishProducts2", "Dish_Id", "dbo.Dishes");
            DropForeignKey("dbo.DishProducts2", "ProductId", "dbo.Products");
            DropForeignKey("dbo.DishProducts2", "DishId", "dbo.Dishes");
            DropIndex("dbo.DishProducts2", new[] { "Product_Id" });
            DropIndex("dbo.DishProducts2", new[] { "Dish_Id" });
            DropIndex("dbo.DishProducts2", new[] { "ProductId" });
            DropIndex("dbo.DishProducts2", new[] { "DishId" });
            DropTable("dbo.DishProducts2");
        }
    }
}
