namespace RestaurantSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MonthAccountingMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MonthAccountings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MonthExpense = c.Double(nullable: false),
                        MonthIncome = c.Double(nullable: false),
                        MonthProfit = c.Double(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.DayAccountings", "MonthAccountingId", c => c.Int(nullable: false));
            CreateIndex("dbo.DayAccountings", "MonthAccountingId");
            AddForeignKey("dbo.DayAccountings", "MonthAccountingId", "dbo.MonthAccountings", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DayAccountings", "MonthAccountingId", "dbo.MonthAccountings");
            DropIndex("dbo.DayAccountings", new[] { "MonthAccountingId" });
            DropColumn("dbo.DayAccountings", "MonthAccountingId");
            DropTable("dbo.MonthAccountings");
        }
    }
}
