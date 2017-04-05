using System;
using System.ComponentModel.DataAnnotations;

namespace Rhythm.Event.Domain
{
    public class EventDetail
    {
        [Key]
        public int EventDetailID { get; set; }
        public string Name { get; set; }
        public Organiser Organiser { get; set; }
        public DateTime Date { get; set; }
        public Address Venue { get; set; }
    }

}
