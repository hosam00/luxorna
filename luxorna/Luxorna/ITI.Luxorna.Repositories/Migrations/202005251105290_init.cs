namespace ITI.Luxorna.Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.User", "CountryID", "dbo.Country");
            DropForeignKey("dbo.HotelImage", "HotelID", "dbo.Hotel");
            DropForeignKey("dbo.Hotel", "SectionID", "dbo.Section");
            DropForeignKey("dbo.Museum", "SectionID", "dbo.Section");
            DropForeignKey("dbo.Resturant", "SectionID", "dbo.Section");
            DropForeignKey("dbo.Temple", "SectionID", "dbo.Section");
            DropForeignKey("dbo.MuseumImage", "MuseumID", "dbo.Museum");
            DropForeignKey("dbo.ResturantImage", "ResturantID", "dbo.Resturant");
            DropForeignKey("dbo.ResturantMenuItem", "RestrantID", "dbo.Resturant");
            DropForeignKey("dbo.ResturantItemSize", "ResturantMenuItemID", "dbo.ResturantMenuItem");
            DropForeignKey("dbo.ResturantItemSize", "SizeID", "dbo.Size");
            DropForeignKey("dbo.TempleImage", "TempleID", "dbo.Temple");
            CreateTable(
                "dbo.AdminRole",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AdminID = c.Int(nullable: false),
                        RoleID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Admin", t => t.AdminID)
                .ForeignKey("dbo.Role", t => t.RoleID)
                .Index(t => t.AdminID)
                .Index(t => t.RoleID);
            
            CreateTable(
                "dbo.Role",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 500),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Package",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 500),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        PersonNumber = c.Int(nullable: false),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.User", t => t.UserID)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.HotelPackage",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        HotelID = c.Int(nullable: false),
                        PackageID = c.Int(nullable: false),
                        DayNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Hotel", t => t.HotelID)
                .ForeignKey("dbo.Package", t => t.PackageID)
                .Index(t => t.HotelID)
                .Index(t => t.PackageID);
            
            CreateTable(
                "dbo.MuseumPackage",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MuseumID = c.Int(nullable: false),
                        PackageID = c.Int(nullable: false),
                        DayNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Museum", t => t.MuseumID)
                .ForeignKey("dbo.Package", t => t.PackageID)
                .Index(t => t.MuseumID)
                .Index(t => t.PackageID);
            
            CreateTable(
                "dbo.ResturantPackageMenuItem",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ResturantPackageID = c.Int(nullable: false),
                        ResturantMenuItemID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ResturantPackage", t => t.ResturantPackageID)
                .ForeignKey("dbo.ResturantMenuItem", t => t.ResturantMenuItemID)
                .Index(t => t.ResturantPackageID)
                .Index(t => t.ResturantMenuItemID);
            
            CreateTable(
                "dbo.ResturantPackage",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ResturantID = c.Int(nullable: false),
                        PackageID = c.Int(nullable: false),
                        DayNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Resturant", t => t.ResturantID)
                .ForeignKey("dbo.Package", t => t.PackageID)
                .Index(t => t.ResturantID)
                .Index(t => t.PackageID);
            
            CreateTable(
                "dbo.TemplePackage",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TempleID = c.Int(nullable: false),
                        PackageID = c.Int(nullable: false),
                        DayNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Temple", t => t.TempleID)
                .ForeignKey("dbo.Package", t => t.PackageID)
                .Index(t => t.TempleID)
                .Index(t => t.PackageID);
            
            AddForeignKey("dbo.User", "CountryID", "dbo.Country", "ID");
            AddForeignKey("dbo.HotelImage", "HotelID", "dbo.Hotel", "ID");
            AddForeignKey("dbo.Hotel", "SectionID", "dbo.Section", "ID");
            AddForeignKey("dbo.Museum", "SectionID", "dbo.Section", "ID");
            AddForeignKey("dbo.Resturant", "SectionID", "dbo.Section", "ID");
            AddForeignKey("dbo.Temple", "SectionID", "dbo.Section", "ID");
            AddForeignKey("dbo.MuseumImage", "MuseumID", "dbo.Museum", "ID");
            AddForeignKey("dbo.ResturantImage", "ResturantID", "dbo.Resturant", "ID");
            AddForeignKey("dbo.ResturantMenuItem", "RestrantID", "dbo.Resturant", "ID");
            AddForeignKey("dbo.ResturantItemSize", "ResturantMenuItemID", "dbo.ResturantMenuItem", "ID");
            AddForeignKey("dbo.ResturantItemSize", "SizeID", "dbo.Size", "ID");
            AddForeignKey("dbo.TempleImage", "TempleID", "dbo.Temple", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TempleImage", "TempleID", "dbo.Temple");
            DropForeignKey("dbo.ResturantItemSize", "SizeID", "dbo.Size");
            DropForeignKey("dbo.ResturantItemSize", "ResturantMenuItemID", "dbo.ResturantMenuItem");
            DropForeignKey("dbo.ResturantMenuItem", "RestrantID", "dbo.Resturant");
            DropForeignKey("dbo.ResturantImage", "ResturantID", "dbo.Resturant");
            DropForeignKey("dbo.MuseumImage", "MuseumID", "dbo.Museum");
            DropForeignKey("dbo.Temple", "SectionID", "dbo.Section");
            DropForeignKey("dbo.Resturant", "SectionID", "dbo.Section");
            DropForeignKey("dbo.Museum", "SectionID", "dbo.Section");
            DropForeignKey("dbo.Hotel", "SectionID", "dbo.Section");
            DropForeignKey("dbo.HotelImage", "HotelID", "dbo.Hotel");
            DropForeignKey("dbo.User", "CountryID", "dbo.Country");
            DropForeignKey("dbo.Package", "UserID", "dbo.User");
            DropForeignKey("dbo.TemplePackage", "PackageID", "dbo.Package");
            DropForeignKey("dbo.ResturantPackage", "PackageID", "dbo.Package");
            DropForeignKey("dbo.HotelPackage", "PackageID", "dbo.Package");
            DropForeignKey("dbo.HotelPackage", "HotelID", "dbo.Hotel");
            DropForeignKey("dbo.TemplePackage", "TempleID", "dbo.Temple");
            DropForeignKey("dbo.ResturantPackageMenuItem", "ResturantMenuItemID", "dbo.ResturantMenuItem");
            DropForeignKey("dbo.ResturantPackageMenuItem", "ResturantPackageID", "dbo.ResturantPackage");
            DropForeignKey("dbo.ResturantPackage", "ResturantID", "dbo.Resturant");
            DropForeignKey("dbo.MuseumPackage", "PackageID", "dbo.Package");
            DropForeignKey("dbo.MuseumPackage", "MuseumID", "dbo.Museum");
            DropForeignKey("dbo.AdminRole", "RoleID", "dbo.Role");
            DropForeignKey("dbo.AdminRole", "AdminID", "dbo.Admin");
            DropIndex("dbo.TemplePackage", new[] { "PackageID" });
            DropIndex("dbo.TemplePackage", new[] { "TempleID" });
            DropIndex("dbo.ResturantPackage", new[] { "PackageID" });
            DropIndex("dbo.ResturantPackage", new[] { "ResturantID" });
            DropIndex("dbo.ResturantPackageMenuItem", new[] { "ResturantMenuItemID" });
            DropIndex("dbo.ResturantPackageMenuItem", new[] { "ResturantPackageID" });
            DropIndex("dbo.MuseumPackage", new[] { "PackageID" });
            DropIndex("dbo.MuseumPackage", new[] { "MuseumID" });
            DropIndex("dbo.HotelPackage", new[] { "PackageID" });
            DropIndex("dbo.HotelPackage", new[] { "HotelID" });
            DropIndex("dbo.Package", new[] { "UserID" });
            DropIndex("dbo.AdminRole", new[] { "RoleID" });
            DropIndex("dbo.AdminRole", new[] { "AdminID" });
            DropTable("dbo.TemplePackage");
            DropTable("dbo.ResturantPackage");
            DropTable("dbo.ResturantPackageMenuItem");
            DropTable("dbo.MuseumPackage");
            DropTable("dbo.HotelPackage");
            DropTable("dbo.Package");
            DropTable("dbo.Role");
            DropTable("dbo.AdminRole");
            AddForeignKey("dbo.TempleImage", "TempleID", "dbo.Temple", "ID", cascadeDelete: true);
            AddForeignKey("dbo.ResturantItemSize", "SizeID", "dbo.Size", "ID", cascadeDelete: true);
            AddForeignKey("dbo.ResturantItemSize", "ResturantMenuItemID", "dbo.ResturantMenuItem", "ID", cascadeDelete: true);
            AddForeignKey("dbo.ResturantMenuItem", "RestrantID", "dbo.Resturant", "ID", cascadeDelete: true);
            AddForeignKey("dbo.ResturantImage", "ResturantID", "dbo.Resturant", "ID", cascadeDelete: true);
            AddForeignKey("dbo.MuseumImage", "MuseumID", "dbo.Museum", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Temple", "SectionID", "dbo.Section", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Resturant", "SectionID", "dbo.Section", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Museum", "SectionID", "dbo.Section", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Hotel", "SectionID", "dbo.Section", "ID", cascadeDelete: true);
            AddForeignKey("dbo.HotelImage", "HotelID", "dbo.Hotel", "ID", cascadeDelete: true);
            AddForeignKey("dbo.User", "CountryID", "dbo.Country", "ID", cascadeDelete: true);
        }
    }
}
