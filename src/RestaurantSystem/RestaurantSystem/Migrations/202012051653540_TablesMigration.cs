namespace RestaurantSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TablesMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tables");
        }
    }
}
