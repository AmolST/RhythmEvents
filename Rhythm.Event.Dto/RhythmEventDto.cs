using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhythm.Event.Dto
{
    public class RhythmEventDto
    {
        public int EventID { get; set; }
        public MediaDto Photos { get; set; }
        public MediaDto Videos { get; set; }
        public EventDetailDto EventDetails { get; set; }
        public FeedbackDto FeedbackDto { get; set; }
    }
}
