using System.ComponentModel.DataAnnotations;

namespace Rhythm.Event.Domain
{
    public class RhythmEvent
    {
        [Key]
        public int EventID { get; set; }
        public Media Photos { get; set; }
        public Media Videos { get; set; }
        public EventDetail EventDetails { get; set; }
        public Feedback Feedback { get; set; }
    }

}
