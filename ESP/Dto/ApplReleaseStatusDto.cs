using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ESP.Dto
{
    public class ApplReleaseStatusDto
    {
        public int YearMonth { get; set; }
        public string ReleaseGroupCode { get; set; }
        public int ApplicationId { get; set; }
        public string ReleaseStrategy { get; set; }
        public int ReleaseStrategyLevel { get; set; }
        public string ReleaseCode { get; set; }
        public string ReleaseStatusCode { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string ReleaseAuth { get; set; }
        public bool IsFinalRelease { get; set; }
        public string Remarks { get; set; }

        public string ReleaserName { get; set; }
    }
}