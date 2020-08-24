namespace Contour.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initialize : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ContourColors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ColorMethod = c.Int(nullable: false),
                        R = c.Byte(nullable: false),
                        G = c.Byte(nullable: false),
                        B = c.Byte(nullable: false),
                        ColorIndex = c.Short(nullable: false),
                        ColorValueName = c.String(maxLength: 100),
                        ContourId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Contours",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 1000),
                        Description = c.String(),
                        LineType = c.String(maxLength: 100),
                        ContourType = c.Int(nullable: false),
                        ContourKind = c.Int(nullable: false),
                        ParentId = c.Int(),
                        GroupId = c.Int(nullable: false),
                        BorderColorId = c.Int(nullable: false),
                        FillColorId = c.Int(),
                        Geometry = c.Geometry(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ContourColors", t => t.BorderColorId, cascadeDelete: true)
                .ForeignKey("dbo.ContourColors", t => t.FillColorId)
                .ForeignKey("dbo.Groups", t => t.GroupId)
                .Index(t => t.GroupId)
                .Index(t => t.BorderColorId)
                .Index(t => t.FillColorId);
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 1000),
                        Description = c.String(),
                        Url = c.String(maxLength: 2048),
                        GroupStatus = c.Int(nullable: false),
                        GroupState = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        LocationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Locations", t => t.LocationId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.LocationId);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 1000),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Purposes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GroupId = c.Int(nullable: false),
                        PurposeTypeNameId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PurposeTypeNames", t => t.PurposeTypeNameId, cascadeDelete: true)
                .ForeignKey("dbo.Groups", t => t.GroupId, cascadeDelete: true)
                .Index(t => t.GroupId)
                .Index(t => t.PurposeTypeNameId);
            
            CreateTable(
                "dbo.PurposeTypeNames",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 1000),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 200),
                        LastName = c.String(maxLength: 200),
                        Email = c.String(maxLength: 200),
                        SiteKeyId = c.String(maxLength: 1000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Url = c.String(maxLength: 2048),
                        Name = c.String(maxLength: 1000),
                        Description = c.String(),
                        ContourId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contours", t => t.ContourId, cascadeDelete: true)
                .Index(t => t.ContourId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Images", "ContourId", "dbo.Contours");
            DropForeignKey("dbo.Groups", "UserId", "dbo.Users");
            DropForeignKey("dbo.Purposes", "GroupId", "dbo.Groups");
            DropForeignKey("dbo.Purposes", "PurposeTypeNameId", "dbo.PurposeTypeNames");
            DropForeignKey("dbo.Groups", "LocationId", "dbo.Locations");
            DropForeignKey("dbo.Contours", "GroupId", "dbo.Groups");
            DropForeignKey("dbo.Contours", "FillColorId", "dbo.ContourColors");
            DropForeignKey("dbo.Contours", "BorderColorId", "dbo.ContourColors");
            DropIndex("dbo.Images", new[] { "ContourId" });
            DropIndex("dbo.Purposes", new[] { "PurposeTypeNameId" });
            DropIndex("dbo.Purposes", new[] { "GroupId" });
            DropIndex("dbo.Groups", new[] { "LocationId" });
            DropIndex("dbo.Groups", new[] { "UserId" });
            DropIndex("dbo.Contours", new[] { "FillColorId" });
            DropIndex("dbo.Contours", new[] { "BorderColorId" });
            DropIndex("dbo.Contours", new[] { "GroupId" });
            DropTable("dbo.Images");
            DropTable("dbo.Users");
            DropTable("dbo.PurposeTypeNames");
            DropTable("dbo.Purposes");
            DropTable("dbo.Locations");
            DropTable("dbo.Groups");
            DropTable("dbo.Contours");
            DropTable("dbo.ContourColors");
        }
    }
}
