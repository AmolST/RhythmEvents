namespace Rhythm.Event.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMoreTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EventDetails",
                c => new
                    {
                        EventDetailID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Date = c.DateTime(nullable: false),
                        Organiser_OrganiserID = c.Int(),
                        Venue_AddressID = c.Int(),
                    })
                .PrimaryKey(t => t.EventDetailID)
                .ForeignKey("dbo.Organisers", t => t.Organiser_OrganiserID)
                .ForeignKey("dbo.Addresses", t => t.Venue_AddressID)
                .Index(t => t.Organiser_OrganiserID)
                .Index(t => t.Venue_AddressID);
            
            CreateTable(
                "dbo.Organisers",
                c => new
                    {
                        OrganiserID = c.Int(nullable: false, identity: true),
                        Company = c.String(),
                        Address_AddressID = c.Int(),
                    })
                .PrimaryKey(t => t.OrganiserID)
                .ForeignKey("dbo.Addresses", t => t.Address_AddressID)
                .Index(t => t.Address_AddressID);
            
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressID = c.Int(nullable: false, identity: true),
                        Unit = c.String(),
                        Street1 = c.String(),
                        Street2 = c.String(),
                        Suburb = c.String(),
                        City = c.String(),
                        State = c.String(),
                        PinCode = c.Int(nullable: false),
                        Country = c.String(),
                    })
                .PrimaryKey(t => t.AddressID);
            
            CreateTable(
                "dbo.Media",
                c => new
                    {
                        MedailID = c.Int(nullable: false, identity: true),
                        MediaType = c.Int(nullable: false),
                        Url = c.String(),
                    })
                .PrimaryKey(t => t.MedailID);
            
            AddColumn("dbo.Events", "EventDetails_EventDetailID", c => c.Int());
            AlterColumn("dbo.Events", "Photos_MedailID", c => c.Int());
            AlterColumn("dbo.Events", "Videos_MedailID", c => c.Int());
            CreateIndex("dbo.Events", "EventDetails_EventDetailID");
            CreateIndex("dbo.Events", "Photos_MedailID");
            CreateIndex("dbo.Events", "Videos_MedailID");
            AddForeignKey("dbo.Events", "EventDetails_EventDetailID", "dbo.EventDetails", "EventDetailID");
            AddForeignKey("dbo.Events", "Photos_MedailID", "dbo.Media", "MedailID");
            AddForeignKey("dbo.Events", "Videos_MedailID", "dbo.Media", "MedailID");
            DropColumn("dbo.Events", "Photos_MediaType");
            DropColumn("dbo.Events", "Photos_Url");
            DropColumn("dbo.Events", "Videos_MediaType");
            DropColumn("dbo.Events", "Videos_Url");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Events", "Videos_Url", c => c.String());
            AddColumn("dbo.Events", "Videos_MediaType", c => c.Int(nullable: false));
            AddColumn("dbo.Events", "Photos_Url", c => c.String());
            AddColumn("dbo.Events", "Photos_MediaType", c => c.Int(nullable: false));
            DropForeignKey("dbo.Events", "Videos_MedailID", "dbo.Media");
            DropForeignKey("dbo.Events", "Photos_MedailID", "dbo.Media");
            DropForeignKey("dbo.Events", "EventDetails_EventDetailID", "dbo.EventDetails");
            DropForeignKey("dbo.EventDetails", "Venue_AddressID", "dbo.Addresses");
            DropForeignKey("dbo.EventDetails", "Organiser_OrganiserID", "dbo.Organisers");
            DropForeignKey("dbo.Organisers", "Address_AddressID", "dbo.Addresses");
            DropIndex("dbo.Events", new[] { "Videos_MedailID" });
            DropIndex("dbo.Events", new[] { "Photos_MedailID" });
            DropIndex("dbo.Events", new[] { "EventDetails_EventDetailID" });
            DropIndex("dbo.Organisers", new[] { "Address_AddressID" });
            DropIndex("dbo.EventDetails", new[] { "Venue_AddressID" });
            DropIndex("dbo.EventDetails", new[] { "Organiser_OrganiserID" });
            AlterColumn("dbo.Events", "Videos_MedailID", c => c.Int(nullable: false));
            AlterColumn("dbo.Events", "Photos_MedailID", c => c.Int(nullable: false));
            DropColumn("dbo.Events", "EventDetails_EventDetailID");
            DropTable("dbo.Media");
            DropTable("dbo.Addresses");
            DropTable("dbo.Organisers");
            DropTable("dbo.EventDetails");
        }
    }
}
