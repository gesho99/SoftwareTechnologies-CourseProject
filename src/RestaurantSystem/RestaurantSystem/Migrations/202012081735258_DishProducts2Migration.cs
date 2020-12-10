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
                    })
                .PrimaryKey(t => new { t.DishId, t.ProductId })
                .ForeignKey("dbo.Dishes", t => t.DishId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.DishId)
                .Index(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DishProducts2", "ProductId", "dbo.Products");
            DropForeignKey("dbo.DishProducts2", "DishId", "dbo.Dishes");
            DropIndex("dbo.DishProducts2", new[] { "ProductId" });
            DropIndex("dbo.DishProducts2", new[] { "DishId" });
            DropTable("dbo.DishProducts2");
        }
    }
}
