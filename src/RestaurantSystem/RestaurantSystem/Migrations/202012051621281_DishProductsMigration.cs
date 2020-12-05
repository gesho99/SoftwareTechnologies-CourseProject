namespace RestaurantSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DishProductsMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DishProducts",
                c => new
                    {
                        Product_Id = c.Int(nullable: false),
                        Dish_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Product_Id, t.Dish_Id })
                .ForeignKey("dbo.Products", t => t.Product_Id, cascadeDelete: true)
                .ForeignKey("dbo.Dishes", t => t.Dish_Id, cascadeDelete: true)
                .Index(t => t.Product_Id)
                .Index(t => t.Dish_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DishProducts", "Dish_Id", "dbo.Dishes");
            DropForeignKey("dbo.DishProducts", "Product_Id", "dbo.Products");
            DropIndex("dbo.DishProducts", new[] { "Dish_Id" });
            DropIndex("dbo.DishProducts", new[] { "Product_Id" });
            DropTable("dbo.DishProducts");
        }
    }
}
