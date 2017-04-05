namespace Rhythm.Event.Domain.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        EventID = c.Int(nullable: false, identity: true),
                        Photos_MedailID = c.Int(nullable: false),
                        Photos_MediaType = c.Int(nullable: false),
                        Photos_Url = c.String(),
                        Videos_MedailID = c.Int(nullable: false),
                        Videos_MediaType = c.Int(nullable: false),
                        Videos_Url = c.String(),
                        Feedback_FeedbackID = c.Int(),
                    })
                .PrimaryKey(t => t.EventID)
                .ForeignKey("dbo.Feedbacks", t => t.Feedback_FeedbackID)
                .Index(t => t.Feedback_FeedbackID);
            
            CreateTable(
                "dbo.Feedbacks",
                c => new
                    {
                        FeedbackID = c.Int(nullable: false, identity: true),
                        Rating = c.Int(nullable: false),
                        Comments = c.String(),
                        When = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.FeedbackID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Events", "Feedback_FeedbackID", "dbo.Feedbacks");
            DropIndex("dbo.Events", new[] { "Feedback_FeedbackID" });
            DropTable("dbo.Feedbacks");
            DropTable("dbo.Events");
        }
    }
}
