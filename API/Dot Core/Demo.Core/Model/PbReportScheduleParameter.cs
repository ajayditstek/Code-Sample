using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class PbReportScheduleParameter
    {
        public int Id { get; set; }
        public Guid ReportId { get; set; }
        public string ClientId { get; set; }
        public string Parameters { get; set; }
        public string RecipientList { get; set; }
        public bool? Landscape { get; set; }
    }
}
