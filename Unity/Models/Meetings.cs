using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Unity.Models
{
    public class Meetings
    {
        [Key]
        public int MeetingId { get; set; }
        [Display(Name = "Begin Date")]
        [Column(TypeName = "DateTime2")]
        public DateTime BeginDateTime { get; set; }
        public String Name { get; set; }
        public String Location { get; set; }
        [Display(Name = "Map Link")]
        public String MapLink { get; set; }

    }
}