namespace Rhythm.Event.Domain
{
    using System;
    using System.Data.Entity;

    public partial class RhythmEventContext : DbContext
    {
        public DbSet<RhythmEvent> Events { get; set; }
        public DbSet<EventDetail> EventDetails { get; set; }
        public DbSet<Media> Medias { get; set; }

        public RhythmEventContext()
            : base("name=RhythmEventContext")
        {

        }

       

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public override DbSet<TEntity> Set<TEntity>()
        {
            return base.Set<TEntity>();
        }
    }
}
