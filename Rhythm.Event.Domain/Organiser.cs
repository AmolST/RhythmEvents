using System.ComponentModel.DataAnnotations;

namespace Rhythm.Event.Domain
{
    public class Organiser
    {
        [Key]
        public int OrganiserID { get; set; }
        public string Company { get; set; }
        public Address Address { get; set; }
    }

}
