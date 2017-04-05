using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhythm.Event.Dto
{
    public class MediaDto
    {
        public int MedailID { get; set; }
        public MediaType MediaType { get; set; }
        public string Url { get; set; }
    }

    public enum MediaType
    {
        Photo,
        Video
    }
}
