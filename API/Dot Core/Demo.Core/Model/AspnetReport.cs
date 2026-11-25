using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class AspnetReport
    {
        public Guid ReportId { get; set; }
        public int? ReportOrder { get; set; }
        public string LuReportType { get; set; }
        public string LuReportCategory { get; set; }
        public string ReportName { get; set; }
        public string AllowedRoles { get; set; }
        public bool? FilterDateRange { get; set; }
        public bool? FilterPeriod { get; set; }
        public bool? FilterUser { get; set; }
        public bool? FilterBlock { get; set; }
    }
}
