namespace RestaurantSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class YearAccountingsMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.YearAccountings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        YearExpense = c.Double(nullable: false),
                        YearIncome = c.Double(nullable: false),
                        YearProfit = c.Double(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.MonthAccountings", "YearAccountingId", c => c.Int(nullable: false));
            CreateIndex("dbo.MonthAccountings", "YearAccountingId");
            AddForeignKey("dbo.MonthAccountings", "YearAccountingId", "dbo.YearAccountings", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MonthAccountings", "YearAccountingId", "dbo.YearAccountings");
            DropIndex("dbo.MonthAccountings", new[] { "YearAccountingId" });
            DropColumn("dbo.MonthAccountings", "YearAccountingId");
            DropTable("dbo.YearAccountings");
        }
    }
}
