namespace projectMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AdminUserName = c.String(nullable: false, maxLength: 100),
                        AdminPassword = c.String(nullable: false, maxLength: 100),
                        BussinesType = c.Int(nullable: false),
                        Code = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.AdminUserName, unique: true)
                .Index(t => t.Code, unique: true);
            
            CreateTable(
                "dbo.Drinks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 70),
                        Buy = c.Decimal(nullable: false, storeType: "money"),
                        Sale = c.Decimal(nullable: false, storeType: "money"),
                        Profit = c.Decimal(nullable: false, storeType: "money"),
                        Amonut = c.Int(nullable: false),
                        Code = c.String(nullable: false, maxLength: 100),
                        Type = c.Int(nullable: false),
                        Admin_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Admins", t => t.Admin_Id, cascadeDelete: true)
                .Index(t => t.Admin_Id);
            
            CreateTable(
                "dbo.Employes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 70),
                        Phone = c.String(nullable: false, maxLength: 15),
                        Salary = c.Decimal(nullable: false, storeType: "money"),
                        Job = c.String(nullable: false, maxLength: 50),
                        Adress = c.String(nullable: false, maxLength: 70),
                        Code = c.String(nullable: false, maxLength: 100),
                        EmployeType = c.Int(nullable: false),
                        Admin_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Admins", t => t.Admin_Id, cascadeDelete: true)
                .Index(t => t.Admin_Id);
            
            CreateTable(
                "dbo.Foods",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 70),
                        Buy = c.Decimal(nullable: false, storeType: "money"),
                        Sale = c.Decimal(nullable: false, storeType: "money"),
                        Profit = c.Decimal(nullable: false, storeType: "money"),
                        Amonut = c.Int(nullable: false),
                        Code = c.String(nullable: false, maxLength: 100),
                        Type = c.Int(nullable: false),
                        Admin_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Admins", t => t.Admin_Id, cascadeDelete: true)
                .Index(t => t.Admin_Id);
            
            CreateTable(
                "dbo.Seets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SeetType = c.Int(nullable: false),
                        Number = c.Int(nullable: false),
                        Code = c.String(nullable: false, maxLength: 100),
                        IsEmpty = c.Boolean(nullable: false),
                        Cost = c.Decimal(nullable: false, storeType: "money"),
                        StartTime = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        EndTime = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Admin_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Admins", t => t.Admin_Id, cascadeDelete: true)
                .Index(t => t.Admin_Id);
            
            CreateTable(
                "dbo.Cashers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CasherUserName = c.String(nullable: false, maxLength: 100),
                        CasherPassword = c.String(nullable: false, maxLength: 100),
                        Admin_Id = c.Int(nullable: false),
                        Emp_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Admins", t => t.Admin_Id, cascadeDelete: false)
                .ForeignKey("dbo.Employes", t => t.Emp_Id, cascadeDelete: false)
                .Index(t => t.CasherUserName, unique: true)
                .Index(t => t.Admin_Id)
                .Index(t => t.Emp_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cashers", "Emp_Id", "dbo.Employes");
            DropForeignKey("dbo.Cashers", "Admin_Id", "dbo.Admins");
            DropForeignKey("dbo.Seets", "Admin_Id", "dbo.Admins");
            DropForeignKey("dbo.Foods", "Admin_Id", "dbo.Admins");
            DropForeignKey("dbo.Employes", "Admin_Id", "dbo.Admins");
            DropForeignKey("dbo.Drinks", "Admin_Id", "dbo.Admins");
            DropIndex("dbo.Cashers", new[] { "Emp_Id" });
            DropIndex("dbo.Cashers", new[] { "Admin_Id" });
            DropIndex("dbo.Cashers", new[] { "CasherUserName" });
            DropIndex("dbo.Seets", new[] { "Admin_Id" });
            DropIndex("dbo.Foods", new[] { "Admin_Id" });
            DropIndex("dbo.Employes", new[] { "Admin_Id" });
            DropIndex("dbo.Drinks", new[] { "Admin_Id" });
            DropIndex("dbo.Admins", new[] { "Code" });
            DropIndex("dbo.Admins", new[] { "AdminUserName" });
            DropTable("dbo.Cashers");
            DropTable("dbo.Seets");
            DropTable("dbo.Foods");
            DropTable("dbo.Employes");
            DropTable("dbo.Drinks");
            DropTable("dbo.Admins");
        }
    }
}
