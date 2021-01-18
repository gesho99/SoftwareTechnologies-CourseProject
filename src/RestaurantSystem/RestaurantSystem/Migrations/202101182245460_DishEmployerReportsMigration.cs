namespace RestaurantSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DishEmployerReportsMigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.DishEmployerReports", "Dish_Id", "dbo.Dishes");
            DropForeignKey("dbo.DishEmployerReports", "EmployerReport_Id", "dbo.EmployerReports");
            DropIndex("dbo.DishEmployerReports", new[] { "Dish_Id" });
            DropIndex("dbo.DishEmployerReports", new[] { "EmployerReport_Id" });
            DropTable("dbo.DishEmployerReports");
            CreateTable(
                "dbo.DishEmployerReports",
                c => new
                    {
                        DishId = c.Int(nullable: false),
                        EmployerReportId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.DishId, t.EmployerReportId })
                .ForeignKey("dbo.Dishes", t => t.DishId, cascadeDelete: true)
                .ForeignKey("dbo.EmployerReports", t => t.EmployerReportId, cascadeDelete: true)
                .Index(t => t.DishId)
                .Index(t => t.EmployerReportId);
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.DishEmployerReports",
                c => new
                    {
                        Dish_Id = c.Int(nullable: false),
                        EmployerReport_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Dish_Id, t.EmployerReport_Id });
            
            DropForeignKey("dbo.DishEmployerReports", "EmployerReportId", "dbo.EmployerReports");
            DropForeignKey("dbo.DishEmployerReports", "DishId", "dbo.Dishes");
            DropIndex("dbo.DishEmployerReports", new[] { "EmployerReportId" });
            DropIndex("dbo.DishEmployerReports", new[] { "DishId" });
            DropTable("dbo.DishEmployerReports");
            CreateIndex("dbo.DishEmployerReports", "EmployerReport_Id");
            CreateIndex("dbo.DishEmployerReports", "Dish_Id");
            AddForeignKey("dbo.DishEmployerReports", "EmployerReport_Id", "dbo.EmployerReports", "Id", cascadeDelete: true);
            AddForeignKey("dbo.DishEmployerReports", "Dish_Id", "dbo.Dishes", "Id", cascadeDelete: true);
        }
    }
}
