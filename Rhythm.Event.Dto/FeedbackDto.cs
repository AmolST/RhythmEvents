using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhythm.Event.Dto
{
    public class FeedbackDto
    {
        public int FeedbackID { get; set; }
        public Rating Rating { get; set; }
        public string Comments { get; set; }
        public DateTime When { get; set; }
    }

    public enum Rating
    {
        Poor,
        Average,
        Good,
        VeryGood,
        Excellent
    }
}
