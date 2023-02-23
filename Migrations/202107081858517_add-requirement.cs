namespace projectMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addrequirement : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Requirements",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Rent = c.Single(nullable: false),
                        WaterBill = c.Single(nullable: false),
                        ElectricityBill = c.Single(nullable: false),
                        Code = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Requirements");
        }
    }
}
