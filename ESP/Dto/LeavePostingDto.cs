using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ESP.Dto
{
    public class LeavePostingDto
    {
        public int YearMonth { get; set; }
        public int LeaveAppId { get; set; }
        public int LeaveAppItem { get; set; }
        public string IsPosted { get; set; }
        public string Remarks { get; set; }
        public string UserId { get; set; }
    }
}