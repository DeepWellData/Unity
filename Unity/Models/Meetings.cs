using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public Days DayofWeek { get; set; }
        [RegularExpression(@"^([1-9]|1[0-2]|0[1-9]){1}(:[0-5][0-9][AP][M]){1}$", ErrorMessage = "Date Format ex 7:00pm")]
        public String TimeofDay { get; set; }
        public String Name { get; set; }
        public String Location { get; set; }
        public String MapLink { get; set; }

    }
}