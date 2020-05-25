namespace ITI.Luxorna.Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admin",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CreateBy = c.Int(nullable: false),
                        UpdateBy = c.Int(),
                        AdminID = c.Int(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        UserName = c.String(),
                        Password = c.String(),
                        Image = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Admin", t => t.AdminID)
                .Index(t => t.AdminID);
            
            CreateTable(
                "dbo.Country",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Phone = c.String(nullable: false, maxLength: 20),
                        DeleteDate = c.DateTime(),
                        IsDeleted = c.Boolean(),
                        CountryID = c.Int(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        UserName = c.String(),
                        Password = c.String(),
                        Image = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Country", t => t.CountryID, cascadeDelete: true)
                .Index(t => t.CountryID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.User", "CountryID", "dbo.Country");
            DropForeignKey("dbo.Admin", "AdminID", "dbo.Admin");
            DropIndex("dbo.User", new[] { "CountryID" });
            DropIndex("dbo.Admin", new[] { "AdminID" });
            DropTable("dbo.User");
            DropTable("dbo.Country");
            DropTable("dbo.Admin");
        }
    }
}
