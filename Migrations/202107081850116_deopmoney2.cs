namespace projectMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deopmoney2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Drinks", "Buy", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Drinks", "Sale", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Drinks", "Profit", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Foods", "Buy", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Foods", "Sale", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Foods", "Profit", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Foods", "Profit", c => c.Decimal(nullable: false, storeType: "money"));
            AlterColumn("dbo.Foods", "Sale", c => c.Decimal(nullable: false, storeType: "money"));
            AlterColumn("dbo.Foods", "Buy", c => c.Decimal(nullable: false, storeType: "money"));
            AlterColumn("dbo.Drinks", "Profit", c => c.Decimal(nullable: false, storeType: "money"));
            AlterColumn("dbo.Drinks", "Sale", c => c.Decimal(nullable: false, storeType: "money"));
            AlterColumn("dbo.Drinks", "Buy", c => c.Decimal(nullable: false, storeType: "money"));
        }
    }
}
