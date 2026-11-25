using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class PbReportScheduleRecipient
    {
        public Guid ReportSchedulerRecipients { get; set; }
        public Guid? ClientId { get; set; }
        public Guid? ReportId { get; set; }
        public string Recipients { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeleteBy { get; set; }
    }
}
