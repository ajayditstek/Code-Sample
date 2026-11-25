using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class PbReport
    {
        public Guid ReportId { get; set; }
        public int? ReportOrder { get; set; }
        public string LuReportType { get; set; }
        public string LuReportCategory { get; set; }
        public string ReportName { get; set; }
        public string AllowedRoles { get; set; }
        public string GlobalRole { get; set; }
        public bool? FilterDateRange { get; set; }
        public bool? FilterPeriod { get; set; }
        public bool? FilterUser { get; set; }
        public bool? FilterBlock { get; set; }
        public string LuReportSubCategory { get; set; }
        public bool? ReportToPdfenabled { get; set; }
        public bool? Display { get; set; }
        public string DisplayName { get; set; }
    }
}
