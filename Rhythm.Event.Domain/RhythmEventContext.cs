using System.Data.Entity;

namespace Rhythm.Event.Domain
{
    public class RhythmEventContext : DbContext
    {
      
        public RhythmEventContext() : base()
        {

        }
        
        public DbSet<RhythmEvent> Events { get; set; }
        public DbSet<EventDetail> EventDetails { get; set; }
        public DbSet<Media> Medias { get; set; }
    }
}