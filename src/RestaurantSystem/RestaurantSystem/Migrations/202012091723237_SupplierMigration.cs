namespace RestaurantSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SupplierMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PhoneNumber = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Deliveries", "SupplierId", c => c.Int(nullable: false));
            CreateIndex("dbo.Deliveries", "SupplierId");
            AddForeignKey("dbo.Deliveries", "SupplierId", "dbo.Suppliers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Deliveries", "SupplierId", "dbo.Suppliers");
            DropIndex("dbo.Deliveries", new[] { "SupplierId" });
            DropColumn("dbo.Deliveries", "SupplierId");
            DropTable("dbo.Suppliers");
        }
    }
}
