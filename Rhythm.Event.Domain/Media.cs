using System.ComponentModel.DataAnnotations;

namespace Rhythm.Event.Domain
{
    public class Media
    {
        [Key]
        public int MedailID { get; set; }
        public MediaType MediaType { get; set; }
        public string Url { get; set; }
    }
}
