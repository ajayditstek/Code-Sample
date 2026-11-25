using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class PbPaymentBatch
    {
        public Guid BatchId { get; set; }
        public string BatchName { get; set; }
        public Guid? CsvFileId { get; set; }
        public string CsvFileName { get; set; }
        public string CsvFileData { get; set; }
        public bool? BatchPaid { get; set; }
        public DateTime? BatchPaidDate { get; set; }
        public string BatchPaidBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public bool? BatchClosed { get; set; }
    }
}
