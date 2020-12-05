namespace RestaurantSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RestaurantMenuMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RestaurantMenus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DishName = c.String(nullable: false, maxLength: 30),
                        DishPrice = c.Double(nullable: false),
                        DishWeight = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RestaurantMenus");
        }
    }
}
