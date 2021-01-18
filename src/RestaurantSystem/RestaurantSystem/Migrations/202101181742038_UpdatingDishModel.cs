namespace RestaurantSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatingDishModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Dishes", "DishSellingPrice", c => c.Double(nullable: false));
            AddColumn("dbo.Dishes", "DishMakingPrice", c => c.Double(nullable: false));
            DropColumn("dbo.Dishes", "DishPrice");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Dishes", "DishPrice", c => c.Double(nullable: false));
            DropColumn("dbo.Dishes", "DishMakingPrice");
            DropColumn("dbo.Dishes", "DishSellingPrice");
        }
    }
}
