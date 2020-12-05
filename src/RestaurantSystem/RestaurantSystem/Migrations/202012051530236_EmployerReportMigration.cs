namespace RestaurantSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmployerReportMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmployerReports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployerId = c.Int(nullable: false),
                        Bill = c.Double(nullable: false),
                        ReportDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employers", t => t.EmployerId)
                .Index(t => t.EmployerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmployerReports", "EmployerId", "dbo.Employers");
            DropIndex("dbo.EmployerReports", new[] { "EmployerId" });
            DropTable("dbo.EmployerReports");
        }
    }
}
