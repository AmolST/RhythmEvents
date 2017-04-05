using System.ComponentModel.DataAnnotations;

namespace Rhythm.Event.Domain
{
    public class Guest
    {
        [Key]
        public int GuestID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
    }
}