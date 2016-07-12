namespace Trajectus.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class M1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        CityID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.CityID);
            
            CreateTable(
                "dbo.Continents",
                c => new
                    {
                        ContinentID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ContinentID);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        CountryID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Code = c.String(),
                        GoldAveragePerDay = c.Double(nullable: false),
                        Currency = c.String(nullable: false),
                        Language = c.String(nullable: false),
                        CapitalCity_CityID = c.Int(nullable: false),
                        Continent_ContinentID = c.Int(),
                    })
                .PrimaryKey(t => t.CountryID)
                .ForeignKey("dbo.Cities", t => t.CapitalCity_CityID, cascadeDelete: true)
                .ForeignKey("dbo.Continents", t => t.Continent_ContinentID)
                .Index(t => t.CapitalCity_CityID)
                .Index(t => t.Continent_ContinentID);
            
            CreateTable(
                "dbo.GPSPositions",
                c => new
                    {
                        GPSPositionID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.GPSPositionID);
            
            CreateTable(
                "dbo.Paths",
                c => new
                    {
                        PathID = c.Int(nullable: false, identity: true),
                        StartDateTime = c.DateTime(nullable: false),
                        StopDateTime = c.DateTime(nullable: false),
                        Distance = c.Short(nullable: false),
                        Index = c.Int(nullable: false),
                        StartCity_CityID = c.Int(),
                        StopCity_CityID = c.Int(),
                        Route_RouteID = c.Int(),
                    })
                .PrimaryKey(t => t.PathID)
                .ForeignKey("dbo.Cities", t => t.StartCity_CityID)
                .ForeignKey("dbo.Cities", t => t.StopCity_CityID)
                .ForeignKey("dbo.Routes", t => t.Route_RouteID)
                .Index(t => t.StartCity_CityID)
                .Index(t => t.StopCity_CityID)
                .Index(t => t.Route_RouteID);
            
            CreateTable(
                "dbo.Routes",
                c => new
                    {
                        RouteID = c.Int(nullable: false, identity: true),
                        StartDate = c.DateTime(nullable: false),
                        StopDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.RouteID);
            
            CreateTable(
                "dbo.Steps",
                c => new
                    {
                        StepID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                        Index = c.Int(nullable: false),
                        Duration = c.Time(nullable: false, precision: 7),
                        City_CityID = c.Int(nullable: false),
                        Route_RouteID = c.Int(),
                    })
                .PrimaryKey(t => t.StepID)
                .ForeignKey("dbo.Cities", t => t.City_CityID, cascadeDelete: true)
                .ForeignKey("dbo.Routes", t => t.Route_RouteID)
                .Index(t => t.City_CityID)
                .Index(t => t.Route_RouteID);
            
            CreateTable(
                "dbo.Travels",
                c => new
                    {
                        TravelID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Travelers = c.Int(nullable: false),
                        Description = c.String(),
                        Owner_UserID = c.Int(),
                        Route_RouteID = c.Int(),
                    })
                .PrimaryKey(t => t.TravelID)
                .ForeignKey("dbo.Users", t => t.Owner_UserID)
                .ForeignKey("dbo.Routes", t => t.Route_RouteID)
                .Index(t => t.Owner_UserID)
                .Index(t => t.Route_RouteID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Login = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        EMail = c.String(),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Travels", "Route_RouteID", "dbo.Routes");
            DropForeignKey("dbo.Travels", "Owner_UserID", "dbo.Users");
            DropForeignKey("dbo.Steps", "Route_RouteID", "dbo.Routes");
            DropForeignKey("dbo.Steps", "City_CityID", "dbo.Cities");
            DropForeignKey("dbo.Paths", "Route_RouteID", "dbo.Routes");
            DropForeignKey("dbo.Paths", "StopCity_CityID", "dbo.Cities");
            DropForeignKey("dbo.Paths", "StartCity_CityID", "dbo.Cities");
            DropForeignKey("dbo.Countries", "Continent_ContinentID", "dbo.Continents");
            DropForeignKey("dbo.Countries", "CapitalCity_CityID", "dbo.Cities");
            DropIndex("dbo.Travels", new[] { "Route_RouteID" });
            DropIndex("dbo.Travels", new[] { "Owner_UserID" });
            DropIndex("dbo.Steps", new[] { "Route_RouteID" });
            DropIndex("dbo.Steps", new[] { "City_CityID" });
            DropIndex("dbo.Paths", new[] { "Route_RouteID" });
            DropIndex("dbo.Paths", new[] { "StopCity_CityID" });
            DropIndex("dbo.Paths", new[] { "StartCity_CityID" });
            DropIndex("dbo.Countries", new[] { "Continent_ContinentID" });
            DropIndex("dbo.Countries", new[] { "CapitalCity_CityID" });
            DropTable("dbo.Users");
            DropTable("dbo.Travels");
            DropTable("dbo.Steps");
            DropTable("dbo.Routes");
            DropTable("dbo.Paths");
            DropTable("dbo.GPSPositions");
            DropTable("dbo.Countries");
            DropTable("dbo.Continents");
            DropTable("dbo.Cities");
        }
    }
}
