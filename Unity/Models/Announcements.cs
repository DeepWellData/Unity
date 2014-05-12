using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Unity.Models
{
    public class Announcements
    {
        [Key]
        public int AnnouncementId { get; set; }
        public String Description { get; set; }
        public DateTime Expiration { get; set; }
    }
}