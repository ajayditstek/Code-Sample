using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class ReportsPrint
    {
        public Guid ReportsPrintId { get; set; }
        public string ReportServerName { get; set; }
        public string FileName { get; set; }
        public string ReportParams { get; set; }
        public string ReportFormat { get; set; }
        public string DeliverTo { get; set; }
        public short Landscape { get; set; }
        public DateTime InsertedOn { get; set; }
        public string InsertedBy { get; set; }
        public DateTime? ProcessedOn { get; set; }
        public int CustomPdf { get; set; }
        public int NotSsrs { get; set; }
        public string MethodName { get; set; }
        public string ErrorMessage { get; set; }
        public string Sqlscript { get; set; }
    }
}
