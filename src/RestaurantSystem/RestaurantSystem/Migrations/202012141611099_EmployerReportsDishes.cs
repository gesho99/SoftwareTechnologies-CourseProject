namespace RestaurantSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmployerReportsDishes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmployerReportDishes",
                c => new
                    {
                        EmployerReport_Id = c.Int(nullable: false),
                        Dish_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.EmployerReport_Id, t.Dish_Id })
                .ForeignKey("dbo.EmployerReports", t => t.EmployerReport_Id, cascadeDelete: true)
                .ForeignKey("dbo.Dishes", t => t.Dish_Id, cascadeDelete: true)
                .Index(t => t.EmployerReport_Id)
                .Index(t => t.Dish_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmployerReportDishes", "Dish_Id", "dbo.Dishes");
            DropForeignKey("dbo.EmployerReportDishes", "EmployerReport_Id", "dbo.EmployerReports");
            DropIndex("dbo.EmployerReportDishes", new[] { "Dish_Id" });
            DropIndex("dbo.EmployerReportDishes", new[] { "EmployerReport_Id" });
            DropTable("dbo.EmployerReportDishes");
        }
    }
}
