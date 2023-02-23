namespace projectMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class x : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Bills", "Total", c => c.String());
            DropColumn("dbo.Bills", "Amount");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Bills", "Amount", c => c.String());
            AlterColumn("dbo.Bills", "Total", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
