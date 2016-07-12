namespace Trajectus.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class M2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Countries", "CapitalCity_CityID", "dbo.Cities");
            DropForeignKey("dbo.Countries", "Continent_ContinentID", "dbo.Continents");
            DropIndex("dbo.Countries", new[] { "CapitalCity_CityID" });
            DropIndex("dbo.Countries", new[] { "Continent_ContinentID" });
            CreateTable(
                "dbo.Currencies",
                c => new
                    {
                        CurrencyID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Country_CountryID = c.Int(),
                    })
                .PrimaryKey(t => t.CurrencyID)
                .ForeignKey("dbo.Countries", t => t.Country_CountryID)
                .Index(t => t.Country_CountryID);
            
            CreateTable(
                "dbo.Languages",
                c => new
                    {
                        LanguageID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Country_CountryID = c.Int(),
                    })
                .PrimaryKey(t => t.LanguageID)
                .ForeignKey("dbo.Countries", t => t.Country_CountryID)
                .Index(t => t.Country_CountryID);
            
            CreateTable(
                "dbo.TimeZones",
                c => new
                    {
                        TimeZoneID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Country_CountryID = c.Int(),
                    })
                .PrimaryKey(t => t.TimeZoneID)
                .ForeignKey("dbo.Countries", t => t.Country_CountryID)
                .Index(t => t.Country_CountryID);
            
            AddColumn("dbo.Cities", "CountryID", c => c.Int(nullable: false));
            AddColumn("dbo.Countries", "CapitalCity", c => c.String(nullable: false));
            AddColumn("dbo.Countries", "Population", c => c.Int(nullable: false));
            AddColumn("dbo.Countries", "CallingCode", c => c.String());
            DropColumn("dbo.Countries", "Code");
            DropColumn("dbo.Countries", "Currency");
            DropColumn("dbo.Countries", "Language");
            DropColumn("dbo.Countries", "CapitalCity_CityID");
            DropColumn("dbo.Countries", "Continent_ContinentID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Countries", "Continent_ContinentID", c => c.Int());
            AddColumn("dbo.Countries", "CapitalCity_CityID", c => c.Int(nullable: false));
            AddColumn("dbo.Countries", "Language", c => c.String(nullable: false));
            AddColumn("dbo.Countries", "Currency", c => c.String(nullable: false));
            AddColumn("dbo.Countries", "Code", c => c.String());
            DropForeignKey("dbo.TimeZones", "Country_CountryID", "dbo.Countries");
            DropForeignKey("dbo.Languages", "Country_CountryID", "dbo.Countries");
            DropForeignKey("dbo.Currencies", "Country_CountryID", "dbo.Countries");
            DropIndex("dbo.TimeZones", new[] { "Country_CountryID" });
            DropIndex("dbo.Languages", new[] { "Country_CountryID" });
            DropIndex("dbo.Currencies", new[] { "Country_CountryID" });
            DropColumn("dbo.Countries", "CallingCode");
            DropColumn("dbo.Countries", "Population");
            DropColumn("dbo.Countries", "CapitalCity");
            DropColumn("dbo.Cities", "CountryID");
            DropTable("dbo.TimeZones");
            DropTable("dbo.Languages");
            DropTable("dbo.Currencies");
            CreateIndex("dbo.Countries", "Continent_ContinentID");
            CreateIndex("dbo.Countries", "CapitalCity_CityID");
            AddForeignKey("dbo.Countries", "Continent_ContinentID", "dbo.Continents", "ContinentID");
            AddForeignKey("dbo.Countries", "CapitalCity_CityID", "dbo.Cities", "CityID", cascadeDelete: true);
        }
    }
}
