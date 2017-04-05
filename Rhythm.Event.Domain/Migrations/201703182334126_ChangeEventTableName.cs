namespace Rhythm.Event.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeEventTableName : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Events", newName: "RhythmEvents");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.RhythmEvents", newName: "Events");
        }
    }
}
