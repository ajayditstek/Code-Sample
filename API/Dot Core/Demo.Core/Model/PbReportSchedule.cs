using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class PbReportSchedule
    {
        public int ReportScheduleId { get; set; }
        public Guid ReportId { get; set; }
        public string Interval { get; set; }
        public int? Quantity { get; set; }
        public string ReportFormat { get; set; }
        public DateTime? NextRunTime { get; set; }
        public DateTime? LastRunTime { get; set; }
        public string IntervalType { get; set; }
        public string IntervalQuantity { get; set; }
    }
}
