using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Unity.Models
{
    public class Announcements
    {
        public int Id { get; set; }
        public String Description { get; set; }
        public DateTime Expiration { get; set; }
    }
}