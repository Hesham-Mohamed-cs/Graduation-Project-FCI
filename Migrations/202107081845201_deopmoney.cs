namespace projectMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deopmoney : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employes", "Salary", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employes", "Salary", c => c.Decimal(nullable: false, storeType: "money"));
        }
    }
}
