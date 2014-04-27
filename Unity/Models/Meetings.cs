using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Unity.Models
{

    public enum Days
    {
        Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
    }
    public class Meetings
    {
        public int MeetingsID { get; set; }
        public String Name { get; set; }
        public String Location { get; set; }
        public String MapLink { get; set; }
        public Days DayofWeek { get; set; }
        public String Latitude { get; set; }
        public String Longitude { get; set; }

    }
}