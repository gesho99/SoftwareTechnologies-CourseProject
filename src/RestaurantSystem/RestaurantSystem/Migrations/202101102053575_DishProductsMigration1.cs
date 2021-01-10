namespace RestaurantSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DishProductsMigration1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProductDishes", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.ProductDishes", "Dish_Id", "dbo.Dishes");
            DropIndex("dbo.ProductDishes", new[] { "Product_Id" });
            DropIndex("dbo.ProductDishes", new[] { "Dish_Id" });
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
            
            DropTable("dbo.ProductDishes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ProductDishes",
                c => new
                    {
                        Product_Id = c.Int(nullable: false),
                        Dish_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Product_Id, t.Dish_Id });
            
            DropForeignKey("dbo.DishProducts", "ProductId", "dbo.Products");
            DropForeignKey("dbo.DishProducts", "DishId", "dbo.Dishes");
            DropIndex("dbo.DishProducts", new[] { "ProductId" });
            DropIndex("dbo.DishProducts", new[] { "DishId" });
            DropTable("dbo.DishProducts");
            CreateIndex("dbo.ProductDishes", "Dish_Id");
            CreateIndex("dbo.ProductDishes", "Product_Id");
            AddForeignKey("dbo.ProductDishes", "Dish_Id", "dbo.Dishes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ProductDishes", "Product_Id", "dbo.Products", "Id", cascadeDelete: true);
        }
    }
}
