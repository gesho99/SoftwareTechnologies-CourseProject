namespace RestaurantSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatingDishModel1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Dishes", "ProductsQuantity", c => c.String(nullable: false));
            DropColumn("dbo.Dishes", "DishCategory");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Dishes", "DishCategory", c => c.String(maxLength: 30));
            DropColumn("dbo.Dishes", "ProductsQuantity");
        }
    }
}
