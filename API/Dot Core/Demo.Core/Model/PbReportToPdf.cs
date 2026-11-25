using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class PbReportToPdf
    {
        public Guid ReportsToPdfid { get; set; }
        public string DisplayName { get; set; }
        public string ProcToRun { get; set; }
        public string Params { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DeleteDate { get; set; }
        public string DeleteBy { get; set; }
        public bool? CustomPdf { get; set; }
        public int? DisplayOrder { get; set; }
    }
}
