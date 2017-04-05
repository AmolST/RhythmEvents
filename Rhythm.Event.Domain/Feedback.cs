using System;
using System.ComponentModel.DataAnnotations;

namespace Rhythm.Event.Domain
{
    public class Feedback
    {
        [Key]
        public int FeedbackID { get; set; }
        public Rating Rating { get; set; }
        public string Comments { get; set; }
        public DateTime When { get; set; }
    }
}