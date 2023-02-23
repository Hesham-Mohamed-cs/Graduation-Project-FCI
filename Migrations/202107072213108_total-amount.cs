namespace projectMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class totalamount : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Drinks", "TotalAmonut", c => c.Int(nullable: false));
            AddColumn("dbo.Foods", "TotalAmonut", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Foods", "TotalAmonut");
            DropColumn("dbo.Drinks", "TotalAmonut");
        }
    }
}
